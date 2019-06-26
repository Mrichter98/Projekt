namespace Projekt
{
    partial class DodajWpływ
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Income = new System.Windows.Forms.TextBox();
            this.Description2 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IncomeFrome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IncomeData = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Przychód";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opis";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Income
            // 
            this.Income.Location = new System.Drawing.Point(88, 43);
            this.Income.Name = "Income";
            this.Income.Size = new System.Drawing.Size(268, 26);
            this.Income.TabIndex = 3;
            // 
            // Description2
            // 
            this.Description2.Location = new System.Drawing.Point(88, 107);
            this.Description2.Name = "Description2";
            this.Description2.Size = new System.Drawing.Size(268, 76);
            this.Description2.TabIndex = 4;
            this.Description2.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Od";
            // 
            // IncomeFrome
            // 
            this.IncomeFrome.Location = new System.Drawing.Point(88, 10);
            this.IncomeFrome.Name = "IncomeFrome";
            this.IncomeFrome.Size = new System.Drawing.Size(268, 26);
            this.IncomeFrome.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data";
            // 
            // IncomeData
            // 
            this.IncomeData.Location = new System.Drawing.Point(89, 75);
            this.IncomeData.Name = "IncomeData";
            this.IncomeData.Size = new System.Drawing.Size(267, 26);
            this.IncomeData.TabIndex = 8;
            // 
            // DodajWpływ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 255);
            this.Controls.Add(this.IncomeData);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IncomeFrome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Description2);
            this.Controls.Add(this.Income);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajWpływ";
            this.Text = "Dodaj przychód";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Income;
        private System.Windows.Forms.RichTextBox Description2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IncomeFrome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker IncomeData;
    }
}