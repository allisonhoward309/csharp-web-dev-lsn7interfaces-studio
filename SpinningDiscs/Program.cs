using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            CD cd = new CD("CD example", 700, "CD-R", 350);
            DVD dvd = new DVD("DVD example", 4700, "DVD-R", 1450);

            cd.SpinDisc();
            dvd.SpinDisc();
                  /*Breakpoints added at line 13 and 18. 
                   Execution will stop after running dvd.SpinDisc()
                  and then after printng cd.WriteData(275)*/
            cd.ReadData();
            dvd.ReadData();

            Console.WriteLine(cd.WriteData(275));
            Console.WriteLine(dvd.WriteData(8000));

            Console.WriteLine(cd.DiskInfo());
            Console.WriteLine(dvd.DiskInfo());
        }
    }
}
