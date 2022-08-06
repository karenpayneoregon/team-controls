
namespace PanelControlTestApp
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
            this.MonthsPanel = new TeamControls.PanelControl();
            this.GetSelectedMonthButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MonthsPanel
            // 
            this.MonthsPanel.Location = new System.Drawing.Point(12, 12);
            this.MonthsPanel.Name = "MonthsPanel";
            this.MonthsPanel.Size = new System.Drawing.Size(184, 88);
            this.MonthsPanel.TabIndex = 0;
            // 
            // GetSelectedMonthButton
            // 
            this.GetSelectedMonthButton.Location = new System.Drawing.Point(202, 44);
            this.GetSelectedMonthButton.Name = "GetSelectedMonthButton";
            this.GetSelectedMonthButton.Size = new System.Drawing.Size(95, 23);
            this.GetSelectedMonthButton.TabIndex = 1;
            this.GetSelectedMonthButton.Text = "Get selected";
            this.GetSelectedMonthButton.UseVisualStyleBackColor = true;
            this.GetSelectedMonthButton.Click += new System.EventHandler(this.GetSelectedMonthButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 142);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GetSelectedMonthButton);
            this.Controls.Add(this.MonthsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TeamControls.PanelControl MonthsPanel;
        private System.Windows.Forms.Button GetSelectedMonthButton;
        private System.Windows.Forms.Label label1;
    }
}

