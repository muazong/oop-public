namespace App {
class Program {
  static void Main() {
    int isContinue = 1;

    do {
      Console.Clear();
      Console.WriteLine("Lựa chọn phép tính");
      Console.WriteLine("1. Phép cộng");
      Console.WriteLine("2. Giai thừa");
      Console.WriteLine("3. Tổ hợp");
      Console.WriteLine("4. Chỉnh hợp");
      Console.WriteLine("0. Thoát");
      Console.Write("Lựa chọn của bạn: ");
      int choice = Convert.ToInt32(Console.ReadLine());

      switch (choice) {
      case 1:
        PhepCong();
        break;
      case 2:
        GiaiThua();
        break;
      case 3:
        ToHop();
        break;
      case 4:
        ChinhHop();
        break;
      default:
        return;
      }

      Console.WriteLine("Bạn có muốn tiếp tục? (1: có - 0: không)");
      Console.Write("Lựa chọn: ");
      isContinue = Convert.ToInt32(Console.ReadLine());
    } while (isContinue == 1);
  }

  static void PhepCong() {
    Console.Clear();

    Console.Write("Nhập a: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Nhập b: ");
    int b = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Kết quả: {MathLib.MyMath.Cong(a, b)}");
  }
  static void GiaiThua() {
    Console.Clear();

    Console.Write("Nhập n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Kết quả: {MathLib.MyMath.GiaiThua(n)}");
  }
  static void ToHop() {
    Console.Clear();

    Console.Write("Nhập k: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Nhập n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Kết quả: {MathLib.MyMath.ToHop(k, n)}");
  }
  static void ChinhHop() {
    Console.Clear();

    Console.Write("Nhập k: ");
    int k = Convert.ToInt32(Console.ReadLine());
    Console.Write("Nhập n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Kết quả: {MathLib.MyMath.ToHop(k, n)}");
  }
}
}
