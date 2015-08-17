using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication5
{
    class Spot
    {
        public int column { get; set; }
        public int row { get; set; }

        public Spot(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
    }
}
