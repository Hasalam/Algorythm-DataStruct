using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Alg
{
    static class MergeSort
    {
        static void Individual(ref int[] arr, System.Windows.Forms.TextBox Ind)
        {
            List<int> temp = arr.ToList();
            int max = arr[0];
            int min = arr[0];
            temp.Remove(arr.Max());
            temp.Remove(arr.Min());
            arr = temp.ToArray();
            Ind.Text = string.Join(" ",arr);
        }

        static void merge(int[] arr,int l,int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];

            int i, j;

            for (i = 0; i < n1; i++)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] >= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                k++;
                i++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                k++;
                j++;
            }
        }

        static void Main_Merge_Sort( int[] arr,int l,int r, System.Windows.Forms.RichTextBox textBox)
        {
            if (r > l)
            {
                int m = l + (r - l) / 2;
                Main_Merge_Sort(arr,l,m, textBox);
                Main_Merge_Sort(arr,m+1,r, textBox);
                merge(arr,l,m,r);
                textBox.AppendText(string.Join(" ", arr)+"\n\n");
            }
        }

        static public void UserMergeSort(int[] arr, System.Windows.Forms.RichTextBox textBox, System.Windows.Forms.TextBox result, System.Windows.Forms.TextBox Ind)
        {
            Individual(ref arr,Ind);
            Main_Merge_Sort(arr,0,arr.Length-1, textBox);
            result.Text = string.Join(" ", arr);
        }
    }
}
