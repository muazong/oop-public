namespace Stack {
class VH_Stack<T> {
  List<T> list = new List<T>();
  int size = 0;
  int capacity;

  public VH_Stack(int capacity) {
    this.Capacity = capacity;
    this.list = new List<T>();
  }
  public VH_Stack(VH_Stack<T> oldStack) {
    this.Capacity = oldStack.Capacity;
    this.list = new List<T>(oldStack.list);
    this.size = oldStack.size;
  }

  // Properties
  public int Size { get => size; }
  public int Capacity {
    get => capacity;
  private
    set => capacity = value;
  }

  // Methods
  public bool IsEmpty() { return this.Size == 0; }
  public bool IsFull() { return this.Size == this.Capacity; }
  public int Count() { return this.Size; }

  public void Push(T element) {
    if (IsFull()) {
      throw new InvalidOperationException("Stack đã đầy!");
    }
    size++;
    this.list.Add(element);
  }
  public T Pop() {
    if (IsEmpty()) {
      throw new InvalidOperationException("Stack trống!");
    }
    return this.list[--size];
  }
  public T Peek() {
    if (IsEmpty()) {
      throw new InvalidOperationException("Stack trống!");
    }
    return this.list[size - 1];
  }
}
}
