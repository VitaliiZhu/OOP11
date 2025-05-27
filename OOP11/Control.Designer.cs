namespace OOP11
{
    partial class Control
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnCloneStack = new System.Windows.Forms.Button();
            this.btnSortStack = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(123, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Додати фігуру";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(12, 305);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(105, 40);
            this.btnSort.TabIndex = 3;
            this.btnSort.Text = "Сортувати";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(183, 244);
            this.listBox1.TabIndex = 4;
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(12, 259);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(183, 40);
            this.btnClone.TabIndex = 5;
            this.btnClone.Text = "Клонувати";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnCloneStack
            // 
            this.btnCloneStack.Location = new System.Drawing.Point(214, 259);
            this.btnCloneStack.Name = "btnCloneStack";
            this.btnCloneStack.Size = new System.Drawing.Size(183, 40);
            this.btnCloneStack.TabIndex = 7;
            this.btnCloneStack.Text = "Клонувати";
            this.btnCloneStack.UseVisualStyleBackColor = true;
            this.btnCloneStack.Click += new System.EventHandler(this.btnCloneStack_Click);
            // 
            // btnSortStack
            // 
            this.btnSortStack.Location = new System.Drawing.Point(274, 305);
            this.btnSortStack.Name = "btnSortStack";
            this.btnSortStack.Size = new System.Drawing.Size(123, 40);
            this.btnSortStack.TabIndex = 6;
            this.btnSortStack.Text = "Сортувати";
            this.btnSortStack.UseVisualStyleBackColor = true;
            this.btnSortStack.Click += new System.EventHandler(this.btnSortStack_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(214, 6);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(183, 244);
            this.listBox2.TabIndex = 9;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 357);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnCloneStack);
            this.Controls.Add(this.btnSortStack);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnAdd);
            this.MaximumSize = new System.Drawing.Size(430, 404);
            this.MinimumSize = new System.Drawing.Size(430, 404);
            this.Name = "Control";
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Control_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnCloneStack;
        private System.Windows.Forms.Button btnSortStack;
        private System.Windows.Forms.ListBox listBox2;
    }
}