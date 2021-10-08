using OOPS.Abstraction;
using OOPS.Inheritance;
using OOPS.Polymorphism;
using OOPS1;
using System;

namespace OOPS
{
    class Car
    {
        /// <summary>
        /// The model
        /// </summary>
   

        //class variable
        string model;   
        string color;
        int year;

        static void Main(string[] args)
        {
            //creating multiple objects


            Car Ford = new Car();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Car Opel = new Car();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Car swift = new Car();
            swift.model = "Swift";
            swift.color = "Black";
            swift.year = 2010;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.color);
            Console.WriteLine(swift.year);

            Console.WriteLine();

            //using constructor and class1 method

            class1 dog = new class1("German shepherd", 2, "Brown color");
            Console.WriteLine("Species of dog: " + dog.species + " age: " + dog.age + " color: " + dog.color);

            Console.WriteLine();

            //below block of code is for example of encapsulation

            Encap student = new Encap();
            student.Name = "Subhadeep";
            student.Age = 25;
            student.Stream = "Engineering";

            Console.WriteLine("Name:" + student.Name + " Age: " + student.Age + " Stream: " + student.Stream);

            Console.WriteLine();


            //below is for inheritance
            // Create a myBike object
            Bike myBike = new Bike();

            // Call the honk() method (From the Vehicle class) on the myBike object
            myBike.sound();

            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myBike.brand + " " + myBike.modelName);

            Console.WriteLine();
            //Following code is for method ovverride

            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            Console.WriteLine();

            //test method overloading below

            MethodOverloading overload1 = new MethodOverloading(); //creating objects
            MethodOverloading overload2 = new MethodOverloading();

            int add1 = overload1.add(10, 20);
            int add2 = overload2.add(30, 40, 50, 60);
            Console.WriteLine("First addition example {0}, secondly {1}",add1,add2);

            Console.WriteLine();

            //Following code is for abstraction

            Shape abc;
            abc = new Rectangle();
            abc.draw();
            abc = new Circle();
            abc.draw();





        }
    }

    
}

