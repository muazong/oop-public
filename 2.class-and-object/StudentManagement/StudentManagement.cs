namespace StudentManagenent {
class StudentList {
  static int soLuongSinhVien = 0;
  static List<Student> danhSachSinhVien = new List<Student>();

  // Constructors
  public StudentList() {}
  public StudentList(Student sinhVien) {
    danhSachSinhVien.Add(sinhVien);
    soLuongSinhVien++;
  }

  // Methods
  static public void DanhSachSinhVien() {
    if (soLuongSinhVien == 0) {
      Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG!");
      return;
    }
    Console.WriteLine("DANH SÁCH SINH VIÊN");
    for (int i = 0; i < soLuongSinhVien; i++) {
      Console.WriteLine(danhSachSinhVien[i].ToString());
      Console.WriteLine("-------------------");
    }
  }

  static public void SapXepTheoDiemTB() {
    for (int i = 0; i < soLuongSinhVien; i++) {
      for (int j = 0; j < soLuongSinhVien - i - 1; j++) {
        if (danhSachSinhVien[j].DiemTB > danhSachSinhVien[j + 1].DiemTB) {
          List<Student> tmp = new List<Student>();
          tmp.Add(danhSachSinhVien[j]);
          danhSachSinhVien[j] = danhSachSinhVien[j + 1];
          danhSachSinhVien[j + 1] = tmp[0];
        }
      }
    }
  }

  static public void SapXepTheoID() {
    for (int i = 0; i < soLuongSinhVien; i++) {
      for (int j = 0; j < soLuongSinhVien - i - 1; j++) {
        if (danhSachSinhVien[j].ID > danhSachSinhVien[j + 1].ID) {
          List<Student> tmp = new List<Student>();
          tmp.Add(danhSachSinhVien[j]);
          danhSachSinhVien[j] = danhSachSinhVien[j + 1];
          danhSachSinhVien[j + 1] = tmp[0];
        }
      }
    }
  }
}

class Student {
  int id = 0;
  string tenSV = "";
  string khoa = "";
  float diemTB;

  // Biến soLuongSinhVien
  // được sử dụng để làm giá trị cho id
  // vì id không thể trùng nhau
  // ******
  // Để kiểu dữ liệu static vì mong muốn
  // biến và danh sách sẽ chỉ khởi tạo duy nhất 1 lần
  static int soLuongSinhVien = 0;
  static StudentList danhSachSinhVien = new StudentList();

  // Constructor
  public Student(string tenSV = "Nguyen Van A", string khoa = "CNTT",
                 float diemTB = 0) {

    // Gán id = soLuongSinhVien + 1
    this.id = ++soLuongSinhVien;

    this.TenSV = tenSV;
    this.Khoa = khoa;
    this.DiemTB = diemTB;

    // Thêm sinh viên vừa được khởi tạo vào danh sách
    danhSachSinhVien = new StudentList(this);
  }
  // Copy sinh viên
  public Student(Student sinhVienGoc) {
    this.ID = sinhVienGoc.ID;
    this.TenSV = sinhVienGoc.TenSV;
    this.Khoa = sinhVienGoc.Khoa;
    this.DiemTB = sinhVienGoc.DiemTB;
    soLuongSinhVien++;
    danhSachSinhVien = new StudentList(sinhVienGoc);
  }

  // Properties
  public int ID {
    get => id;
  // Để private vì mong muốn chỉ đọc id
  // chứ sẽ không được phép thay đổi id
  private
    set => id = value;
  }
  public string TenSV {
    get => tenSV;
    set => tenSV = value;
  }
  public string Khoa {
    get => khoa;
    set => khoa = value;
  }
  public float DiemTB {
    get => diemTB;
    set => diemTB = value;
  }

  // Methods
  public override string ToString() {
    return $"Họ và tên: {this.TenSV}\nMã sinh viên: {this.ID}\nKhoa: {this.Khoa}\nĐiểm trung bình: {this.DiemTB}";
  }
}
}
