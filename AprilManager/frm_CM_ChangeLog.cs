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

            // 20220826 - 1 
            cbDllVer.AddItems("1.0.0.7",  "콤보박스 관련 기능 추가");
            cbProgramVer.AddItems("1.0.0.2", "로그 기능 추가");
            //

            // 20220826 - 2
            cbProgramVer.AddItems("1.0.0.3", "업데이트 항목 미 체크시 진행하지 못하도록 수정");
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
    }
}
