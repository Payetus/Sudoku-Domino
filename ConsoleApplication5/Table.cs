using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Table
    {
        
        
        private const int length = 9;
        private int[,] array = new int[length, length];

        public Table()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    array[i, j] = 0;
                }
            }
        }
        private Spot GetFirstavialableSpot(int value)
        {
            Spot spot;
            //Checking North
            for (int i = 0; i < 9; i++)
            {
                if (array[i, 0] == 0) 
                {
                    for (int j = 1; j < 9; j++)
                    {
                        if (array[i, j] != 0)
                        {
                            if (IsCorrect(i, j, value))
                            {
                                return new Spot(i, j);
                            }
                        }
                    }
                }                
            }
            
            return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="value"></param>
        private bool IsCorrect(int row, int column, int value)
        {
            return (CheckQuadrant(row, column, value) && CheckRow(row, value) && CheckColumn(column, value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CheckRow(int row, int value)
        {
            for (int j = 0; j < length; j++)
            {
                if (array[row,j]==value)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="column"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CheckColumn(int column, int value)
        {
            for (int i = 0; i < length; i++)
            {
                if (array[i, column]==value)
                    return false;
            }
            return true;
        }


        private bool CheckQuadrant(int column, int row, int value)
        {
            //GoFoward
            int i = row;
            int j = column;
            do
            {
                do
                {
                    if (array[i,j] == value)
	                {
                        return false;
	                }
                    j++;	            
                } while (j%3 != 0);
                i++;
            } while (i%3 !=0);
            //Go backwards
            do
            {
                do
                {
                    if (array[i,j] == value)
	                {
                        return false;
	                }
                    j--;	            
                } while (j%3 != 0);
                i--;
            } while (i%3 !=0); 
            return true;
        }
        public override string ToString()
        {
            string str = " |                       | \n";
            for (int i = 0; i < length; i++)
			{
                if (i%3 == 0)
                {
                    str = str + "-+-----------------------+-\n";                    
                }
                for (int j = 0; j < length; j++)
			    {
                    if (j % 3 == 0)
                    {
                        str = str + " |";
                    }
                    str = str + " " + array[i,j];
			    }
                str = str +" |\n";
                
			}
            str = str + "-+-----------------------+-\n";
            str = str + " |                       | \n";
            return str;
        }

        internal void addSlot(int i, int j, int intTemp)
        {
            array[i, j] = intTemp;
        }
    }
}
