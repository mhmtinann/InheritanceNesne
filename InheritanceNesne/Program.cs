using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace InheritanceNesne
{
    public class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Rectangle(10,20);

            Console.WriteLine("{0},{1}",s1.X,s1.Y);

            var s2 =new Circle(25,35);

            Console.WriteLine("{0},{1}", s2.X, s2.Y);

            var s3 = new Sqaure(45,55);
            
            Console.WriteLine("{0},{1}", s3.X, s3.Y);

            s3.WorkWithDifferentObject(s2); //baştaki s3. veya başka s1. falan olması farketmez önemli olan gönderdiğimiz shape türünde bir obje olması.Mesela sayi veya string de gönderemeyiz hata alırız.

            Console.ReadKey();



            

            

            
        }
        private static void Polymorphishm()
        {
            var shapes = new List<Shape>()
            {
                new Triangle(),
                new Circle(),
                new Rectangle()


            };

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            Sqaure sqaure = new Sqaure();

            sqaure.Calculate();
        }

        static void VirtualKeyword()
        {
            Rectangle rectangle = new Rectangle();
            Circle circle = new Circle();

            rectangle.X = 10;
            rectangle.Y = 100;

            Console.WriteLine($"{rectangle.X} {rectangle.Y}");

            rectangle.Draw();

            circle.X = 5;
            circle.Y = 55;
            Console.WriteLine($"{circle.X} {circle.Y}");

            circle.Draw();
        }



    }

}
