namespace ErrorProviderSample
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
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgeTextBox
            // 
            this.AgeTextBox.Location = new System.Drawing.Point(110, 42);
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.Size = new System.Drawing.Size(125, 27);
            this.AgeTextBox.TabIndex = 0;
            this.AgeTextBox.TextChanged += new System.EventHandler(this.AgeTextBox_TextChanged);
            this.AgeTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AgeTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Age";
            // 
            // CheckButton
            // 
            this.CheckButton.Location = new System.Drawing.Point(257, 42);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(94, 29);
            this.CheckButton.TabIndex = 2;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = true;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox AgeTextBox;
        private Label label1;
        private Button CheckButton;
    }
}