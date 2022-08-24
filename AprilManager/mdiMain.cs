﻿using System;
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
    public partial class mdiMain : AprilFormBase
    {
        bool cInternetConnected = false;
        RegistryKey cRegKey = RegistryMgr.OpenKey(RegistryMgr.APPLICATION_ONLY_SETTINGS_PATH);

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
                            MsgBoxOK("test");
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

                FormMgr.ShowForm("", false, this, null, false);

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

                FormMgr.ShowForm("", false, this, null, false);
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
                FormMgr.ShowForm("frm_CM_Setting", false, this, new DTOEventArgs(this.Name, "frm_CM_Setting", string.Empty));
            }
            catch (Exception ex)
            {
                LogMgr.Write(AprCommon.DataLinkObject, ex);
            }
        }
    }
}
