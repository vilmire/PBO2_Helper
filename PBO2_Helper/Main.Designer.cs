namespace PBO2_Helper
{
    partial class Main
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
            this.selectPboButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.core_1_textBox = new System.Windows.Forms.TextBox();
            this.core_2_textBox = new System.Windows.Forms.TextBox();
            this.core_3_textBox = new System.Windows.Forms.TextBox();
            this.core_4_textBox = new System.Windows.Forms.TextBox();
            this.core_5_textBox = new System.Windows.Forms.TextBox();
            this.core_6_textBox = new System.Windows.Forms.TextBox();
            this.core_7_textBox = new System.Windows.Forms.TextBox();
            this.core_8_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.applyToCore1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CoreBox = new System.Windows.Forms.GroupBox();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.CoreBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectPboButton
            // 
            this.selectPboButton.Location = new System.Drawing.Point(12, 12);
            this.selectPboButton.Name = "selectPboButton";
            this.selectPboButton.Size = new System.Drawing.Size(214, 51);
            this.selectPboButton.TabIndex = 0;
            this.selectPboButton.Text = "1. Select \"PBO2 tuner.exe\"";
            this.selectPboButton.UseVisualStyleBackColor = true;
            this.selectPboButton.Click += new System.EventHandler(this.selectPboButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Enabled = false;
            this.ApplyButton.Location = new System.Drawing.Point(12, 69);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(214, 42);
            this.ApplyButton.TabIndex = 1;
            this.ApplyButton.Text = "2. Add Task";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // core_1_textBox
            // 
            this.core_1_textBox.Location = new System.Drawing.Point(75, 27);
            this.core_1_textBox.Name = "core_1_textBox";
            this.core_1_textBox.Size = new System.Drawing.Size(74, 23);
            this.core_1_textBox.TabIndex = 2;
            this.core_1_textBox.Text = "-30";
            // 
            // core_2_textBox
            // 
            this.core_2_textBox.Location = new System.Drawing.Point(75, 56);
            this.core_2_textBox.Name = "core_2_textBox";
            this.core_2_textBox.Size = new System.Drawing.Size(127, 23);
            this.core_2_textBox.TabIndex = 3;
            this.core_2_textBox.Text = "-30";
            // 
            // core_3_textBox
            // 
            this.core_3_textBox.Location = new System.Drawing.Point(75, 85);
            this.core_3_textBox.Name = "core_3_textBox";
            this.core_3_textBox.Size = new System.Drawing.Size(127, 23);
            this.core_3_textBox.TabIndex = 4;
            this.core_3_textBox.Text = "-30";
            // 
            // core_4_textBox
            // 
            this.core_4_textBox.Location = new System.Drawing.Point(75, 114);
            this.core_4_textBox.Name = "core_4_textBox";
            this.core_4_textBox.Size = new System.Drawing.Size(127, 23);
            this.core_4_textBox.TabIndex = 5;
            this.core_4_textBox.Text = "-30";
            // 
            // core_5_textBox
            // 
            this.core_5_textBox.Location = new System.Drawing.Point(75, 143);
            this.core_5_textBox.Name = "core_5_textBox";
            this.core_5_textBox.Size = new System.Drawing.Size(127, 23);
            this.core_5_textBox.TabIndex = 6;
            this.core_5_textBox.Text = "-30";
            // 
            // core_6_textBox
            // 
            this.core_6_textBox.Location = new System.Drawing.Point(75, 172);
            this.core_6_textBox.Name = "core_6_textBox";
            this.core_6_textBox.Size = new System.Drawing.Size(127, 23);
            this.core_6_textBox.TabIndex = 7;
            this.core_6_textBox.Text = "-30";
            // 
            // core_7_textBox
            // 
            this.core_7_textBox.Location = new System.Drawing.Point(75, 201);
            this.core_7_textBox.Name = "core_7_textBox";
            this.core_7_textBox.Size = new System.Drawing.Size(127, 23);
            this.core_7_textBox.TabIndex = 8;
            this.core_7_textBox.Text = "-30";
            // 
            // core_8_textBox
            // 
            this.core_8_textBox.Location = new System.Drawing.Point(75, 230);
            this.core_8_textBox.Name = "core_8_textBox";
            this.core_8_textBox.Size = new System.Drawing.Size(127, 23);
            this.core_8_textBox.TabIndex = 9;
            this.core_8_textBox.Text = "-30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Core 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Core 2:";
            // 
            // applyToCore1
            // 
            this.applyToCore1.Location = new System.Drawing.Point(155, 27);
            this.applyToCore1.Name = "applyToCore1";
            this.applyToCore1.Size = new System.Drawing.Size(47, 23);
            this.applyToCore1.TabIndex = 12;
            this.applyToCore1.Text = "★";
            this.applyToCore1.UseVisualStyleBackColor = true;
            this.applyToCore1.Click += new System.EventHandler(this.applyToCore1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Core 3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Core 4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Core 5:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Core 6:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 204);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Core 7:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Core 8:";
            // 
            // CoreBox
            // 
            this.CoreBox.Controls.Add(this.label1);
            this.CoreBox.Controls.Add(this.label8);
            this.CoreBox.Controls.Add(this.core_1_textBox);
            this.CoreBox.Controls.Add(this.label7);
            this.CoreBox.Controls.Add(this.core_2_textBox);
            this.CoreBox.Controls.Add(this.label6);
            this.CoreBox.Controls.Add(this.core_3_textBox);
            this.CoreBox.Controls.Add(this.label5);
            this.CoreBox.Controls.Add(this.core_4_textBox);
            this.CoreBox.Controls.Add(this.label4);
            this.CoreBox.Controls.Add(this.core_5_textBox);
            this.CoreBox.Controls.Add(this.label3);
            this.CoreBox.Controls.Add(this.core_6_textBox);
            this.CoreBox.Controls.Add(this.applyToCore1);
            this.CoreBox.Controls.Add(this.core_7_textBox);
            this.CoreBox.Controls.Add(this.label2);
            this.CoreBox.Controls.Add(this.core_8_textBox);
            this.CoreBox.Location = new System.Drawing.Point(12, 117);
            this.CoreBox.Name = "CoreBox";
            this.CoreBox.Size = new System.Drawing.Size(214, 270);
            this.CoreBox.TabIndex = 19;
            this.CoreBox.TabStop = false;
            this.CoreBox.Text = "Cores (Only Support 8Core CPU)";
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.Enabled = false;
            this.DeleteTaskButton.Location = new System.Drawing.Point(12, 393);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(214, 42);
            this.DeleteTaskButton.TabIndex = 20;
            this.DeleteTaskButton.Text = "Delete Task";
            this.DeleteTaskButton.UseVisualStyleBackColor = true;
            this.DeleteTaskButton.Click += new System.EventHandler(this.DeleteTaskButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 446);
            this.Controls.Add(this.DeleteTaskButton);
            this.Controls.Add(this.CoreBox);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.selectPboButton);
            this.Name = "Main";
            this.Text = "PBO2_tuner_Helper";
            this.Load += new System.EventHandler(this.Main_Load);
            this.CoreBox.ResumeLayout(false);
            this.CoreBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button selectPboButton;
        private Button ApplyButton;
        private TextBox core_1_textBox;
        private TextBox core_2_textBox;
        private TextBox core_3_textBox;
        private TextBox core_4_textBox;
        private TextBox core_5_textBox;
        private TextBox core_6_textBox;
        private TextBox core_7_textBox;
        private TextBox core_8_textBox;
        private Label label1;
        private Label label2;
        private Button applyToCore1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox CoreBox;
        private Button DeleteTaskButton;
    }
}