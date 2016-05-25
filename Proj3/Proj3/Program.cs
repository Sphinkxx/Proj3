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
            p1.x = 3; p1.y = 1;  p1.sym = '*';   p1.Draw(p1.x, p1.y, p1.sym);

            Point p2 = new Point();
            p2.x = 2; p2.y = 2;  p2.sym = '*';   p2.Draw(p2.x, p2.y, p2.sym);

            Point p3 = new Point();
            p3.x = 4; p3.y = 2;  p3.sym = '*';   p3.Draw(p3.x, p3.y, p3.sym);

            Point p4 = new Point();
            p4.x = 1; p4.y = 3;  p4.sym = '*';   p4.Draw(p4.x, p4.y, p4.sym);

            Point p5 = new Point();
            p5.x = 5; p5.y = 3;  p5.sym = '*';   p5.Draw(p5.x, p5.y, p5.sym);

            Point p6 = new Point();
            p6.x = 1; p6.y = 4; p6.sym = '*'; p6.Draw(p6.x, p6.y, p6.sym);

            Point p7 = new Point();
            p7.x = 1; p7.y = 5; p7.sym = '*'; p7.Draw(p7.x, p7.y, p7.sym);

            Point p8 = new Point();
            p8.x = 1; p8.y = 6; p8.sym = '*'; p8.Draw(p8.x, p8.y, p8.sym);

            Point p9 = new Point();
            p9.x = 1; p9.y = 7; p9.sym = '*'; p9.Draw(p9.x, p9.y, p9.sym);

            Point p10 = new Point();
            p10.x = 1; p10.y = 8; p10.sym = '*'; p10.Draw(p10.x, p10.y, p10.sym);


            int x11 = 2; int y11 = 9; char sym11 = '*';
            int x12 = 3; int y12 = 10; char sym12 = '*';
            int x13 = 5; int y13 = 4; char sym13 = '*';
            int x14 = 5; int y14 = 5; char sym14 = '*';
            int x15 = 5; int y15 = 6; char sym15 = '*';
            int x16 = 5; int y16 = 7; char sym16 = '*';
            int x17 = 5; int y17 = 8; char sym17 = '*';
            int x18 = 4; int y18 = 9; char sym18 = '*';
            int x19 = 8; int y19 = 1; char sym19 = '*';
            int x20 = 8; int y20 = 2; char sym20 = '*';
            int x21 = 8; int y21 = 3; char sym21 = '*';
            int x22 = 8; int y22 = 4; char sym22 = '*';
            int x23 = 8; int y23 = 5; char sym23 = '*';
            int x24 = 8; int y24 = 6; char sym24 = '*';
            int x25 = 8; int y25 = 7; char sym25 = '*';
            int x26 = 8; int y26 = 8; char sym26 = '*';
            int x27 = 8; int y27 = 9; char sym27 = '*';
            int x28 = 8; int y28 = 10; char sym28 = '*';
            int x29 = 9; int y29 = 1; char sym29 = '*';
            int x30 = 10; int y30 = 1; char sym30 = '*';
            int x31 = 11; int y31 = 1; char sym31 = '*';
            int x32 = 12; int y32 = 1; char sym32 = '*';
            int x33 = 9; int y33 = 5; char sym33 = '*';
            int x34 = 10; int y34 = 5; char sym34 = '*';
            int x35 = 11; int y35 = 6; char sym35 = '*';
            int x36 = 12; int y36 = 7; char sym36 = '*';
            int x37 = 12; int y37 = 8; char sym37 = '*';
            int x38 = 11; int y38 = 9; char sym38 = '*';
            int x39 = 10; int y39 = 10; char sym39 = '*';
            int x40 = 9; int y40 = 10; char sym40 = '*';
            int x41 = 15; int y41 = 1; char sym41 = '*';
            int x42 = 15; int y42 = 2; char sym42 = '*';
            int x43 = 15; int y43 = 3; char sym43 = '*';
            int x44 = 15; int y44 = 4; char sym44 = '*';
            int x45 = 15; int y45 = 5; char sym45 = '*';
            int x46 = 15; int y46 = 6; char sym46 = '*';
            int x47 = 15; int y47 = 7; char sym47 = '*';
            int x48 = 15; int y48 = 8; char sym48 = '*';
            int x49 = 15; int y49 = 9; char sym49 = '*';
            int x50 = 15; int y50 = 10; char sym50 = '*';
            int x51 = 19; int y51 = 1; char sym51 = '*';
            int x52 = 19; int y52 = 2; char sym52 = '*';
            int x53 = 19; int y53 = 3; char sym53 = '*';
            int x54 = 19; int y54 = 4; char sym54 = '*';
            int x55 = 19; int y55 = 5; char sym55 = '*';
            int x56 = 19; int y56 = 6; char sym56 = '*';
            int x57 = 19; int y57 = 7; char sym57 = '*';
            int x58 = 19; int y58 = 8; char sym58 = '*';
            int x59 = 19; int y59 = 9; char sym59 = '*';
            int x60 = 19; int y60 = 10; char sym60 = '*';
            int x62 = 16; int y62 = 6; char sym62 = '*';
            int x63 = 17; int y63 = 5; char sym63 = '*';
            int x64 = 18; int y64 = 4; char sym64 = '*';

            Draw(x11, y11, sym11); Draw(x12, y12, sym12);
            Draw(x13, y13, sym13); Draw(x14, y14, sym14); Draw(x15, y15, sym15);
            Draw(x16, y16, sym16); Draw(x17, y17, sym17); Draw(x18, y18, sym18);
            Draw(x19, y19, sym19); Draw(x20, y20, sym20); Draw(x21, y21, sym21);
            Draw(x22, y22, sym22); Draw(x23, y23, sym23); Draw(x24, y24, sym24);
            Draw(x25, y25, sym25); Draw(x26, y26, sym26); Draw(x27, y27, sym27);
            Draw(x28, y28, sym28); Draw(x29, y29, sym29); Draw(x30, y30, sym30);
            Draw(x31, y31, sym31); Draw(x32, y32, sym32); Draw(x33, y33, sym33);
            Draw(x34, y34, sym34); Draw(x35, y35, sym35); Draw(x36, y36, sym36);
            Draw(x37, y37, sym37); Draw(x38, y38, sym38); Draw(x39, y39, sym39);
            Draw(x40, y40, sym40); Draw(x41, y41, sym41); Draw(x42, y42, sym42);
            Draw(x43, y43, sym43); Draw(x44, y44, sym44); Draw(x45, y45, sym45);
            Draw(x46, y46, sym46); Draw(x47, y47, sym47); Draw(x48, y48, sym48);
            Draw(x49, y49, sym49); Draw(x50, y50, sym50); Draw(x51, y51, sym51);
            Draw(x52, y52, sym52); Draw(x53, y53, sym53); Draw(x54, y54, sym54);
            Draw(x55, y55, sym55); Draw(x56, y56, sym56); Draw(x57, y57, sym57);
            Draw(x58, y58, sym58); Draw(x59, y59, sym59); Draw(x60, y60, sym60);
            Draw(x62, y62, sym62); Draw(x63, y63, sym63); Draw(x64, y64, sym64);

            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}