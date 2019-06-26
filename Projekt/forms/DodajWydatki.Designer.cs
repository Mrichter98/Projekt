namespace Projekt
{
    partial class DodajWydatki
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MarketDateText = new System.Windows.Forms.DateTimePicker();
            this.MarketPlaceText = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fees = new System.Windows.Forms.RadioButton();
            this.cloathing = new System.Windows.Forms.RadioButton();
            this.meal = new System.Windows.Forms.RadioButton();
            this.other = new System.Windows.Forms.RadioButton();
            this.GwarancyDateText = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kwota";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Miejsce zakupu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data zakupu";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 192);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 24);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Gwarancja";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Opis";
            // 
            // MarketDateText
            // 
            this.MarketDateText.Location = new System.Drawing.Point(135, 160);
            this.MarketDateText.Name = "MarketDateText";
            this.MarketDateText.Size = new System.Drawing.Size(221, 26);
            this.MarketDateText.TabIndex = 7;
            // 
            // MarketPlaceText
            // 
            this.MarketPlaceText.Location = new System.Drawing.Point(135, 128);
            this.MarketPlaceText.Name = "MarketPlaceText";
            this.MarketPlaceText.Size = new System.Drawing.Size(221, 26);
            this.MarketPlaceText.TabIndex = 8;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(135, 25);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(221, 26);
            this.PriceBox.TabIndex = 10;
            this.PriceBox.Text = "-";
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(76, 232);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(280, 83);
            this.DescriptionText.TabIndex = 11;
            this.DescriptionText.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 45);
            this.button1.TabIndex = 12;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // fees
            // 
            this.fees.AutoSize = true;
            this.fees.Location = new System.Drawing.Point(135, 60);
            this.fees.Name = "fees";
            this.fees.Size = new System.Drawing.Size(80, 24);
            this.fees.TabIndex = 13;
            this.fees.TabStop = true;
            this.fees.Text = "Opłaty";
            this.fees.UseVisualStyleBackColor = true;
            // 
            // cloathing
            // 
            this.cloathing.AutoSize = true;
            this.cloathing.Location = new System.Drawing.Point(135, 89);
            this.cloathing.Name = "cloathing";
            this.cloathing.Size = new System.Drawing.Size(90, 24);
            this.cloathing.TabIndex = 14;
            this.cloathing.TabStop = true;
            this.cloathing.Text = "Ubrania";
            this.cloathing.UseVisualStyleBackColor = true;
            // 
            // meal
            // 
            this.meal.AutoSize = true;
            this.meal.Location = new System.Drawing.Point(254, 60);
            this.meal.Name = "meal";
            this.meal.Size = new System.Drawing.Size(98, 24);
            this.meal.TabIndex = 15;
            this.meal.TabStop = true;
            this.meal.Text = "Jedzenie";
            this.meal.UseVisualStyleBackColor = true;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Location = new System.Drawing.Point(254, 89);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(66, 24);
            this.other.TabIndex = 16;
            this.other.TabStop = true;
            this.other.Text = "Inne";
            this.other.UseVisualStyleBackColor = true;
            // 
            // GwarancyDateText
            // 
            this.GwarancyDateText.Enabled = false;
            this.GwarancyDateText.Location = new System.Drawing.Point(135, 192);
            this.GwarancyDateText.Name = "GwarancyDateText";
            this.GwarancyDateText.Size = new System.Drawing.Size(221, 26);
            this.GwarancyDateText.TabIndex = 17;
            // 
            // DodajWydatki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 395);
            this.Controls.Add(this.GwarancyDateText);
            this.Controls.Add(this.other);
            this.Controls.Add(this.meal);
            this.Controls.Add(this.cloathing);
            this.Controls.Add(this.fees);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.MarketPlaceText);
            this.Controls.Add(this.MarketDateText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DodajWydatki";
            this.Text = "Dodaj wydatki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker MarketDateText;
        private System.Windows.Forms.TextBox MarketPlaceText;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton fees;
        private System.Windows.Forms.RadioButton cloathing;
        private System.Windows.Forms.RadioButton meal;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.DateTimePicker GwarancyDateText;
    }
}