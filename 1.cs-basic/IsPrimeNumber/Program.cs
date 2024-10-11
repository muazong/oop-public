namespace IsPrimeNumber {
class Program {
  static void Main() { isPrime(); }

  static void isPrime() {
    int userInput;
    do {
      Console.Clear();
      Console.Write("Nhập 1 số: ");
      int n = Convert.ToInt32(Console.ReadLine());

      if (n < 2) {
        Console.WriteLine($"{n} không phải là số nguyên tố.");
      }

      if (n < 4) {
        Console.WriteLine($"{n} là số nguyên tố.");
      } else {
        double condition = Math.Sqrt(n);
        for (int i = 2; i < condition; i++) {
          if (n % i == 0) {
            Console.WriteLine($"{n} là số nguyên tố.");
            break;
          }
        }
        Console.WriteLine($"{n} không phải là số nguyên tố.");
      }

      Console.WriteLine("----------------------------------");
      Console.Write("Bạn có muốn nhập lại? (1: có - 0: không): ");

      userInput = Convert.ToInt32(Console.ReadLine());
      if (userInput == 0) {
        break;
      }
    } while (userInput == 1);
  }
}
}
