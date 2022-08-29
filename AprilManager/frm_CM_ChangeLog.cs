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
    public partial class frm_CM_ChangeLog : AprilFormBase
    {
        public frm_CM_ChangeLog()
        {
            InitializeComponent();

            // DLL
            cbDllVer.AddItems("1.0.0.7", "콤보박스 관련 기능 추가");
            cbDllVer.AddItems("1.0.0.8", "콤보박스 관련 기능 수정" + NEWLINE + "eComboboxItem엔티티를 통하여 AprilComboBox를 지정하고, SetSelectedItem, Add, Remove 메서드 추가");
            cbDllVer.AddItems("1.0.0.9", "GridRowMove 추가, AprilDataGrid 추가");

            //

            // PROGRAM
            cbProgramVer.AddItems("1.0.0.2", "로그 기능 추가");
            cbProgramVer.AddItems("1.0.0.3", "업데이트 항목 미 체크시 진행하지 못하도록 수정");
            cbProgramVer.AddItems("1.0.0.4", "버전에 따른 콤보박스 자동 세팅기능 추가");
            //
        }

        private void cbDllVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbDllLog.Text = cbDllVer.SelectedValue as string;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void cbProgramVer_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbProgramLog.Text = cbProgramVer.SelectedValue as string;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void frm_CM_ChangeLog_Load(object sender, EventArgs e)
        {
            try
            {
                cbDllVer.SetSelectedItem(AprCommon.DataLinkObject.DLL_VERSION);
                cbProgramVer.SetSelectedItem(AprCommon.DataLinkObject.APPLICATION_VERSION);
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }
    }
}
