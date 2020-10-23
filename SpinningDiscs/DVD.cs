using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisk, IDisk
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately
        public DVD(string name, string diskType, int capacity) : base(name, diskType, capacity)
        {

        }
        public void SpinDisk()
        {
            Console.WriteLine("A DVD spins at a rate of 570 - 1600 rpm.");
        }
        public void DataWrittenByLaser()
        {
            Console.WriteLine("A DVD is read by a 650nm red Laser");
        }
        public override void StoreData()
        {
            Console.WriteLine("This DVD stores: " + Capacity + "GB");
        }
    }
}
