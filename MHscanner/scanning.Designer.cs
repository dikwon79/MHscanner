namespace MHscanner
{
    partial class MHscanning
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtBarcodeLbl = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SKU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.area1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.textBox_html = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mcompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.McenterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mgeorae = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mdates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MCCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scanned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readingtime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palzu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.savepost = new System.Windows.Forms.WebBrowser();
            this.CheckIdleTimer = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.area = new System.Windows.Forms.TextBox();
            this.savingData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingData)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "스캔시작";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(519, 199);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(379, 399);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // txtBarcodeLbl
            // 
            this.txtBarcodeLbl.Location = new System.Drawing.Point(67, 35);
            this.txtBarcodeLbl.Name = "txtBarcodeLbl";
            this.txtBarcodeLbl.Size = new System.Drawing.Size(839, 21);
            this.txtBarcodeLbl.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SKU,
            this.itemName,
            this.time});
            this.dataGridView1.Location = new System.Drawing.Point(10, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(668, 205);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // SKU
            // 
            this.SKU.HeaderText = "바코드";
            this.SKU.Name = "SKU";
            this.SKU.Width = 180;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "품목명";
            this.itemName.Name = "itemName";
            this.itemName.Width = 250;
            // 
            // time
            // 
            this.time.HeaderText = "판독시간";
            this.time.Name = "time";
            this.time.Width = 180;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // area1
            // 
            this.area1.FormattingEnabled = true;
            this.area1.Location = new System.Drawing.Point(226, 9);
            this.area1.Name = "area1";
            this.area1.Size = new System.Drawing.Size(121, 20);
            this.area1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "라벨발행조회";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(586, 285);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(302, 196);
            this.webBrowser1.TabIndex = 8;
            this.webBrowser1.Visible = false;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // textBox_html
            // 
            this.textBox_html.Location = new System.Drawing.Point(651, 267);
            this.textBox_html.Multiline = true;
            this.textBox_html.Name = "textBox_html";
            this.textBox_html.Size = new System.Drawing.Size(200, 116);
            this.textBox_html.TabIndex = 9;
            this.textBox_html.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.barcode,
            this.Mcompany,
            this.McenterName,
            this.itemcode,
            this.dataGridViewTextBoxColumn1,
            this.Mgeorae,
            this.Mdates,
            this.MCCODE,
            this.pid,
            this.state,
            this.scanned,
            this.readingtime,
            this.palzu});
            this.dataGridView2.Location = new System.Drawing.Point(9, 281);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(896, 263);
            this.dataGridView2.TabIndex = 10;
            // 
            // barcode
            // 
            this.barcode.HeaderText = "바코드";
            this.barcode.Name = "barcode";
            // 
            // Mcompany
            // 
            this.Mcompany.HeaderText = "회사명";
            this.Mcompany.Name = "Mcompany";
            this.Mcompany.Width = 80;
            // 
            // McenterName
            // 
            this.McenterName.HeaderText = "센터명";
            this.McenterName.Name = "McenterName";
            this.McenterName.Width = 70;
            // 
            // itemcode
            // 
            this.itemcode.HeaderText = "품목코드";
            this.itemcode.Name = "itemcode";
            this.itemcode.Width = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "품목명";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Mgeorae
            // 
            this.Mgeorae.HeaderText = "거래처명";
            this.Mgeorae.Name = "Mgeorae";
            // 
            // Mdates
            // 
            this.Mdates.HeaderText = "출고일";
            this.Mdates.Name = "Mdates";
            this.Mdates.Width = 60;
            // 
            // MCCODE
            // 
            this.MCCODE.HeaderText = "창고코드";
            this.MCCODE.Name = "MCCODE";
            this.MCCODE.Width = 40;
            // 
            // pid
            // 
            this.pid.HeaderText = "키값";
            this.pid.Name = "pid";
            this.pid.Width = 80;
            // 
            // state
            // 
            this.state.HeaderText = "상태";
            this.state.Name = "state";
            this.state.Width = 50;
            // 
            // scanned
            // 
            this.scanned.HeaderText = "판독유무";
            this.scanned.Name = "scanned";
            this.scanned.Width = 30;
            // 
            // readingtime
            // 
            this.readingtime.HeaderText = "판독시간";
            this.readingtime.Name = "readingtime";
            // 
            // palzu
            // 
            this.palzu.HeaderText = "발주합";
            this.palzu.Name = "palzu";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(817, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 24);
            this.button3.TabIndex = 11;
            this.button3.Text = "관리자모드";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(577, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 24);
            this.button4.TabIndex = 12;
            this.button4.Text = "서버저장";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(355, 111);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(256, 147);
            this.textBox2.TabIndex = 13;
            this.textBox2.Visible = false;
            // 
            // savepost
            // 
            this.savepost.Location = new System.Drawing.Point(12, 111);
            this.savepost.MinimumSize = new System.Drawing.Size(20, 20);
            this.savepost.Name = "savepost";
            this.savepost.Size = new System.Drawing.Size(324, 147);
            this.savepost.TabIndex = 14;
            this.savepost.Visible = false;
            // 
            // CheckIdleTimer
            // 
            this.CheckIdleTimer.Interval = 3000;
            this.CheckIdleTimer.Tick += new System.EventHandler(this.CheckIdleTimer_Tick);
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(617, 111);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(281, 148);
            this.listBox1.TabIndex = 15;
            this.listBox1.Visible = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(353, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(669, 62);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 206);
            this.textBox3.TabIndex = 17;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(672, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 24);
            this.button6.TabIndex = 18;
            this.button6.Text = "미발행조회";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // area
            // 
            this.area.Location = new System.Drawing.Point(10, 35);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(51, 21);
            this.area.TabIndex = 19;
            // 
            // savingData
            // 
            this.savingData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.savingData.Location = new System.Drawing.Point(672, 111);
            this.savingData.Name = "savingData";
            this.savingData.RowTemplate.Height = 23;
            this.savingData.Size = new System.Drawing.Size(233, 157);
            this.savingData.TabIndex = 20;
            // 
            // MHscanning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 548);
            this.Controls.Add(this.savingData);
            this.Controls.Add(this.area);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.savepost);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox_html);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.area1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBarcodeLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(930, 587);
            this.MinimumSize = new System.Drawing.Size(930, 587);
            this.Name = "MHscanning";
            this.Text = "명현 스캐너(준비중)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.savingData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtBarcodeLbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox area1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox textBox_html;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.WebBrowser savepost;
        private System.Windows.Forms.Timer CheckIdleTimer;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mcompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn McenterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mgeorae;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mdates;
        private System.Windows.Forms.DataGridViewTextBoxColumn MCCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn pid;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn scanned;
        private System.Windows.Forms.DataGridViewTextBoxColumn readingtime;
        private System.Windows.Forms.DataGridViewTextBoxColumn palzu;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKU;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox area;
        private System.Windows.Forms.DataGridView savingData;
    }
}

