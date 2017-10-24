﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMP
{
    public partial class Form1 : Form
    {
        public string ReturnValue1 { get; set; }

        public Form1()
        {
            InitializeComponent();
            pattern = this.inpPattern.Text;
            text = this.inpText.Text;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(FindSubstring(pattern, text).ToString());
            if (pattern.Length > 0 && text.Length > 0)
                {
                this.output.Text = AG(pattern, text).ToString();
                }
        }

        string pattern, text;
        //int result = FindSubstring(pattern, text);

        private void getT(string x, int[] t)
        { //функция, вычисляющая массив t для строки x

            int i = 0;
            int j = -1;
            t[0] = j;
            while (i < x.Length-1)
            {
                while ((j > -1) && (x[i] != x[j]))
                {
                    j = t[j];
                }
            i++;
            j++;
            if (x[i] == x[j])
            {
                t[i] = t[j];
            }
            else t[i] = j;
            }
        }

        public int AG(string xx, string y)
        { //x — образец, y — текст
            int l = new int();
            int[] t = new int[xx.Length];
            int v = new int();

            //этап предпосчета
            getT(xx, t);
            //вычисление значения l 
            for (l = 1; xx[l - 1] == xx[l]; l++)
            {
                if (l == xx.Length)
                {
                    l = 0;
                }
            }
            //этап поиска
            int i = l;
            int j = 0;
            int k = 0;
            while (j <= y.Length-1 - xx.Length-1)
            {
                while ((i < xx.Length-1) && (xx[i] == y[i + j]))
                { // если x[i] = y[i + j]
                    ++i;
                }          // тогда следующая тройка (i + 1, j, k) 
                if (i >= xx.Length-1)
                {
                    while ((k < l) && (xx[k] == y[j + k]))
                    { // если k < l и x[k] = y[j + k]
                        ++k;
                    }                           // тогда следующая тройка (i, j, k + 1) 
                    if (k >= l)
                    {           // если k = l 
                        v = j;
                    }   // тогда найдена подстрока в позиции j
                }
                j += i - t[i];         // вычисляем новый сдвиг
                if (i == l)
                {
                    k = Math.Max(0, k - 1);
                } // если i = l и x[i] \neq y[i + j], тогда следующая тройка (l, j + 1, \max(0, k - 1))
                else
                   if (t[i] <= l)
                { // если t[i] \leqslant l, тогда следующая тройка (l, i + j - t[i], \max(0, t[i]))
                    k = Math.Max(0, t[i]);
                    i = l;
                }
                else
                {           // если t[i] > l, тогда следующая тройка (t[i], i + j - t[i], l)
                    k = l;
                    i = t[i];
                }
            }
            return v;
        }

        private void inpPattern_TextChanged(object sender, EventArgs e)
        {
            pattern = this.inpPattern.Text;
        }

        private void output_Click(object sender, EventArgs e)
        {

        }

        private void inpText_TextChanged(object sender, EventArgs e)
        {
            text = this.inpText.Text;
        }
    }
}
