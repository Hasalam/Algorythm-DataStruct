using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Alg
{

    class Bubble_method
    {
        private int[] data;
        public int[] Prop
        {
            get { return data; }
        
        }
       public Bubble_method(int[] data)
        {
            this.data = data;
        }


        public void Individual(fuction func, condition cond)
        {
            List<int> enddata = new List<int>();
            foreach (int a in data)
            {
                if (cond(a))
                {
                    enddata.Add(a);
                }
            }
            data = enddata.ToArray();
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = func(data[i], data[i]);
            }
           
        }

        public void BSort(System.Windows.Forms.RichTextBox textBox , System.Windows.Forms.TextBox result) {
            bool flag;
            int a;
            do
            {
                flag = false;
                for (int j =data.Length - 2; j >= 0; j--)
                {
                    if (data[j] < data[j + 1])
                    {
                        a = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = a;
                        flag = true;
                        textBox.AppendText(string.Join(" ",data));
                        textBox.AppendText("\n\n");
                    }
                }
                
            }
            while (flag);
            for (int i = 0; i < data.Length - 1; i++)
            {
                if (data[i] < data[i + 1])
                {
                    textBox.AppendText("Відсортовано неправильно!");
                    return;
                }
            }
            textBox.AppendText("Відсортовано правильно!");
            result.AppendText(string.Join(" ", data));

        }
    }
}
