using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.

            // TODO: Call each CD and DVD method to verify that they work as expected.

            CD cd = new CD("Johnny Cash", "CD");
            cd.SpinDisk();
            ((IDisk)cd).ReadableByLaser();
            ((IDisk)cd).DiskSize();
            cd.DataWrittenByLaser();
            ((IDisk)cd).DiskMaterial();
            cd.StoreData();

            DVD dvd = new DVD("Shrek", "DVD", 8);
            dvd.SpinDisk();
            ((IDisk)dvd).ReadableByLaser();
            ((IDisk)dvd).DiskSize();
            dvd.DataWrittenByLaser();
            ((IDisk)dvd).DiskMaterial();
            dvd.StoreData();
        }
    }
}