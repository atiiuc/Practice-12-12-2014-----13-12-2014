using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameDatabaseApps
{
    public partial class Form1 : Form
    {
         
            ArrayList mList = new ArrayList();
      //  int count;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
       
        private void SaveButton_Click(object sender, EventArgs e)
        {

            String name = nameInputText.Text;
            nameInputText.Text = string.Empty;
            
           int  count = Convert.ToInt32(countText.Text);
            if (count <10)
            {
                mList.Add(name);
                count++;
                countText.Text = count.ToString();
            }
            

            else
            {
                
                MessageBox.Show("sorry,you are not permitted to add more...");
               
            }
            if (count == 10)
            {
                int i;

                nameList.Items.Clear();

                foreach (Object obj in mList)
                {

                    nameList.Items.Add(obj + "\n");
                } 
            }

        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
           /* int i;

            nameList.Items.Clear();

            foreach (Object obj in mList)
            {
              
                nameList.Items.Add(obj + "\n");
            }*/

        }
    }
}
