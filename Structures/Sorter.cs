using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class Sorter
    {
        private int[] array;

        public Sorter(int[] array) 
        {
            this.array = array;
        }

        public int[] BubleSort(bool increase = true)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool flag = false;
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (increase)
                    {
                        if (array[j] > array[j + 1])
                        {
                            Swap(j);
                            flag = true;
                        }
                    }
                    else
                    {
                        if (array[j] < array[j + 1])
                        {
                            Swap(j);
                            flag = true;
                        }
                    }
                    
                }
                if (!flag)
                    break;
            }
            return array;
        }

        public int[] SelectionSort()
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var min = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
                        min = j;
                }
                int tmp = array[i];
                array[i] = array[min];
                array[min] = tmp;
            }
            return array;
        }

        private void Swap(int index) 
        { 
            int tmp = array[index];
            array[index] = array[index +1];
            array[index +1] = tmp;    
        }

    }
}