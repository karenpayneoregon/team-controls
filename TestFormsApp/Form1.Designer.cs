
namespace TestFormsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxListButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.noBeepTextBox1 = new TeamControls.NoBeepTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GetStashButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.RemoveSpacesButton = new System.Windows.Forms.Button();
            this.MultipleSpacesTextBox = new TeamControls.NoBeepTextBox();
            this.SaveImageButton = new System.Windows.Forms.Button();
            this.pictureBoxCustom1 = new TeamControls.PictureBoxCustom();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.GetIntValueButton = new System.Windows.Forms.Button();
            this.integerTextBox1 = new TeamControls.IntegerTextBox();
            this.dateTimePickerCustom1 = new TeamControls.DateTimePickerCustom();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustom1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBoxListButton);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.AccountTextBox);
            this.groupBox1.Controls.Add(this.LastNameTextBox);
            this.groupBox1.Controls.Add(this.FirstNameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TextBoxList example";
            // 
            // TextBoxListButton
            // 
            this.TextBoxListButton.Location = new System.Drawing.Point(16, 111);
            this.TextBoxListButton.Name = "TextBoxListButton";
            this.TextBoxListButton.Size = new System.Drawing.Size(103, 23);
            this.TextBoxListButton.TabIndex = 4;
            this.TextBoxListButton.Text = "Get TextBoxes";
            this.TextBoxListButton.UseVisualStyleBackColor = true;
            this.TextBoxListButton.Click += new System.EventHandler(this.TextBoxListButton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(126, 22);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 109);
            this.listBox1.TabIndex = 3;
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(19, 82);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(100, 23);
            this.AccountTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(19, 53);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(19, 24);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // noBeepTextBox1
            // 
            this.noBeepTextBox1.Id = 0;
            this.noBeepTextBox1.Location = new System.Drawing.Point(18, 22);
            this.noBeepTextBox1.Name = "noBeepTextBox1";
            this.noBeepTextBox1.PlaceholderText = "No beep on pressing enter";
            this.noBeepTextBox1.Size = new System.Drawing.Size(227, 23);
            this.noBeepTextBox1.Stash = "A place to stash whatever";
            this.noBeepTextBox1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GetStashButton);
            this.groupBox2.Controls.Add(this.noBeepTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stashing";
            // 
            // GetStashButton
            // 
            this.GetStashButton.Location = new System.Drawing.Point(15, 56);
            this.GetStashButton.Name = "GetStashButton";
            this.GetStashButton.Size = new System.Drawing.Size(230, 23);
            this.GetStashButton.TabIndex = 4;
            this.GetStashButton.Text = "Get stash";
            this.GetStashButton.UseVisualStyleBackColor = true;
            this.GetStashButton.Click += new System.EventHandler(this.GetStashButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.RemoveSpacesButton);
            this.groupBox3.Controls.Add(this.MultipleSpacesTextBox);
            this.groupBox3.Location = new System.Drawing.Point(13, 272);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 90);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Remove extra spaces";
            // 
            // RemoveSpacesButton
            // 
            this.RemoveSpacesButton.Location = new System.Drawing.Point(15, 56);
            this.RemoveSpacesButton.Name = "RemoveSpacesButton";
            this.RemoveSpacesButton.Size = new System.Drawing.Size(229, 23);
            this.RemoveSpacesButton.TabIndex = 4;
            this.RemoveSpacesButton.Text = "Remove multiple spaces";
            this.RemoveSpacesButton.UseVisualStyleBackColor = true;
            this.RemoveSpacesButton.Click += new System.EventHandler(this.RemoveSpacesButton_Click);
            // 
            // MultipleSpacesTextBox
            // 
            this.MultipleSpacesTextBox.Id = 0;
            this.MultipleSpacesTextBox.Location = new System.Drawing.Point(18, 22);
            this.MultipleSpacesTextBox.Name = "MultipleSpacesTextBox";
            this.MultipleSpacesTextBox.PlaceholderText = "No beep on pressing enter";
            this.MultipleSpacesTextBox.Size = new System.Drawing.Size(227, 23);
            this.MultipleSpacesTextBox.Stash = "A place to stash whatever";
            this.MultipleSpacesTextBox.TabIndex = 3;
            this.MultipleSpacesTextBox.Text = "This    is    a simple      Test";
            // 
            // SaveImageButton
            // 
            this.SaveImageButton.Location = new System.Drawing.Point(32, 263);
            this.SaveImageButton.Name = "SaveImageButton";
            this.SaveImageButton.Size = new System.Drawing.Size(227, 23);
            this.SaveImageButton.TabIndex = 7;
            this.SaveImageButton.Text = "Save Image";
            this.SaveImageButton.UseVisualStyleBackColor = true;
            this.SaveImageButton.Click += new System.EventHandler(this.SaveImageButton_Click);
            // 
            // pictureBoxCustom1
            // 
            this.pictureBoxCustom1.Id = 0;
            this.pictureBoxCustom1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCustom1.Image")));
            this.pictureBoxCustom1.Location = new System.Drawing.Point(32, 32);
            this.pictureBoxCustom1.Name = "pictureBoxCustom1";
            this.pictureBoxCustom1.Size = new System.Drawing.Size(405, 216);
            this.pictureBoxCustom1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCustom1.Stash = null;
            this.pictureBoxCustom1.TabIndex = 8;
            this.pictureBoxCustom1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxCustom1);
            this.groupBox4.Controls.Add(this.SaveImageButton);
            this.groupBox4.Location = new System.Drawing.Point(275, 9);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 308);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Save image to disk";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.GetIntValueButton);
            this.groupBox5.Controls.Add(this.integerTextBox1);
            this.groupBox5.Location = new System.Drawing.Point(13, 372);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(254, 78);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Int TextBox";
            // 
            // GetIntValueButton
            // 
            this.GetIntValueButton.Location = new System.Drawing.Point(119, 30);
            this.GetIntValueButton.Name = "GetIntValueButton";
            this.GetIntValueButton.Size = new System.Drawing.Size(125, 23);
            this.GetIntValueButton.TabIndex = 1;
            this.GetIntValueButton.Text = "Get Value";
            this.GetIntValueButton.UseVisualStyleBackColor = true;
            this.GetIntValueButton.Click += new System.EventHandler(this.GetIntValueButton_Click);
            // 
            // integerTextBox1
            // 
            this.integerTextBox1.Id = 0;
            this.integerTextBox1.Location = new System.Drawing.Point(13, 30);
            this.integerTextBox1.Name = "integerTextBox1";
            this.integerTextBox1.Size = new System.Drawing.Size(100, 23);
            this.integerTextBox1.Stash = null;
            this.integerTextBox1.TabIndex = 0;
            this.integerTextBox1.Text = "0";
            // 
            // dateTimePickerCustom1
            // 
            this.dateTimePickerCustom1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerCustom1.Id = 0;
            this.dateTimePickerCustom1.Location = new System.Drawing.Point(307, 349);
            this.dateTimePickerCustom1.Name = "dateTimePickerCustom1";
            this.dateTimePickerCustom1.Size = new System.Drawing.Size(100, 23);
            this.dateTimePickerCustom1.Stash = null;
            this.dateTimePickerCustom1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Custom DateTimePicker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerCustom1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examples";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCustom1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button TextBoxListButton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private TeamControls.NoBeepTextBox noBeepTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetStashButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button RemoveSpacesButton;
        private TeamControls.NoBeepTextBox MultipleSpacesTextBox;
        private System.Windows.Forms.Button SaveImageButton;
        private TeamControls.PictureBoxCustom pictureBoxCustom1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button GetIntValueButton;
        private TeamControls.IntegerTextBox integerTextBox1;
        private TeamControls.DateTimePickerCustom dateTimePickerCustom1;
        private System.Windows.Forms.Label label1;
    }
}

