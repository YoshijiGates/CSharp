namespace WinFormMVVM.Views
{
    partial class MainView
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
            this.AAALabel = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.BBBTextBox = new System.Windows.Forms.TextBox();
            this.CCCDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // AAALabel
            // 
            this.AAALabel.AutoSize = true;
            this.AAALabel.Location = new System.Drawing.Point(33, 36);
            this.AAALabel.Name = "AAALabel";
            this.AAALabel.Size = new System.Drawing.Size(35, 12);
            this.AAALabel.TabIndex = 0;
            this.AAALabel.Text = "label1";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(127, 36);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 1;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // BBBTextBox
            // 
            this.BBBTextBox.Location = new System.Drawing.Point(35, 82);
            this.BBBTextBox.Name = "BBBTextBox";
            this.BBBTextBox.Size = new System.Drawing.Size(100, 19);
            this.BBBTextBox.TabIndex = 2;
            // 
            // CCCDateTimePicker
            // 
            this.CCCDateTimePicker.Location = new System.Drawing.Point(35, 130);
            this.CCCDateTimePicker.Name = "CCCDateTimePicker";
            this.CCCDateTimePicker.Size = new System.Drawing.Size(200, 19);
            this.CCCDateTimePicker.TabIndex = 3;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CCCDateTimePicker);
            this.Controls.Add(this.BBBTextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.AAALabel);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AAALabel;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.TextBox BBBTextBox;
        private System.Windows.Forms.DateTimePicker CCCDateTimePicker;
    }
}