using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Sudoku
    {
        private Table table;
        public Sudoku()
        {
            table = new Table();
        }
        public override string ToString()
        {
            return "Table: \n"+table.ToString();
        }
    }
}
