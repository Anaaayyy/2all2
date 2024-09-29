using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2all2
{
    class Shape
    {
        // Метод для нахождения площади
        public virtual double Area()
        {
            return 0;
        }

        // Метод для нахождения периметра
        public virtual double Perimeter()
        {
            return 0;
        }
    }

    class Circle : Shape
    {
        private double radius;

        // Конструктор для инициализации радиуса
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // Переопределение метода для вычисления площади круга
        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        // Переопределение метода для вычисления периметра круга
        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }

    class Rectangle : Shape
    {
        private double width;
        private double height;

        // Конструктор для инициализации ширины и высоты
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        // Переопределение метода для вычисления площади прямоугольника
        public override double Area()
        {
            return width * height;
        }

        // Переопределение метода для вычисления периметра прямоугольника
        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }

    class Program
    {
        static void Main()
        {
            // Создание объектов классов Circle и Rectangle
            Shape circle = new Circle(10);  // Радиус круга = 5
            Shape rectangle = new Rectangle(7, 18);  // Ширина = 7, Высота = 18

            Console.WriteLine("Круг:");
            Console.WriteLine("Площадь: " + circle.Area());
            Console.WriteLine("Периметр: " + circle.Perimeter());

            Console.WriteLine("\nПрямоугольник:");
            Console.WriteLine("Площадь: " + rectangle.Area());
            Console.WriteLine("Периметр: " + rectangle.Perimeter());
            Console.ReadLine();

        }
    }
}
