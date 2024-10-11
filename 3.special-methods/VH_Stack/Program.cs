using Stack;

namespace App {
class Program {
  static void Main() {
    int isContinue = 1;
    do {
      Console.Clear();
      Console.WriteLine("1. Thực hành với Stack");
      Console.WriteLine("2. Chuyển sang nhị phân");
      Console.WriteLine("0. Thoát");
      Console.Write("Lựa chọn của bạn: ");
      int choice = Convert.ToInt32(Console.ReadLine());

      switch (choice) {
      case 1:
        PractiseWithStack();
        break;
      case 2:
        break;

      default:
        return;
      }

    } while (isContinue == 1);

    // FirstTest(); // Thực hành với stack tự xây dựng
    // SecondTest(); // Thực hành chuyển số thập phân sang nhị phân với Stack
  }

  static void ConvertToBinary(int decimalNumber, VH_Stack<int> stack) {
    if (decimalNumber == 0) {
      stack.Push(0);
      return;
    }

    while (decimalNumber > 0) {
      stack.Push(decimalNumber % 2);
      decimalNumber /= 2;
    }
  }

  static void PractiseWithStack() {

    Console.WriteLine();

    VH_Stack<int> intStack = new VH_Stack<int>(10);

    intStack.Push(1);
    intStack.Push(3);
    intStack.Push(1);
    intStack.Push(2);
    intStack.Push(7);

    Console.Write("Stack hiện tại: ");
    VH_Stack<int> tmpStack = new VH_Stack<int>(intStack);
    int length = tmpStack.Count();
    for (int i = 0; i < length - 1; i++) {
      Console.Write(tmpStack.Peek() + " ");
      tmpStack.Pop();
    }
    Console.WriteLine();

    int x = intStack.Peek();
    Console.WriteLine($"Phần tử đầu Stack: {x}");
    Console.WriteLine($"Số lượng phần tử hiện tại: {intStack.Count()}");

    intStack.Pop();
    Console.WriteLine("Sau khi loại bỏ 1 phần tử");
    Console.WriteLine(
        $"Số lượng phần tử sau khi loại bỏ một phần tử: {intStack.Count()}");

    Console.ReadLine();
  }

  static void SecondTest() {
    VH_Stack<int> decimalStack = new VH_Stack<int>(10);
    int decimalNumber;
    Console.Write("Nhập phân số muốn đổi: ");
    decimalNumber = Convert.ToInt32(Console.ReadLine());

    ConvertToBinary(decimalNumber, decimalStack);

    int length = decimalStack.Count();
    Console.Write($"{decimalNumber} chuyển sang nhị phân là: ");

    for (int i = 0; i < length; i++) {
      System.Console.Write(decimalStack.Peek());
      decimalStack.Pop();
    }
    System.Console.WriteLine();

    Console.ReadLine();
  }
}

}
