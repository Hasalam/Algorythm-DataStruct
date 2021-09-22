using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Alg
{
    class QS
    {
        static void Individual(ref double[] data)
        {
            double min = data.Min();
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0)
                {
                    data[i] *= min;
                }
            }
        }

        static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }

        static int Partition(double[] arr, int minIndex, int maxIndex)
        {
            int pivot=minIndex;
            int markElem = pivot + 1;
            for (int i = pivot + 1; i <= maxIndex; i++)
            {
                if (arr[pivot] < arr[i])
                {
                    Swap(ref arr[i],ref arr[markElem]);
                    markElem++;
                }
            }
            Swap(ref arr[pivot], ref arr[markElem-1]); ;
            return markElem - 1;
        }

        static void QuickSort(ref double[] data, int minIndex, int maxIndex, System.Windows.Forms.RichTextBox textBox) {
            int pivot;
            if (minIndex < maxIndex)
            {
                pivot = Partition(data, minIndex, maxIndex);
                textBox.AppendText(string.Join(" ", data));
                textBox.AppendText("\n\n");
                QuickSort(ref data, minIndex, pivot - 1, textBox);
                QuickSort(ref data, pivot + 1, maxIndex, textBox);
            }
            
        }

        public static void QuickSort(double[] data, System.Windows.Forms.RichTextBox textBox, System.Windows.Forms.TextBox result)
        {
            Individual(ref data);
            QuickSort(ref data, 0, data.Length - 1, textBox);
            textBox.AppendText(string.Join(" ", data));
            textBox.AppendText("\n\n");
            result.Text = string.Join(" ", data);
        }
    }
}
