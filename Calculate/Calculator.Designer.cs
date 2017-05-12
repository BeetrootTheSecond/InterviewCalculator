namespace Calculate
{
    partial class Calculator
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
            this.CalculateButton = new System.Windows.Forms.Button();
            this.UserInputTXT = new System.Windows.Forms.TextBox();
            this.ResultTXT = new System.Windows.Forms.RichTextBox();
            this.AddRB = new System.Windows.Forms.RadioButton();
            this.SubstractRB = new System.Windows.Forms.RadioButton();
            this.OperatorsGroup = new System.Windows.Forms.GroupBox();
            this.MultipleRB = new System.Windows.Forms.RadioButton();
            this.DivideRB = new System.Windows.Forms.RadioButton();
            this.OperatorsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // CalculateButton
            // 
            this.CalculateButton.Enabled = false;
            this.CalculateButton.Location = new System.Drawing.Point(283, 27);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 0;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // UserInputTXT
            // 
            this.UserInputTXT.Location = new System.Drawing.Point(35, 30);
            this.UserInputTXT.Name = "UserInputTXT";
            this.UserInputTXT.Size = new System.Drawing.Size(226, 20);
            this.UserInputTXT.TabIndex = 5;
            this.UserInputTXT.TextChanged += new System.EventHandler(this.UserInputTXT_TextChanged);
            // 
            // ResultTXT
            // 
            this.ResultTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ResultTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ResultTXT.Location = new System.Drawing.Point(35, 98);
            this.ResultTXT.Name = "ResultTXT";
            this.ResultTXT.Size = new System.Drawing.Size(323, 235);
            this.ResultTXT.TabIndex = 6;
            this.ResultTXT.Text = "";
            // 
            // AddRB
            // 
            this.AddRB.AutoSize = true;
            this.AddRB.Checked = true;
            this.AddRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AddRB.Location = new System.Drawing.Point(18, 13);
            this.AddRB.Name = "AddRB";
            this.AddRB.Size = new System.Drawing.Size(34, 21);
            this.AddRB.TabIndex = 7;
            this.AddRB.TabStop = true;
            this.AddRB.Text = "+";
            this.AddRB.UseVisualStyleBackColor = true;
            this.AddRB.CheckedChanged += new System.EventHandler(this.AddRB_CheckedChanged);
            // 
            // SubstractRB
            // 
            this.SubstractRB.AutoSize = true;
            this.SubstractRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SubstractRB.Location = new System.Drawing.Point(84, 13);
            this.SubstractRB.Name = "SubstractRB";
            this.SubstractRB.Size = new System.Drawing.Size(31, 21);
            this.SubstractRB.TabIndex = 8;
            this.SubstractRB.Text = "-";
            this.SubstractRB.UseVisualStyleBackColor = true;
            this.SubstractRB.CheckedChanged += new System.EventHandler(this.SubstractRB_CheckedChanged);
            // 
            // OperatorsGroup
            // 
            this.OperatorsGroup.Controls.Add(this.MultipleRB);
            this.OperatorsGroup.Controls.Add(this.DivideRB);
            this.OperatorsGroup.Controls.Add(this.AddRB);
            this.OperatorsGroup.Controls.Add(this.SubstractRB);
            this.OperatorsGroup.Location = new System.Drawing.Point(35, 56);
            this.OperatorsGroup.Name = "OperatorsGroup";
            this.OperatorsGroup.Size = new System.Drawing.Size(323, 36);
            this.OperatorsGroup.TabIndex = 9;
            this.OperatorsGroup.TabStop = false;
            // 
            // MultipleRB
            // 
            this.MultipleRB.AutoSize = true;
            this.MultipleRB.Location = new System.Drawing.Point(260, 13);
            this.MultipleRB.Name = "MultipleRB";
            this.MultipleRB.Size = new System.Drawing.Size(32, 17);
            this.MultipleRB.TabIndex = 10;
            this.MultipleRB.Text = "X";
            this.MultipleRB.UseVisualStyleBackColor = true;
            this.MultipleRB.CheckedChanged += new System.EventHandler(this.MultipleRB_CheckedChanged);
            // 
            // DivideRB
            // 
            this.DivideRB.AutoSize = true;
            this.DivideRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DivideRB.Location = new System.Drawing.Point(166, 13);
            this.DivideRB.Name = "DivideRB";
            this.DivideRB.Size = new System.Drawing.Size(34, 21);
            this.DivideRB.TabIndex = 9;
            this.DivideRB.Text = "÷";
            this.DivideRB.UseVisualStyleBackColor = true;
            this.DivideRB.CheckedChanged += new System.EventHandler(this.DivideRB_CheckedChanged);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 351);
            this.Controls.Add(this.OperatorsGroup);
            this.Controls.Add(this.ResultTXT);
            this.Controls.Add(this.UserInputTXT);
            this.Controls.Add(this.CalculateButton);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.OperatorsGroup.ResumeLayout(false);
            this.OperatorsGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox UserInputTXT;
        private System.Windows.Forms.RichTextBox ResultTXT;
        private System.Windows.Forms.RadioButton AddRB;
        private System.Windows.Forms.RadioButton SubstractRB;
        private System.Windows.Forms.GroupBox OperatorsGroup;
        private System.Windows.Forms.RadioButton DivideRB;
        private System.Windows.Forms.RadioButton MultipleRB;
    }
}

