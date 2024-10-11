namespace App {
class Program {
  static void Main() {
    Console.Clear();
    List<Employee> employeeManagement = new List<Employee>();
    Employee employee2 = new Employee("Nguyen Van B", 200);
    Employee employee3 = new Employee("Nguyen Van C", 300);
    Employee employee4 = new Employee("Nguyen Van D", 140);
    Employee employee1 = new Employee("Nguyen Van A", 500);

    employeeManagement.Add(employee1);
    employeeManagement.Add(employee2);
    employeeManagement.Add(employee3);
    employeeManagement.Add(employee4);

    Console.WriteLine("Before sort");
    Console.WriteLine($"Name{new String(' ', employee1.Name.Length)}Salary");
    foreach (Employee item in employeeManagement) {
      Console.Write($"{item.Name}\t");
      Console.WriteLine(item.Salary);
    }

    int length = employeeManagement.Count;
    Employee comparer = new Employee();
    for (int i = 0; i < length - 1; i++) {
      for (int j = 0; j < length - i - 1; j++) {
        if (comparer.CompareTo(employeeManagement[j],
                               employeeManagement[j + 1]) == 1) {
          Employee tmp = employeeManagement[j];
          employeeManagement[j] = employeeManagement[j + 1];
          employeeManagement[j + 1] = tmp;
        }
      }
    }

    Console.WriteLine("\nAfter sort");
    Console.WriteLine($"Name{new String(' ', employee1.Name.Length)}Salary");
    foreach (Employee item in employeeManagement) {
      Console.Write($"{item.Name}\t");
      Console.WriteLine(item.Salary);
    }
  }
}
}
