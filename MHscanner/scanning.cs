using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Threading;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using CoreScanner;
using System.Net;
using System.Collections;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using Win32_API;

namespace MHscanner
{


    public partial class MHscanning : Form
    {
        [DllImport("KERNEL32.DLL")]
        extern public static void Beep(int freq, int dur);
        CCoreScannerClass m_pCoreScanner;

        public MHscanning()
        {
            InitializeComponent();
        }
     
        void OnBarcodeEvent(short eventType, ref string pscanData)
        {
            string barcode = pscanData;

            this.Invoke((MethodInvoker)delegate {
                textBox1.Clear();
                textBox1.Text = barcode;

               
            });
            ShowBarcodeLabel(pscanData);
        }
        private void ErrorMessage(string value)
        {
            System.Media.SystemSounds.Exclamation.Play();

            string message = value+"라벨입니다.확인하여주세요?";
            string caption = value+"라벨";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(this, message, caption, buttons);
            if (result == DialogResult.Yes)
            {

                // Closes the parent form.
                //this.Close();

            }
        }
        private void ErrorMessage2(string value)
        {
            System.Media.SystemSounds.Exclamation.Play();

            string message = value;
            string caption = value + "에러";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(this, message, caption, buttons);
            if (result == DialogResult.Yes)
            {

                // Closes the parent form.
                //this.Close();

            }
        }
        private void ShowBarcodeLabel(string strXml)
        {
            System.Diagnostics.Debug.WriteLine("Initial XML" + strXml);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(strXml);

            string strData = String.Empty;
            string barcode = xmlDoc.DocumentElement.GetElementsByTagName("datalabel").Item(0).InnerText;
            string symbology = xmlDoc.DocumentElement.GetElementsByTagName("datatype").Item(0).InnerText;
            string[] numbers = barcode.Split(' ');
            string Date1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string name = String.Empty;
            foreach (string number in numbers)
            {

                if (String.IsNullOrEmpty(number))
                {
                    break;
                }

                strData += ((char)Convert.ToInt32(number, 16)).ToString();
            }

            if (txtBarcodeLbl.InvokeRequired)
            {
                txtBarcodeLbl.Invoke(new MethodInvoker(delegate
                {
                    txtBarcodeLbl.Clear();
                    txtBarcodeLbl.Text = strData;


                    if (txtBarcodeLbl.Text.Trim() == "11111111111111111111")
                    {
                        button4_Click(this.button4, null);
                        return;
                    }
                    else if (txtBarcodeLbl.Text.Trim() == "22222222222222222222")
                    {
                        button2_Click(this.button2, null);
                        return;
                    }
                    //dataGridView1.Rows.Add(strData, '0', Date1);
                    //비교하여 값 가져오기 
                    int rows = dataGridView2.Rows.Count;
                    
                    string barcode2 = txtBarcodeLbl.Text.Trim();
                    bool star1 = false; //상태 * 여부
                    bool star2 = false; //증가 감소 신 여부
                    bool labelCheck = false;
                    String strFolder = System.IO.Directory.GetCurrentDirectory();
                    for (int i = 0; i < rows-1; i++)
                    {
 
                        string barcodeValue = Convert.ToString(dataGridView2.Rows[i].Cells[0].Value).Trim();
                        string labelyesno = Convert.ToString(dataGridView2.Rows[i].Cells[9].Value).Trim();
                        //바코드 18자리 이하는 에러 만든다. 제어
                        if (barcode2.Length < 19)
                        {
                            AutoClosingMessageBox.Show("바코드가 CJ라벨길이가 아닙니다.", "라벨", 1000);
                            return;
                        }

                        string cowork = barcodeValue.Substring(0,18);
                        string bowork2 = barcode2.Substring(0, 18);
                        string value = Convert.ToString(dataGridView2.Rows[i].Cells[12].Value);

                        if (cowork== bowork2)
                        {
                            if (labelyesno=="*취소")
                            {
                                AutoClosingMessageBox.Show("취소라벨입니다.", "취소", 1000);

                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\cancel.wav");
                                player.Play();
                                return;
                            }
                            if  (labelyesno.IndexOf('*')==0)
                            {
                                star1 = true;
                            }
                            if (labelyesno.IndexOf('신')>0)
                            {
                                star2 = true;
                            }
                            

                        }
                     
                        if (barcode2 == barcodeValue)
                        {
                            string scanned = Convert.ToString(dataGridView2.Rows[i].Cells[10].Value);
                           
                            labelCheck = true;

                            //취소라벨 찾기(신규)

                            if ((star1 == true) && (star2 == true))
                            {
                                Beep(640, 300);
                                AutoClosingMessageBox.Show("증가감소로인한 취소라벨입니다.", "취소", 1000);
                               
                                System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\cancel.wav");
                                player.Play();
                                textBox3.AppendText("증가감소로인한 취소라벨입니다. : " + Date1 + Environment.NewLine);

                                break;
                            }
                            else if ((labelyesno.IndexOf("*감소") == 0) && (value.Trim() == "0"))

                            {

                                //Beep(512, 300); // 도 0.3초
                                // Beep(640, 300); // 미 0.3초
                                    Beep(640, 300);
                                    AutoClosingMessageBox.Show("감소로인한 취소라벨입니다.", "취소", 1000);
                                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\cancel.wav");
                                    player.Play();
                                    textBox3.AppendText("감소로인한 취소라벨입니다. : " + Date1 + Environment.NewLine);
                                    return;
                                
                            }
                            else
                            {
                                //판독란에 O가 있을 경우에 중복 메세지 표기 

                                if ((scanned.Trim() == "O") || (scanned.Trim() == "C"))
                                {

                                    Beep(640, 300);
                                    AutoClosingMessageBox.Show("중복라벨입니다 확인하세요.", "중복라벨", 1000);
                                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\duplicate.wav");
                                    player.Play();
                                    textBox3.AppendText("중복라벨입니다 확인하세요. : " + Date1 + Environment.NewLine);
                                    break;
                                }
                               

                            }

                            name = Convert.ToString(dataGridView2.Rows[i].Cells[4].Value);
                            dataGridView1.Rows.Add(strData, name, Date1);

                            // 바코드 인식 찍는 센터가 바뀌면 메세지 음성출력을 해준다........
                            if (area.Text.Trim() != Convert.ToString(dataGridView2.Rows[i].Cells[2].Value).Substring(0, 2))
                            {
                                area.Text = Convert.ToString(dataGridView2.Rows[i].Cells[2].Value).Substring(0, 2);
                               


                                if (area.Text == "양산")
                                {
                                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\yangsan.wav");
                                    player.Play();
                                }
                                else if (area.Text == "제주")
                                {
                                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\jeju.wav");
                                    player.Play();
                                }
                                else if (area.Text == "대구")
                                {
                                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\daegu.wav");
                                    player.Play();
                                }
                                else if (area.Text == "장성")
                                {
                                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\jangsung.wav");
                                    player.Play();
                                }

                            }

                            
                            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                            dataGridView2[10, i].Value = 'O';
                            dataGridView2[11, i].Value = Date1;

                            //저장 그리드에 옮긴다..
                            savingData[0, savingData.RowCount - 1].Value = '0';
                            savingData[1, savingData.RowCount - 1].Value = Date1;


                            break;
                            

                        }
                          
                    }
                    if (labelCheck==false)
                    {
                        Beep(640, 1000);
                        AutoClosingMessageBox.Show("미발행 라벨입니다", "미발행", 1000);
                        System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\unpublish.wav");
                        player.Play();
                        textBox3.AppendText("미발행 라벨입니다 : " + Date1 +Environment.NewLine);
                        Thread.Sleep(2000);
                       
                        Beep(640, 1000);
                        //서버저장중
                        button4_Click(this.button4, null);
                        player = new System.Media.SoundPlayer(strFolder + "\\sound\\saving.wav");
                        player.Play();

                        Thread.Sleep(2000);
                        Beep(640, 1000);

                        player = new System.Media.SoundPlayer(strFolder + "\\sound\\labelpublish.wav");
                        player.Play();


                        //this.button4.PerformClick();


                        /*
                        Beep(640, 1000);
                        player = new System.Media.SoundPlayer(strFolder + "\\sound\\searching.wav");
                        player.Play();
                        Thread.Sleep(2000);
                        button2_Click(this.button2, null);
                        */

                    }


                }));
            }

           
        }

        /// <summary>
        /// BarcodeEvent received
        private void button1_Click(object sender, EventArgs e)
        {

            //CheckIdleTimer.Start();  //자동 저장하기....기능.... 
            
            string test = Convert.ToString(dataGridView2.Rows[0].Cells[0].Value);
            if (test=="")
            {
                ErrorMessage2("라벨발행조회를 눌러주세요");
                return;
            }

            try
            {
                
                //Instantiate CoreScanner Class
                this.Text = "명현스캐너(스캔가능)";
                m_pCoreScanner = new CCoreScannerClass();
                //Call Open API
                short[] scannerTypes = new short[1];//Scanner Types you are interested in
                scannerTypes[0] = 1; // 1 for all scanner types
                short numberOfScannerTypes = 1; // Size of the scannerTypes array
                int status; // Extended API return code
                m_pCoreScanner.Open(0, scannerTypes, numberOfScannerTypes, out status);
                // Subscribe for barcode events in cCoreScannerClass
                m_pCoreScanner.BarcodeEvent += new
                _ICoreScannerEvents_BarcodeEventEventHandler(OnBarcodeEvent);
                // Let's subscribe for events
                int opcode = 1001; // Method for Subscribe events
                string outXML; // XML Output

                string inXML = "<inArgs>" +
                "<cmdArgs>" +
                "<arg-int>1</arg-int>" + // Number of events you want to subscribe
                "<arg-int>1</arg-int>" + // Comma separated event IDs
                "</cmdArgs>" +
                "</inArgs>";
                m_pCoreScanner.ExecCommand(opcode, ref inXML, out outXML, out status);
                Console.WriteLine(outXML);
            }
            catch (Exception exp)
            {
                Console.WriteLine("Something wrong please check... " + exp.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Value.ToString("yyyyMMdd");
            //MessageBox.Show(date);
            webBrowser1.Navigate("http://jjukkh.cafe24.com/scanner/labelInfo.php?index=" + area1.SelectedIndex+"&date2="+date);
            dataGridView2.Rows.Clear();
            
            CheckIdleTimer.Start();

        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
          
            string shtml = webBrowser1.Document.Body.InnerHtml;
            textBox_html.AppendText(shtml);
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
                    dataGridView2.RowCount++;
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

                    dataGridView2[nNum, j].Value = sTitle;
                    nNum++;


                    //MessageBox.Show(sTitle);
                }
                
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "명현스캐너(준비중)";

            area1.Items.Add("전체");
            area1.Items.Add("지방");
            area1.Items.Add("이천");
            area1.Items.Add("수원");
            area1.Items.Add("SPC");
            area1.Items.Add("푸드하우스");
            area1.Items.Add("외식");
            area1.Items.Add("투바앤");
            area1.SelectedIndex = 1;


        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (txtBarcodeLbl.Text.Trim()=="1004")
            {
                if (savepost.Visible == false)
                {
                    savepost.Visible = true;
                    textBox2.Visible = true;
                    listBox1.Visible = true;
                }
                else
                {
                    savepost.Visible = false;
                    textBox2.Visible = false;
                    listBox1.Visible = false;
                }

            } 
            /*
                
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count-1; j++)
                {
                  
                    worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            Thread save = new Thread(new ThreadStart(SaveBarinfo));
            save.Start();


        }
      
        public void SaveBarinfo()
        {
            string datagrid = "";
            int nRow = 0;
           
            for (int i = 0; i < dataGridView2.RowCount-1; i++)
            {
               
                if (Convert.ToString(dataGridView2.Rows[i].Cells[10].Value).Trim() == "N")
                {
                    continue;
                }
                if (Convert.ToString(dataGridView2.Rows[i].Cells[10].Value).Trim() == "C")
                {
                    continue;
                }
                this.Invoke((MethodInvoker)delegate
                {
                    dataGridView2[10, i].Value = 'C';
                    datagrid = datagrid + dataGridView2.Rows[i].Cells[8].Value + "<z>" + dataGridView2.Rows[i].Cells[11].Value + "<k>";
                    nRow++;
                });
            }

               
            if (nRow < 1)
            {
                this.Invoke((MethodInvoker)delegate {
                    textBox3.AppendText("저장할 데이타가 없습니다.  " + Environment.NewLine);
                });
               

                //MessageBox.Show("없음");
                return;
                

            }
          
            this.Invoke((MethodInvoker)delegate
            {

                textBox2.Text = datagrid;
                string strUrl = "http://jjukkh.cafe24.com/scanner/readingtime.php";
                string date = dateTimePicker1.Value.ToString("yyyyMMdd");
                string strPostData = string.Format("id={0}&data={1}&datetime={2}", date, datagrid, date);
                byte[] postData = Encoding.Default.GetBytes(strPostData);
                savepost.Navigate(strUrl, null, postData, "Content-Type: application/x-www-form-urlencoded");
               
            });
 
        }

        private void CheckIdleTimer_Tick(object sender, EventArgs e)
        {
            /*
            //listBox1.Items.Add(Win32.GetIdleTime().ToString());

                listBox1.Items.Add("Total time : " + Win32.GetTickCount().ToString() + "; "
                    + "Last input time : " + Win32.GetLastInputTime().ToString());

                if (Win32.GetIdleTime() > 60000)
                    this.button4.PerformClick();
            
            */
            this.Invoke((MethodInvoker)delegate
            {
                if (this.Text != "명현스캐너(스캔가능)")
                {
                    String strFolder = System.IO.Directory.GetCurrentDirectory();
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(strFolder + "\\sound\\startscan.wav");
                    player.Play();
                }
                else
                {
                    CheckIdleTimer.Stop();
                }

            });  

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\권동일\Desktop\enNavi 5.0_2D_180621\SKNavi\Map\sound\clock.wav");
            player.Play();
            //AutoClosingMessageBox.Show("Wrong Input.", "LMS", 5000);
        }
       
        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                MessageBox.Show(text, caption);
            }

            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }

            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow(null, _caption);
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            
            frm.Show();
        }
    }
}
