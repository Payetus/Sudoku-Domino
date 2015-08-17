using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {

        static void Main(string[] args)
        {
            Sudoku sudoku = new Sudoku();
            Table table = new Table();
            string line;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int intTemp = Convert.ToInt32(Console.ReadLine());
                    table.addSlot(i, j, intTemp);
                   
                }
            }
            
            while ((line = Console.ReadLine()) != "Exit")
            {
                Console.Write(sudoku.ToString());
            }
        }
    }
}
