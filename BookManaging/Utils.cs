class Utils {
  public static int Menu() {
    Console.Clear();

    Console.WriteLine("____BOOK MANAGING SYSTEM____");
    Console.WriteLine("1 - Show all books");
    Console.WriteLine("2 - Add new book");
    Console.WriteLine("3 - Add new books");
    Console.WriteLine("4 - Find book");
    Console.WriteLine("5 - Update book");
    Console.WriteLine("6 - Remove book");
    Console.WriteLine("7 - Sort all book");
    Console.WriteLine("0 - Exit");
    Console.Write("Your choice: ");
    int choice = Convert.ToInt32(Console.ReadLine());

    return choice;
  }

  public static void Exit() {
    Console.WriteLine("\nExiting...");
    Thread.Sleep(2000);  // Wait for 2 seconds then exit.
    Environment.Exit(0);
  }

  public static void PressAnyKey() {
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
  }
}
