namespace WindowsFormsApp1
{
    partial class Delete_Form
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
            this.Back_button = new System.Windows.Forms.Button();
            this.delete_button1 = new System.Windows.Forms.Button();
            this.Id_seler_label1 = new System.Windows.Forms.Label();
            this.Id_label3 = new System.Windows.Forms.Label();
            this.Id_Seller_textBox1 = new System.Windows.Forms.TextBox();
            this.Id_pr_textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(12, 29);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 8;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // delete_button1
            // 
            this.delete_button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_button1.Location = new System.Drawing.Point(390, 186);
            this.delete_button1.Name = "delete_button1";
            this.delete_button1.Size = new System.Drawing.Size(143, 47);
            this.delete_button1.TabIndex = 9;
            this.delete_button1.Text = "Удалить товар";
            this.delete_button1.UseVisualStyleBackColor = true;
            this.delete_button1.Click += new System.EventHandler(this.delete_button1_Click);
            // 
            // Id_seler_label1
            // 
            this.Id_seler_label1.AutoSize = true;
            this.Id_seler_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Id_seler_label1.Location = new System.Drawing.Point(60, 167);
            this.Id_seler_label1.Name = "Id_seler_label1";
            this.Id_seler_label1.Size = new System.Drawing.Size(107, 20);
            this.Id_seler_label1.TabIndex = 10;
            this.Id_seler_label1.Text = "ID Продавца";
            // 
            // Id_label3
            // 
            this.Id_label3.AutoSize = true;
            this.Id_label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Id_label3.Location = new System.Drawing.Point(86, 229);
            this.Id_label3.Name = "Id_label3";
            this.Id_label3.Size = new System.Drawing.Size(81, 20);
            this.Id_label3.TabIndex = 12;
            this.Id_label3.Text = "Id товара";
            // 
            // Id_Seller_textBox1
            // 
            this.Id_Seller_textBox1.Location = new System.Drawing.Point(179, 167);
            this.Id_Seller_textBox1.Name = "Id_Seller_textBox1";
            this.Id_Seller_textBox1.Size = new System.Drawing.Size(100, 20);
            this.Id_Seller_textBox1.TabIndex = 15;
            // 
            // Id_pr_textBox2
            // 
            this.Id_pr_textBox2.Location = new System.Drawing.Point(179, 231);
            this.Id_pr_textBox2.Name = "Id_pr_textBox2";
            this.Id_pr_textBox2.Size = new System.Drawing.Size(100, 20);
            this.Id_pr_textBox2.TabIndex = 16;
            // 
            // Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Id_pr_textBox2);
            this.Controls.Add(this.Id_Seller_textBox1);
            this.Controls.Add(this.Id_label3);
            this.Controls.Add(this.Id_seler_label1);
            this.Controls.Add(this.delete_button1);
            this.Controls.Add(this.Back_button);
            this.Name = "Delete_Form";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button delete_button1;
        private System.Windows.Forms.Label Id_seler_label1;
        private System.Windows.Forms.Label Id_label3;
        private System.Windows.Forms.TextBox Id_Seller_textBox1;
        private System.Windows.Forms.TextBox Id_pr_textBox2;
    }
}