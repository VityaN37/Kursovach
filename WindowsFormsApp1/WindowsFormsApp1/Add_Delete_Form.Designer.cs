namespace WindowsFormsApp1
{
    partial class Add_Delete_Form
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
            this.Hat = new System.Windows.Forms.Panel();
            this.Back_button = new System.Windows.Forms.Button();
            this.Electro_Store = new System.Windows.Forms.Label();
            this.Footer = new System.Windows.Forms.Panel();
            this.emeil_2 = new System.Windows.Forms.Label();
            this.Nomber = new System.Windows.Forms.Label();
            this.Add_prod_button = new System.Windows.Forms.Button();
            this.Del_prod_button = new System.Windows.Forms.Button();
            this.Hat.SuspendLayout();
            this.Footer.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hat
            // 
            this.Hat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(152)))), ((int)(((byte)(227)))));
            this.Hat.Controls.Add(this.Back_button);
            this.Hat.Controls.Add(this.Electro_Store);
            this.Hat.Dock = System.Windows.Forms.DockStyle.Top;
            this.Hat.Location = new System.Drawing.Point(0, 0);
            this.Hat.Name = "Hat";
            this.Hat.Size = new System.Drawing.Size(800, 69);
            this.Hat.TabIndex = 3;
            // 
            // Back_button
            // 
            this.Back_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Back_button.Location = new System.Drawing.Point(0, 0);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(75, 23);
            this.Back_button.TabIndex = 7;
            this.Back_button.Text = "Назад";
            this.Back_button.UseVisualStyleBackColor = false;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Electro_Store
            // 
            this.Electro_Store.AllowDrop = true;
            this.Electro_Store.AutoSize = true;
            this.Electro_Store.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Electro_Store.Location = new System.Drawing.Point(287, 9);
            this.Electro_Store.Name = "Electro_Store";
            this.Electro_Store.Size = new System.Drawing.Size(183, 37);
            this.Electro_Store.TabIndex = 0;
            this.Electro_Store.Text = "ЭлектроStore";
            this.Electro_Store.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Footer
            // 
            this.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(152)))), ((int)(((byte)(227)))));
            this.Footer.Controls.Add(this.emeil_2);
            this.Footer.Controls.Add(this.Nomber);
            this.Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Footer.Location = new System.Drawing.Point(0, 373);
            this.Footer.Name = "Footer";
            this.Footer.Size = new System.Drawing.Size(800, 77);
            this.Footer.TabIndex = 4;
            // 
            // emeil_2
            // 
            this.emeil_2.AutoSize = true;
            this.emeil_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emeil_2.Location = new System.Drawing.Point(12, 50);
            this.emeil_2.Name = "emeil_2";
            this.emeil_2.Size = new System.Drawing.Size(388, 18);
            this.emeil_2.TabIndex = 6;
            this.emeil_2.Text = "Адресс электронной почты : vitanecaev373@gmail.com";
            // 
            // Nomber
            // 
            this.Nomber.AutoSize = true;
            this.Nomber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nomber.Location = new System.Drawing.Point(12, 22);
            this.Nomber.Name = "Nomber";
            this.Nomber.Size = new System.Drawing.Size(280, 17);
            this.Nomber.TabIndex = 4;
            this.Nomber.Text = "Телефон тех поддержки : +89677156781";
            // 
            // Add_prod_button
            // 
            this.Add_prod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_prod_button.Location = new System.Drawing.Point(462, 168);
            this.Add_prod_button.Name = "Add_prod_button";
            this.Add_prod_button.Size = new System.Drawing.Size(185, 85);
            this.Add_prod_button.TabIndex = 5;
            this.Add_prod_button.Text = "Добавить товар";
            this.Add_prod_button.UseVisualStyleBackColor = true;
            this.Add_prod_button.Click += new System.EventHandler(this.Add_prod_button_Click);
            // 
            // Del_prod_button
            // 
            this.Del_prod_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Del_prod_button.Location = new System.Drawing.Point(179, 168);
            this.Del_prod_button.Name = "Del_prod_button";
            this.Del_prod_button.Size = new System.Drawing.Size(185, 85);
            this.Del_prod_button.TabIndex = 6;
            this.Del_prod_button.Text = "Удалить товар";
            this.Del_prod_button.UseVisualStyleBackColor = true;
            this.Del_prod_button.Click += new System.EventHandler(this.Del_prod_button_Click);
            // 
            // Add_Delete_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Del_prod_button);
            this.Controls.Add(this.Add_prod_button);
            this.Controls.Add(this.Footer);
            this.Controls.Add(this.Hat);
            this.Name = "Add_Delete_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Delete_Form";
            this.Hat.ResumeLayout(false);
            this.Hat.PerformLayout();
            this.Footer.ResumeLayout(false);
            this.Footer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Hat;
        private System.Windows.Forms.Label Electro_Store;
        private System.Windows.Forms.Panel Footer;
        private System.Windows.Forms.Label Nomber;
        private System.Windows.Forms.Button Add_prod_button;
        private System.Windows.Forms.Button Del_prod_button;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Label emeil_2;
    }
}