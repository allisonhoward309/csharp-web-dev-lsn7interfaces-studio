using System;
namespace SpinningDiscs
{
    public class CD : BaseDisk, IDisk
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 


        public CD(string name, string diskType) : base(name,diskType)
        {
           
        }
            public void SpinDisk()
            {
                Console.WriteLine("A CD spins at a rate of 200 - 500 rpm.");
            }
            public void DataWrittenByLaser()
            {
                Console.WriteLine("A CD is read by a infred 780");
            
            
            }

            public override void StoreData()
            {
            Console.WriteLine("This CD stores: " + Capacity + "GB" );
            }

    }
}
