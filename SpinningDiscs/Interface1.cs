using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IDisk
    {
        const double diskSize= 4.7;
        void SpinDisk();
        void DataWrittenByLaser();
        void DiskSize()
        {
            Console.WriteLine("The physical size of the disk is " + diskSize);
        }
        void ReadableByLaser()
        {
            Console.WriteLine("A disk is read by a laser");
        }
        void DiskMaterial()
        {
            {
                Console.WriteLine("A disk is made up of plastic, metal, polycarbonate");
            }
        }
       
    }
}
