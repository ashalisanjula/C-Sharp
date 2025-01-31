interface IAnimal{
    void Eat();
     
}

class Dog : IAnimal{
    public void Eat(){
        Console.WriteLine("Dog is eating..");
    }
}

class Cat : IAnimal{
    public void Eat(){
        Console.WriteLine("Cat is eating..");
    }
}

class Program{
    static void Main(){
        IAnimal animal1 = new Dog();
        IAnimal animal2 = new Cat();

        animal1.Eat();
        animal2.Eat();
    }
}