namespace DotNetAssignmentAndLearning
{
    partial class des
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
            this.fromNumberSystem = new System.Windows.Forms.ComboBox();
            this.toNumberSystem = new System.Windows.Forms.ComboBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fromNumberSystem
            // 
            this.fromNumberSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromNumberSystem.FormattingEnabled = true;
            this.fromNumberSystem.Location = new System.Drawing.Point(112, 188);
            this.fromNumberSystem.Name = "fromNumberSystem";
            this.fromNumberSystem.Size = new System.Drawing.Size(121, 21);
            this.fromNumberSystem.TabIndex = 2;
            this.fromNumberSystem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toNumberSystem
            // 
            this.toNumberSystem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toNumberSystem.FormattingEnabled = true;
            this.toNumberSystem.Location = new System.Drawing.Point(282, 188);
            this.toNumberSystem.Name = "toNumberSystem";
            this.toNumberSystem.Size = new System.Drawing.Size(121, 21);
            this.toNumberSystem.TabIndex = 3;
            this.toNumberSystem.SelectedIndexChanged += new System.EventHandler(this.toNumberSystem_SelectedIndexChanged);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(112, 301);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(121, 20);
            this.inputTextBox.TabIndex = 4;
            this.inputTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Enabled = false;
            this.outputTextBox.Location = new System.Drawing.Point(282, 301);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(121, 20);
            this.outputTextBox.TabIndex = 5;
            this.outputTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Jitendra Sahu\'s Number System Conversion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "From Number System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "To Number System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter value to be coverted";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Coverted value";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(433, 170);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 147);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(430, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Error Box";
            // 
            // des
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.toNumberSystem);
            this.Controls.Add(this.fromNumberSystem);
            this.Name = "des";
            this.Text = "numberSystemConv";
            this.Load += new System.EventHandler(this.des_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox fromNumberSystem;
        private System.Windows.Forms.ComboBox toNumberSystem;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label6;
    }
}