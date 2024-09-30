namespace Calulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtValue1 = new TextBox();
            txtValue2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            txtresult = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 72);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 0;
            label1.Text = "Value 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 97);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Value 2";
            // 
            // txtValue1
            // 
            txtValue1.Location = new Point(229, 66);
            txtValue1.Name = "txtValue1";
            txtValue1.Size = new Size(211, 23);
            txtValue1.TabIndex = 2;
            // 
            // txtValue2
            // 
            txtValue2.Location = new Point(229, 97);
            txtValue2.Name = "txtValue2";
            txtValue2.Size = new Size(211, 23);
            txtValue2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(121, 158);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(425, 158);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Div";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(321, 158);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 6;
            button3.Text = "Mul";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(216, 158);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 7;
            button4.Text = "Sub";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtresult
            // 
            txtresult.Location = new Point(229, 223);
            txtresult.Name = "txtresult";
            txtresult.Size = new Size(211, 23);
            txtresult.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 231);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(txtresult);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtValue2);
            Controls.Add(txtValue1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtValue1;
        private TextBox txtValue2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox txtresult;
        private Label label3;
    }
}
