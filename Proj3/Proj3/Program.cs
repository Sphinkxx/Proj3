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
            Point p1 = new Point(3, 1, '*');
            p1.Draw();

            Point p2 = new Point(2, 2, '*');
            p2.Draw();

            Point p3 = new Point(4, 2, '*');
           p3.Draw();

            Point p4 = new Point(1, 3, '*');
            p4.Draw();

            Point p5 = new Point(5, 3, '*');
            p5.Draw();

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

            Point p11 = new Point();
            p11.x = 2; p11.y = 9; p11.sym = '*'; p11.Draw();

            Point p12 = new Point();
            p12.x = 3; p12.y = 10; p12.sym = '*'; p12.Draw();

            Point p13 = new Point();
            p13.x = 5; p13.y = 4; p13.sym = '*'; p13.Draw();

            Point p14 = new Point();
            p14.x = 5; p14.y = 5; p14.sym = '*'; p14.Draw();

            Point p15 = new Point();
            p15.x = 5; p15.y = 6; p15.sym = '*'; p15.Draw();

            Point p16 = new Point();
            p16.x = 5; p16.y = 7; p16.sym = '*'; p16.Draw();

            Point p17 = new Point();
            p17.x = 5; p17.y = 8; p17.sym = '*'; p17.Draw();

            Point p18 = new Point();
            p18.x = 4; p18.y = 9; p18.sym = '*'; p18.Draw();

            Point p19 = new Point();
            p19.x = 8; p19.y = 1; p19.sym = '*'; p19.Draw();

            Point p20 = new Point();
            p20.x = 8; p20.y = 2; p20.sym = '*'; p20.Draw();

            Console.ReadLine();
        }
        
    }
}