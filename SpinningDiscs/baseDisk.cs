using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
   public abstract class BaseDisk
    {
       public string Name { get; set; }
       public int Capacity { get; set; }
       public string DiskType { get; set; }

        public BaseDisk(string name, string diskType, int capacity=5)
        {
            Name = name;
            Capacity = capacity;
            DiskType = diskType;
        }

       public abstract void StoreData();
    }
}
