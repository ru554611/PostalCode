using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostalCode
{
    public partial class Keyboard : UserControl
    {
        // Current postal code
        string pCode;

        // code.Text
        public TextBoxBase LinkedControl { get; set; }

        public Button btn2 = new Button();

        // Alphabet
        public char[] numeric = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public char[] letters = { 'A', 'B', 'C', 'E', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'V', 'X', 'Y', 'D', 'F', 'Q', 'U', 'W', 'Z' };
        public char[] c = { 'D', 'F', 'Q', 'U', 'W', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public char[] firstLetter = { 'A', 'B', 'C', 'E', 'G', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'V', 'X', 'Y'};

        public Keyboard()
        {
            InitializeComponent();
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            // Pressed button
            Button btn = sender as Button;
            // Length 
            int codeLength = LinkedControl.Text.Length + 1;

            ActivateKeyboard(codeLength);

            if (codeLength == 6)
            {
                pCode = pCode + btn.Name;
                CheckLength();
            }
            else
            {
                pCode = pCode + btn.Name;
            }

            LinkedControl.Text = pCode;
        }

        protected void backSpace_Click(object sender, EventArgs e)
        {
            string text = LinkedControl.Text;
            int length =text.Length -1;
            if (length != -1)
            {
                text = text.Substring(0, text.Length - 1);
            }
            
            if ( length > 0)
            {
                ActivateKeyboard(text.Length);
            }
            else
            {
                foreach (var item in c)
                {
                    if (Controls.ContainsKey(item.ToString()))
                    {
                        Button btn = (Button)Controls[item.ToString()];
                        btn.Enabled = false;
                    }
                }
                foreach (var item in firstLetter)
                {
                    if (Controls.ContainsKey(item.ToString()))
                    {
                        Button btn = (Button)Controls[item.ToString()];
                        btn.Enabled = true;
                    }
                }
            }

            pCode = text;
            LinkedControl.Text = text;
        }

        // Activate/Deactivate
        public void ActivateKeyboard(int codeLength)
        {
            if (codeLength % 2 == 0)
            {
                foreach (var item in letters)
                {
                    if (Controls.ContainsKey(item.ToString()))
                    {
                        btn2 = (Button)Controls[item.ToString()];
                        btn2.Enabled = true;
                    }
                }

                foreach (var item in numeric)
                {
                    if (Controls.ContainsKey(item.ToString()))
                    {
                        btn2 = (Button)Controls[item.ToString()];
                        btn2.Enabled = false;
                    }
                }
            }
            else
            {
                foreach (var item in letters)
                {
                    if (Controls.ContainsKey(item.ToString()))
                    {
                        btn2 = (Button)Controls[item.ToString()];
                        btn2.Enabled = false;
                    }
                }
                foreach (var item in numeric)
                {
                    if (Controls.ContainsKey(item.ToString()))
                    {
                        btn2 = (Button)Controls[item.ToString()];
                        btn2.Enabled = true;
                    }
                }
            }
        }

        public void CheckLength()
        {
            foreach (var item in letters)
            {
                if (Controls.ContainsKey(item.ToString()))
                {
                    btn2 = (Button)Controls[item.ToString()];
                    btn2.Enabled = false;
                }
            }
            foreach (var item in numeric)
            {
                if (Controls.ContainsKey(item.ToString()))
                {
                    btn2 = (Button)Controls[item.ToString()];
                    btn2.Enabled = false;
                }
            }
        }
    }
}
