class Employee : IComparable<Employee> {
  int salary;
  string name = "";

  public Employee(string name, int salary) {
    Name = name;
    Salary = salary;
  }

  public int CompareTo(Employee otherEmployee) {
    if (this.Salary == ((Employee)otherEmployee).Salary) {
      return this.Name.CompareTo(((Employee)otherEmployee).Name);
    }
    return this.Salary.CompareTo(((Employee)otherEmployee).Salary);
  }

  public int Salary {
    get => salary;
    set => salary = value;
  }

  public string Name {
    get => name;
    set => name = value;
  }

  public static void Run() {}
}
