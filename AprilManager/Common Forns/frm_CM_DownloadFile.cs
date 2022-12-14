using April.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace AprilManager
{
    public partial class frm_CM_DownloadFile : AprilFormBase
    {

        List<eDownloadFile> cDownloadList = new List<eDownloadFile>();
        string cBasePath = string.Empty;

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

                                cBasePath = e.dataObject[2] as string;

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

                                cBasePath = e.dataObject[0] as string;
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
                DownloadFile();
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

        private void DownloadFile()
        {
            try
            {
                cDownloadList.Clear();
                List<FileInfo> fileInfos = new List<FileInfo>();

                if (!cBasePath.Equals(AprCommon.DataLinkObject.APPLICATION_LOCATION_WITHOUT_EXENAME))
                {
                    if (MsgBoxYesNo("설정된 경로와 현 프로그램의 경로가 다릅니다. 그래도 진행하시겠습니까?" + NEWLINE + "프로그램 경로 : " + AprCommon.DataLinkObject.APPLICATION_LOCATION_WITHOUT_EXENAME + NEWLINE + "설정된 경로 : " + cBasePath) != DialogResult.Yes)
                        return;
                }

                if (cbDll.Checked)
                {
                    cDownloadList.Add(new eDownloadFile(tbDllUrl.Text, tbDllSavePath.Text));
                    fileInfos.Add(new FileInfo(tbDllSavePath.Text));
                }

                if (cbProgram.Checked)
                {
                    cDownloadList.Add(new eDownloadFile(tbProgramUrl.Text, tbProgramSavePath.Text));
                    fileInfos.Add(new FileInfo(tbProgramSavePath.Text));
                }

                if (fileInfos.Count == 0)
                {
                    MsgBoxError("선택된 항목이 없습니다.");
                    return;
                }

                foreach (FileInfo fi in fileInfos)
                {
                    string path = fi.FullName.Substring(0, fi.FullName.LastIndexOf(@"\")) + @"\" + fi.Name.RemoveExtension() + ".APRILOLD";
                    if (FileMgr.Exists(path))
                        FileMgr.Delete(path);
                    fi.MoveTo(fi.FullName.Substring(0, fi.FullName.LastIndexOf(@"\")) + @"\" + fi.Name.RemoveExtension() + ".APRILOLD");
                }

                ShowDownloadDialog(cDownloadList);

                MsgBoxOK("업데이트가 완료되었습니다. 프로그램을 다시 시작해주세요.");
                ProcessMgr.OpenExplorer(AprCommon.DataLinkObject.APPLICATION_LOCATION_WITHOUT_EXENAME);
                Application.Exit();

            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }
    }
}
