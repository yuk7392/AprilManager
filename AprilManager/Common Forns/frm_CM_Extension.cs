using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using April.Common;

namespace AprilManager
{
    public partial class frm_CM_Extension : AprilFormBase
    {

        private DataTable cTable = new DataTable();

        public frm_CM_Extension()
        {
            InitializeComponent();

            aprgrdMain.DataSource = cTable;

            // Columns
            cTable.Columns.Add("확장기능명");
            cTable.Columns.Add("설명");
            cTable.Columns.Add("버전");
            cTable.Columns.Add("DOWNLOADURL");
            //

            // Rows
            cTable.Rows.Add("Test", "testtesttest", "1.0.0.1", "123123123");
            //

            // Settings
            aprgrdMain.Columns[3].Visible = false;

            aprgrdMain.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            aprgrdMain.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            aprgrdMain.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;

            aprgrdMain.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aprgrdMain.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            aprgrdMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //

            MsgBoxOK(aprgrdMain.Rows[0].Cells["DOWNLOADURL"].Value.ToString());
        }


    }
}
