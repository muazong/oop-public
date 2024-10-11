interface IComparable<T> {
  public int Salary { get; set; }
  public string Name { get; set; }
  public int CompareTo(T obj);
}
