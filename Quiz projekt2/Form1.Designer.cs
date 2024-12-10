namespace Quiz_projekt2
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
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.questionbar = new System.Windows.Forms.Label();
            this.option1 = new System.Windows.Forms.Label();
            this.option2 = new System.Windows.Forms.Label();
            this.option3 = new System.Windows.Forms.Label();
            this.valasz = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.option4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(46, 186);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(106, 20);
            this.answerTextBox.TabIndex = 0;
            // 
            // questionbar
            // 
            this.questionbar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.questionbar.Location = new System.Drawing.Point(203, 18);
            this.questionbar.Name = "questionbar";
            this.questionbar.Size = new System.Drawing.Size(481, 96);
            this.questionbar.TabIndex = 1;
            this.questionbar.Text = "label1";
            this.questionbar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // option1
            // 
            this.option1.AutoSize = true;
            this.option1.Location = new System.Drawing.Point(203, 263);
            this.option1.Name = "option1";
            this.option1.Size = new System.Drawing.Size(35, 13);
            this.option1.TabIndex = 2;
            this.option1.Text = "label2";
            // 
            // option2
            // 
            this.option2.AutoSize = true;
            this.option2.Location = new System.Drawing.Point(649, 263);
            this.option2.Name = "option2";
            this.option2.Size = new System.Drawing.Size(35, 13);
            this.option2.TabIndex = 3;
            this.option2.Text = "label3";
            // 
            // option3
            // 
            this.option3.AutoSize = true;
            this.option3.Location = new System.Drawing.Point(203, 398);
            this.option3.Name = "option3";
            this.option3.Size = new System.Drawing.Size(35, 13);
            this.option3.TabIndex = 3;
            this.option3.Text = "label3";
            // 
            // valasz
            // 
            this.valasz.Location = new System.Drawing.Point(172, 186);
            this.valasz.Name = "valasz";
            this.valasz.Size = new System.Drawing.Size(75, 23);
            this.valasz.TabIndex = 4;
            this.valasz.Text = "button1";
            this.valasz.UseVisualStyleBackColor = true;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(839, 439);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(35, 13);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "label1";
            // 
            // option4
            // 
            this.option4.AutoSize = true;
            this.option4.Location = new System.Drawing.Point(649, 398);
            this.option4.Name = "option4";
            this.option4.Size = new System.Drawing.Size(35, 13);
            this.option4.TabIndex = 6;
            this.option4.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 479);
            this.Controls.Add(this.option4);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.valasz);
            this.Controls.Add(this.option3);
            this.Controls.Add(this.option2);
            this.Controls.Add(this.option1);
            this.Controls.Add(this.questionbar);
            this.Controls.Add(this.answerTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label questionbar;
        private System.Windows.Forms.Label option1;
        private System.Windows.Forms.Label option2;
        private System.Windows.Forms.Label option3;
        private System.Windows.Forms.Button valasz;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label option4;
    }
}

