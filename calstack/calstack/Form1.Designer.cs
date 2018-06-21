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
            this.StackPushButton = new System.Windows.Forms.Button();
            this.StackPopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(44, 27);
            this.TxtBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBox1.Multiline = true;
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(154, 40);
            this.TxtBox1.TabIndex = 0;
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(332, 10);
            this.TxtBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtBox2.Multiline = true;
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(260, 347);
            this.TxtBox2.TabIndex = 1;
            // 
            // MyStack
            // 
            this.MyStack.AutoSize = true;
            this.MyStack.Location = new System.Drawing.Point(247, 293);
            this.MyStack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyStack.Name = "MyStack";
            this.MyStack.Size = new System.Drawing.Size(67, 17);
            this.MyStack.TabIndex = 5;
            this.MyStack.TabStop = true;
            this.MyStack.Text = "MyStack";
            this.MyStack.UseVisualStyleBackColor = true;
            // 
            // ArrayStack
            // 
            this.ArrayStack.AutoSize = true;
            this.ArrayStack.Location = new System.Drawing.Point(247, 315);
            this.ArrayStack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ArrayStack.Name = "ArrayStack";
            this.ArrayStack.Size = new System.Drawing.Size(77, 17);
            this.ArrayStack.TabIndex = 6;
            this.ArrayStack.TabStop = true;
            this.ArrayStack.Text = "ArrayStack";
            this.ArrayStack.UseVisualStyleBackColor = true;
            // 
            // MyListStack
            // 
            this.MyListStack.AutoSize = true;
            this.MyListStack.Location = new System.Drawing.Point(247, 337);
            this.MyListStack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyListStack.Name = "MyListStack";
            this.MyListStack.Size = new System.Drawing.Size(83, 17);
            this.MyListStack.TabIndex = 7;
            this.MyListStack.TabStop = true;
            this.MyListStack.Text = "MyListStack";
            this.MyListStack.UseVisualStyleBackColor = true;
            // 
            // StackPushButton
            // 
            this.StackPushButton.Location = new System.Drawing.Point(218, 24);
            this.StackPushButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StackPushButton.Name = "StackPushButton";
            this.StackPushButton.Size = new System.Drawing.Size(70, 25);
            this.StackPushButton.TabIndex = 8;
            this.StackPushButton.Text = "> >";
            this.StackPushButton.UseVisualStyleBackColor = true;
            this.StackPushButton.Click += new System.EventHandler(this.StackPushButton_Click);
            // 
            // StackPopButton
            // 
            this.StackPopButton.Location = new System.Drawing.Point(218, 58);
            this.StackPopButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StackPopButton.Name = "StackPopButton";
            this.StackPopButton.Size = new System.Drawing.Size(70, 25);
            this.StackPopButton.TabIndex = 9;
            this.StackPopButton.Text = "< <";
            this.StackPopButton.UseVisualStyleBackColor = true;
            this.StackPopButton.Click += new System.EventHandler(this.StackPopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.StackPopButton);
            this.Controls.Add(this.StackPushButton);
            this.Controls.Add(this.MyListStack);
            this.Controls.Add(this.ArrayStack);
            this.Controls.Add(this.MyStack);
            this.Controls.Add(this.TxtBox2);
            this.Controls.Add(this.TxtBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button StackPushButton;
        private System.Windows.Forms.Button StackPopButton;
    }
}

