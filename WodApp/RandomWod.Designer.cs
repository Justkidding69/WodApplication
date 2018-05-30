namespace WodApp
{
    partial class RandomWod
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
            this.RandomListBox = new System.Windows.Forms.ListBox();
            this.BarbellCheck = new System.Windows.Forms.CheckBox();
            this.BarCheck = new System.Windows.Forms.CheckBox();
            this.KettlebellCheck = new System.Windows.Forms.CheckBox();
            this.BodyCheck = new System.Windows.Forms.CheckBox();
            this.CardioCheck = new System.Windows.Forms.CheckBox();
            this.CreateButton = new System.Windows.Forms.Button();
            this.testBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RandomListBox
            // 
            this.RandomListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.RandomListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RandomListBox.ForeColor = System.Drawing.Color.White;
            this.RandomListBox.FormattingEnabled = true;
            this.RandomListBox.ItemHeight = 21;
            this.RandomListBox.Location = new System.Drawing.Point(244, 114);
            this.RandomListBox.Name = "RandomListBox";
            this.RandomListBox.Size = new System.Drawing.Size(260, 315);
            this.RandomListBox.TabIndex = 0;
            // 
            // BarbellCheck
            // 
            this.BarbellCheck.AutoSize = true;
            this.BarbellCheck.Location = new System.Drawing.Point(12, 114);
            this.BarbellCheck.Name = "BarbellCheck";
            this.BarbellCheck.Size = new System.Drawing.Size(81, 25);
            this.BarbellCheck.TabIndex = 1;
            this.BarbellCheck.Text = "Barbell";
            this.BarbellCheck.UseVisualStyleBackColor = true;
            // 
            // BarCheck
            // 
            this.BarCheck.AutoSize = true;
            this.BarCheck.Location = new System.Drawing.Point(12, 145);
            this.BarCheck.Name = "BarCheck";
            this.BarCheck.Size = new System.Drawing.Size(54, 25);
            this.BarCheck.TabIndex = 2;
            this.BarCheck.Text = "Bar";
            this.BarCheck.UseVisualStyleBackColor = true;
            // 
            // KettlebellCheck
            // 
            this.KettlebellCheck.AutoSize = true;
            this.KettlebellCheck.Location = new System.Drawing.Point(12, 176);
            this.KettlebellCheck.Name = "KettlebellCheck";
            this.KettlebellCheck.Size = new System.Drawing.Size(102, 25);
            this.KettlebellCheck.TabIndex = 3;
            this.KettlebellCheck.Text = "Kettlebell";
            this.KettlebellCheck.UseVisualStyleBackColor = true;
            // 
            // BodyCheck
            // 
            this.BodyCheck.AutoSize = true;
            this.BodyCheck.Location = new System.Drawing.Point(12, 207);
            this.BodyCheck.Name = "BodyCheck";
            this.BodyCheck.Size = new System.Drawing.Size(67, 25);
            this.BodyCheck.TabIndex = 4;
            this.BodyCheck.Text = "Body";
            this.BodyCheck.UseVisualStyleBackColor = true;
            // 
            // CardioCheck
            // 
            this.CardioCheck.AutoSize = true;
            this.CardioCheck.Location = new System.Drawing.Point(12, 238);
            this.CardioCheck.Name = "CardioCheck";
            this.CardioCheck.Size = new System.Drawing.Size(82, 25);
            this.CardioCheck.TabIndex = 5;
            this.CardioCheck.Text = "Cardio";
            this.CardioCheck.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.ForeColor = System.Drawing.Color.White;
            this.CreateButton.Location = new System.Drawing.Point(553, 116);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(165, 33);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(553, 58);
            this.testBox.Name = "testBox";
            this.testBox.Size = new System.Drawing.Size(165, 27);
            this.testBox.TabIndex = 7;
            // 
            // RandomWod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.ClientSize = new System.Drawing.Size(743, 445);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.CardioCheck);
            this.Controls.Add(this.BodyCheck);
            this.Controls.Add(this.KettlebellCheck);
            this.Controls.Add(this.BarCheck);
            this.Controls.Add(this.BarbellCheck);
            this.Controls.Add(this.RandomListBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "RandomWod";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox RandomListBox;
        private System.Windows.Forms.CheckBox BarbellCheck;
        private System.Windows.Forms.CheckBox BarCheck;
        private System.Windows.Forms.CheckBox KettlebellCheck;
        private System.Windows.Forms.CheckBox BodyCheck;
        private System.Windows.Forms.CheckBox CardioCheck;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.TextBox testBox;
    }
}

