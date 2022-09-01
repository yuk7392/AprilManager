namespace AprilManager
{
    partial class frm_CM_Extension
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aprgrdMain = new April.Common.AprilDataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aprgrdMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.aprgrdMain, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(759, 497);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // aprgrdMain
            // 
            this.aprgrdMain.AllowUserToAddRows = false;
            this.aprgrdMain.AllowUserToDeleteRows = false;
            this.aprgrdMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aprgrdMain.BackgroundColor = System.Drawing.SystemColors.Control;
            this.aprgrdMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aprgrdMain.CellFont = new System.Drawing.Font("맑은 고딕", 10F);
            this.aprgrdMain.ColumnHeaderColor = System.Drawing.Color.LightSkyBlue;
            this.aprgrdMain.ColumnHeaderFont = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.aprgrdMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aprgrdMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.aprgrdMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aprgrdMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aprgrdMain.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.aprgrdMain.EnableHeadersVisualStyles = false;
            this.aprgrdMain.GridColor = System.Drawing.Color.Black;
            this.aprgrdMain.HotTrackColor = System.Drawing.Color.Blue;
            this.aprgrdMain.HotTrackColorAlpha = 50;
            this.aprgrdMain.Location = new System.Drawing.Point(4, 4);
            this.aprgrdMain.Name = "aprgrdMain";
            this.aprgrdMain.ReadOnly = true;
            this.aprgrdMain.RowHeadersVisible = false;
            this.aprgrdMain.RowTemplate.Height = 23;
            this.aprgrdMain.SelectedRowColor = System.Drawing.SystemColors.Highlight;
            this.aprgrdMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aprgrdMain.Size = new System.Drawing.Size(598, 489);
            this.aprgrdMain.TabIndex = 0;
            // 
            // frm_CM_Extension
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 497);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_CM_Extension";
            this.Text = "확장 다운로드";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aprgrdMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private April.Common.AprilDataGridView aprgrdMain;
    }
}