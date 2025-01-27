namespace MHscanner
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mchasu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.centerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mgeorae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.recognition = new System.Windows.Forms.WebBrowser();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company,
            this.Mchasu,
            this.centerName,
            this.itemName,
            this.Mgeorae});
            this.dataGridView1.Location = new System.Drawing.Point(14, 60);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(866, 488);
            this.dataGridView1.TabIndex = 0;
            // 
            // company
            // 
            this.company.HeaderText = "회사명";
            this.company.MinimumWidth = 6;
            this.company.Name = "company";
            this.company.Width = 125;
            // 
            // Mchasu
            // 
            this.Mchasu.HeaderText = "차수";
            this.Mchasu.MinimumWidth = 6;
            this.Mchasu.Name = "Mchasu";
            this.Mchasu.Width = 80;
            // 
            // centerName
            // 
            this.centerName.HeaderText = "센터명";
            this.centerName.MinimumWidth = 6;
            this.centerName.Name = "centerName";
            this.centerName.Width = 125;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "상품명";
            this.itemName.MinimumWidth = 6;
            this.itemName.Name = "itemName";
            this.itemName.Width = 200;
            // 
            // Mgeorae
            // 
            this.Mgeorae.HeaderText = "거래처명";
            this.Mgeorae.MinimumWidth = 6;
            this.Mgeorae.Name = "Mgeorae";
            this.Mgeorae.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(14, 15);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(228, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(278, 19);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 19);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "냉동제외";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(379, 19);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "냉동포함";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // recognition
            // 
            this.recognition.Location = new System.Drawing.Point(616, 481);
            this.recognition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recognition.MinimumSize = new System.Drawing.Size(23, 25);
            this.recognition.Name = "recognition";
            this.recognition.Size = new System.Drawing.Size(264, 66);
            this.recognition.TabIndex = 5;
            this.recognition.Visible = false;
            this.recognition.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(660, 15);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 25);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 562);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.recognition);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.WebBrowser recognition;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mchasu;
        private System.Windows.Forms.DataGridViewTextBoxColumn centerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mgeorae;
    }
}