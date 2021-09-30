using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Alg
{
    static class Counting_Sort
    {
        static void Individual(ref int[] arr)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 3 != 0)
                {
                    temp.Add(arr[i]*arr[i]);
                }
                
            }
            arr = temp.ToArray();
        }

        static public void CountSort(int[] arr, System.Windows.Forms.RichTextBox textBox, System.Windows.Forms.TextBox result, System.Windows.Forms.TextBox Indiv)
        {
            Individual(ref arr);
            int k = arr.Max();
            int[] count = new int[k + 1];
            Indiv.Text = string.Join(" ",arr);
            for (int i = 0; i < arr.Length; i++)
            {
                count[arr[i]]++;
            }

            int index = arr.Length-1;
            for (int i = 0; i < count.Length; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    arr[index] = i;
                    index--;
                }
                textBox.AppendText(string.Join(" ",arr)+"\n\n");
            }
            result.Text = string.Join(" ",arr);
        }

    }
}
