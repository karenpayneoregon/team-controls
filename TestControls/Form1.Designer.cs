
namespace TestControls
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.integerTextBox1 = new TeamControls.IntegerTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxUpDown1 = new TeamControls.TextBoxUpDown();
            this.IncrementButton = new System.Windows.Forms.Button();
            this.DecrementButton = new System.Windows.Forms.Button();
            this.ValueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(160, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(281, 41);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            // 
            // integerTextBox1
            // 
            this.integerTextBox1.Id = 0;
            this.integerTextBox1.Location = new System.Drawing.Point(42, 84);
            this.integerTextBox1.Name = "integerTextBox1";
            this.integerTextBox1.Size = new System.Drawing.Size(100, 23);
            this.integerTextBox1.Stash = null;
            this.integerTextBox1.TabIndex = 3;
            this.integerTextBox1.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(160, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUpDown1
            // 
            this.textBoxUpDown1.Location = new System.Drawing.Point(47, 161);
            this.textBoxUpDown1.Name = "textBoxUpDown1";
            this.textBoxUpDown1.Size = new System.Drawing.Size(100, 23);
            this.textBoxUpDown1.TabIndex = 5;
            this.textBoxUpDown1.Text = "0";
            // 
            // IncrementButton
            // 
            this.IncrementButton.Location = new System.Drawing.Point(160, 160);
            this.IncrementButton.Name = "IncrementButton";
            this.IncrementButton.Size = new System.Drawing.Size(75, 23);
            this.IncrementButton.TabIndex = 6;
            this.IncrementButton.Text = "Increment";
            this.IncrementButton.UseVisualStyleBackColor = true;
            this.IncrementButton.Click += new System.EventHandler(this.IncrementButton_Click);
            // 
            // DecrementButton
            // 
            this.DecrementButton.Location = new System.Drawing.Point(241, 161);
            this.DecrementButton.Name = "DecrementButton";
            this.DecrementButton.Size = new System.Drawing.Size(75, 23);
            this.DecrementButton.TabIndex = 7;
            this.DecrementButton.Text = "Decrement";
            this.DecrementButton.UseVisualStyleBackColor = true;
            this.DecrementButton.Click += new System.EventHandler(this.DecrementButton_Click);
            // 
            // ValueButton
            // 
            this.ValueButton.Location = new System.Drawing.Point(322, 160);
            this.ValueButton.Name = "ValueButton";
            this.ValueButton.Size = new System.Drawing.Size(75, 23);
            this.ValueButton.TabIndex = 8;
            this.ValueButton.Text = "Value";
            this.ValueButton.UseVisualStyleBackColor = true;
            this.ValueButton.Click += new System.EventHandler(this.ValueButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 285);
            this.Controls.Add(this.ValueButton);
            this.Controls.Add(this.DecrementButton);
            this.Controls.Add(this.IncrementButton);
            this.Controls.Add(this.textBoxUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.integerTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private TeamControls.IntegerTextBox integerTextBox1;
        private System.Windows.Forms.Button button1;
        private TeamControls.TextBoxUpDown textBoxUpDown1;
        private System.Windows.Forms.Button IncrementButton;
        private System.Windows.Forms.Button DecrementButton;
        private System.Windows.Forms.Button ValueButton;
    }
}

