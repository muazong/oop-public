namespace App {
class Program {
  class Animal {
    public virtual void MakeSound() { Console.WriteLine("Make sound"); }
  }

  class Dog : Animal {
    public override void MakeSound() { Console.WriteLine("Bark"); }
  }

  static void Main() {
    Animal dog = new Dog();
    dog.MakeSound();
  }
}
}
