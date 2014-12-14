using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketApps
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void totalPrice_Click(object sender, EventArgs e)
        {
            
            String name = customerNameText.Text;
            customerNameText.Text = string.Empty;
            String ticket = noOfTicketText.Text;
            noOfTicketText.Text = string.Empty;
            int totalTicket = Convert.ToInt32(ticket);
            totalTicket = totalTicket*10;
            ticket = totalTicket.ToString();

            MessageBox.Show(name+",Please pay "+ticket+" taka.");
        }

        private void details_Click(object sender, EventArgs e)
        {

            String name = customerNameText.Text;
            customerNameText.Text = string.Empty;
            String ticket = noOfTicketText.Text;
            noOfTicketText.Text = string.Empty;
            int totalTicket = Convert.ToInt32(ticket);
            totalTicket = totalTicket * 10;
            ticket = totalTicket.ToString();
            MessageBox.Show("Customer Name:" + name + "\n Unit Price: " + noOfTicketText.Text + "\nTotal Price: "+ticket+" taka.");
        }
    }
}
