using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            
        }
       

        string RandFunc(string key)
        {            
            switch (key)
            {
                case "upper": return GetRandomUpper();
                case "lower": return GetRandomLower();
                case "num": return GetRandomNum();
                default: return GetRandomSymbol();
            }               
        }

        string GetPass(bool upper, bool lower, bool num, bool symbol, int length)
        {
            if (length <= 0)
            {
                MessageBox.Show("Bạn chưa nhập độ dài mật khẩu!");
                return null;
            }
            if (upper == false && lower == false && symbol == false && num == false)
            {
                MessageBox.Show("Bạn chưa chọn loại mật khẩu!");
                return null;
            }

            int typeCount = 0;
            List<KeyValuePair<string,bool>> arrList = new List<KeyValuePair<string, bool>>();
            arrList.Add(new KeyValuePair<string, bool>("upper",upper));
            arrList.Add(new KeyValuePair<string, bool>("lower", lower));
            arrList.Add(new KeyValuePair<string, bool>("num", num));
            arrList.Add(new KeyValuePair<string, bool>("symbol", symbol));

            typeCount = arrList.Count(p => p.Value == true);

            StringBuilder sb = new StringBuilder(length);

            if (typeCount == 0) return null;

            for (int i = 0; i < length; i+=typeCount)
            {
                foreach (var item in arrList)
                {
                    if(item.Value != false)
                        sb.Append(RandFunc(item.Key));
                }
            }
            return sb.ToString();
        }

        string GetRandomLower()
        {         
            var charcode = Convert.ToChar((rand.Next(1,26)) + 97);
            return charcode.ToString();
        }

        string GetRandomUpper()
        {           
            var charcode = Convert.ToChar((rand.Next(1, 26)) + 65);
            return charcode.ToString();
        }

        string GetRandomNum()
        {
            var charcode = Convert.ToChar((rand.Next(1, 10)) + 48);
            return charcode.ToString();
        }

        string GetRandomSymbol()
        {
            string symbols = "!@#$%^&*()_+{}[]-=<>/,.";
            return symbols[(rand.Next(0, symbols.Length))].ToString();          
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(numLength.Value);
            bool upper = ckbUppercase.Checked;
            bool lower = ckbLowercase.Checked;
            bool num = ckbNums.Checked;
            bool symbol = ckbSymbols.Checked;

            txtResult.Text = GetPass(upper,lower,num,symbol,length);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string text = txtResult.Text;

            if (text == null || text == "")
            {
                MessageBox.Show("Nothing to copy");
            }
            else
            {
                Clipboard.SetText(text);
                MessageBox.Show("Copied!");                
            }
        }
    }
}
