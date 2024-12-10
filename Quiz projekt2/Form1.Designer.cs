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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.kerdes = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.Label();
            this.b = new System.Windows.Forms.Label();
            this.c = new System.Windows.Forms.Label();
            this.valasz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 0;
            // 
            // kerdes
            // 
            this.kerdes.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.kerdes.Location = new System.Drawing.Point(203, 18);
            this.kerdes.Name = "kerdes";
            this.kerdes.Size = new System.Drawing.Size(481, 96);
            this.kerdes.TabIndex = 1;
            this.kerdes.Text = "label1";
            this.kerdes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Location = new System.Drawing.Point(203, 263);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(35, 13);
            this.a.TabIndex = 2;
            this.a.Text = "label2";
            // 
            // b
            // 
            this.b.AutoSize = true;
            this.b.Location = new System.Drawing.Point(649, 263);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(35, 13);
            this.b.TabIndex = 3;
            this.b.Text = "label3";
            // 
            // c
            // 
            this.c.AutoSize = true;
            this.c.Location = new System.Drawing.Point(424, 398);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(35, 13);
            this.c.TabIndex = 3;
            this.c.Text = "label3";
            // 
            // valasz
            // 
            this.valasz.Location = new System.Drawing.Point(172, 186);
            this.valasz.Name = "valasz";
            this.valasz.Size = new System.Drawing.Size(75, 23);
            this.valasz.TabIndex = 4;
            this.valasz.Text = "button1";
            this.valasz.UseVisualStyleBackColor = true;
            this.valasz.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 479);
            this.Controls.Add(this.valasz);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.kerdes);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label kerdes;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.Label b;
        private System.Windows.Forms.Label c;
        private System.Windows.Forms.Button valasz;
    }
}

