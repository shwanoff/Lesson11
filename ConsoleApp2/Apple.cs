using System;

namespace ConsoleApp2
{
    public class Apple : Product
    {
        public Apple(string name, int calorie, int volume) : base(name, calorie, volume)
        {

        }

        public static Apple Add(Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);

            return apple;
        }

        public static Apple operator+ (Apple apple1, Apple apple2)
        {
            int calories = (int)Math.Round(((apple1.Calorie + apple2.Calorie) / 2.0));
            var volume = apple1.Volume + apple2.Volume;
            var apple = new Apple("Яблоко", calories, volume);

            return apple;
        }

        public static Apple operator+ (Apple apple1, int volume)
        {
            var apple = new Apple(apple1.Name, apple1.Calorie, apple1.Volume + volume);
            return apple;
        }

        public static bool operator ==(Apple apple1, Apple apple2)
        {
            return apple1.Name == apple2.Name;
        }

        public static bool operator!= (Apple apple1, Apple apple2)
        {
            return apple1.Name == apple2.Name;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
