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

            ShowWaitScreen();

            string URL_DLLCHANGELOG = @"https://raw.githubusercontent.com/yuk7392/AprilManager/master/AprilManager/Changelog_DLL.txt";
            string URL_PROGRAMCHANGELOG = @"https://raw.githubusercontent.com/yuk7392/AprilManager/master/AprilManager/Changelog_Program.txt";
            List<string> version = new List<string>();
            List<string> context = new List<string>();

            AprParser.ParseSharpContext(NetMgr.DownloadString(URL_DLLCHANGELOG), version, context);

            for (int i = 0; i < version.Count; i++)
            {
                cbDllVer.AddItems(version[i], context[i]);
            }

            version.Clear();
            context.Clear();

            AprParser.ParseSharpContext(NetMgr.DownloadString(URL_PROGRAMCHANGELOG), version, context);

            for (int i = 0; i < version.Count; i++)
            {
                cbProgramVer.AddItems(version[i], context[i]);
            }

            CloseWaitScreen();
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
