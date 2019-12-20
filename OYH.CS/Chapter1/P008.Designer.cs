namespace OYH.CS.Chapter1
{
    partial class P008
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
            this.button1 = new System.Windows.Forms.Button();
            this.tb_COUNT = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_PRICE = new System.Windows.Forms.TextBox();
            this.tb_NAME = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 41;
            this.button1.Text = "등록";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tb_COUNT
            // 
            this.tb_COUNT.Location = new System.Drawing.Point(248, 180);
            this.tb_COUNT.Name = "tb_COUNT";
            this.tb_COUNT.Size = new System.Drawing.Size(158, 21);
            this.tb_COUNT.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 39;
            this.label4.Text = "물품명";
            // 
            // tb_PRICE
            // 
            this.tb_PRICE.Location = new System.Drawing.Point(248, 251);
            this.tb_PRICE.Name = "tb_PRICE";
            this.tb_PRICE.Size = new System.Drawing.Size(158, 21);
            this.tb_PRICE.TabIndex = 36;
            // 
            // tb_NAME
            // 
            this.tb_NAME.Location = new System.Drawing.Point(248, 117);
            this.tb_NAME.Name = "tb_NAME";
            this.tb_NAME.Size = new System.Drawing.Size(158, 21);
            this.tb_NAME.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "가격";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "수량";
            // 
            // P008
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_COUNT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_PRICE);
            this.Controls.Add(this.tb_NAME);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "P008";
            this.Text = "P008";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_COUNT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_PRICE;
        private System.Windows.Forms.TextBox tb_NAME;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}