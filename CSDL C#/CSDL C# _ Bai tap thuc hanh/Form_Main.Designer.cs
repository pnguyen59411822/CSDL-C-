namespace CSDL_C____Bai_tap_thuc_hanh
{
    partial class Form_Main
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txt_server = new TextBox();
            txt_database = new TextBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            rdo_sql = new RadioButton();
            rdo_win = new RadioButton();
            txt_acc = new TextBox();
            label4 = new Label();
            txt_pwd = new TextBox();
            label5 = new Label();
            btn_connect = new Button();
            btn_access = new Button();
            btn_excel = new Button();
            btn_excel2 = new Button();
            btn_connectApp = new Button();
            btn_connectFile = new Button();
            btn_close = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 57);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(296, 18);
            label1.Name = "label1";
            label1.Size = new Size(180, 20);
            label1.TabIndex = 0;
            label1.Text = "KẾT NỐI CƠ SỞ DỮ LIỆU";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên server";
            // 
            // txt_server
            // 
            txt_server.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_server.Location = new Point(221, 88);
            txt_server.Name = "txt_server";
            txt_server.Size = new Size(567, 27);
            txt_server.TabIndex = 2;
            // 
            // txt_database
            // 
            txt_database.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_database.Location = new Point(221, 131);
            txt_database.Name = "txt_database";
            txt_database.Size = new Size(567, 27);
            txt_database.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 3;
            label3.Text = "Tên database";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdo_sql);
            groupBox1.Controls.Add(rdo_win);
            groupBox1.Location = new Point(221, 164);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(567, 70);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // rdo_sql
            // 
            rdo_sql.AutoSize = true;
            rdo_sql.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdo_sql.ForeColor = Color.Tomato;
            rdo_sql.Location = new Point(55, 38);
            rdo_sql.Name = "rdo_sql";
            rdo_sql.Size = new Size(145, 19);
            rdo_sql.TabIndex = 1;
            rdo_sql.TabStop = true;
            rdo_sql.Text = "Chứng thực bằng SQL";
            rdo_sql.UseVisualStyleBackColor = true;
            // 
            // rdo_win
            // 
            rdo_win.AutoSize = true;
            rdo_win.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rdo_win.ForeColor = Color.Tomato;
            rdo_win.Location = new Point(55, 13);
            rdo_win.Name = "rdo_win";
            rdo_win.Size = new Size(174, 19);
            rdo_win.TabIndex = 0;
            rdo_win.TabStop = true;
            rdo_win.Text = "Chứng thực bằng Windows";
            rdo_win.UseVisualStyleBackColor = true;
            // 
            // txt_acc
            // 
            txt_acc.Enabled = false;
            txt_acc.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_acc.Location = new Point(221, 252);
            txt_acc.Name = "txt_acc";
            txt_acc.Size = new Size(567, 27);
            txt_acc.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(12, 255);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 6;
            label4.Text = "Tài khoản";
            // 
            // txt_pwd
            // 
            txt_pwd.Enabled = false;
            txt_pwd.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pwd.Location = new Point(221, 296);
            txt_pwd.Name = "txt_pwd";
            txt_pwd.Size = new Size(567, 27);
            txt_pwd.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.RoyalBlue;
            label5.Location = new Point(12, 299);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Mật khẩu";
            // 
            // btn_connect
            // 
            btn_connect.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_connect.FlatStyle = FlatStyle.Flat;
            btn_connect.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_connect.Location = new Point(12, 359);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(125, 35);
            btn_connect.TabIndex = 10;
            btn_connect.Text = "Kết nối";
            btn_connect.UseVisualStyleBackColor = true;
            // 
            // btn_access
            // 
            btn_access.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_access.FlatStyle = FlatStyle.Flat;
            btn_access.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_access.Location = new Point(12, 403);
            btn_access.Name = "btn_access";
            btn_access.Size = new Size(125, 35);
            btn_access.TabIndex = 11;
            btn_access.Text = "Access";
            btn_access.UseVisualStyleBackColor = true;
            // 
            // btn_excel
            // 
            btn_excel.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_excel.FlatStyle = FlatStyle.Flat;
            btn_excel.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_excel.Location = new Point(143, 359);
            btn_excel.Name = "btn_excel";
            btn_excel.Size = new Size(125, 35);
            btn_excel.TabIndex = 12;
            btn_excel.Text = "Excel";
            btn_excel.UseVisualStyleBackColor = true;
            // 
            // btn_excel2
            // 
            btn_excel2.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_excel2.FlatStyle = FlatStyle.Flat;
            btn_excel2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_excel2.Location = new Point(143, 403);
            btn_excel2.Name = "btn_excel2";
            btn_excel2.Size = new Size(125, 35);
            btn_excel2.TabIndex = 13;
            btn_excel2.Text = "Excel 2";
            btn_excel2.UseVisualStyleBackColor = true;
            // 
            // btn_connectApp
            // 
            btn_connectApp.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_connectApp.FlatStyle = FlatStyle.Flat;
            btn_connectApp.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_connectApp.Location = new Point(274, 359);
            btn_connectApp.Name = "btn_connectApp";
            btn_connectApp.Size = new Size(125, 35);
            btn_connectApp.TabIndex = 14;
            btn_connectApp.Text = "Kết nối app";
            btn_connectApp.UseVisualStyleBackColor = true;
            // 
            // btn_connectFile
            // 
            btn_connectFile.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_connectFile.FlatStyle = FlatStyle.Flat;
            btn_connectFile.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_connectFile.Location = new Point(274, 403);
            btn_connectFile.Name = "btn_connectFile";
            btn_connectFile.Size = new Size(125, 35);
            btn_connectFile.TabIndex = 15;
            btn_connectFile.Text = "Kết nối file";
            btn_connectFile.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            btn_close.FlatAppearance.MouseOverBackColor = Color.RoyalBlue;
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_close.Location = new Point(405, 403);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(125, 35);
            btn_close.TabIndex = 16;
            btn_close.Text = "Đóng";
            btn_close.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_close);
            Controls.Add(btn_connectFile);
            Controls.Add(btn_connectApp);
            Controls.Add(btn_excel2);
            Controls.Add(btn_excel);
            Controls.Add(btn_access);
            Controls.Add(btn_connect);
            Controls.Add(txt_pwd);
            Controls.Add(label5);
            Controls.Add(txt_acc);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(txt_database);
            Controls.Add(label3);
            Controls.Add(txt_server);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Form_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kết nối cơ sở dữ liệu";
            Load += Form_Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txt_server;
        private TextBox txt_database;
        private Label label3;
        private GroupBox groupBox1;
        private RadioButton rdo_sql;
        private RadioButton rdo_win;
        private TextBox txt_acc;
        private Label label4;
        private TextBox txt_pwd;
        private Label label5;
        private Button btn_connect;
        private Button btn_access;
        private Button btn_excel;
        private Button btn_excel2;
        private Button btn_connectApp;
        private Button btn_connectFile;
        private Button btn_close;
    }
}