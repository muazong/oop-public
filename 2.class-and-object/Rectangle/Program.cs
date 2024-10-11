namespace CS_Rectangle {
class Rectangle {
  int x, y;
  int width, height;

  public Rectangle(int x = 0, int y = 0, int w = 0, int h = 0) {
    this.OffsetX = x;
    this.OffsetY = y;
    this.Width = w;
    this.Height = h;
  }

  // Properties
  public int OffsetX {
    get => x;
    set => x = value;
  }
  public int OffsetY {
    get => y;
    set => y = value;
  }

  public int Width {
    get => width;
    set => width = value;
  }
  public int Height {
    get => height;
    set => height = value;
  }

  // Methods
  public void Draw() {
    int offsetY = this.OffsetY;
    int offsetX = this.OffsetX;
    int rectWidth = this.Width;
    int rectHeight = this.Height - 1;

    // Draw offset x line
    Console.Write("+");
    int totalOffsetXCol = (offsetX + rectWidth);
    for (int i = 0; i < totalOffsetXCol; i++) {
      Console.Write("-");
    }
    Console.WriteLine("x");

    // Draw offset y line
    for (int i = 0; i < offsetY; i++) {
      Console.WriteLine("|");
    }

    // Draw rectangle
    bool isFirstRow = true;
    int totalOffsetYRow = offsetY + rectHeight;

    /*
    The first row should only be checked once,
    so we want the check condition of row 1
    to be at the bottom so it doesn't affect
    execution speed too much.
    */
    for (int i = 0; i <= totalOffsetYRow; i++) {
      if (i == totalOffsetYRow) { // Last row
        Console.Write("|");
        for (int j = 0; j < offsetX - 2; j++) {
          Console.Write(" ");
        }

        Console.Write("+");
        for (int j = 0; j < rectWidth; j++) {
          Console.Write("-");
        }
        Console.WriteLine("+");
        continue;
      }

      if (!isFirstRow) { // Middle rows
        Console.Write("|");
        for (int j = 0; j < offsetX - 2; j++) {
          Console.Write(" ");
        }

        Console.Write("|");
        for (int j = 0; j < rectWidth; j++) {
          Console.Write(" ");
        }
        Console.WriteLine("|");
        continue;
      }

      if (i == offsetY && isFirstRow) { // First row
        isFirstRow = false;

        Console.Write("|");
        for (int j = 0; j < offsetX - 2; j++) {
          Console.Write(" ");
        }

        Console.Write("+");
        for (int j = 0; j < rectWidth; j++) {
          Console.Write("-");
        }
        Console.WriteLine("+");
      }
    }
    Console.Write("y");
  }
  public int rectangularArea() {
    int result = Width * Height;
    return result;
  }
}

class Program {
  static void Main() {
    Console.Clear();

    Console.Write("Nhập tọa độ x: ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("Nhập tọa độ y: ");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.Write("Nhập chiều dài: ");
    int w = Convert.ToInt32(Console.ReadLine());

    Console.Write("Nhập chiều rộng: ");
    int h = Convert.ToInt32(Console.ReadLine());

    Rectangle myRect = new Rectangle(x, y, w, h);
    myRect.Draw();

    Console.WriteLine(
        $"\n\nDiện tích hình chữ nhật: {myRect.rectangularArea()}cm\u00B2");
  }
}
}
