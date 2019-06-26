namespace Projekt
{
    partial class Historia
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
            this.components = new System.ComponentModel.Container();
            this.gridReaderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbStringBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grid1 = new System.Windows.Forms.DataGridView();
            this.wydatkiModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodajWydatkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dodajWydatkiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.wydatkiModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.historiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridReaderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStringBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydatkiModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajWydatkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajWydatkiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydatkiModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridReaderBindingSource
            // 
            this.gridReaderBindingSource.DataSource = typeof(Dapper.SqlMapper.GridReader);
            // 
            // dbStringBindingSource
            // 
            this.dbStringBindingSource.DataSource = typeof(Dapper.DbString);
            // 
            // grid1
            // 
            this.grid1.AllowUserToAddRows = false;
            this.grid1.AllowUserToDeleteRows = false;
            this.grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid1.Location = new System.Drawing.Point(2, 0);
            this.grid1.Name = "grid1";
            this.grid1.ReadOnly = true;
            this.grid1.RowHeadersWidth = 62;
            this.grid1.RowTemplate.Height = 28;
            this.grid1.Size = new System.Drawing.Size(1165, 448);
            this.grid1.TabIndex = 0;
            // 
            // wydatkiModelBindingSource
            // 
            this.wydatkiModelBindingSource.DataSource = typeof(Projekt.WydatkiModel);
            // 
            // dodajWydatkiBindingSource
            // 
            this.dodajWydatkiBindingSource.DataSource = typeof(Projekt.DodajWydatki);
            // 
            // dodajWydatkiBindingSource1
            // 
            this.dodajWydatkiBindingSource1.DataSource = typeof(Projekt.DodajWydatki);
            // 
            // wydatkiModelBindingSource1
            // 
            this.wydatkiModelBindingSource1.DataSource = typeof(Projekt.WydatkiModel);
            // 
            // historiaBindingSource
            // 
            this.historiaBindingSource.DataSource = typeof(Projekt.Historia);
            // 
            // Historia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.grid1);
            this.Name = "Historia";
            this.Text = "Historia";
            this.Load += new System.EventHandler(this.Historia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReaderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbStringBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydatkiModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajWydatkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dodajWydatkiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wydatkiModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historiaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dodajWydatkiBindingSource;
        private System.Windows.Forms.BindingSource dodajWydatkiBindingSource1;
        private System.Windows.Forms.BindingSource wydatkiModelBindingSource;
        private System.Windows.Forms.BindingSource wydatkiModelBindingSource1;
        private System.Windows.Forms.BindingSource gridReaderBindingSource;
        private System.Windows.Forms.BindingSource dbStringBindingSource;
        private System.Windows.Forms.BindingSource historiaBindingSource;
        private System.Windows.Forms.DataGridView grid1;
    }
}