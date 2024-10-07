namespace Stop_Watch
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.msecslb = new System.Windows.Forms.Label();
            this.secslb = new System.Windows.Forms.Label();
            this.minslb = new System.Windows.Forms.Label();
            this.hrslb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stop Watch";
            // 
            // msecslb
            // 
            this.msecslb.AutoSize = true;
            this.msecslb.Location = new System.Drawing.Point(449, 192);
            this.msecslb.Name = "msecslb";
            this.msecslb.Size = new System.Drawing.Size(19, 13);
            this.msecslb.TabIndex = 1;
            this.msecslb.Text = "00";
            // 
            // secslb
            // 
            this.secslb.AutoSize = true;
            this.secslb.Location = new System.Drawing.Point(200, 192);
            this.secslb.Name = "secslb";
            this.secslb.Size = new System.Drawing.Size(19, 13);
            this.secslb.TabIndex = 1;
            this.secslb.Text = "00";
            // 
            // minslb
            // 
            this.minslb.AutoSize = true;
            this.minslb.Location = new System.Drawing.Point(282, 192);
            this.minslb.Name = "minslb";
            this.minslb.Size = new System.Drawing.Size(19, 13);
            this.minslb.TabIndex = 1;
            this.minslb.Text = "00";
            // 
            // hrslb
            // 
            this.hrslb.AutoSize = true;
            this.hrslb.Location = new System.Drawing.Point(370, 192);
            this.hrslb.Name = "hrslb";
            this.hrslb.Size = new System.Drawing.Size(19, 13);
            this.hrslb.TabIndex = 1;
            this.hrslb.Text = "00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 278);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(338, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Resume";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(419, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hrslb);
            this.Controls.Add(this.minslb);
            this.Controls.Add(this.secslb);
            this.Controls.Add(this.msecslb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label msecslb;
        private System.Windows.Forms.Label secslb;
        private System.Windows.Forms.Label minslb;
        private System.Windows.Forms.Label hrslb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}

