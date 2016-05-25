using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            p1.x = 3; p1.y = 1;  p1.sym = '*';   p1.Draw();

            Point p2 = new Point();
            p2.x = 2; p2.y = 2;  p2.sym = '*';   p2.Draw();

            Point p3 = new Point();
            p3.x = 4; p3.y = 2;  p3.sym = '*';   p3.Draw();

            Point p4 = new Point();
            p4.x = 1; p4.y = 3;  p4.sym = '*';   p4.Draw();

            Point p5 = new Point();
            p5.x = 5; p5.y = 3;  p5.sym = '*';   p5.Draw();

            Point p6 = new Point();
            p6.x = 1; p6.y = 4; p6.sym = '*'; p6.Draw();

            Point p7 = new Point();
            p7.x = 1; p7.y = 5; p7.sym = '*'; p7.Draw();

            Point p8 = new Point();
            p8.x = 1; p8.y = 6; p8.sym = '*'; p8.Draw();

            Point p9 = new Point();
            p9.x = 1; p9.y = 7; p9.sym = '*'; p9.Draw();

            Point p10 = new Point();
            p10.x = 1; p10.y = 8; p10.sym = '*'; p10.Draw();

            
            Console.ReadLine();
        }
        
    }
}