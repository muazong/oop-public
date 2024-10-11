using Newtonsoft.Json;

class BookList {
  static int quantity = 0;
  static List<Book> books = new List<Book>();

  const string UPDATE = "update";
  const string FIND = "find";
  const string REMOVE = "remove";

  // for saving
  class BookListData {
    List<Book> bookListData = new List<Book>();
    int quantity = 0;

    public List<Book> Data {
      get => bookListData;
      set => bookListData = value;
    }
    public int Quantity {
      get => quantity;
      set => quantity = value;
    }
  }

  // CONSTRUCTOR
  public BookList() {
    this.LoadFile();
  }

  // PROPERTIES
  public List<Book> Books {
    get => books;
    set => books = value;
  }
  public int Quantity {
    get => quantity;
  private
    set => quantity = value;
  }

  // METHODS
  // This method should only be used privately and in support of other input methods
  private void AddBook(Book book) {
    Books.Add(book);
    Quantity++;

    Console.WriteLine("\nSuccessfully added! :D");
    SaveFile();
  }
  public void AddNewBook() {
    Console.Clear();
    Book book = new Book();
    book.InputBook();
    AddBook(book);
    SaveFile();
  }
  public void AddNewBooks() {
    Console.Clear();
    Console.Write("How many books you want to add: ");
    int quantity = int.Parse(Console.ReadLine()!);
    int index = 1;

    while (quantity > 0) {
      Console.Clear();
      Console.WriteLine($"Book {index++}: ");

      Book book = new Book();
      book.InputBook();

      AddBook(book);
      quantity--;
    }
  }

  // Show all book
  public void ShowList() {
    if (Quantity == 0) {
      Console.Clear();
      Console.WriteLine("No book found :(");
    } else {
      Console.Clear();
      foreach (Book book in books) {
        book.Show();
        Console.WriteLine("----------");
      }
      Console.WriteLine($"Total: {Quantity} {(Quantity > 1 ? "books" : "book")} found");
    }
  }

  // Find book
  public void FindBook() {
    int isContinue = 1;

    do {
      Console.Clear();
      Console.WriteLine("Find by?");
      Console.WriteLine("1 - Title");
      Console.WriteLine("2 - Author");
      Console.WriteLine("0 - Back");
      Console.Write("Your choice: ");
      int choice = int.Parse(Console.ReadLine()!);

      switch (choice) {
        case 1:
          this.FindBookByTitle(FIND);
          break;
        case 2:
          this.FindBookByAuthor(FIND);
          break;
        case 0:
          return;
        default:
          Console.WriteLine("Wrong choice!");
          Utils.PressAnyKey();
          break;
      }

      Console.WriteLine("\nContinue? (1 - yes, 0 - no)");
      Console.Write("Your choice: ");
      isContinue = int.Parse(Console.ReadLine()!);
    } while (isContinue == 1);
  }
  private void FindBookByTitle(string choice = FIND) {
    Console.Clear();
    Console.Write("Enter title: ");
    string title = (Console.ReadLine()!).Trim();
    bool found = false;

    switch (choice) {
      case FIND:
        foreach (Book book in Books) {
          if ((book.Title).ToLower() == title.ToLower()) {
            book.Show();
            found = true;
            break;
          }
        }
        break;
      case UPDATE:
        foreach (Book book in Books) {
          if ((book.Title).ToLower() == title.ToLower()) {
            book.Show();
            found = true;
            Update(book);
            Utils.PressAnyKey();
            break;
          }
        }
        break;
      case REMOVE:
        foreach (Book book in Books) {
          if ((book.Title).ToLower() == title.ToLower()) {
            found = true;
            Books.Remove(book);
            Quantity--;
            Console.WriteLine("Removed successfully!");
            Utils.PressAnyKey();
            break;
          }
        }
        break;
    }

    if (!found)
      Console.WriteLine("Not found!");
    else
      SaveFile();
  }
  private void FindBookByAuthor(string choice = FIND) {
    Console.Clear();
    Console.Write("Enter author: ");
    string author = (Console.ReadLine()!).Trim();
    int bookFound = 0;
    bool found = false;

    switch (choice) {
      case FIND:
        foreach (Book book in Books) {
          if ((book.Author).ToLower() == author.ToLower()) {
            book.Show();
            found = true;
            bookFound++;
            Console.WriteLine("__________");
          }
        }
        break;
      case UPDATE:
        foreach (Book book in Books) {
          if ((book.Author).ToLower() == author.ToLower()) {
            book.Show();
            Console.WriteLine("__________");
            Console.WriteLine("Next or not? (1 - next, 0 - no)");
            Console.Write("Your choice: ");
            int isNext = int.Parse(Console.ReadLine()!);

            if (isNext == 0) {
              found = true;
              Update(book);
              Console.WriteLine("Updated successfully!");
              Utils.PressAnyKey();
              break;
            }
            Console.Clear();
          }
        }
        break;
      case REMOVE:
        foreach (Book book in Books) {
          if ((book.Author).ToLower() == author.ToLower()) {
            book.Show();
            Console.WriteLine("__________");
            Console.WriteLine("Next or not? (1 - next, 0 - no)");
            Console.Write("Your choice: ");
            int isNext = int.Parse(Console.ReadLine()!);

            if (isNext == 0) {
              found = true;
              Books.Remove(book);
              Quantity--;
              Console.WriteLine("Removed successfully!");
              break;
            }
            bookFound++;
            Console.Clear();
          }
        }
        break;
    }

    if (!found)
      Console.WriteLine("Not found!");
    else {
      SaveFile();
      Console.WriteLine($"\n{bookFound} {(bookFound > 1 ? "books" : "book")} found");
    }
  }

  // Update book
  public void UpdateBook() {
    int isContinue = 1;
    bool isSkip;

    do {
      isSkip = false;

      Console.Clear();
      Console.WriteLine("Update by?");
      Console.WriteLine("1 - Title");
      Console.WriteLine("2 - Author");
      Console.WriteLine("0 - Back");
      Console.Write("Your choice: ");
      int choice = int.Parse(Console.ReadLine()!);

      switch (choice) {
        case 1:
          this.FindBookByTitle(UPDATE);
          isSkip = true;
          break;
        case 2:
          this.FindBookByAuthor(UPDATE);
          break;
        case 0:
          return;
        default:
          Console.WriteLine("Wrong choice!");
          Utils.PressAnyKey();
          break;
      }

      if (!isSkip) {
        Console.WriteLine("\nContinue? (1 - yes, 0 - no)");
        Console.Write("Your choice: ");
        isContinue = int.Parse(Console.ReadLine()!);
      }
    } while (isContinue == 1);
  }
  private void Update(Book book) {
    int isContinue = 1;

    do {
      Console.WriteLine("\nUpdate book found");
      Console.WriteLine("1 - Title");
      Console.WriteLine("2 - Author");
      Console.WriteLine("3 - Publisher");
      Console.WriteLine("4 - ISBN");
      Console.WriteLine("5 - Year");
      Console.WriteLine("6 - Chapter");
      Console.WriteLine("0 - Back");
      Console.Write("\nYour choice: ");
      int updateChoice = Convert.ToInt32(Console.ReadLine());

      switch (updateChoice) {
        case 0:
          return;
        case 1:
          Console.Write("Enter new title: ");
          book.Title = (Console.ReadLine()!).Trim();
          break;
        case 2:
          Console.Write("Enter new author: ");
          book.Author = (Console.ReadLine()!).Trim();
          break;
        case 3:
          Console.Write("Enter new publisher: ");
          book.Publisher = (Console.ReadLine()!).Trim();
          break;
        case 4:
          Console.Write("Enter new ISBN: ");
          book.ISBN = (Console.ReadLine()!).Trim();
          break;
        case 5:
          Console.Write("Enter new year: ");
          book.Year = Convert.ToInt32(Console.ReadLine());
          break;
        case 6:
          Console.WriteLine("Enter new chapters: ");
          UpdateChapter(book);
          break;
      }

      Console.WriteLine("Continue? (1 - yes, 0 - no)");
      Console.Write("Your choice: ");
      isContinue = int.Parse(Console.ReadLine()!);
    } while (isContinue == 1);
    SaveFile();
  }
  private void UpdateChapter(Book book) {
    int length = book.Chapters.Count;

    if (length == 0) {
      Console.WriteLine("No chapters found!");
      Utils.PressAnyKey();
      return;
    }

    Console.Clear();
    Console.WriteLine("Update chapters");
    Console.WriteLine("1 - Update all");
    Console.WriteLine("2 - Update only one chapter");
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    if (choice == 1) {
      Console.WriteLine($"\nTotal chapters: {length}");
      for (int i = 0; i < length; i++) {
        Console.Write($"Chapter {i + 1}: ");
        book[i] = Console.ReadLine()!.Trim();
      }
    } else if (choice == 2) {
      Console.WriteLine($"\nTotal chapters: {length}");
      Console.Write("Enter number of chapter: ");
      int number = Convert.ToInt32(Console.ReadLine());

      Console.Write($"Chapter {number}: ");
      book[number - 1] = Console.ReadLine()!.Trim();
    }
    Console.WriteLine("Updated successfully!");
    SaveFile();
  }

  // Remove book
  public void RemoveBook() {
    int isContinue = 1;

    do {
      Console.Clear();
      Console.WriteLine("Find by?");
      Console.WriteLine("1 - Title");
      Console.WriteLine("2 - Author");
      Console.WriteLine("0 - Back");
      Console.Write("Your choice: ");
      int choice = int.Parse(Console.ReadLine()!);

      switch (choice) {
        case 0:
          return;
        case 1:
          FindBookByTitle(REMOVE);
          break;
        case 2:
          FindBookByAuthor(REMOVE);
          break;
      }

      Console.WriteLine("Continue? (1 - yes, 0 - no)");
      Console.Write("Your choice: ");
      isContinue = int.Parse(Console.ReadLine()!);

    } while (isContinue == 1);
  }

  // Sort methods
  public void SortByAuthorOrTitle() {
    for (int i = 0; i < Quantity - 1; i++) {
      if (Compare(Books[i], Books[i + 1]) > 0) {
        Book temp = new Book();
        temp = Books[i];
        Books[i] = Books[i + 1];
        Books[i + 1] = temp;
      }
    }
    Console.WriteLine("Sorted!");
    Utils.PressAnyKey();
    SaveFile();
  }
  private int Compare(Book firstBook, Book secondBook) {
    if (firstBook.Author == secondBook.Author) {
      return firstBook.Title.CompareTo(secondBook.Title);
    }
    return firstBook.Author.CompareTo(secondBook.Author);
  }

  // This method should be called every time add new book
  private void SaveFile() {
    var bookData = new BookListData { Data = Books, Quantity = Quantity };

    string jsonData = JsonConvert.SerializeObject(bookData);
    File.WriteAllText("./data/BookData.json", jsonData);
  }
  // This method should be called only once at the first time running the app
  private void LoadFile() {
    string jsonData = File.ReadAllText("./data/BookData.json");
    var booksData = JsonConvert.DeserializeObject<BookListData>(jsonData);

    if (booksData != null) {
      Books = booksData.Data;
      Quantity = booksData.Quantity;
    }
  }
}
