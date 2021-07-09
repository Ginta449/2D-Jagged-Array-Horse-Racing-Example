namespace Question_3
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
            this.btnRunner1 = new System.Windows.Forms.Button();
            this.lstRunner1 = new System.Windows.Forms.ListBox();
            this.lstRunner3 = new System.Windows.Forms.ListBox();
            this.lstRunner2 = new System.Windows.Forms.ListBox();
            this.btnRunner3 = new System.Windows.Forms.Button();
            this.btnRunner2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRunner1
            // 
            this.btnRunner1.Location = new System.Drawing.Point(79, 50);
            this.btnRunner1.Name = "btnRunner1";
            this.btnRunner1.Size = new System.Drawing.Size(75, 23);
            this.btnRunner1.TabIndex = 0;
            this.btnRunner1.Text = "Runner 1";
            this.btnRunner1.UseVisualStyleBackColor = true;
            this.btnRunner1.Click += new System.EventHandler(this.btnRunner1_Click);
            // 
            // lstRunner1
            // 
            this.lstRunner1.FormattingEnabled = true;
            this.lstRunner1.Location = new System.Drawing.Point(196, 50);
            this.lstRunner1.Name = "lstRunner1";
            this.lstRunner1.Size = new System.Drawing.Size(262, 56);
            this.lstRunner1.TabIndex = 1;
            // 
            // lstRunner3
            // 
            this.lstRunner3.FormattingEnabled = true;
            this.lstRunner3.Location = new System.Drawing.Point(196, 219);
            this.lstRunner3.Name = "lstRunner3";
            this.lstRunner3.Size = new System.Drawing.Size(262, 56);
            this.lstRunner3.TabIndex = 4;
            // 
            // lstRunner2
            // 
            this.lstRunner2.FormattingEnabled = true;
            this.lstRunner2.Location = new System.Drawing.Point(196, 132);
            this.lstRunner2.Name = "lstRunner2";
            this.lstRunner2.Size = new System.Drawing.Size(262, 56);
            this.lstRunner2.TabIndex = 5;
            // 
            // btnRunner3
            // 
            this.btnRunner3.Location = new System.Drawing.Point(79, 239);
            this.btnRunner3.Name = "btnRunner3";
            this.btnRunner3.Size = new System.Drawing.Size(75, 23);
            this.btnRunner3.TabIndex = 2;
            this.btnRunner3.Text = "Runner 3";
            this.btnRunner3.UseVisualStyleBackColor = true;
            this.btnRunner3.Click += new System.EventHandler(this.btnRunner3_Click);
            // 
            // btnRunner2
            // 
            this.btnRunner2.Location = new System.Drawing.Point(79, 145);
            this.btnRunner2.Name = "btnRunner2";
            this.btnRunner2.Size = new System.Drawing.Size(75, 23);
            this.btnRunner2.TabIndex = 3;
            this.btnRunner2.Text = "Runner 2";
            this.btnRunner2.UseVisualStyleBackColor = true;
            this.btnRunner2.Click += new System.EventHandler(this.btnRunner2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstRunner2);
            this.Controls.Add(this.lstRunner3);
            this.Controls.Add(this.btnRunner2);
            this.Controls.Add(this.btnRunner3);
            this.Controls.Add(this.lstRunner1);
            this.Controls.Add(this.btnRunner1);
            this.Name = "Form1";
            this.Text = "Question 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRunner1;
        private System.Windows.Forms.ListBox lstRunner1;
        private System.Windows.Forms.ListBox lstRunner3;
        private System.Windows.Forms.ListBox lstRunner2;
        private System.Windows.Forms.Button btnRunner3;
        private System.Windows.Forms.Button btnRunner2;
    }
}

