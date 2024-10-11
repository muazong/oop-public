namespace MathLib {
class MyMath {
  public static int Cong(int x, int y) { return x + y; }
  public static int GiaiThua(int n) {
    if (n == 0) {
      return 1;
    }
    return n * GiaiThua(n - 1);
  }
  public static long ChinhHop(int k, int n) {
    if (k > n)
      return 0;
    return GiaiThua(n) / GiaiThua(k - n);
  }
  public static long ToHop(int k, int n) {
    if (k > n)
      return 0;
    return GiaiThua(n) / (GiaiThua(k) * GiaiThua(n - k));
  }
}
}
