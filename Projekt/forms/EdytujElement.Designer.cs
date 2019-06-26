namespace Projekt
{
    partial class EdytujElement
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
            this.btnRfrsh2 = new System.Windows.Forms.Button();
            this.grid3 = new System.Windows.Forms.DataGridView();
            this.IndexBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BuyDateEdit = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceEdit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionEdit = new System.Windows.Forms.RichTextBox();
            this.CategoryEdit = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.GwarancyOffDateEdit = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.MarketPlaceEdit = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRfrsh2
            // 
            this.btnRfrsh2.Location = new System.Drawing.Point(640, 1);
            this.btnRfrsh2.Name = "btnRfrsh2";
            this.btnRfrsh2.Size = new System.Drawing.Size(110, 42);
            this.btnRfrsh2.TabIndex = 7;
            this.btnRfrsh2.Text = "Odśwież";
            this.btnRfrsh2.UseVisualStyleBackColor = true;
            this.btnRfrsh2.Click += new System.EventHandler(this.BtnRfrsh2_Click);
            // 
            // grid3
            // 
            this.grid3.AllowUserToAddRows = false;
            this.grid3.AllowUserToDeleteRows = false;
            this.grid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid3.Location = new System.Drawing.Point(-1, 50);
            this.grid3.Name = "grid3";
            this.grid3.ReadOnly = true;
            this.grid3.RowHeadersWidth = 62;
            this.grid3.RowTemplate.Height = 28;
            this.grid3.Size = new System.Drawing.Size(1158, 130);
            this.grid3.TabIndex = 6;
            this.grid3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid3_CellClick);
            // 
            // IndexBox2
            // 
            this.IndexBox2.Location = new System.Drawing.Point(519, 9);
            this.IndexBox2.Name = "IndexBox2";
            this.IndexBox2.Size = new System.Drawing.Size(115, 26);
            this.IndexBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(418, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Indeks(ID):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nowe dane: ";
            // 
            // BuyDateEdit
            // 
            this.BuyDateEdit.Location = new System.Drawing.Point(664, 242);
            this.BuyDateEdit.Name = "BuyDateEdit";
            this.BuyDateEdit.Size = new System.Drawing.Size(209, 26);
            this.BuyDateEdit.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(714, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Buy Date";
            // 
            // PriceEdit
            // 
            this.PriceEdit.Location = new System.Drawing.Point(115, 242);
            this.PriceEdit.Name = "PriceEdit";
            this.PriceEdit.Size = new System.Drawing.Size(122, 26);
            this.PriceEdit.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // DescriptionEdit
            // 
            this.DescriptionEdit.Location = new System.Drawing.Point(115, 290);
            this.DescriptionEdit.Name = "DescriptionEdit";
            this.DescriptionEdit.Size = new System.Drawing.Size(973, 77);
            this.DescriptionEdit.TabIndex = 13;
            this.DescriptionEdit.Text = "";
            // 
            // CategoryEdit
            // 
            this.CategoryEdit.Location = new System.Drawing.Point(243, 242);
            this.CategoryEdit.Name = "CategoryEdit";
            this.CategoryEdit.Size = new System.Drawing.Size(145, 26);
            this.CategoryEdit.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(974, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Edytuj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(913, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gwarancy Off Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Category";
            // 
            // GwarancyOffDateEdit
            // 
            this.GwarancyOffDateEdit.Location = new System.Drawing.Point(879, 242);
            this.GwarancyOffDateEdit.Name = "GwarancyOffDateEdit";
            this.GwarancyOffDateEdit.Size = new System.Drawing.Size(209, 26);
            this.GwarancyOffDateEdit.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Description";
            // 
            // MarketPlaceEdit
            // 
            this.MarketPlaceEdit.Location = new System.Drawing.Point(398, 242);
            this.MarketPlaceEdit.Name = "MarketPlaceEdit";
            this.MarketPlaceEdit.Size = new System.Drawing.Size(254, 26);
            this.MarketPlaceEdit.TabIndex = 21;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(479, 212);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(97, 20);
            this.lbl.TabIndex = 20;
            this.lbl.Text = "MarketPlace";
            // 
            // EdytujElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 450);
            this.Controls.Add(this.MarketPlaceEdit);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.GwarancyOffDateEdit);
            this.Controls.Add(this.BuyDateEdit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PriceEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescriptionEdit);
            this.Controls.Add(this.CategoryEdit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRfrsh2);
            this.Controls.Add(this.grid3);
            this.Controls.Add(this.IndexBox2);
            this.Controls.Add(this.label1);
            this.Name = "EdytujElement";
            this.Text = "EdytujElement";
            ((System.ComponentModel.ISupportInitialize)(this.grid3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRfrsh2;
        private System.Windows.Forms.DataGridView grid3;
        private System.Windows.Forms.TextBox IndexBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker BuyDateEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceEdit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox DescriptionEdit;
        private System.Windows.Forms.TextBox CategoryEdit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker GwarancyOffDateEdit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MarketPlaceEdit;
        private System.Windows.Forms.Label lbl;
    }
}