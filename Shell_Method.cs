using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Alg
{
    class Shell_Method
    {
        static void Swap(ref int[,] arr, int index1, int index2)
        {
            int temp;
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                temp = arr[index1, i];
                arr[index1, i] = arr[index2, i];
                arr[index2, i] = temp;
            }
        }

        static void ModifiedSort(ref int[,] arr, int[] sum, int[] pos)
        {
            int temp;
            for (int i = sum.Length-1; i >=0 ; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (sum[j] > sum[j + 1])
                    {
                        temp = sum[j];
                        sum[j] = sum[j + 1];
                        sum[j + 1] = temp;

                        Swap(ref arr,pos[j],pos[j+1]);
                    }
                }
            }
        
        }

        static void print_Matrix(int[,] arr, System.Windows.Forms.RichTextBox textBox)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    textBox.Text += arr[i, j].ToString() + " ";
                }
                textBox.Text += "\n\n";
            }
            textBox.Text += "\n\n\n\n";
        }

       public static void ShellSort(int[,] arr, System.Windows.Forms.RichTextBox textBox)
        {
            int d = arr.GetLength(0)/2;
            int iter = 1;
            int sum;
            List<int> sumarr=new List<int>();
            List<int> pos=new List<int>();
            while (d >= 1)
            {
                textBox.Text += "This is iteration№"+iter.ToString()+" d="+d.ToString()+"\n\n";
                for (int j = 0; j + d <= arr.GetLength(0); j++)
                {
                    
                    for (int i = j; i < arr.GetLength(0); i += d)
                    {
                        sum = 0;
                        for (int k = 0; k < arr.GetLength(1); k++)
                        {
                            sum += arr[i, k];
                        }
                        sumarr.Add(sum);
                        pos.Add(i);
                    }
                    ModifiedSort(ref arr,sumarr.ToArray(),pos.ToArray());
                    print_Matrix(arr,textBox);
                    sumarr.Clear();
                    pos.Clear();
                }
                iter++;
                d /= 2;
            }
            textBox.Text += "Result:\n";
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                sum = 0;
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    textBox.Text += arr[i, k].ToString()+" ";
                    sum += arr[i, k];
                }
                textBox.Text += sum.ToString() + "\n\n";
            }

        }
    }
}
