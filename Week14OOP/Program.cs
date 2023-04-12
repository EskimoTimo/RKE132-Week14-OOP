Console.WriteLine("Name your dog:");
string myDogName = Console.ReadLine();

Dog myDog = new Dog(myDogName);

Dog neighboursDog = new Dog("Good Girl");

Console.WriteLine($"My dogs name is {myDog.Name}.");
Console.WriteLine($"My neighbours dogs name is {neighboursDog.Name}.");

myDog.Rename("Bad Boy");

while (myDog.LevelOfHapiness != 5) {
    myDog.Bark();
}

myDog.WagTail();

class Dog {
    private string _name; // Field
    private int _levelOfHapiness;

    // Constructor
    public Dog(string name) { // name - lets the user name the dog
        _name = name;
        _levelOfHapiness = 0;
    }

    // Getter 1
    public string Name {
        get { return _name; }
    }

    // Getter 2
    public int LevelOfHapiness {
        get { return _levelOfHapiness; }
    }

    public void Rename(string newName) {
        _name = newName;
        Console.WriteLine($"The dog has been renamed to: {newName}");
    }

    public void Bark() {
        Console.WriteLine("Woof-woof!");
        _levelOfHapiness++;
    }

    public void WagTail() {
        Console.WriteLine("Wiggle-wiggle!");
    }
}