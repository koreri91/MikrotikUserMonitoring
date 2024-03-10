namespace MikrotikUserMonitoring
{
    partial class MainApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            totalUserLbl = new Label();
            dgvHosts = new DataGridView();
            ColumnNo = new DataGridViewTextBoxColumn();
            ColumnIPAddress = new DataGridViewTextBoxColumn();
            ColumnMACAddress = new DataGridViewTextBoxColumn();
            ColumnUpTime = new DataGridViewTextBoxColumn();
            ColumnBytesIn = new DataGridViewTextBoxColumn();
            ColumnBytesOut = new DataGridViewTextBoxColumn();
            ColumnDeviceName = new DataGridViewTextBoxColumn();
            ColumnComment = new DataGridViewTextBoxColumn();
            settingConnectionBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHosts).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(totalUserLbl);
            panel1.Controls.Add(dgvHosts);
            panel1.Controls.Add(settingConnectionBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(903, 403);
            panel1.TabIndex = 0;
            // 
            // totalUserLbl
            // 
            totalUserLbl.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalUserLbl.AutoSize = true;
            totalUserLbl.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            totalUserLbl.Location = new Point(769, 374);
            totalUserLbl.Name = "totalUserLbl";
            totalUserLbl.Size = new Size(120, 21);
            totalUserLbl.TabIndex = 2;
            totalUserLbl.Text = "Total User (100)";
            // 
            // dgvHosts
            // 
            dgvHosts.AllowUserToAddRows = false;
            dgvHosts.AllowUserToDeleteRows = false;
            dgvHosts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHosts.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHosts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHosts.Columns.AddRange(new DataGridViewColumn[] { ColumnNo, ColumnIPAddress, ColumnMACAddress, ColumnUpTime, ColumnBytesIn, ColumnBytesOut, ColumnDeviceName, ColumnComment });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHosts.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHosts.Location = new Point(13, 66);
            dgvHosts.Name = "dgvHosts";
            dgvHosts.ReadOnly = true;
            dgvHosts.RowHeadersVisible = false;
            dgvHosts.RowTemplate.Height = 25;
            dgvHosts.Size = new Size(878, 304);
            dgvHosts.TabIndex = 1;
            // 
            // ColumnNo
            // 
            ColumnNo.HeaderText = "#";
            ColumnNo.Name = "ColumnNo";
            ColumnNo.ReadOnly = true;
            ColumnNo.Width = 40;
            // 
            // ColumnIPAddress
            // 
            ColumnIPAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnIPAddress.HeaderText = "Alamat IP";
            ColumnIPAddress.MinimumWidth = 150;
            ColumnIPAddress.Name = "ColumnIPAddress";
            ColumnIPAddress.ReadOnly = true;
            ColumnIPAddress.Width = 150;
            // 
            // ColumnMACAddress
            // 
            ColumnMACAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnMACAddress.HeaderText = "Alamat MAC";
            ColumnMACAddress.MinimumWidth = 150;
            ColumnMACAddress.Name = "ColumnMACAddress";
            ColumnMACAddress.ReadOnly = true;
            ColumnMACAddress.Width = 150;
            // 
            // ColumnUpTime
            // 
            ColumnUpTime.HeaderText = "Waktu Aktif";
            ColumnUpTime.Name = "ColumnUpTime";
            ColumnUpTime.ReadOnly = true;
            // 
            // ColumnBytesIn
            // 
            ColumnBytesIn.HeaderText = "Download";
            ColumnBytesIn.Name = "ColumnBytesIn";
            ColumnBytesIn.ReadOnly = true;
            // 
            // ColumnBytesOut
            // 
            ColumnBytesOut.HeaderText = "Upload";
            ColumnBytesOut.Name = "ColumnBytesOut";
            ColumnBytesOut.ReadOnly = true;
            // 
            // ColumnDeviceName
            // 
            ColumnDeviceName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnDeviceName.HeaderText = "Nama Perangkat";
            ColumnDeviceName.MinimumWidth = 180;
            ColumnDeviceName.Name = "ColumnDeviceName";
            ColumnDeviceName.ReadOnly = true;
            ColumnDeviceName.Width = 180;
            // 
            // ColumnComment
            // 
            ColumnComment.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            ColumnComment.HeaderText = "Komentar";
            ColumnComment.MinimumWidth = 150;
            ColumnComment.Name = "ColumnComment";
            ColumnComment.ReadOnly = true;
            ColumnComment.Width = 150;
            // 
            // settingConnectionBtn
            // 
            settingConnectionBtn.Image = Properties.Resources.ic_settings;
            settingConnectionBtn.Location = new Point(13, 12);
            settingConnectionBtn.Name = "settingConnectionBtn";
            settingConnectionBtn.Size = new Size(38, 38);
            settingConnectionBtn.TabIndex = 0;
            settingConnectionBtn.UseVisualStyleBackColor = true;
            settingConnectionBtn.Click += settingConnectionBtn_Click;
            // 
            // MainApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(903, 403);
            Controls.Add(panel1);
            Name = "MainApp";
            Text = "Mikrotik User Monitoring";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHosts).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button settingConnectionBtn;
        private DataGridView dgvHosts;
        private DataGridViewTextBoxColumn ColumnNo;
        private DataGridViewTextBoxColumn ColumnIPAddress;
        private DataGridViewTextBoxColumn ColumnMACAddress;
        private DataGridViewTextBoxColumn ColumnUpTime;
        private DataGridViewTextBoxColumn ColumnBytesIn;
        private DataGridViewTextBoxColumn ColumnBytesOut;
        private DataGridViewTextBoxColumn ColumnDeviceName;
        private DataGridViewTextBoxColumn ColumnComment;
        private Label totalUserLbl;
    }
}