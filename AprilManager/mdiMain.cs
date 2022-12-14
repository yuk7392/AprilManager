using April.Common;
using Microsoft.Win32;
using System;
using System.Text;
using System.Windows.Forms;

namespace AprilManager
{
    public partial class mdiMain : AprilFormBase
    {
        bool cInternetConnected = false;
        RegistryKey cRegKey = RegistryMgr.OpenKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);

        // Constraints
        string SAVEPATH = string.Empty;
        string AUTOUPDATE = string.Empty;
        string URL_DLL = string.Empty;
        string URL_DLLVERSION = string.Empty;
        string URL_PROGRAM = string.Empty;
        string URL_PROGRAMVERSION = string.Empty;
        //

        bool isProgramLatest = true;
        bool isDLLLatest = true;

        public mdiMain()
        {
            InitializeComponent();

            this.Text = "April Manager [ App : " + AprCommon.DataLinkObject.APPLICATION_VERSION + ", DLL : " + AprCommon.DataLinkObject.DLL_VERSION + " ]";
            FormMgr.SubscribeDTOEvent(this);
        }

        public override void Received_DTO(DTOEventArgs e)
        {
            if (e.DSTNAME.Equals(this.Name))
            {
                switch (e.SRCNAME)
                {
                    case "frm_CM_Setting":
                        if (e.MESSAGE.ToUpper().Equals("REFRESH"))
                        {
                            SetConstraintValue((string)e.dataObject[0], // SavePath
                                              (string)e.dataObject[1], // AutoUpdate
                                              (string)e.dataObject[2], // DLL URL
                                              (string)e.dataObject[3], // DLL ver Url
                                              (string)e.dataObject[4], // Program URL
                                              (string)e.dataObject[5]); // Program Ver URL

                            cRegKey = RegistryMgr.OpenKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);
                        }

                        break;
                }
            }
        }

        private void mdiMain_Load(object sender, EventArgs e)
        {
            try
            {
                if (!NetMgr.InternetConnected())
                {
                    cInternetConnected = false;
                    MsgBoxWarning("인터넷에 연결되어 있지 않습니다.");
                }
                else
                {
                    cInternetConnected = true;
                }

                if (cRegKey == null)
                    btnSetting.PerformClick();
                else
                    SetConstraintValue();

                if (AUTOUPDATE.Equals("1"))
                    btnCheckUpdate.PerformClick();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnCheckUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!cInternetConnected)
                {
                    MsgBoxError("인터넷에 연결되지 않아 해당 기능을 사용할 수 없습니다.");
                    return;
                }

                string dllServerVersion = NetMgr.DownloadString(URL_DLLVERSION);
                string programServerVersion = NetMgr.DownloadString(URL_PROGRAMVERSION);
                isProgramLatest = AprCommon.DataLinkObject.APPLICATION_VERSION.Equals(programServerVersion.Trim()) ? true : false;
                isDLLLatest = AprCommon.DataLinkObject.DLL_VERSION.Equals(dllServerVersion.Trim()) ? true : false;

                StringBuilder msgStr = new StringBuilder();
                msgStr.Append("프로그램 버전 : " + AprCommon.DataLinkObject.APPLICATION_VERSION + NEWLINE);
                msgStr.Append("프로그램 서버 버전 : " + programServerVersion + NEWLINE);
                msgStr.Append(NEWLINE);
                msgStr.Append("DLL 버전 : " + AprCommon.DataLinkObject.DLL_VERSION + NEWLINE);
                msgStr.Append("DLL 서버 버전 : " + dllServerVersion + NEWLINE);
                msgStr.Append(NEWLINE);
                msgStr.Append("프로그램 상태 : " + (isProgramLatest ? "최신입니다." : "업데이트가 존재합니다.") + NEWLINE);
                msgStr.Append("DLL 상태 : " + (isDLLLatest ? "최신입니다." : "업데이트가 존재합니다.") + NEWLINE);
                msgStr.Append(NEWLINE);

                if (isDLLLatest && isProgramLatest)
                    msgStr.Append("모두 최신버전입니다.");
                else if (!isDLLLatest && !isProgramLatest)
                    msgStr.Append("모든 항목의 업데이트가 존재합니다, 업데이트를 진행하시겠습니까?");
                else
                    msgStr.Append((isDLLLatest ? "프로그램" : "DLL") + " 업데이트가 존재합니다, 업데이트를 진행하시겠습니까?");

                if (isDLLLatest && isProgramLatest)
                {
                    MsgBoxOK(msgStr.ToString());
                    return;
                }

                if (MsgBoxYesNo(msgStr.ToString()) != DialogResult.Yes)
                    return;

                btnDownload.PerformClick();
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
                if (!cInternetConnected)
                {
                    MsgBoxError("인터넷에 연결되지 않아 해당 기능을 사용할 수 없습니다.");
                    return;
                }

                //if (FormMgr.IsFormOpened("frm_CM_Setting"))
                //{
                //    MsgBoxWarning("오작동 방지를 위해 설정완료 후 다시 시도하세요.");
                //    return;
                //}

                FormMgr.ShowForm("frm_CM_DownloadFile", false, this, new DTOEventArgs(this.Name, "frm_CM_DownloadFile", string.Empty, isDLLLatest, isProgramLatest, SAVEPATH, URL_DLL, URL_PROGRAM), false); ;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            try
            {
                //if (FormMgr.IsFormOpened("frm_CM_Download"))
                //{
                //    MsgBoxWarning("오작동 방지를 위해 설정완료 후 다시 시도하세요.");
                //    return;
                //}

                FormMgr.ShowForm("frm_CM_Setting", false, this, new DTOEventArgs(this.Name, "frm_CM_Setting", string.Empty));
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void SetConstraintValue(string pSavePath, string pAutoUpdate, string pDLLUrl, string pDllVerUrl, string pProgramUrl, string pProgramVerUrl)
        {
            try
            {
                SAVEPATH = pSavePath;
                AUTOUPDATE = pAutoUpdate;
                URL_DLL = pDLLUrl;
                URL_DLLVERSION = pDllVerUrl;
                URL_PROGRAM = pProgramUrl;
                URL_PROGRAMVERSION = pProgramVerUrl;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void SetConstraintValue()
        {
            try
            {
                SAVEPATH = RegistryMgr.GetValue(cRegKey, "SavePath");
                AUTOUPDATE = RegistryMgr.GetValue(cRegKey, "AutoUpdate");
                URL_DLL = RegistryMgr.GetValue(cRegKey, "Url_DLL");
                URL_DLLVERSION = RegistryMgr.GetValue(cRegKey, "Url_DLL_Version");
                URL_PROGRAM = RegistryMgr.GetValue(cRegKey, "Url_Program");
                URL_PROGRAMVERSION = RegistryMgr.GetValue(cRegKey, "Url_Program_Version");
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnChangeLog_Click(object sender, EventArgs e)
        {
            try
            {
                if (!NetMgr.InternetConnected())
                {
                    MsgBoxError("인터넷에 연결되지 않아 해당 기능을 사용할 수 없습니다.");
                    return;
                }

                FormMgr.ShowForm("frm_CM_ChangeLog", false, this);
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnExtension_Click(object sender, EventArgs e)
        {
            try
            {
                if (!NetMgr.InternetConnected())
                {
                    MsgBoxError("인터넷에 연결되지 않아 해당 기능을 사용할 수 없습니다.");
                    return;
                }

                FormMgr.ShowForm("frm_CM_Extension", false, this);
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }
    }
}
