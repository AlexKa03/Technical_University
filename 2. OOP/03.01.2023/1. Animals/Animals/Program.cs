using System;
using System.Drawing;

namespace Animals
{
    class Program
    {
        static void Main()
        {
            ConsoleWriteLineWithColor(nameof(ShowCasting));
            Console.WriteLine();
            ShowCasting(new Jiraf(1, 1));
            Console.WriteLine();

            ConsoleWriteLineWithColor(nameof(ShowCasting));
            Console.WriteLine();
            ShowCasting(new Kon(2, Color.Black));
            Console.WriteLine();

            ConsoleWriteLineWithColor(nameof(ShowPolymorphism));
            Console.WriteLine();
            ShowPolymorphism();

            ConsoleWriteLineWithColor(nameof(ShowBoxingUnboxing));
            Console.WriteLine();
            ShowBoxingUnboxing(
                animal: new Kon(10, new Name("Gospodin", "Vihur")),
                logger: Console.WriteLine);

            Console.WriteLine();
            ConsoleWriteLineWithColor(nameof(ShowEqualityComparing));
            Console.WriteLine();
            ShowEqualityComparing(new Kon(6, new Name("Woo", "Hoo")), new Kon(9, new Name("Woo", "Hoo")));
        }

        public static void ConsoleWriteLineWithColor(string str, ConsoleColor consoleColor = ConsoleColor.Yellow)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ShowCasting(Animal animal)
        {
            // This type of casting may throw exception

            //Console.WriteLine(((Kon)animal).SkinColor);
            //Console.WriteLine(((Jiraf)animal).NeckLength);

            // The following types of casting are safe

            Console.WriteLine($"{nameof(Animal)} as {nameof(Jiraf)}: {animal as Jiraf}");
            Console.WriteLine($"{nameof(Animal)} as {nameof(Kon)}: {animal as Kon}");

            if (animal is Kon kon)
                Console.WriteLine($"Az sum {nameof(Kon)} s cvqt: {kon.SkinColor}");
            else if (animal is Jiraf jiraf)
                Console.WriteLine($"Az sum {nameof(Jiraf)} i vruta mi e dulug: {jiraf.NeckLength}cm");
        }

        public static void ShowPolymorphism()
        {
            Animal animal1 = new Jiraf(1, 1);
            Console.WriteLine(animal1.Speed);
            Console.WriteLine(animal1.Sound);
            Console.WriteLine(animal1.GetSound());

            Console.WriteLine();
            Animal animal2 = new Kon(2);
            Console.WriteLine(animal2.Speed);
            Console.WriteLine(animal2.Sound);
            Console.WriteLine(animal2.GetSound());

            Console.WriteLine();
            Console.WriteLine("In array:");
            Console.WriteLine();
            Animal[] animals = new Animal[] { new Jiraf(3, 3), new Kon(5, Color.Brown) };
            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine("Element: " + i);
                Console.WriteLine(animals[i].Speed);
                Console.WriteLine(animals[i].Sound);
                Console.WriteLine(animals[i].GetSound());
                Console.WriteLine();
                ShowCasting(animals[i]);
                Console.WriteLine();
            }
        }

        public static void ShowBoxingUnboxing(Animal animal, Action<string> logger)
        {
            object obj = animal.Name; // Boxing
            Console.WriteLine(obj); // Calls ToString() on obj
            Name name = (Name)obj; // Unboxing (in this case it will always succeed because we know that obj has Name in it)
            name.Log(logger); // Passes a method which is used to log the name somewhere (the example will be with console)
        }

        public static void ShowEqualityComparing(Animal animal1, Animal animal2)
        {
            Console.WriteLine("Are animals equal: ");
            Console.WriteLine(animal1 == animal2);
            Console.WriteLine();
            Console.WriteLine("Are their names equal");
            Console.WriteLine(animal1.Name == animal2.Name);
        }

        // Every class inherits object
        public abstract class Animal //: object
        {
            public Name Name { get; }
            public int Speed { get; }
            public abstract string Sound { get; }

            protected Animal(int speed)
            {
                Speed = speed;
                Name = new Name("Nameless", "Animal");
            }

            protected Animal(int speed, Name name)
            {
                Speed = speed;
                Name = name;
            }

            public virtual string GetSound() => Sound;
        }

        public class Jiraf : Animal
        {
            public int NeckLength { get; }

            public Jiraf(int speed, int neckLength) : base(speed) => NeckLength = neckLength;
            public Jiraf(int speed, Name name, int neckLength) : base(speed, name) => NeckLength = neckLength;

            public override string Sound => "Iskam Qbulka";
        }

        public class Kon : Animal
        {
            public Color SkinColor { get; }
            public override string Sound => "Dii Vihre";

            public Kon(int speed) : base(speed) => SkinColor = Color.Brown;
            public Kon(int speed, Color skinColor) : base(speed) => SkinColor = skinColor;
            public Kon(int speed, Name name) : base(speed, name) { }
            public Kon(int speed, Name name, Color skinColor) : base(speed, name) => SkinColor = skinColor;

            public override string GetSound() => Sound + " " + Sound;
        }

        public struct Name
        {
            public string First { get; }
            public string Last { get; }

            public Name(string first, string last)
            {
                First = first;
                Last = last;
            }

            public override bool Equals(object obj) => obj is Name name && this == name;

            public override int GetHashCode() => First.GetHashCode() ^ Last.GetHashCode();

            public void Log(Action<string> logger) => logger?.Invoke(First + " " + Last);

            public static bool operator ==(Name l, Name r) => l.First == r.First;
            public static bool operator !=(Name l, Name r) => !(l == r);
        }
    }
}
