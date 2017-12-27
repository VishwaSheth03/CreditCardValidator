namespace WindowsFormsApplication3
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
            this.checkButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.creditCardNumInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.creditCardNumInput)).BeginInit();
            this.SuspendLayout();
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(61, 40);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(162, 77);
            this.checkButton.TabIndex = 0;
            this.checkButton.Text = "Check validity";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter credit card number";
            // 
            // creditCardNumInput
            // 
            this.creditCardNumInput.Location = new System.Drawing.Point(84, 12);
            this.creditCardNumInput.Maximum = new decimal(new int[] {
            -1304428545,
            434162106,
            542,
            0});
            this.creditCardNumInput.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.creditCardNumInput.Name = "creditCardNumInput";
            this.creditCardNumInput.Size = new System.Drawing.Size(120, 22);
            this.creditCardNumInput.TabIndex = 3;
            this.creditCardNumInput.Value = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(295, 176);
            this.Controls.Add(this.creditCardNumInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkButton);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.creditCardNumInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown creditCardNumInput;
    }
}

