namespace App {
  class Program {
    static void Main() {
      BookList list = new BookList();
      bool wrongChoice = false;
      bool isSkip;
      int isContinue = 1;

      do {
        do {
          int mainChoice = Utils.Menu();
          isSkip = false;
          wrongChoice = false;

          switch (mainChoice) {
            case 0:  // Exit
              Utils.Exit();
              break;
            case 1:  // Show all books
              list.ShowList();
              break;
            case 2:  // Add a new book
              Console.Clear();
              list.AddNewBook();
              break;
            case 3:  // Add new books
              Console.Clear();
              list.AddNewBooks();
              break;
            case 4:  // Find book
              list.FindBook();
              isSkip = true;
              break;
            case 5:  // Update a book
              list.UpdateBook();
              isSkip = true;
              break;
            case 6:  // Remove a book
              list.RemoveBook();
              isSkip = true;
              break;
            case 7:  // Sort by author or title
              list.SortByAuthorOrTitle();
              isSkip = true;
              break;
            default:
              Console.WriteLine("Wrong choice!");
              Utils.PressAnyKey();
              wrongChoice = true;
              break;
          }
        } while (wrongChoice);

        if (!isSkip) {
          Console.WriteLine("\nBack? (1: Yes - 0: Exit)");
          Console.Write("Your choice: ");
          isContinue = Convert.ToInt32(Console.ReadLine());
        }
      } while (isContinue == 1);
      Utils.Exit();
    }
  }
}
