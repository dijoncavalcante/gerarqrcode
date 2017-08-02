namespace vw_GerarQRCode
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncode = new System.Windows.Forms.TextBox();
            this.txtDecode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.checkBoxOpcao1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOpcao2 = new System.Windows.Forms.CheckBox();
            this.checkBoxOpcao3 = new System.Windows.Forms.CheckBox();
            this.checkBoxOpcao6 = new System.Windows.Forms.CheckBox();
            this.checkBoxOpcao5 = new System.Windows.Forms.CheckBox();
            this.checkBoxOpcao4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(22, 83);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(369, 227);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(670, 119);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 1;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(407, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Valor:";
            // 
            // txtEncode
            // 
            this.txtEncode.Location = new System.Drawing.Point(447, 84);
            this.txtEncode.Name = "txtEncode";
            this.txtEncode.Size = new System.Drawing.Size(298, 20);
            this.txtEncode.TabIndex = 3;
            // 
            // txtDecode
            // 
            this.txtDecode.Location = new System.Drawing.Point(447, 163);
            this.txtDecode.Name = "txtDecode";
            this.txtDecode.Size = new System.Drawing.Size(298, 20);
            this.txtDecode.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor:";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(670, 198);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 4;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // checkBoxOpcao1
            // 
            this.checkBoxOpcao1.AutoSize = true;
            this.checkBoxOpcao1.Location = new System.Drawing.Point(22, 12);
            this.checkBoxOpcao1.Name = "checkBoxOpcao1";
            this.checkBoxOpcao1.Size = new System.Drawing.Size(80, 17);
            this.checkBoxOpcao1.TabIndex = 8;
            this.checkBoxOpcao1.Text = "checkBox1";
            this.checkBoxOpcao1.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpcao2
            // 
            this.checkBoxOpcao2.AutoSize = true;
            this.checkBoxOpcao2.Location = new System.Drawing.Point(22, 36);
            this.checkBoxOpcao2.Name = "checkBoxOpcao2";
            this.checkBoxOpcao2.Size = new System.Drawing.Size(80, 17);
            this.checkBoxOpcao2.TabIndex = 9;
            this.checkBoxOpcao2.Text = "checkBox2";
            this.checkBoxOpcao2.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpcao3
            // 
            this.checkBoxOpcao3.AutoSize = true;
            this.checkBoxOpcao3.Location = new System.Drawing.Point(22, 59);
            this.checkBoxOpcao3.Name = "checkBoxOpcao3";
            this.checkBoxOpcao3.Size = new System.Drawing.Size(80, 17);
            this.checkBoxOpcao3.TabIndex = 10;
            this.checkBoxOpcao3.Text = "checkBox3";
            this.checkBoxOpcao3.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpcao6
            // 
            this.checkBoxOpcao6.AutoSize = true;
            this.checkBoxOpcao6.Location = new System.Drawing.Point(217, 59);
            this.checkBoxOpcao6.Name = "checkBoxOpcao6";
            this.checkBoxOpcao6.Size = new System.Drawing.Size(80, 17);
            this.checkBoxOpcao6.TabIndex = 13;
            this.checkBoxOpcao6.Text = "checkBox4";
            this.checkBoxOpcao6.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpcao5
            // 
            this.checkBoxOpcao5.AutoSize = true;
            this.checkBoxOpcao5.Location = new System.Drawing.Point(217, 36);
            this.checkBoxOpcao5.Name = "checkBoxOpcao5";
            this.checkBoxOpcao5.Size = new System.Drawing.Size(80, 17);
            this.checkBoxOpcao5.TabIndex = 12;
            this.checkBoxOpcao5.Text = "checkBox5";
            this.checkBoxOpcao5.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpcao4
            // 
            this.checkBoxOpcao4.AutoSize = true;
            this.checkBoxOpcao4.Location = new System.Drawing.Point(217, 12);
            this.checkBoxOpcao4.Name = "checkBoxOpcao4";
            this.checkBoxOpcao4.Size = new System.Drawing.Size(80, 17);
            this.checkBoxOpcao4.TabIndex = 11;
            this.checkBoxOpcao4.Text = "checkBox6";
            this.checkBoxOpcao4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 333);
            this.Controls.Add(this.checkBoxOpcao6);
            this.Controls.Add(this.checkBoxOpcao5);
            this.Controls.Add(this.checkBoxOpcao4);
            this.Controls.Add(this.checkBoxOpcao3);
            this.Controls.Add(this.checkBoxOpcao2);
            this.Controls.Add(this.checkBoxOpcao1);
            this.Controls.Add(this.txtDecode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtEncode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Gerar QRCode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEncode;
        private System.Windows.Forms.TextBox txtDecode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.CheckBox checkBoxOpcao1;
        private System.Windows.Forms.CheckBox checkBoxOpcao2;
        private System.Windows.Forms.CheckBox checkBoxOpcao3;
        private System.Windows.Forms.CheckBox checkBoxOpcao6;
        private System.Windows.Forms.CheckBox checkBoxOpcao5;
        private System.Windows.Forms.CheckBox checkBoxOpcao4;
    }
}

