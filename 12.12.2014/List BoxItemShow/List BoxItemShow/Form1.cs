using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_BoxItemShow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButtonClick_Click(object sender, EventArgs e)
        {
            int i;
          
            int numInput = Convert.ToInt32(numInputText.Text);
            nameListText.Items.Clear();
            String numText;
            for (i=1;i<=numInput;i++)
            {
                numText = Convert.ToString(i);
                nameListText.Items.Add(numText+"\n");
            }
        }
    }
}
