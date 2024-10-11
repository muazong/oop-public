class Book : IBook {
  string title = "";
  string author = "";
  string publisher = "";
  string isbn = "";
  int year;
  List<string> chapters = new List<string>();

  // Properties
  public string this[int index] {
    get {
      if (index >= 0 && index < Chapters.Count) {
        return (string)chapters[index]!;
      }
      throw new Exception("Index out of range");
    }
    set {
      if (index >= 0 && index < Chapters.Count) {
        chapters[index] = value;
      } else if (index == Chapters.Count) {
        chapters.Add(value);
      } else {
        throw new Exception("Index out of range");
      }
    }
  }
  public string Title {
    get => title;
    set => title = value;
  }
  public string Author {
    get => author;
    set => author = value;
  }
  public string Publisher {
    get => publisher;
    set => publisher = value;
  }
  public string ISBN {
    get => isbn;
    set => isbn = value;
  }
  public int Year {
    get => year;
    set => year = value;
  }
  public List<string> Chapters { get => chapters; }

  // Methods
  public void InputBook() {
    Console.Write("Title: ");
    Title = Console.ReadLine()!.Trim();

    Console.Write("Author: ");
    Author = Console.ReadLine()!.Trim();

    Console.Write("Publisher: ");
    Publisher = Console.ReadLine()!.Trim();

    Console.Write("ISBN: ");
    ISBN = Console.ReadLine()!.Trim();

    Console.Write("Year of publication: ");
    Year = Convert.ToInt32(Console.ReadLine());

    Console.Write("How many chapters in the book?: ");
    int chapterQuantity = Convert.ToInt32(Console.ReadLine());
    InputBookChapter(chapterQuantity);
  }
  private void InputBookChapter(int quantity) {
    for (int i = 0; i < quantity; i++) {
      Console.Write($"Chapter {i + 1}: ");
      this[i] = Console.ReadLine()!.Trim();
    }
  }

  public void Show() {
    Console.WriteLine($"Title: {Title}");
    Console.WriteLine($"Author: {Author}");
    Console.WriteLine($"Publisher: {Publisher}");
    Console.WriteLine($"ISBN: {ISBN}");
    Console.WriteLine($"Year: {Year}");
    Console.WriteLine("Chapters: ");

    int index = 1;
    foreach (string chapter in Chapters) {
      Console.WriteLine($"\tChapter {index++}: {chapter}");
    }
  }
}
