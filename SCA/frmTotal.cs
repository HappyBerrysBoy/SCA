using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace SCA
{
    public partial class frmTotal : Form
    {
        ArrayList _aReceiveData = new ArrayList();
        List<string> _aDayList = new List<string>();
        bool _bArray = false;
        private const int COL_WIDTH = 40;

        public frmTotal()
        {
            InitializeComponent();
        }

        public frmTotal(List<string> dayList, ArrayList p_aReceiveData, bool bArray)
        {
            InitializeComponent();
            _aReceiveData = p_aReceiveData;
            _bArray = bArray;
            _aDayList = dayList;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
        }

        private void frmTotal_Load(object sender, EventArgs e)
        {
            dgvTotal.ColumnCount = _aReceiveData.Count;

            int maxLength = 0;
            foreach (ArrayList list in _aReceiveData)
            {
                if (maxLength < list.Count)
                    maxLength = list.Count;
            }

            dgvTotal.RowCount = maxLength + 1;

            for (int i = 0; i < _aDayList.Count; i++)
            {
                dgvTotal[i, 0].Value = _aDayList[i];
                dgvTotal[i, 0].Style.BackColor = Color.Yellow;
            }

            for (int i = 0; i < _aReceiveData.Count; i++)
            {
                dgvTotal.Columns[i].Width = COL_WIDTH;
                int iTmp = i + 1;
                dgvTotal.Columns[i].HeaderText = iTmp.ToString();
            }

            if (_bArray)
            {
                for (int i = 0; i < _aReceiveData.Count; i++)
                {
                    ArrayList aTmp = _aReceiveData[i] as ArrayList;

                    for (int j = 0; j < aTmp.Count; j++)
                    {
                        dgvTotal[i, j + 1].Value = aTmp[j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < _aReceiveData.Count; i++)
                {
                    List<int> lstTmp = _aReceiveData[i] as List<int>;

                    for (int j = 0; j < lstTmp.Count; j++)
                    {
                        dgvTotal[i, j].Value = lstTmp[j];
                    }
                }
            }

            dgvTotal.SelectAll();
        }
    }
}
