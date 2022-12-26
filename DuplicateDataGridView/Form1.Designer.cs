namespace DuplicateDataGridView
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column2A = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2B = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2C = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1A,
            this.Column1B,
            this.Column1C});
            this.dataGridView1.Location = new System.Drawing.Point(48, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(300, 188);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            // 
            // Column1A
            // 
            this.Column1A.HeaderText = "Column1A";
            this.Column1A.MinimumWidth = 6;
            this.Column1A.Name = "Column1A";
            this.Column1A.Width = 125;
            // 
            // Column1B
            // 
            this.Column1B.HeaderText = "Column1B";
            this.Column1B.MinimumWidth = 6;
            this.Column1B.Name = "Column1B";
            this.Column1B.Width = 125;
            // 
            // Column1C
            // 
            this.Column1C.HeaderText = "Column1C";
            this.Column1C.MinimumWidth = 6;
            this.Column1C.Name = "Column1C";
            this.Column1C.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2A,
            this.Column2B,
            this.Column2C});
            this.dataGridView2.Location = new System.Drawing.Point(385, 92);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(300, 188);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView2_Scroll);
            // 
            // Column2A
            // 
            this.Column2A.HeaderText = "Column2A";
            this.Column2A.MinimumWidth = 6;
            this.Column2A.Name = "Column2A";
            this.Column2A.Width = 125;
            // 
            // Column2B
            // 
            this.Column2B.HeaderText = "Column2B";
            this.Column2B.MinimumWidth = 6;
            this.Column2B.Name = "Column2B";
            this.Column2B.Width = 125;
            // 
            // Column2C
            // 
            this.Column2C.HeaderText = "Column2C";
            this.Column2C.MinimumWidth = 6;
            this.Column2C.Name = "Column2C";
            this.Column2C.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1A;
        private DataGridViewTextBoxColumn Column1B;
        private DataGridViewTextBoxColumn Column1C;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn Column2A;
        private DataGridViewTextBoxColumn Column2B;
        private DataGridViewTextBoxColumn Column2C;
    }
}