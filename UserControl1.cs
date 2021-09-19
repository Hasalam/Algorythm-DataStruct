﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_Alg
{
    delegate int fuction(int a, int b);
    delegate bool condition(int a);
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Result.Clear();
            Steps.Clear();
            Individual.Clear();
            string[] subs = EnterData.Text.Split(',');
            switch (comboBox1.SelectedIndex)
                
            {
                case 0:
                    
                    int[] dataArr = new int[subs.Length];
                    for (int i = 0; i < subs.Length; i++)
                    {
                        dataArr[i] = int.Parse(subs[i]);
                    }

                    Bubble_method bubble = new Bubble_method(dataArr);
                    bubble.Individual((a, b) => a * b, a => a % 3 != 0);
                    Individual.Text = string.Join(" ", bubble.Prop);
                    bubble.BSort(Steps, Result);
                 break;
                case 1:
                    subs = EnterData.Text.Split(',');
                    InsertMethod Insert = new InsertMethod(subs.ToList());
                    Insert.InsertSort(Steps, Result);
                    break;
                case 2:
                    button2_Click(sender,e);
                    break;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int m = int.Parse(n.Text);
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    for (int i = 0; i < m - 1; i++)
                    {
                        EnterData.AppendText(rand.Next(50).ToString());
                        EnterData.AppendText(",");
                    }
                    EnterData.AppendText(rand.Next(50).ToString());
                    break;
                case 2:
                    int[,] data = new int[m, m];
                    for (int i = 0; i < m; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            data[i, j] = rand.Next(100);
                        }
                    }
                    Shell_Method.ShellSort(data,Steps);
                        break;
            }
        }
    }
}
