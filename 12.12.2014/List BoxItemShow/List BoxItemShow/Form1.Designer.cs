namespace List_BoxItemShow
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
            this.nameListText = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numInputText = new System.Windows.Forms.TextBox();
            this.addButtonClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameListText
            // 
            this.nameListText.FormattingEnabled = true;
            this.nameListText.Location = new System.Drawing.Point(12, 120);
            this.nameListText.Name = "nameListText";
            this.nameListText.Size = new System.Drawing.Size(246, 95);
            this.nameListText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number";
            // 
            // numInputText
            // 
            this.numInputText.Location = new System.Drawing.Point(62, 22);
            this.numInputText.Name = "numInputText";
            this.numInputText.Size = new System.Drawing.Size(100, 20);
            this.numInputText.TabIndex = 2;
            // 
            // addButtonClick
            // 
            this.addButtonClick.Location = new System.Drawing.Point(197, 20);
            this.addButtonClick.Name = "addButtonClick";
            this.addButtonClick.Size = new System.Drawing.Size(75, 23);
            this.addButtonClick.TabIndex = 3;
            this.addButtonClick.Text = "Add";
            this.addButtonClick.UseVisualStyleBackColor = true;
            this.addButtonClick.Click += new System.EventHandler(this.addButtonClick_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.addButtonClick);
            this.Controls.Add(this.numInputText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameListText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameListText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numInputText;
        private System.Windows.Forms.Button addButtonClick;
    }
}

