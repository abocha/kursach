using System;
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
                this.output.Text = FindSubstring(pattern, text).ToString();
                }
        }

        string pattern, text;
        //int result = FindSubstring(pattern, text);

        static int[] GetPrefix(string s)
        {
            int[] result = new int[s.Length];
            result[0] = 0;
            int index = 0;

            for (int i = 1; i < s.Length; i++)
            {
                while (index >= 0 && s[index] != s[i]) { index--; }
                index++;
                result[i] = index;
            }

            return result;
        }

        static int FindSubstring(string pattern, string text)
        {
            int res = -1;
            int[] pf = GetPrefix(pattern);
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                while (index > 0 && pattern[index] != text[i]) { index = pf[index - 1]; }
                if (pattern[index] == text[i]) index++;
                if (index == pattern.Length)
                {
                    return res = i - index + 1;
                }
            }

            return res;
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
