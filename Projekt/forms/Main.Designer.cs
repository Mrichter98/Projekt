namespace Projekt
{
    partial class Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.finanseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajWydatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajWpływToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.AllPrice = new System.Windows.Forms.Label();
            this.AllIncome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grid4 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.finanseToolStripMenuItem,
            this.edytujToolStripMenuItem,
            this.autorToolStripMenuItem,
            this.historiaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(489, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // finanseToolStripMenuItem
            // 
            this.finanseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajWydatkiToolStripMenuItem,
            this.dodajWpływToolStripMenuItem});
            this.finanseToolStripMenuItem.Name = "finanseToolStripMenuItem";
            this.finanseToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.finanseToolStripMenuItem.Text = "Finanse";
            // 
            // dodajWydatkiToolStripMenuItem
            // 
            this.dodajWydatkiToolStripMenuItem.Name = "dodajWydatkiToolStripMenuItem";
            this.dodajWydatkiToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dodajWydatkiToolStripMenuItem.Text = "Dodaj wydatki";
            this.dodajWydatkiToolStripMenuItem.Click += new System.EventHandler(this.DodajWydatkiToolStripMenuItem_Click);
            // 
            // dodajWpływToolStripMenuItem
            // 
            this.dodajWpływToolStripMenuItem.Name = "dodajWpływToolStripMenuItem";
            this.dodajWpływToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.dodajWpływToolStripMenuItem.Text = "Dodaj wpływ ";
            this.dodajWpływToolStripMenuItem.Click += new System.EventHandler(this.DodajWpływToolStripMenuItem_Click);
            // 
            // edytujToolStripMenuItem
            // 
            this.edytujToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuńElementToolStripMenuItem,
            this.edytujElementToolStripMenuItem});
            this.edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            this.edytujToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.edytujToolStripMenuItem.Text = "Edytuj";
            // 
            // usuńElementToolStripMenuItem
            // 
            this.usuńElementToolStripMenuItem.Name = "usuńElementToolStripMenuItem";
            this.usuńElementToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.usuńElementToolStripMenuItem.Text = "Usuń element";
            this.usuńElementToolStripMenuItem.Click += new System.EventHandler(this.UsuńElementToolStripMenuItem_Click);
            // 
            // edytujElementToolStripMenuItem
            // 
            this.edytujElementToolStripMenuItem.Name = "edytujElementToolStripMenuItem";
            this.edytujElementToolStripMenuItem.Size = new System.Drawing.Size(231, 34);
            this.edytujElementToolStripMenuItem.Text = "Edytuj element";
            this.edytujElementToolStripMenuItem.Click += new System.EventHandler(this.EdytujElementToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.autorToolStripMenuItem.Text = "Autor..";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.AutorToolStripMenuItem_Click);
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.historiaToolStripMenuItem.Text = "Historia";
            this.historiaToolStripMenuItem.Click += new System.EventHandler(this.HistoriaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Suma wydatków";
            // 
            // AllPrice
            // 
            this.AllPrice.AutoSize = true;
            this.AllPrice.Location = new System.Drawing.Point(164, 55);
            this.AllPrice.Name = "AllPrice";
            this.AllPrice.Size = new System.Drawing.Size(35, 20);
            this.AllPrice.TabIndex = 2;
            this.AllPrice.Text = "\'     \'";
            // 
            // AllIncome
            // 
            this.AllIncome.AutoSize = true;
            this.AllIncome.Location = new System.Drawing.Point(164, 89);
            this.AllIncome.Name = "AllIncome";
            this.AllIncome.Size = new System.Drawing.Size(35, 20);
            this.AllIncome.TabIndex = 3;
            this.AllIncome.Text = "\'     \'";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Suma przychodów";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(164, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "\'     \'";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Bilans";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Suma wpływów";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // grid4
            // 
            this.grid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid4.Location = new System.Drawing.Point(12, 36);
            this.grid4.Name = "grid4";
            this.grid4.RowHeadersWidth = 62;
            this.grid4.RowTemplate.Height = 28;
            this.grid4.Size = new System.Drawing.Size(272, 129);
            this.grid4.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(187, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "Suma wydatków";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(290, 127);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(187, 38);
            this.button3.TabIndex = 10;
            this.button3.Text = "Bilans";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 177);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grid4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AllIncome);
            this.Controls.Add(this.AllPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Bilans Wydatków";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem finanseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajWydatkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajWpływToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuńElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edytujElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label AllPrice;
        private System.Windows.Forms.Label AllIncome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView grid4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

