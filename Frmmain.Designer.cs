﻿namespace cshape_Login
{
    partial class Frmmain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnhapso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lsb = new System.Windows.Forms.ListBox();
            this.btntinh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tính Bội Số Ước Số";
            // 
            // txtnhapso
            // 
            this.txtnhapso.Location = new System.Drawing.Point(365, 126);
            this.txtnhapso.Name = "txtnhapso";
            this.txtnhapso.Size = new System.Drawing.Size(100, 20);
            this.txtnhapso.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ước";
            // 
            // lsb
            // 
            this.lsb.FormattingEnabled = true;
            this.lsb.Location = new System.Drawing.Point(353, 268);
            this.lsb.Name = "lsb";
            this.lsb.Size = new System.Drawing.Size(120, 95);
            this.lsb.TabIndex = 6;
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(374, 200);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 7;
            this.btntinh.Text = "tính ";
            this.btntinh.UseVisualStyleBackColor = true;
            // 
            // Frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.lsb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnhapso);
            this.Controls.Add(this.label1);
            this.Name = "Frmmain";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnhapso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lsb;
        private System.Windows.Forms.Button btntinh;
    }
}