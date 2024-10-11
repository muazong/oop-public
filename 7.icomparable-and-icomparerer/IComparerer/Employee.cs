class Employee : IComparable<Employee> {
  int salary;
  string name = "";

  public Employee() {}
  public Employee(string name, int salary) {
    Name = name;
    Salary = salary;
  }

  public int CompareTo(Employee employeeFirst, Employee employeeSecond) {
    if (employeeFirst.Salary == employeeFirst.Salary) {
      return employeeFirst.Name.CompareTo(employeeFirst.Name);
    }
    return employeeFirst.Salary.CompareTo(employeeFirst.Salary);
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
