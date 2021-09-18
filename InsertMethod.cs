using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Alg
{
    class InsertMethod
    {
        private List<string> data;

        public List<string> Prop {
            get { return data; }
        }
        public InsertMethod(List<string> dat)
        {
            data = dat;
        }

        public void InsertSort(System.Windows.Forms.RichTextBox textBox, System.Windows.Forms.TextBox result)
        {
            string min;
            string temp;
            int minpos;
            int res;
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i].Length > 8)
                {
                    data.Remove(data[i]);
                    i--;
                    continue;
                }
            }

            for (int i = 0; i < data.Count; i++)
            {
                
                minpos = i;
                min = data[i];
                for (int j = i+1; j < data.Count; j++)
                {
                    res = String.Compare(data[j], min);
                    if (res<=0)
                    {
                        min = data[j];
                        minpos = j;
                    }   
                }
                res = String.Compare(data[i], min);
                if (res>0)
                {
                    temp = data[i];
                    data[i] = min;
                    data[minpos] = temp;
                }
                res = 0;
                textBox.AppendText(string.Join(" ", data));
                textBox.AppendText("\n\n");
                

            }
            result.AppendText(string.Join(" ", data));

        }
    }
}
