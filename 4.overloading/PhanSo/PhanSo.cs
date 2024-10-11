namespace PS {
class PhanSo {
  int tuSo;
  int mauSo;

  // Constructor
  public PhanSo(int x = 0, int y = 1) {
    this.TuSo = x;
    this.MauSo = y;
  }

  // Properties
  public int TuSo {
    get => tuSo;
    set => tuSo = value;
  }
  public int MauSo {
    get => mauSo;
    set {
      if (value == 0) {
        Console.WriteLine("Mẫu số không được phép = 0 !");
        Console.WriteLine("Mặc định mẫu số sẽ = 1");
        mauSo = 1;
      }
      mauSo = value;
    }
  }

  // Methods
  static int UCLN(int a, int b) {
    while (b != 0) {
      int temp = b;
      b = a % b;
      a = temp;
    }
    return a;
  }
  public void RutGonPhanSo() {
    int ucln = UCLN(this.TuSo, this.MauSo);

    this.TuSo = this.TuSo / ucln;
    this.MauSo = this.MauSo / ucln;
  }
  public void HienThiPhanSo() {
    Console.WriteLine(this.TuSo == this.MauSo ? $"{this.TuSo}"
                                              : $"{this.TuSo}/{this.MauSo}");
  }
  public PhanSo Add(PhanSo other) {
    int tuSo = (this.TuSo * other.MauSo) + (this.MauSo * other.TuSo);
    int mauSo = this.MauSo * other.MauSo;
    int ucln = UCLN(tuSo, mauSo);

    tuSo = tuSo / ucln;
    mauSo = mauSo / ucln;

    PhanSo temp = new PhanSo(tuSo, mauSo);
    return temp;
  }
  public PhanSo Minus(PhanSo other) {
    int tuSo = (this.TuSo * other.MauSo) - (this.MauSo * other.TuSo);
    int mauSo = this.MauSo * other.MauSo;
    int ucln = UCLN(tuSo, mauSo);

    tuSo = tuSo / ucln;
    mauSo = mauSo / ucln;

    PhanSo temp = new PhanSo(tuSo, mauSo);
    return temp;
  }
  public PhanSo Times(PhanSo other) {
    int tuSo = this.TuSo * other.TuSo;
    int mauSo = this.MauSo * other.MauSo;
    int ucln = UCLN(tuSo, mauSo);

    tuSo = tuSo / ucln;
    mauSo = mauSo / ucln;

    PhanSo temp = new PhanSo(tuSo, mauSo);
    return temp;
  }
  public PhanSo Divide(PhanSo other) {
    int tuSo = this.TuSo * other.MauSo;
    int mauSo = this.MauSo * other.TuSo;
    int ucln = UCLN(tuSo, mauSo);

    tuSo = tuSo / ucln;
    mauSo = mauSo / ucln;

    PhanSo temp = new PhanSo(tuSo, mauSo);
    return temp;
  }

  // Override methods
  public override string ToString() { return $"{this.TuSo}/{this.MauSo}"; }
  public override int GetHashCode() { return base.GetHashCode(); }
  public override bool Equals(object? obj) {
    return obj is PhanSo other && this.TuSo == other.TuSo &&
           this.MauSo == other.MauSo;
  }

  // Operator methods
  public static PhanSo operator +(PhanSo a, PhanSo b) {
    int tuSo = (a.TuSo * b.MauSo) + (a.MauSo * b.TuSo);
    int mauSo = a.MauSo * b.MauSo;
    int ucln = UCLN(tuSo, mauSo);

    tuSo = tuSo / ucln;
    mauSo = mauSo / ucln;

    return new PhanSo(tuSo, mauSo);
  }
  public static PhanSo operator -(PhanSo a, PhanSo b) {
    int tuSo = (a.TuSo * b.MauSo) - (a.MauSo * b.TuSo);
    int mauSo = a.MauSo * b.MauSo;
    int ucln = UCLN(tuSo, mauSo);

    tuSo = tuSo / ucln;
    mauSo = mauSo / ucln;

    return new PhanSo(tuSo, mauSo);
  }
  public static PhanSo operator *(PhanSo a, PhanSo b) {
    int tuSo = a.TuSo * b.TuSo;
    int mauSo = a.MauSo * b.MauSo;
    int ucln = UCLN(tuSo, mauSo);

    tuSo = tuSo / ucln;
    mauSo = mauSo / ucln;

    return new PhanSo(tuSo, mauSo);
  }
  public static PhanSo operator /(PhanSo a, PhanSo b) {
    int tuSo = a.TuSo * b.MauSo;
    int mauSo = a.MauSo * b.TuSo;
    int ucln = UCLN(tuSo, mauSo);

    tuSo = tuSo / ucln;
    mauSo = mauSo / ucln;

    return new PhanSo(tuSo, mauSo);
  }
  public static bool operator ==(PhanSo a, PhanSo b) {
    return a.TuSo == b.TuSo && a.MauSo == b.MauSo;
  }
  public static bool operator !=(PhanSo a, PhanSo b) {
    return a.TuSo == b.TuSo && a.MauSo == b.MauSo;
  }

  // Main
  public static void MainPS() {
    PhanSo phanSo1 = new PhanSo(3, 2);
    PhanSo phanSo2 = new PhanSo(5, 1);
    PhanSo phanSo3 = new PhanSo(2, 4);

    // Rút gọn phân số
    Console.WriteLine($"Rút gọn phân số: {phanSo3.TuSo}/{phanSo3.MauSo}");
    phanSo3.RutGonPhanSo();                              // 2/4 -> 1/2
    Console.WriteLine("Kết quả: " + phanSo3.ToString()); // 1/2
    Console.WriteLine("==========");

    // So sánh hai phân số
    Console.WriteLine(
        $"So sánh phân số: {phanSo1.TuSo}/{phanSo1.MauSo} == {phanSo2.TuSo}/{phanSo2.MauSo}");
    phanSo1.Equals(phanSo2);                    // True
    bool ketQua1 = phanSo1 == phanSo2;          // operator ==
    bool ketQua2 = phanSo1 != phanSo2;          // operator !=
    Console.WriteLine($"Kết quả 1: {ketQua1}"); // False
    Console.WriteLine($"Kết quả 2: {ketQua2}"); // True
    Console.WriteLine("==========");

    // Các toán tử + - * /
    // Toán tử cộng
    Console.WriteLine(
        $"Cộng hai phân số {phanSo1.TuSo}/{phanSo1.MauSo} + {phanSo2.TuSo}/{phanSo2.MauSo}");
    PhanSo ketQua = phanSo1 + phanSo2;                  // 3/2 + 5/1
    Console.WriteLine("Kết quả: " + ketQua.ToString()); // 3/2 + 5/1 = 13/2
    PhanSo tong = phanSo1.Add(phanSo2);
    Console.WriteLine("Kết quả: " + tong.ToString());
    Console.WriteLine("==========");

    // Toán tử trừ
    Console.WriteLine(
        $"Trừ hai phân số {phanSo1.TuSo}/{phanSo1.MauSo} - {phanSo2.TuSo}/{phanSo2.MauSo}");
    phanSo1 = new PhanSo(3, 2);
    phanSo2 = new PhanSo(5, 1);

    ketQua = phanSo1 - phanSo2;                         // 3/2 - 5/1
    Console.WriteLine("Kết quả: " + ketQua.ToString()); // 3/2 - 5/1 = 7/-2
    PhanSo hieu = phanSo1.Minus(phanSo2);
    Console.WriteLine("Kết quả: " + hieu.ToString());
    Console.WriteLine("==========");

    // Toán tử nhân
    Console.WriteLine(
        $"Nhân hai phân số {phanSo1.TuSo}/{phanSo1.MauSo} x {phanSo2.TuSo}/{phanSo2.MauSo}");
    phanSo1 = new PhanSo(3, 2);
    phanSo2 = new PhanSo(5, 1);

    ketQua = phanSo1 * phanSo2;                         // 3/2 * 5/1
    Console.WriteLine("Kết quả: " + ketQua.ToString()); // 3/2 * 5/1 = 15/2
    PhanSo tich = phanSo1.Times(phanSo2);
    Console.WriteLine("Kết quả: " + tich.ToString());
    Console.WriteLine("==========");

    // Toán tử chia
    Console.WriteLine(
        $"Chia hai phân số {phanSo1.TuSo}/{phanSo1.MauSo} : {phanSo2.TuSo}/{phanSo2.MauSo}");
    phanSo1 = new PhanSo(3, 2);
    phanSo2 = new PhanSo(5, 1);

    ketQua = phanSo1 / phanSo2;                         // 3/2 : 5/1
    Console.WriteLine("Kết quả: " + ketQua.ToString()); // 3/2 : 5/1 = 3/10
    PhanSo thuong = phanSo1.Divide(phanSo2);
    Console.WriteLine("Kết quả: " + thuong.ToString());
  }
}
}
