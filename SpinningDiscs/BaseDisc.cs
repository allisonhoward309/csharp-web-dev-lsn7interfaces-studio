using System;
using System.Collections.Generic;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string Name { get; set; }
    /*Name does change*/
        public int StorageCapacity { get; set; }
        public int RemainingCapacity { get; set; }
        public int CapacityUsed { get; set; }
        public string DiskType { get; set; }
        public List<string> Contents { get; set; }

        public BaseDisc(string name, int maxCapacity, string disktype, int someUsedCapacity)
        {
            Name = name;
            StorageCapacity = maxCapacity;
            DiskType = disktype;
            CapacityUsed = CheckCapacity(someUsedCapacity);
            RemainingCapacity = SpaceLeft();
        }

        public int CheckCapacity(int data)
        {
            if (StorageCapacity < data)
            {
                return StorageCapacity;
            }
            else
            {
                return data;
            }
        }

        public int SpaceLeft()
        {
            return StorageCapacity - CapacityUsed;
        }

        public string DiskInfo()
        {
            string output = "Disk name: " + Name + "\nMax Capacity: " + StorageCapacity + "\nSpace Used: " + CapacityUsed + "\nAvailable Space: " + RemainingCapacity;
            return output;
        }
        /*Breakpoint added to line 44, program will not output anything when called as the defining line is a breakpoint and output is not defined.
            SpinningDiscs.dll!SpinningDiscs.Program.Main(string[] args) Line 23	C#
        */

        public string WriteData(int size)
        {
            if (size > RemainingCapacity)
            {
                return "Not enough disc space!";
            }
            CapacityUsed += size;
            RemainingCapacity += size;

            return "Data written to disc. Remaining space = " + RemainingCapacity;
        }
    }
}
/*When would you use the Call Stack pane? If you run the app and it is already functioning, what shows up there?
The call stack shows the execution path, in reverse chronological order, that brought the code to that breakpoint. */
