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
    public partial class frm_CM_Download : AprilFormBase
    {

        List<eDownloadFile> cDownloadList = new List<eDownloadFile>();

        public frm_CM_Download()
        {
            InitializeComponent();
        }

        public override void Received_DTO(DTOEventArgs e)
        {
            try
            {
                if (e.DSTNAME.Equals(this.Name))
                {
                    switch (e.SRCNAME)
                    {
                        case "mdiMain":
                            if (e.dataObject.Count > 0)
                            {
                                cbDll.Checked = !(bool)e.dataObject[0];
                                cbProgram.Checked = !(bool)e.dataObject[1];
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void SetDownloadCntLbl(string pCount)
        {
            try
            {
                lblDownloadCnt.Text = "다운로드 항목 수 : " + pCount;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void SetDefaultPathLbl(string pPath)
        {
            try
            {
                lblDefaultPath.Text = "기본 저장경로 : " + pPath;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }
    }
}
