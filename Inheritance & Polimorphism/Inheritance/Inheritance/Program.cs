public class Animal{
    public virtual void MakeSound(){
        Console.WriteLine("Animals makes Sound.");
    }
}

public class Dog : Animal{
    public override void MakeSound(){
        Console.WriteLine("Dog is Barking.");
    }
}

public class Cat : Animal{
    public override void MakeSound()
    {
        Console.WriteLine("Cat is Meowing.");
    }
}

public class Program{
    public static void Main(){
        Animal animal1 = new Dog();
        Animal animal2 = new Cat();

        animal1.MakeSound();
        animal2.MakeSound();
    }
}


