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
        
        private int getSearchType()
        {
            return genSearchType.SelectedIndex;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(FindSubstring(pattern, text).ToString());
            if (pattern.Length > 0 && text.Length > 0)
                {
                this.output.Text = FindSubstring(pattern, text).ToString();
                }
        }
        
        string pattern, text;
        private int genLengthValue;
        private int genSubstrLengthValue;

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
        
        private static Random random = new Random();
        public static string RandomString(int length, string chars)
        {            
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (genSubstrLength.Value > genLength.Value)
            {
                genError.Text = "Substring Length must be less or equal to String Length";
            }
            else
            {
                genError.Text = "";
                //string searchType = genSearchType.SelectedItem.ToString();
                string chars = "";
                switch (getSearchType())
                {
                    case 0:
                        chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                        inpPattern.Text = RandomString(genSubstrLengthValue, chars);
                        inpText.Text = RandomString(genLengthValue, chars);
                        break;
                    case 1:
                        chars = "0123456789";
                        inpPattern.Text = RandomString(genSubstrLengthValue, chars);
                        inpText.Text = RandomString(genLengthValue, chars);
                        break;
                    case 2:
                        chars = "ABC";
                        inpPattern.Text = RandomString(genSubstrLengthValue, chars);
                        inpText.Text = RandomString(genLengthValue, chars);
                        break;
                }
            }
        }

        private void genLength_ValueChanged(object sender, EventArgs e)
        {
            genLengthValue = Convert.ToInt32(genLength.Value);
        }

        private void genSubstrLength_ValueChanged(object sender, EventArgs e)
        {
            genSubstrLengthValue = Convert.ToInt32(genSubstrLength.Value);
        }

        private void inpText_TextChanged(object sender, EventArgs e)
        {
            text = inpText.Text;
        }

        private void inpPattern_TextChanged(object sender, EventArgs e)
        {
            pattern = this.inpPattern.Text;
        }
    }
}
