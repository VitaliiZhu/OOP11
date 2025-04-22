namespace OOP11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxAB = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.textBoxCD = new System.Windows.Forms.TextBox();
            this.textBoxAD = new System.Windows.Forms.TextBox();
            this.textBoxBC = new System.Windows.Forms.TextBox();
            this.buttonTask = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAB
            // 
            this.textBoxAB.Location = new System.Drawing.Point(46, 176);
            this.textBoxAB.Name = "textBoxAB";
            this.textBoxAB.Size = new System.Drawing.Size(100, 22);
            this.textBoxAB.TabIndex = 0;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(46, 44);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 22);
            this.textBoxB.TabIndex = 1;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(46, 301);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 2;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(427, 301);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(100, 22);
            this.textBoxD.TabIndex = 5;
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(427, 44);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(100, 22);
            this.textBoxC.TabIndex = 4;
            // 
            // textBoxCD
            // 
            this.textBoxCD.Location = new System.Drawing.Point(427, 176);
            this.textBoxCD.Name = "textBoxCD";
            this.textBoxCD.Size = new System.Drawing.Size(100, 22);
            this.textBoxCD.TabIndex = 3;
            // 
            // textBoxAD
            // 
            this.textBoxAD.Location = new System.Drawing.Point(240, 301);
            this.textBoxAD.Name = "textBoxAD";
            this.textBoxAD.Size = new System.Drawing.Size(100, 22);
            this.textBoxAD.TabIndex = 8;
            // 
            // textBoxBC
            // 
            this.textBoxBC.Location = new System.Drawing.Point(240, 44);
            this.textBoxBC.Name = "textBoxBC";
            this.textBoxBC.Size = new System.Drawing.Size(100, 22);
            this.textBoxBC.TabIndex = 7;
            // 
            // buttonTask
            // 
            this.buttonTask.Location = new System.Drawing.Point(196, 153);
            this.buttonTask.Name = "buttonTask";
            this.buttonTask.Size = new System.Drawing.Size(184, 45);
            this.buttonTask.TabIndex = 9;
            this.buttonTask.Text = "Дані заповнено";
            this.buttonTask.UseVisualStyleBackColor = true;
            this.buttonTask.Click += new System.EventHandler(this.buttonTask_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(580, 352);
            this.Controls.Add(this.buttonTask);
            this.Controls.Add(this.textBoxAD);
            this.Controls.Add(this.textBoxBC);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxCD);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxAB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxCD;
        private System.Windows.Forms.TextBox textBoxAD;
        private System.Windows.Forms.TextBox textBoxBC;
        private System.Windows.Forms.Button buttonTask;
    }
}

