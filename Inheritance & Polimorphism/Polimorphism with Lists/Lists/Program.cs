
class Animal{
    public virtual void Makesound(){
        Console.WriteLine("Animals makes sounds..");
    }
}

class Dog : Animal{
    public override void Makesound()
    {
        Console.WriteLine("Dog is Barking");
    }
}

class Cat : Animal{
    public override void Makesound()
    {
        Console.WriteLine("Cat is Meowing");
    }
}

class Program{
    public static void Main(){
        List<Animal> animals = new List<Animal>{
            new Dog(),
            new Cat(),
            new Dog(),
            new Cat()
        };

        foreach (Animal animal in animals){
            animal.Makesound();
        }
    }
}