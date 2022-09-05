namespace AprilManager
{
    partial class mdiMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCheckUpdate = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnChangeLog = new System.Windows.Forms.Button();
            this.btnExtension = new System.Windows.Forms.Button();
            this.aprilMDITabControl1 = new April.Common.AprilMDITabControl();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(810, 130);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(810, 130);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Controls.Add(this.btnCheckUpdate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDownload, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSetting, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeLog, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnExtension, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 122);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCheckUpdate
            // 
            this.btnCheckUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCheckUpdate.FlatAppearance.BorderSize = 0;
            this.btnCheckUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckUpdate.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnCheckUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCheckUpdate.Image")));
            this.btnCheckUpdate.Location = new System.Drawing.Point(3, 3);
            this.btnCheckUpdate.Name = "btnCheckUpdate";
            this.btnCheckUpdate.Size = new System.Drawing.Size(108, 116);
            this.btnCheckUpdate.TabIndex = 5;
            this.btnCheckUpdate.Text = "업데이트 확인";
            this.btnCheckUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCheckUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCheckUpdate.UseVisualStyleBackColor = true;
            this.btnCheckUpdate.Click += new System.EventHandler(this.btnCheckUpdate_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(117, 3);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(108, 116);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "다운로드";
            this.btnDownload.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.Location = new System.Drawing.Point(687, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(112, 116);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "설정";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnChangeLog
            // 
            this.btnChangeLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeLog.FlatAppearance.BorderSize = 0;
            this.btnChangeLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLog.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnChangeLog.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeLog.Image")));
            this.btnChangeLog.Location = new System.Drawing.Point(573, 3);
            this.btnChangeLog.Name = "btnChangeLog";
            this.btnChangeLog.Size = new System.Drawing.Size(108, 116);
            this.btnChangeLog.TabIndex = 8;
            this.btnChangeLog.Text = "변경 사항";
            this.btnChangeLog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChangeLog.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnChangeLog.UseVisualStyleBackColor = true;
            this.btnChangeLog.Click += new System.EventHandler(this.btnChangeLog_Click);
            // 
            // btnExtension
            // 
            this.btnExtension.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExtension.FlatAppearance.BorderSize = 0;
            this.btnExtension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtension.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnExtension.Image = ((System.Drawing.Image)(resources.GetObject("btnExtension.Image")));
            this.btnExtension.Location = new System.Drawing.Point(459, 3);
            this.btnExtension.Name = "btnExtension";
            this.btnExtension.Size = new System.Drawing.Size(108, 116);
            this.btnExtension.TabIndex = 9;
            this.btnExtension.Text = "확장 다운로드";
            this.btnExtension.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExtension.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExtension.UseVisualStyleBackColor = true;
            this.btnExtension.Visible = false;
            this.btnExtension.Click += new System.EventHandler(this.btnExtension_Click);
            // 
            // aprilMDITabControl1
            // 
            this.aprilMDITabControl1.AllowDrop = true;
            this.aprilMDITabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aprilMDITabControl1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.aprilMDITabControl1.Location = new System.Drawing.Point(0, 130);
            this.aprilMDITabControl1.Name = "aprilMDITabControl1";
            this.aprilMDITabControl1.SelectedIndex = 0;
            this.aprilMDITabControl1.Size = new System.Drawing.Size(810, 508);
            this.aprilMDITabControl1.TabIndex = 2;
            // 
            // mdiMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 638);
            this.Controls.Add(this.aprilMDITabControl1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "mdiMain";
            this.Text = "Title";
            this.Load += new System.EventHandler(this.mdiMain_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private April.Common.AprilMDITabControl aprilMDITabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCheckUpdate;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnChangeLog;
        private System.Windows.Forms.Button btnExtension;
    }
}

