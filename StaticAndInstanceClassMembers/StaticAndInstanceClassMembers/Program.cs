using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndInstanceClassMembers
{
    class Circle
    {
        int radius;
        //staticka varijabla --> kod stvaranja novih objekata ne duplicira se varijabla već svi objekti pokazuju na ovu varijablu u memoriji
        static float _PI;
        
        //privatni konstruktor za inicijalizaciju staticke varijable
        static Circle()
        {
            Console.WriteLine("Staticni konstruktor pozvan");
            _PI = 3.14F; 
        }

        //konstruktor za inicijalizaciju 
        public Circle(int radius)
        {
            Console.WriteLine("Pozvan konstruktor instance");
            this.radius = radius;
        }

        //metoda koja racuna opseg kruznice

        public float CalculateArea()
        {
            return _PI * this.radius * this.radius;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //prvi objekt klase Circle
            Circle C1 = new Circle(5);
            float area1 = C1.CalculateArea();
            Console.WriteLine("Area = {0}", area1);

            //drugi objekt klase circle
            Circle C2 = new Circle(6);
            float area2 = C2.CalculateArea();
            Console.WriteLine("Area = {0}", area2);

        }
    }
}
/*Ispis
Staticni konstruktor pozvan ---> poziva se cim se kreira novi objekt, tj prije poziva konstruktora instance
Pozvan konstruktor instance
Area = 78,5
Pozvan konstruktor instance
Area = 113,04
Press any key to continue . . .


*/
