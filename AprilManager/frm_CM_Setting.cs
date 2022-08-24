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
                RegistryKey rKey = RegistryMgr.OpenKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);
                RegistryMgr.SetValue(rKey, "SavePath", tbSavePath.Text);
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

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                string command = ShowEnterDialog("명령어를 입력해주세요.");

                if (string.IsNullOrEmpty(command))
                    return;

                switch(command.ToUpper().SplitString(StringSplitOptions.None, "=")[0].Trim())
                {
                    case "@DLLURL":
                        tbDLLURL.Text = command.SplitString(StringSplitOptions.None, "=")[1].Trim();
                        break;

                    case "@VERSIONURL":
                        tbVERSIONURL.Text = command.SplitString(StringSplitOptions.None, "=")[1].Trim();
                        break;

                    case "@VPROGRAMURL":
                        tbPROGRAMURL.Text = command.SplitString(StringSplitOptions.None, "=")[1].Trim();
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
    }
}
