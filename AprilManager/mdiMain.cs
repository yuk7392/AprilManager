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
    public partial class mdiMain : AprilFormBase
    {
        public mdiMain()
        {
            InitializeComponent();

            this.Text = "April Manager [ App : "+AprCommon.DataLinkObject.APPLICATION_VERSION+", DLL : "+AprCommon.DataLinkObject.DLL_VERSION+" ]";
        }

        private void btnSetting_Image_Click(object sender, EventArgs e)
        {
            try
            {
                btnSetting.PerformClick();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnChkUpdate_Image_Click(object sender, EventArgs e)
        {
            try
            {
                btnChkUpdate.PerformClick();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }

        private void btnDownload_Image_Click(object sender, EventArgs e)
        {
            try
            {
                btnDownload.PerformClick();
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }
    }
}
