namespace NagradaModel1
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
            this.lblPlaceNumber = new System.Windows.Forms.Label();
            this.lblPlaceName = new System.Windows.Forms.Label();
            this.lblPrizeAmount = new System.Windows.Forms.Label();
            this.lblOR = new System.Windows.Forms.Label();
            this.lblPricePercentage = new System.Windows.Forms.Label();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblCreatePrize = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlaceNumber
            // 
            this.lblPlaceNumber.AutoSize = true;
            this.lblPlaceNumber.Location = new System.Drawing.Point(48, 80);
            this.lblPlaceNumber.Name = "lblPlaceNumber";
            this.lblPlaceNumber.Size = new System.Drawing.Size(74, 13);
            this.lblPlaceNumber.TabIndex = 0;
            this.lblPlaceNumber.Text = "Place Number";
            this.lblPlaceNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPlaceName
            // 
            this.lblPlaceName.AutoSize = true;
            this.lblPlaceName.Location = new System.Drawing.Point(48, 134);
            this.lblPlaceName.Name = "lblPlaceName";
            this.lblPlaceName.Size = new System.Drawing.Size(65, 13);
            this.lblPlaceName.TabIndex = 1;
            this.lblPlaceName.Text = "Place Name";
            this.lblPlaceName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPrizeAmount
            // 
            this.lblPrizeAmount.AutoSize = true;
            this.lblPrizeAmount.Location = new System.Drawing.Point(48, 187);
            this.lblPrizeAmount.Name = "lblPrizeAmount";
            this.lblPrizeAmount.Size = new System.Drawing.Size(69, 13);
            this.lblPrizeAmount.TabIndex = 2;
            this.lblPrizeAmount.Text = "Prize Amount";
            this.lblPrizeAmount.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(144, 241);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(35, 13);
            this.lblOR.TabIndex = 3;
            this.lblOR.Text = "- OR -";
            this.lblOR.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblPricePercentage
            // 
            this.lblPricePercentage.AutoSize = true;
            this.lblPricePercentage.Location = new System.Drawing.Point(51, 293);
            this.lblPricePercentage.Name = "lblPricePercentage";
            this.lblPricePercentage.Size = new System.Drawing.Size(89, 13);
            this.lblPricePercentage.TabIndex = 4;
            this.lblPricePercentage.Text = "Price Percentage";
            this.lblPricePercentage.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.Location = new System.Drawing.Point(146, 389);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(123, 23);
            this.btnCreatePrize.TabIndex = 5;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(146, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(146, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 8;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(146, 290);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(141, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // lblCreatePrize
            // 
            this.lblCreatePrize.AutoSize = true;
            this.lblCreatePrize.Location = new System.Drawing.Point(51, 23);
            this.lblCreatePrize.Name = "lblCreatePrize";
            this.lblCreatePrize.Size = new System.Drawing.Size(64, 13);
            this.lblCreatePrize.TabIndex = 10;
            this.lblCreatePrize.Text = "Create Prize";
            this.lblCreatePrize.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 450);
            this.Controls.Add(this.lblCreatePrize);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.lblPricePercentage);
            this.Controls.Add(this.lblOR);
            this.Controls.Add(this.lblPrizeAmount);
            this.Controls.Add(this.lblPlaceName);
            this.Controls.Add(this.lblPlaceNumber);
            this.Name = "Form1";
            this.Text = "Nagrada Model";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlaceNumber;
        private System.Windows.Forms.Label lblPlaceName;
        private System.Windows.Forms.Label lblPrizeAmount;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.Label lblPricePercentage;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblCreatePrize;
    }
}

