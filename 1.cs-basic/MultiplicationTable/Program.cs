namespace MultiplicationTable {
class Program {
  static void Main() { multiplicationTable(); }
  static void multiplicationTable() {
    int userInput = 0;

    for (int i = 1; i <= 10; i++) {
      Console.WriteLine($"Bảng cửu chương {i}");

      Console.Write("+");
      for (int z = 0; z < 12; z++) {
        Console.Write("-");
      }
      Console.WriteLine("+");

      for (int j = 1; j <= 10; j++) {
        Console.WriteLine(
            $"|{i} x {j}{(i == 1 ? (i*j > 9 ? "|" : " |" ) : (j != 10 ? " |" : "|" ))} = {i*j}{(i*j > 9 ? "|" : " |" )}");

        Console.Write("+");
        for (int z = 0; z < 12; z++) {
          Console.Write("-");
        }
        Console.WriteLine("+");
      }

      do {
        Console.Write("Nhấp 1 - 10 để chuyển qua bảng cửu chương: ");
        userInput = Convert.ToInt16(Console.ReadLine());

        if (userInput <= 0 || userInput > 10) {
          Console.WriteLine("Vui lòng chỉ nhập từ 1 - 10");
        }
      } while (userInput <= 0 || userInput > 10);
      i = --userInput;
      Console.Clear();
    }
  }
}
}
