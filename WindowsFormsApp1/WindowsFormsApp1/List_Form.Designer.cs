namespace WindowsFormsApp1
{
    partial class List_Form
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
            this.Back_button_List = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.text_boxsearch = new System.Windows.Forms.TextBox();
            this.button1_search = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_button_List
            // 
            this.Back_button_List.Location = new System.Drawing.Point(12, 12);
            this.Back_button_List.Name = "Back_button_List";
            this.Back_button_List.Size = new System.Drawing.Size(75, 23);
            this.Back_button_List.TabIndex = 9;
            this.Back_button_List.Text = "Назад";
            this.Back_button_List.UseVisualStyleBackColor = true;
            this.Back_button_List.Click += new System.EventHandler(this.Back_button_List_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 355);
            this.dataGridView1.TabIndex = 10;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // text_boxsearch
            // 
            this.text_boxsearch.Location = new System.Drawing.Point(400, 15);
            this.text_boxsearch.Name = "text_boxsearch";
            this.text_boxsearch.Size = new System.Drawing.Size(229, 20);
            this.text_boxsearch.TabIndex = 12;
            // 
            // button1_search
            // 
            this.button1_search.Location = new System.Drawing.Point(644, 15);
            this.button1_search.Name = "button1_search";
            this.button1_search.Size = new System.Drawing.Size(75, 23);
            this.button1_search.TabIndex = 13;
            this.button1_search.Text = "Поиск";
            this.button1_search.UseVisualStyleBackColor = true;
            this.button1_search.Click += new System.EventHandler(this.button1_search_Click);
            // 
            // List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1_search);
            this.Controls.Add(this.text_boxsearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Back_button_List);
            this.Name = "List_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_button_List;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox text_boxsearch;
        private System.Windows.Forms.Button button1_search;
    }
}