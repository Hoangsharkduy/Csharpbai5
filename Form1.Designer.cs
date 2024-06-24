namespace Csharpbai5
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.txtnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbold = new System.Windows.Forms.CheckBox();
            this.chkitalic = new System.Windows.Forms.CheckBox();
            this.chkgc = new System.Windows.Forms.CheckBox();
            this.grb2 = new System.Windows.Forms.GroupBox();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.radblack = new System.Windows.Forms.RadioButton();
            this.radred = new System.Windows.Forms.RadioButton();
            this.radblue = new System.Windows.Forms.RadioButton();
            this.radgreen = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbllt = new System.Windows.Forms.Label();
            this.grb2.SuspendLayout();
            this.grb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(242, 313);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(106, 64);
            this.btnthoat.TabIndex = 0;
            this.btnthoat.Text = "thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txtnt
            // 
            this.txtnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtnt.Location = new System.Drawing.Point(152, 68);
            this.txtnt.Name = "txtnt";
            this.txtnt.Size = new System.Drawing.Size(311, 38);
            this.txtnt.TabIndex = 1;
            this.txtnt.TextChanged += new System.EventHandler(this.txtnt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Tên";
            // 
            // chkbold
            // 
            this.chkbold.AutoSize = true;
            this.chkbold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbold.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkbold.Location = new System.Drawing.Point(6, 29);
            this.chkbold.Name = "chkbold";
            this.chkbold.Size = new System.Drawing.Size(79, 17);
            this.chkbold.TabIndex = 3;
            this.chkbold.Text = "Đậm boki";
            this.chkbold.UseVisualStyleBackColor = true;
            // 
            // chkitalic
            // 
            this.chkitalic.AutoSize = true;
            this.chkitalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkitalic.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkitalic.Location = new System.Drawing.Point(6, 70);
            this.chkitalic.Name = "chkitalic";
            this.chkitalic.Size = new System.Drawing.Size(105, 17);
            this.chkitalic.TabIndex = 4;
            this.chkitalic.Text = "Nghiêng Italic";
            this.chkitalic.UseVisualStyleBackColor = true;
            // 
            // chkgc
            // 
            this.chkgc.AutoSize = true;
            this.chkgc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkgc.ForeColor = System.Drawing.Color.DarkBlue;
            this.chkgc.Location = new System.Drawing.Point(6, 114);
            this.chkgc.Name = "chkgc";
            this.chkgc.Size = new System.Drawing.Size(89, 17);
            this.chkgc.TabIndex = 5;
            this.chkgc.Text = "Gạch Chân";
            this.chkgc.UseVisualStyleBackColor = true;
            // 
            // grb2
            // 
            this.grb2.BackColor = System.Drawing.Color.PeachPuff;
            this.grb2.Controls.Add(this.chkbold);
            this.grb2.Controls.Add(this.chkgc);
            this.grb2.Controls.Add(this.chkitalic);
            this.grb2.Location = new System.Drawing.Point(295, 124);
            this.grb2.Name = "grb2";
            this.grb2.Size = new System.Drawing.Size(167, 183);
            this.grb2.TabIndex = 6;
            this.grb2.TabStop = false;
            this.grb2.Text = "Font";
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grb1.Controls.Add(this.radblack);
            this.grb1.Controls.Add(this.radred);
            this.grb1.Controls.Add(this.radblue);
            this.grb1.Controls.Add(this.radgreen);
            this.grb1.Location = new System.Drawing.Point(12, 124);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(186, 183);
            this.grb1.TabIndex = 7;
            this.grb1.TabStop = false;
            this.grb1.Text = "Font";
            this.grb1.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // radblack
            // 
            this.radblack.AutoSize = true;
            this.radblack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblack.Location = new System.Drawing.Point(32, 150);
            this.radblack.Name = "radblack";
            this.radblack.Size = new System.Drawing.Size(57, 17);
            this.radblack.TabIndex = 11;
            this.radblack.TabStop = true;
            this.radblack.Text = "Black";
            this.radblack.UseVisualStyleBackColor = true;
            this.radblack.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radred
            // 
            this.radred.AutoSize = true;
            this.radred.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radred.ForeColor = System.Drawing.Color.Red;
            this.radred.Location = new System.Drawing.Point(32, 28);
            this.radred.Name = "radred";
            this.radred.Size = new System.Drawing.Size(48, 17);
            this.radred.TabIndex = 8;
            this.radred.TabStop = true;
            this.radred.Text = "Red";
            this.radred.UseVisualStyleBackColor = true;
            // 
            // radblue
            // 
            this.radblue.AutoSize = true;
            this.radblue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radblue.ForeColor = System.Drawing.Color.Blue;
            this.radblue.Location = new System.Drawing.Point(32, 113);
            this.radblue.Name = "radblue";
            this.radblue.Size = new System.Drawing.Size(50, 17);
            this.radblue.TabIndex = 10;
            this.radblue.TabStop = true;
            this.radblue.Text = "Blue";
            this.radblue.UseVisualStyleBackColor = true;
            // 
            // radgreen
            // 
            this.radgreen.AutoSize = true;
            this.radgreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radgreen.ForeColor = System.Drawing.Color.Green;
            this.radgreen.Location = new System.Drawing.Point(32, 69);
            this.radgreen.Name = "radgreen";
            this.radgreen.Size = new System.Drawing.Size(59, 17);
            this.radgreen.TabIndex = 9;
            this.radgreen.TabStop = true;
            this.radgreen.Text = "Green";
            this.radgreen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(7, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lập Trình Bởi:";
            // 
            // lbllt
            // 
            this.lbllt.AutoSize = true;
            this.lbllt.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbllt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllt.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbllt.Location = new System.Drawing.Point(146, 326);
            this.lbllt.Name = "lbllt";
            this.lbllt.Size = new System.Drawing.Size(90, 31);
            this.lbllt.TabIndex = 9;
            this.lbllt.Text = "Shark";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 668);
            this.Controls.Add(this.lbllt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.grb2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnt);
            this.Controls.Add(this.btnthoat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grb2.ResumeLayout(false);
            this.grb2.PerformLayout();
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.TextBox txtnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbold;
        private System.Windows.Forms.CheckBox chkitalic;
        private System.Windows.Forms.CheckBox chkgc;
        private System.Windows.Forms.GroupBox grb2;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.RadioButton radred;
        private System.Windows.Forms.RadioButton radgreen;
        private System.Windows.Forms.RadioButton radblue;
        private System.Windows.Forms.RadioButton radblack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbllt;
    }
}

