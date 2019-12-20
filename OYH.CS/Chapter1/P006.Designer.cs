namespace OYH.CS.Chapter1
{
    partial class P006
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
            this.tb_AGE = new System.Windows.Forms.TextBox();
            this.tb_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_SEX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_NUMBER = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_AGE
            // 
            this.tb_AGE.Location = new System.Drawing.Point(89, 193);
            this.tb_AGE.Name = "tb_AGE";
            this.tb_AGE.Size = new System.Drawing.Size(158, 21);
            this.tb_AGE.TabIndex = 27;
            // 
            // tb_NAME
            // 
            this.tb_NAME.Location = new System.Drawing.Point(89, 128);
            this.tb_NAME.Name = "tb_NAME";
            this.tb_NAME.Size = new System.Drawing.Size(158, 21);
            this.tb_NAME.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "나이";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "이름";
            // 
            // tb_SEX
            // 
            this.tb_SEX.Location = new System.Drawing.Point(89, 257);
            this.tb_SEX.Name = "tb_SEX";
            this.tb_SEX.Size = new System.Drawing.Size(158, 21);
            this.tb_SEX.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 28;
            this.label3.Text = "성별";
            // 
            // tb_NUMBER
            // 
            this.tb_NUMBER.Location = new System.Drawing.Point(89, 56);
            this.tb_NUMBER.Name = "tb_NUMBER";
            this.tb_NUMBER.Size = new System.Drawing.Size(158, 21);
            this.tb_NUMBER.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 30;
            this.label4.Text = "학번";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // P006
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_NUMBER);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_SEX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_AGE);
            this.Controls.Add(this.tb_NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "P006";
            this.Text = "P006";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_AGE;
        private System.Windows.Forms.TextBox tb_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_SEX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_NUMBER;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}