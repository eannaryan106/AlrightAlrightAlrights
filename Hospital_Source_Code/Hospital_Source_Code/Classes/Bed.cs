using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Source_Code.Classes
{
    class Bed
    {
        int bedId;
        bool occupied;

        public int BedId { get => bedId; set => bedId = value; }
        public bool Occupied { get => occupied; set => occupied = value; }
    }
}
