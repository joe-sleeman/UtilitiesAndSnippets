namespace Factorials
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
            this.btnIterative = new System.Windows.Forms.Button();
            this.btnRecursive = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIterative
            // 
            this.btnIterative.Location = new System.Drawing.Point(6, 60);
            this.btnIterative.Name = "btnIterative";
            this.btnIterative.Size = new System.Drawing.Size(75, 23);
            this.btnIterative.TabIndex = 0;
            this.btnIterative.Text = "Iterative";
            this.btnIterative.UseVisualStyleBackColor = true;
            this.btnIterative.Click += new System.EventHandler(this.btnIterative_Click);
            // 
            // btnRecursive
            // 
            this.btnRecursive.Location = new System.Drawing.Point(95, 60);
            this.btnRecursive.Name = "btnRecursive";
            this.btnRecursive.Size = new System.Drawing.Size(75, 23);
            this.btnRecursive.TabIndex = 1;
            this.btnRecursive.Text = "Recursive";
            this.btnRecursive.UseVisualStyleBackColor = true;
            this.btnRecursive.Click += new System.EventHandler(this.btnRecursive_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "lblResult";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnRecursive);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnIterative);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 121);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Factorials";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIterative;
        private System.Windows.Forms.Button btnRecursive;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

