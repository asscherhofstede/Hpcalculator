namespace calstack
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
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.MyStack = new System.Windows.Forms.RadioButton();
            this.ArrayStack = new System.Windows.Forms.RadioButton();
            this.MyListStack = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(57, 72);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(190, 22);
            this.TxtBox1.TabIndex = 0;
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(443, 12);
            this.TxtBox2.Multiline = true;
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(345, 426);
            this.TxtBox2.TabIndex = 1;
            // 
            // MyStack
            // 
            this.MyStack.AutoSize = true;
            this.MyStack.Location = new System.Drawing.Point(319, 45);
            this.MyStack.Name = "MyStack";
            this.MyStack.Size = new System.Drawing.Size(82, 21);
            this.MyStack.TabIndex = 5;
            this.MyStack.TabStop = true;
            this.MyStack.Text = "MyStack";
            this.MyStack.UseVisualStyleBackColor = true;
            // 
            // ArrayStack
            // 
            this.ArrayStack.AutoSize = true;
            this.ArrayStack.Location = new System.Drawing.Point(319, 72);
            this.ArrayStack.Name = "ArrayStack";
            this.ArrayStack.Size = new System.Drawing.Size(98, 21);
            this.ArrayStack.TabIndex = 6;
            this.ArrayStack.TabStop = true;
            this.ArrayStack.Text = "ArrayStack";
            this.ArrayStack.UseVisualStyleBackColor = true;
            // 
            // MyListStack
            // 
            this.MyListStack.AutoSize = true;
            this.MyListStack.Location = new System.Drawing.Point(319, 99);
            this.MyListStack.Name = "MyListStack";
            this.MyListStack.Size = new System.Drawing.Size(104, 21);
            this.MyListStack.TabIndex = 7;
            this.MyListStack.TabStop = true;
            this.MyListStack.Text = "MyListStack";
            this.MyListStack.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MyListStack);
            this.Controls.Add(this.ArrayStack);
            this.Controls.Add(this.MyStack);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.TxtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox1;
        private System.Windows.Forms.TextBox TxtBox2;
        private System.Windows.Forms.RadioButton MyStack;
        private System.Windows.Forms.RadioButton ArrayStack;
        private System.Windows.Forms.RadioButton MyListStack;
    }
}

