using System;

/* Sukurti struktūrą Point, publiclaukai x ir y tik skaitymui, perduodami per konstr. 
 * Sukurti struktūrą Rectangle, su publiclaukais TopLeft, BottomRightPointtipo. 
 * Sukurti metodą boolIsPointInRectangle(Pointtaskas). */

namespace NETLesson08_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point taskas1 = new Point(2, 10);
            Point taskas2 = new Point(-5, 10);
            Rectangle kvadratas = new Rectangle(taskas1, taskas2);
            Console.WriteLine(kvadratas.IsPointInRectangle(taskas2));
        }
    }
}
