namespace Projekt
{
    partial class UsuńElement
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
            this.IndexBox = new System.Windows.Forms.TextBox();
            this.grid2 = new System.Windows.Forms.DataGridView();
            this.btnRfrsh = new System.Windows.Forms.Button();
            this.btnDlt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indeks(ID):";
            // 
            // IndexBox
            // 
            this.IndexBox.Location = new System.Drawing.Point(515, 20);
            this.IndexBox.Name = "IndexBox";
            this.IndexBox.Size = new System.Drawing.Size(115, 26);
            this.IndexBox.TabIndex = 1;
            // 
            // grid2
            // 
            this.grid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid2.Location = new System.Drawing.Point(-5, 61);
            this.grid2.Name = "grid2";
            this.grid2.RowHeadersWidth = 62;
            this.grid2.RowTemplate.Height = 28;
            this.grid2.Size = new System.Drawing.Size(1158, 130);
            this.grid2.TabIndex = 2;
            // 
            // btnRfrsh
            // 
            this.btnRfrsh.Location = new System.Drawing.Point(636, 12);
            this.btnRfrsh.Name = "btnRfrsh";
            this.btnRfrsh.Size = new System.Drawing.Size(110, 42);
            this.btnRfrsh.TabIndex = 3;
            this.btnRfrsh.Text = "Odśwież";
            this.btnRfrsh.UseVisualStyleBackColor = true;
            this.btnRfrsh.Click += new System.EventHandler(this.btnRfrsh_Click);
            // 
            // btnDlt
            // 
            this.btnDlt.Location = new System.Drawing.Point(457, 207);
            this.btnDlt.Name = "btnDlt";
            this.btnDlt.Size = new System.Drawing.Size(232, 47);
            this.btnDlt.TabIndex = 4;
            this.btnDlt.Text = "Usuń";
            this.btnDlt.UseVisualStyleBackColor = true;
            this.btnDlt.Click += new System.EventHandler(this.DltButton_Click);
            // 
            // UsuńElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 274);
            this.Controls.Add(this.btnDlt);
            this.Controls.Add(this.btnRfrsh);
            this.Controls.Add(this.grid2);
            this.Controls.Add(this.IndexBox);
            this.Controls.Add(this.label1);
            this.Name = "UsuńElement";
            this.Text = "UsuńElement";
            ((System.ComponentModel.ISupportInitialize)(this.grid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IndexBox;
        private System.Windows.Forms.DataGridView grid2;
        private System.Windows.Forms.Button btnRfrsh;
        private System.Windows.Forms.Button btnDlt;
    }
}