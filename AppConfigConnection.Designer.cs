namespace MikrotikUserMonitoring
{
    partial class AppConfigConnection
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
            panel1 = new Panel();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            firstColumIP = new TextBox();
            cancelBtn = new Button();
            saveBtn = new Button();
            passwordField = new TextBox();
            label3 = new Label();
            usernameField = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Window;
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(firstColumIP);
            panel1.Controls.Add(cancelBtn);
            panel1.Controls.Add(saveBtn);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(usernameField);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(272, 154);
            panel1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(225, 22);
            textBox3.MaxLength = 3;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(35, 23);
            textBox3.TabIndex = 12;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 22);
            textBox2.MaxLength = 3;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(35, 23);
            textBox2.TabIndex = 11;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 22);
            textBox1.MaxLength = 3;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(35, 23);
            textBox1.TabIndex = 10;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // firstColumIP
            // 
            firstColumIP.Location = new Point(90, 22);
            firstColumIP.MaxLength = 3;
            firstColumIP.Name = "firstColumIP";
            firstColumIP.Size = new Size(35, 23);
            firstColumIP.TabIndex = 9;
            firstColumIP.TextAlign = HorizontalAlignment.Center;
            firstColumIP.KeyPress += firstColumIP_KeyPress;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            cancelBtn.Location = new Point(185, 108);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 34);
            cancelBtn.TabIndex = 8;
            cancelBtn.Text = "Batal";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            saveBtn.Location = new Point(90, 108);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 34);
            saveBtn.TabIndex = 7;
            saveBtn.Text = "Simpan";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(90, 79);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(170, 23);
            passwordField.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // usernameField
            // 
            usernameField.Location = new Point(90, 50);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(170, 23);
            usernameField.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 51);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 2;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 0;
            label1.Text = "Alamat IP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 33);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 13;
            label4.Text = ".";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 33);
            label5.Name = "label5";
            label5.Size = new Size(10, 15);
            label5.TabIndex = 14;
            label5.Text = ".";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(216, 33);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 15;
            label6.Text = ".";
            // 
            // AppConfigConnection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 154);
            ControlBox = false;
            Controls.Add(panel1);
            Name = "AppConfigConnection";
            Text = "Konfigurasi IP Router";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox passwordField;
        private Label label3;
        private TextBox usernameField;
        private Label label2;
        private Label label1;
        private Button saveBtn;
        private Button cancelBtn;
        private TextBox firstColumIP;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}