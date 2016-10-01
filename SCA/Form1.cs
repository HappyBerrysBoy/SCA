using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace SCA
{
    public partial class Form1 : Form
    {
        List<int> g_lstTodayData = new List<int>();
        bool bRight = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                InputText();
                txtInput.Text = "";
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            InputText();
        }

        private void InputText()
        {
            if (txtInput.Text.Trim().Length == 0) return;

            if(!isNumber(txtInput.Text.Trim()))
            {
                MessageBox.Show("잘못된 값을 입력하였습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lstList.Items.Count > 0)
            {
                if (int.Parse(lstList.Items[lstList.Items.Count - 1].ToString()) >= int.Parse(txtInput.Text))
                {
                    MessageBox.Show("잘못된 값을 입력하였습니다.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            lstList.Items.Add(txtInput.Text);
            lstList.SelectedIndex = lstList.Items.Count - 1;
        }

        private bool isNumber(String p_sText)
        {
            char[] c;
            c = p_sText.ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (!char.IsDigit(c[i]))
                {
                    return false; 
                }
            }

            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstList.SelectedIndex > -1)
            {
                int iSelList = lstList.SelectedIndices.Count;
                int iSelectedIndex = lstList.SelectedIndex;

                for (int i = iSelList + iSelectedIndex; i > iSelectedIndex; i--)
                {
                    lstList.Items.RemoveAt(i - 1);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String sFilename = dtpDate.Value.ToString();

            if (sFilename.Length > 9)
            {
                sFilename = sFilename.Substring(0, 10) + ".txt";
                if (DialogResult.No == MessageBox.Show(sFilename + " 저장하시겠습니까?", "저장", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                {
                    return;
                }
            }

            FileInfo file = new FileInfo(sFilename);

            if (System.IO.File.Exists(sFilename))
                System.IO.File.Delete(sFilename);

            FileStream fs = new FileStream(sFilename, FileMode.CreateNew, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                for (int i = 0; i < lstList.Items.Count; i++)
                {
                    sw.WriteLine(lstList.Items[i].ToString());
                }
            }
            catch (Exception ex)
            {
                
            }

            sw.Close();
            fs.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdData = new OpenFileDialog();

            ofdData.Title = "Load Data File";
            ofdData.Filter = "TXT Files (*.txt) | *.txt";

            if (ofdData.ShowDialog() == DialogResult.OK)
            {
                g_lstTodayData = LoadData(ofdData.FileName);
            }
            
            if (g_lstTodayData.Count > 0)
            {
                for (int i = 0; i < g_lstTodayData.Count; i++)
                {
                    lstList.Items.Add(g_lstTodayData[i].ToString());
                }
            }
        }

        private List<int> LoadData(String p_sFilename)
        {
            List<int> lstReturn = new List<int>();
            using (StreamReader sr = new StreamReader(p_sFilename))
            {
                String line;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    if (line.Length > 0)
                    {
                        int iTmp = int.Parse(line);
                        lstReturn.Add(iTmp);
                    }
                }
            }

            return lstReturn;
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("모든 List가 삭제 됩니다. 정말로 삭제 하시겠습니까?", "경고", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                lstList.Items.Clear();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            //String sMonth = dtpDate.Value.ToString().Substring(0, 7);

            //if (DialogResult.No == MessageBox.Show(sMonth + " 월 정리 하시겠습니까?", "월 정리", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            //{
            //    return;
            //}

            //String sFilepath = Path.GetFullPath(@".");

            //ArrayList g_aSendData = new ArrayList();
            //ArrayList g_aTotalData = new ArrayList();
            //List<int> g_lstTotalList = new List<int>();

            //DirectoryInfo dir = new DirectoryInfo(sFilepath);
            //FileInfo[] files = dir.GetFiles();

            //for (int i = 0; i < files.Length; i++)
            //{
            //    String sTmp = Path.GetFileName(files[i].FullName);

            //    if(sTmp.Length > 6 && sTmp.Substring(0, 7) == sMonth)
            //    {
            //        List<int> lstTmp = LoadData(files[i].FullName);
            //        g_aTotalData.Add(lstTmp);
            //    }
            //}
            
            //if (g_aTotalData.Count > 0)
            //{
            //    for (int i = 0; i < g_aTotalData.Count; i++)
            //    {
            //        List<int> lstTmp = g_aTotalData[i] as List<int>;
            //        List<int> lstSend = new List<int>();

            //        for (int j = 0; j < lstTmp.Count; j++)
            //        {
            //            int iTmp = lstTmp[j];

            //            if (!g_lstTotalList.Contains(iTmp))
            //            {
            //                lstSend.Add(iTmp);
            //                g_lstTotalList.Add(iTmp);
            //            }
            //        }

            //        g_aSendData.Add(lstSend);
            //    }
            //}

            //frmTotal frm = new frmTotal(g_aSendData, false);
            //frm.Show();
        }

        private OpenFileDialog OpenFileDialog()
        {
            OpenFileDialog ofdData = new OpenFileDialog();

            ofdData.Title = "Load Data File";
            ofdData.Filter = "All Files (*.*) |*.*";

            return ofdData;
        }

        private List<string> getDayList(string filename)
        {
            List<string> lstDay = new List<string>();
            String sSelMonth = dtpDate.Value.ToString().Substring(0, 7);

            using (StreamReader sr = new StreamReader(filename, Encoding.GetEncoding(0)))
            {
                string line;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    string[] sTmp = line.Split(',');

                    if (sTmp.Length < 5) continue;

                    string sDate = sTmp[4].Replace('\'', ' ').Trim();
                    string sCurMonth = "";
                    string sDay = "";

                    if (sDate.Length > 9)
                    {
                        sCurMonth = sDate.Substring(0, 7);
                        sDay = sDate.Substring(8, 2);
                    }

                    if (!sCurMonth.Equals("") && sSelMonth.Equals(sCurMonth))
                    {
                        int iIdx = lstDay.IndexOf(sDay);

                        if (iIdx == -1)
                        {
                            lstDay.Add(sDay);
                        }
                    }
                }
            }

            return lstDay;
        }

        private void Arrange2()
        {
            OpenFileDialog ofdData = OpenFileDialog();
            if (ofdData.ShowDialog() != DialogResult.OK) return;

            String sSelMonth = dtpDate.Value.ToString().Substring(0, 7);

            List<string> lstDay = getDayList(ofdData.FileName);
            lstDay.Sort();

            ArrayList aSendList = new ArrayList();
            ArrayList aTotalList = new ArrayList();
            ArrayList[] aDayList = new ArrayList[lstDay.Count];

            for (int i = 0; i < lstDay.Count; i++)
                aDayList[i] = new ArrayList();

            using (StreamReader sr = new StreamReader(ofdData.FileName, Encoding.GetEncoding(0)))
            {
                string line;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    string[] sTmp = line.Split(',');

                    if (sTmp.Length < 5) continue;

                    //string sChartNo = sTmp[1];
                    int sChartNo = int.Parse(sTmp[1].Replace('\'', ' ').Trim());
                    string sDate = sTmp[4].Replace('\'', ' ').Trim();
                    string sCurMonth = "";
                    string sDay = "";
                    //string sName = sTmp[12].Replace('\'', ' ').Trim();

                    if (sDate.Length > 9)
                    {
                        sCurMonth = sDate.Substring(0, 7);
                        sDay = sDate.Substring(8, 2);
                    }

                    if (!sCurMonth.Equals("") && sSelMonth.Equals(sCurMonth))
                    {
                        int iDayIdx = lstDay.IndexOf(sDay);

                        for (int i = iDayIdx; i < lstDay.Count; i++)
                        {
                            if (aDayList[i].Contains(sChartNo))
                            {
                                aDayList[i].Remove(sChartNo);
                                aDayList[iDayIdx].Add(sChartNo);
                            }
                        }

                        if (!aTotalList.Contains(sChartNo))
                        {
                            aTotalList.Add(sChartNo);
                            aDayList[iDayIdx].Add(sChartNo);
                        }
                    }
                }
            }

            for (int i = 0; i < lstDay.Count; i++)
            {
                aDayList[i].Sort();
                aSendList.Add(aDayList[i]);
            }

            frmTotal frm = new frmTotal(lstDay, aSendList, true);
            frm.Show();
        }

        private Hashtable SetPatientCode(string filename)
        {
            Hashtable hPatientMap = new Hashtable();

            using (StreamReader sr = new StreamReader(filename, Encoding.GetEncoding(0)))
            {
                string line;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    string[] sTmp = line.Split(',');

                    if (sTmp.Length < 10) continue;

                    string sNewCode = sTmp[0].Trim();                   // 프로그램 변경이후 암호화된 코드
                    string sOldCode = sTmp[sTmp.Length - 9].Trim();     // 예전에 사용되던 코드
                    hPatientMap.Add(sNewCode, sOldCode);
                }
            }

            return hPatientMap;
        }

        private void Arrange3()
        {
            MessageBox.Show("PATIENT.MON 파일을 선택하여 주십시오.", "PATIENT 파일 선택");
            OpenFileDialog ofdPatient = OpenFileDialog();
            if (ofdPatient.ShowDialog() != DialogResult.OK) return;

            MessageBox.Show("JSO 파일을 선택하여 주십시오.", "JSO 파일 선택");
            OpenFileDialog ofdJso = OpenFileDialog();
            if (ofdJso.ShowDialog() != DialogResult.OK) return;

            String sSelMonth = dtpDate.Value.ToString().Substring(0, 7);

            Hashtable hCodeMap = SetPatientCode(ofdPatient.FileName);
            List<string> lstDay = getDayList(ofdJso.FileName);
            lstDay.Sort();

            ArrayList aSendList = new ArrayList();
            ArrayList aTotalList = new ArrayList();
            ArrayList[] aDayList = new ArrayList[lstDay.Count];

            for (int i = 0; i < lstDay.Count; i++)
                aDayList[i] = new ArrayList();

            using (StreamReader sr = new StreamReader(ofdJso.FileName, Encoding.GetEncoding(0)))
            {
                string line;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    string[] sTmp = line.Split(',');

                    if (sTmp.Length < 5) continue;

                    string sChartNo = sTmp[1].Trim();
                    string sDate = sTmp[4].Replace('\'', ' ').Trim();
                    string sCurMonth = "";
                    string sDay = "";

                    if (sDate.Length > 9)
                    {
                        sCurMonth = sDate.Substring(0, 7);
                        sDay = sDate.Substring(8, 2);
                    }

                    if (!sCurMonth.Equals("") && sSelMonth.Equals(sCurMonth))
                    {
                        int iDayIdx = lstDay.IndexOf(sDay);

                        for (int i = iDayIdx; i < lstDay.Count; i++)
                        {
                            if (aDayList[i].Contains(sChartNo))
                            {
                                aDayList[i].Remove(sChartNo);
                                aDayList[iDayIdx].Add(sChartNo);
                            }
                        }

                        if (!aTotalList.Contains(sChartNo))
                        {
                            aTotalList.Add(sChartNo);
                            aDayList[iDayIdx].Add(sChartNo);
                        }
                    }
                }
            }

            // 진료환자 리스트중 암호화된 코드를 실제 환자 코드로 변경 및 숫자형으로 변경(sort를 위하여)
            for (int i = 0; i < aDayList.Length; i++)
            {
                for (int j = 0; j < aDayList[i].Count; j++)
                {
                    aDayList[i][j] = Convert.ToInt32(hCodeMap[aDayList[i][j]]);
                }
            }

            // 환자 순서 Sort
            for (int i = 0; i < lstDay.Count; i++)
            {
                aDayList[i].Sort();
                aSendList.Add(aDayList[i]);
            }

            // 스프레더로 표시..
            frmTotal frm = new frmTotal(lstDay, aSendList, true);
            frm.Show();
        }

        private void btnArrange_Click(object sender, EventArgs e)
        {
            ////Arrange2();

            //OpenFileDialog ofdData = new OpenFileDialog();

            //ofdData.Title = "Load Data File";
            //ofdData.Filter = "All Files (*.*) |*.*";

            //if (ofdData.ShowDialog() == DialogResult.OK)
            //{
            //    ArrayList g_aSendData = new ArrayList();
            //    ArrayList g_aTotalData = new ArrayList();
            //    ArrayList g_aDate = new ArrayList();
            //    List<int> g_lstTotalList = new List<int>();
            //    List<int> g_lstDayList = new List<int>();

            //    String sMonth = dtpDate.Value.ToString().Substring(0, 7);
            //    String sDay = "";

            //    using (StreamReader sr = new StreamReader(ofdData.FileName))
            //    {
            //        String line;

            //        while (!sr.EndOfStream)
            //        {
            //            line = sr.ReadLine();

            //            String[] sTmp = line.Split(',');

            //            if (sTmp.Length < 5) continue;

            //            String sChartNo = sTmp[1].Replace('\'', ' ').Trim();
            //            String sDate = sTmp[4].Replace('\'', ' ').Trim();
            //            String sCurMonth = "";

            //            if (sDate.Length > 7) sCurMonth = sDate.Substring(0, 7);

            //            if (!sDate.Equals(sDay))
            //            {
            //                if(g_lstDayList.Count > 0) 
            //                {
            //                    g_lstDayList.Sort();
            //                    g_aTotalData.Add(g_lstDayList);
            //                }
            //                g_lstDayList = new List<int>();
            //                sDay = sDate;
            //            }

            //            if (sMonth.Equals(sCurMonth))
            //            {
            //                int iTmp = int.Parse(sChartNo);
            //                g_lstDayList.Add(iTmp);
            //            }
            //        }

            //        if (g_lstDayList.Count > 0)
            //        {
            //            g_lstDayList.Sort();
            //            g_aTotalData.Add(g_lstDayList);
            //        }
            //    }

            //    //for (int i = 0; i < files.Length; i++)
            //    //{
            //    //    String sTmp = Path.GetFileName(files[i].FullName);

            //    //    if (sTmp.Length > 6 && sTmp.Substring(0, 7) == sMonth)
            //    //    {
            //    //        List<int> lstTmp = LoadData(files[i].FullName);
            //    //        g_aTotalData.Add(lstTmp);
            //    //    }
            //    //}

            //    if (g_aTotalData.Count > 0)
            //    {
            //        for (int i = 0; i < g_aTotalData.Count; i++)
            //        {
            //            List<int> lstTmp = g_aTotalData[i] as List<int>;
            //            List<int> lstSend = new List<int>();

            //            for (int j = 0; j < lstTmp.Count; j++)
            //            {
            //                int iTmp = lstTmp[j];

            //                if (!g_lstTotalList.Contains(iTmp))
            //                {
            //                    lstSend.Add(iTmp);
            //                    g_lstTotalList.Add(iTmp);
            //                }
            //            }

            //            g_aSendData.Add(lstSend);
            //        }
            //    }

            //    frmTotal frm = new frmTotal(g_aSendData, false);
            //    frm.Show();
            //}
        }

        private void btnArrange3_Click(object sender, EventArgs e)
        {
            String sMonth = dtpDate.Value.ToString().Substring(0, 7);

            if(DialogResult.Yes == MessageBox.Show(sMonth + " 선택한 년/월이 맞습니까?",  "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Arrange2();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(bRight)
            {
                btnArrange3.Left += 4;
            }else
            {
                btnArrange3.Left -= 4;
            }


            if (bRight && this.Width - 100 < btnArrange3.Left)
                bRight = false;
            else if (!bRight && 20 > btnArrange3.Left)
                bRight = true;

        }

        private void btnArrange4_Click(object sender, EventArgs e)
        {
            String sMonth = dtpDate.Value.ToString().Substring(0, 7);

            if (DialogResult.Yes == MessageBox.Show(sMonth + " 선택한 년/월이 맞습니까?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                Arrange3();
        }
    }
}
