using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHscanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string shtml = recognition.Document.Body.InnerHtml;
            textBox1.Text = shtml.Length.ToString();
            
            string sTitle = "";
            int nNum = 0;
            int j = -1;
            for (int i = 4; i < shtml.Length - 5; i++)
            {
                
                if (
                    (shtml[i - 4] == '<') &&
                    (shtml[i - 3] == 'T') &&
                    (shtml[i - 2] == 'R') &&
                    (shtml[i - 1] == '>')

                    )
                {
                    j++;
                    nNum = 0;
                    dataGridView1.RowCount++;
                    
                }
                if (
                (shtml[i - 4] == '<') &&
                (shtml[i - 3] == 'T') &&
                (shtml[i - 2] == 'D') &&
                (shtml[i - 1] == '>')

                )
                {
                    //MessageBox.Show("인덱스" + i);
                    sTitle = "";
                }
                sTitle += shtml[i];



                //끝발견
                if (
                  (shtml[i + 1] == '<') &&
                  (shtml[i + 2] == '/') &&

                  (shtml[i + 3] == 'T') &&
                  (shtml[i + 4] == 'D') &&
                  (shtml[i + 5] == '>')

                  )
                {

                    dataGridView1[nNum, j].Value = sTitle;
                    nNum++;


                    //MessageBox.Show(sTitle);
                }

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyyMMdd");
            string check = "";
            //MessageBox.Show(date);
            
            if (radioButton1.Checked)
            {
               check = "1";
            }
            else
            {
               check = "2";
            }

            recognition.Navigate("http://jjukkh.cafe24.com/scanner/issuelist.php?index="+check + "&date2=" + date);
            dataGridView1.Rows.Clear();
        }
    }
}
