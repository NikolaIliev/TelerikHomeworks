using System;
namespace FallingRocks
{
    class RockRow
    {
        public RockRow()
        {
            row = new Rock[5];
            rowLength = 0;
        }
        public RockRow(int length)
        {
            row = new Rock[length];
            rowLength = length;
        }

        public Rock[] row { get; set; }
        public int rowLength { get; set; }
    }
}
