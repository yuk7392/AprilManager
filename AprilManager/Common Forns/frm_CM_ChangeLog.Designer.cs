namespace AprilManager
{
    partial class frm_CM_ChangeLog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CM_ChangeLog));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbProgramLog = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDllName = new System.Windows.Forms.Label();
            this.cbDllVer = new April.Common.AprilComboBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.cbProgramVer = new April.Common.AprilComboBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.tbDllLog = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 602F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(732, 603);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tbProgramLog, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbDllLog, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(724, 595);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbProgramLog
            // 
            this.tbProgramLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbProgramLog.Location = new System.Drawing.Point(365, 64);
            this.tbProgramLog.Multiline = true;
            this.tbProgramLog.Name = "tbProgramLog";
            this.tbProgramLog.ReadOnly = true;
            this.tbProgramLog.Size = new System.Drawing.Size(355, 527);
            this.tbProgramLog.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Controls.Add(this.lblDllName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbDllVer, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(354, 53);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblDllName
            // 
            this.lblDllName.AutoSize = true;
            this.lblDllName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDllName.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblDllName.Location = new System.Drawing.Point(4, 1);
            this.lblDllName.Name = "lblDllName";
            this.lblDllName.Size = new System.Drawing.Size(204, 51);
            this.lblDllName.TabIndex = 1;
            this.lblDllName.Text = "April.Common";
            this.lblDllName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDllVer
            // 
            this.cbDllVer.DisplayMember = "DISPLAYTEXT";
            this.cbDllVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbDllVer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDllVer.FormattingEnabled = true;
            this.cbDllVer.ItemHeight = 39;
            this.cbDllVer.ItemTextAlignment = April.Common.AprilComboBox.ItemTextAlign.CENTER;
            this.cbDllVer.Location = new System.Drawing.Point(215, 4);
            this.cbDllVer.Name = "cbDllVer";
            this.cbDllVer.Size = new System.Drawing.Size(135, 45);
            this.cbDllVer.TabIndex = 2;
            this.cbDllVer.ValueMember = "VALUE";
            this.cbDllVer.SelectedIndexChanged += new System.EventHandler(this.cbDllVer_SelectedIndexChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.Controls.Add(this.cbProgramVer, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblProgramName, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(365, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(355, 53);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // cbProgramVer
            // 
            this.cbProgramVer.DisplayMember = "DISPLAYTEXT";
            this.cbProgramVer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbProgramVer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProgramVer.FormattingEnabled = true;
            this.cbProgramVer.ItemHeight = 39;
            this.cbProgramVer.ItemTextAlignment = April.Common.AprilComboBox.ItemTextAlign.CENTER;
            this.cbProgramVer.Location = new System.Drawing.Point(216, 4);
            this.cbProgramVer.Name = "cbProgramVer";
            this.cbProgramVer.Size = new System.Drawing.Size(135, 45);
            this.cbProgramVer.TabIndex = 3;
            this.cbProgramVer.ValueMember = "VALUE";
            this.cbProgramVer.SelectedIndexChanged += new System.EventHandler(this.cbProgramVer_SelectedIndexChanged);
            // 
            // lblProgramName
            // 
            this.lblProgramName.AutoSize = true;
            this.lblProgramName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProgramName.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.lblProgramName.Location = new System.Drawing.Point(4, 1);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(205, 51);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "AprilManager";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbDllLog
            // 
            this.tbDllLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDllLog.Location = new System.Drawing.Point(4, 64);
            this.tbDllLog.Multiline = true;
            this.tbDllLog.Name = "tbDllLog";
            this.tbDllLog.ReadOnly = true;
            this.tbDllLog.Size = new System.Drawing.Size(354, 527);
            this.tbDllLog.TabIndex = 2;
            // 
            // frm_CM_ChangeLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 603);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_CM_ChangeLog";
            this.Text = "변경 사항";
            this.Load += new System.EventHandler(this.frm_CM_ChangeLog_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox tbProgramLog;
        private System.Windows.Forms.Label lblDllName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblProgramName;
        private System.Windows.Forms.TextBox tbDllLog;
        private April.Common.AprilComboBox cbDllVer;
        private April.Common.AprilComboBox cbProgramVer;
    }
}