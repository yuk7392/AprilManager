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

        private void Save()
        {
            try
            {
                if (!FileMgr.Exists(tbSavePath.Text) || string.IsNullOrEmpty(tbSavePath.Text))
                {
                    MsgBoxError("존재하지 않는 경로입니다. 다시 입력하세요.");
                    return;
                }

                RegistryKey rKey = RegistryMgr.OpenKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);
                RegistryMgr.SetValue(rKey, "SavePath", tbSavePath.Text);
                RegistryMgr.SetValue(rKey, "AutoUpdate", rbUse.Checked ? "1" : "0");
                RegistryMgr.SetValue(rKey, "Url_DLL", tbDLLUrl.Text);
                RegistryMgr.SetValue(rKey, "Url_Version", tbDLLVerUrl.Text);
                RegistryMgr.SetValue(rKey, "Url_Program", tbProgramUrl.Text);
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void Load()
        {
            try
            {

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

        private void frm_CM_Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FormMgr.Send_DTO(new DTOEventArgs(this.Name, "mdiMain", "Refresh"));
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }
    }
}
