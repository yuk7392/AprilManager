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
    public partial class frm_CM_DownloadFile : AprilFormBase
    {

        List<eDownloadFile> cDownloadList = new List<eDownloadFile>();

        public frm_CM_DownloadFile()
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

                                SetDefaultPathLbl(e.dataObject[2] as string);
                                tbDllUrl.Text = e.dataObject[3] as string;
                                tbProgramUrl.Text = e.dataObject[4] as string;

                                tbDllSavePath.Text = (e.dataObject[2] as string) + @"\April.Common.dll";
                                tbProgramSavePath.Text = (e.dataObject[2] as string) + @"\AprilManager.exe";

                                SetDownloadCntLbl();
                            }
                            break;

                        case "frm_CM_Setting":
                            if (e.dataObject.Count > 0)
                            {
                                SetDefaultPathLbl(e.dataObject[0] as string);
                                tbDllUrl.Text = e.dataObject[1] as string;
                                tbProgramUrl.Text = e.dataObject[2] as string;

                                tbDllSavePath.Text = (e.dataObject[0] as string) + @"\April.Common.dll";
                                tbProgramSavePath.Text = (e.dataObject[0] as string) + @"\AprilManager.exe";
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

        private void SetDownloadCntLbl(string pCount = "")
        {
            try
            {
                int cnt = 0;

                if (cbDll.Checked)
                    cnt++;
                if (cbProgram.Checked)
                    cnt++;

                lblDownloadCnt.Text = "다운로드 항목 수 : " + (String.IsNullOrEmpty(pCount) ? cnt.ToString() : pCount);
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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void cbDll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetDownloadCntLbl();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void cbProgram_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                SetDownloadCntLbl();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }
    }
}
