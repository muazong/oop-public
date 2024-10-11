namespace Animal {
class Cat {
  static int instance = 0;

  public Cat() { instance++; }

  public static int Count() { return instance; }
  public static void CreateCat() {
    Cat cat1 = new Cat();
    Cat cat2 = new Cat();
    Cat cat3 = new Cat();
    Cat cat4 = new Cat();
    Cat cat5 = new Cat();
    Cat cat6 = new Cat();
  }
}
}
