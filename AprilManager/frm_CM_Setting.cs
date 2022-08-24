using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using April.Common;

namespace AprilManager
{
    public partial class frm_CM_Setting : AprilFormBase
    {
        readonly string URL_DLL = @"https://github.com/yuk7392/AprilManager/raw/master/AprilManager/bin/Debug/April.Common.dll";
        readonly string URL_DLLVERSION = @"https://raw.githubusercontent.com/yuk7392/AprilManager/master/AprilManager/Version_DLL.txt";
        readonly string URL_PROGRAM = @"https://github.com/yuk7392/AprilManager/raw/master/AprilManager/bin/Debug/AprilManager.exe";
        readonly string URL_PROGRAMVERSION = @"https://raw.githubusercontent.com/yuk7392/AprilManager/master/AprilManager/Version_Program.txt";

        RegistryKey cRegKey = RegistryMgr.OpenKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);

        public frm_CM_Setting()
        {
            InitializeComponent();
        }

        public override void Received_DTO(DTOEventArgs e)
        {
            if (e.DSTNAME.Equals(this.Name))
            {
                switch (e.SRCNAME)
                {
                    case "mdiMain":

                        if (e.dataObject.Count > 0)
                        {

                        }

                        break;
                }
            }
        }

        private void Save(string pSavePath, string pAutoUpdate, string pDLLUrl, string pDLLVerUrl, string pProgramUrl, string pProgramVerUrl)
        {
            try
            {
                RegistryMgr.SetValue(cRegKey, "SavePath", pSavePath);
                RegistryMgr.SetValue(cRegKey, "AutoUpdate", pAutoUpdate);
                RegistryMgr.SetValue(cRegKey, "Url_DLL", pDLLUrl);
                RegistryMgr.SetValue(cRegKey, "Url_DLL_Version", pDLLVerUrl);
                RegistryMgr.SetValue(cRegKey, "Url_Program", pProgramUrl);
                RegistryMgr.SetValue(cRegKey, "Url_Program_Version", pProgramVerUrl);
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void LoadSetting()
        {
            try
            {
                if (cRegKey == null)
                    return;

                tbSavePath.Text = RegistryMgr.GetValue(cRegKey, "SavePath");
                rbUse.Checked = RegistryMgr.GetValue(cRegKey, "AutoUpdate").Equals("1");
                tbDLLUrl.Text = RegistryMgr.GetValue(cRegKey, "Url_DLL");
                tbDLLVerUrl.Text = RegistryMgr.GetValue(cRegKey, "Url_DLL_Version");
                tbProgramUrl.Text = RegistryMgr.GetValue(cRegKey, "Url_Program");
                tbProgramVerUrl.Text = RegistryMgr.GetValue(cRegKey, "Url_Program_Version");
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;

                if (!FileMgr.Exists(tbSavePath.Text) || string.IsNullOrEmpty(tbSavePath.Text))
                {
                    MsgBoxError("경로명이 존재하지 않거나 부정확합니다. 다시 입력하세요.");
                    return;
                }

                Save(tbSavePath.Text, rbUse.Checked ? "1" : "0", tbDLLUrl.Text, tbDLLVerUrl.Text, tbProgramUrl.Text, tbProgramVerUrl.Text);
                MsgBoxOK("저장되었습니다.");
                FormMgr.Send_DTO(new DTOEventArgs(this.Name, "mdiMain", "Refresh", tbSavePath.Text, rbUse.Checked ? "1" : "0", tbDLLUrl.Text, tbDLLVerUrl.Text, tbProgramUrl.Text, tbProgramVerUrl.Text));
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (cRegKey == null)
                    return;

                RegistryMgr.DeleteKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);
                ClearSetting();

                MsgBoxOK("초기화 되었습니다.");

                SetRegKey();
                Save(AprCommon.DataLinkObject.APPLICATION_LOCATION_WITHOUT_EXENAME, rbUse.Checked ? "1" : "0", URL_DLL, URL_DLLVERSION, URL_PROGRAM, URL_PROGRAMVERSION);
                LoadSetting();
                FormMgr.Send_DTO(new DTOEventArgs(this.Name, "mdiMain", "Refresh", tbSavePath.Text, rbUse.Checked ? "1" : "0", tbDLLUrl.Text, tbDLLVerUrl.Text, tbProgramUrl.Text, tbProgramVerUrl.Text));
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void ClearSetting()
        {
            try
            {
                tbSavePath.Text = string.Empty;
                tbDLLUrl.Text = string.Empty;
                tbDLLVerUrl.Text = string.Empty;
                tbProgramUrl.Text = string.Empty;
                tbProgramVerUrl.Text = string.Empty;
                rbDontUse.Checked = true;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = tbSavePath.Text;
                string dir = ShowFolderBrowserDialog();

                if (string.IsNullOrEmpty(dir))
                    tbSavePath.Text = temp;
                else
                    tbSavePath.Text = dir;
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            try
            {
                string command = ShowEnterDialog("명령어를 입력해주세요.");

                if (string.IsNullOrEmpty(command))
                    return;

                switch(command.ToUpper().SplitString(StringSplitOptions.None, "=")[0].Trim())
                {
                    case "@DLLURL":
                        tbDLLUrl.Text = command.SplitString(StringSplitOptions.None, "=")[1].Trim();
                        break;

                    case "@DLLVERURL":
                        tbDLLVerUrl.Text = command.SplitString(StringSplitOptions.None, "=")[1].Trim();
                        break;

                    case "@PROGRAMURL":
                        tbProgramUrl.Text = command.SplitString(StringSplitOptions.None, "=")[1].Trim();
                        break;

                    case "@PROGRAMVERURL":
                        tbProgramVerUrl.Text = command.SplitString(StringSplitOptions.None, "=")[1].Trim();
                        break;

                    default:
                        MsgBoxError("알 수 없는 명령어입니다.");
                        break;
                }

            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void frm_CM_Setting_Load(object sender, EventArgs e)
        {
            try
            {
                if (cRegKey == null)
                {
                    SetRegKey();
                    Save(AprCommon.DataLinkObject.APPLICATION_LOCATION_WITHOUT_EXENAME, rbUse.Checked ? "1" : "0", URL_DLL, URL_DLLVERSION, URL_PROGRAM, URL_PROGRAMVERSION);
                    LoadSetting();
                }
                else
                {
                    LoadSetting();
                }
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void SetRegKey()
        {
            try
            {
                cRegKey = RegistryMgr.CreateKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }
    }
}
