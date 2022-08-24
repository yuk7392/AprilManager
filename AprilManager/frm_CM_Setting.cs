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
    }
}
