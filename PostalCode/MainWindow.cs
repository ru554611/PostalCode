using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PostalCode
{
    public partial class PostalCode : Form
    {
        public PostalCode()
        {
            InitializeComponent();
            code.ReadOnly = true;
            keyboard.LinkedControl = code;
        }

        private void code_Enter(object sender, EventArgs e)
        {
            char[] c = { 'D', 'F', 'Q', 'U', 'W', 'Z', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            int codeLength = code.Text.Length;
            if (codeLength == 0)
            {
                foreach (var item in c)
                {
                    if (keyboard.Controls.ContainsKey(item.ToString()))
                    {
                        Button btn = (Button)keyboard.Controls[item.ToString()];
                        btn.Enabled = false;
                    }
                }
            }

        }
    }
}
