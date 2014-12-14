namespace TicketApps
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerNameText = new System.Windows.Forms.TextBox();
            this.noOfTicketText = new System.Windows.Forms.TextBox();
            this.totalPrice = new System.Windows.Forms.Button();
            this.customerName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.details = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customerNameText
            // 
            this.customerNameText.Location = new System.Drawing.Point(108, 44);
            this.customerNameText.Name = "customerNameText";
            this.customerNameText.Size = new System.Drawing.Size(100, 20);
            this.customerNameText.TabIndex = 0;
            // 
            // noOfTicketText
            // 
            this.noOfTicketText.Location = new System.Drawing.Point(108, 98);
            this.noOfTicketText.Name = "noOfTicketText";
            this.noOfTicketText.Size = new System.Drawing.Size(100, 20);
            this.noOfTicketText.TabIndex = 1;
            // 
            // totalPrice
            // 
            this.totalPrice.Location = new System.Drawing.Point(27, 200);
            this.totalPrice.Name = "totalPrice";
            this.totalPrice.Size = new System.Drawing.Size(75, 23);
            this.totalPrice.TabIndex = 2;
            this.totalPrice.Text = "Total Price";
            this.totalPrice.UseVisualStyleBackColor = true;
            this.totalPrice.Click += new System.EventHandler(this.totalPrice_Click);
            // 
            // customerName
            // 
            this.customerName.AutoSize = true;
            this.customerName.Location = new System.Drawing.Point(13, 44);
            this.customerName.Name = "customerName";
            this.customerName.Size = new System.Drawing.Size(82, 13);
            this.customerName.TabIndex = 3;
            this.customerName.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of Ticket";
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(134, 200);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(75, 23);
            this.details.TabIndex = 5;
            this.details.Text = "Details";
            this.details.UseVisualStyleBackColor = true;
            this.details.Click += new System.EventHandler(this.details_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "One Ticket 10 Taka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer Ticket Information";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.details);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerName);
            this.Controls.Add(this.totalPrice);
            this.Controls.Add(this.noOfTicketText);
            this.Controls.Add(this.customerNameText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox customerNameText;
        private System.Windows.Forms.TextBox noOfTicketText;
        private System.Windows.Forms.Button totalPrice;
        private System.Windows.Forms.Label customerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button details;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

