using StudentManagenent;

namespace App {
class Program {
  static void Main() {
    Console.Clear();
    Student myStudent1 = new Student("Nguyen Van C", "CNTT", 10);
    Student myStudent2 = new Student("Nguyen Van D", "CTM", 30);
    Student myStudent3 = new Student("Nguyen Van E", "SP", 90);
    Student myStudent4 = new Student("Nguyen Van L", "QTKD", 50);
    Student myStudent5 = new Student("Nguyen Van B", "KT", 2);

    StudentList.DanhSachSinhVien();

    StudentList.SapXepTheoDiemTB();
    System.Console.WriteLine("\nSAU KHI SẮP XẾP THEO ĐIỂM TB");
    StudentList.DanhSachSinhVien();

    System.Console.WriteLine("\nSAU KHI SẮP XẾP THEO ID");
    StudentList.SapXepTheoID();
    StudentList.DanhSachSinhVien();
  }
}
}
