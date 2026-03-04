namespace PHARMASYNC
{
    partial class AdminForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            btnAddUser = new Button();
            txtPassword = new TextBox();
            txtFullName = new TextBox();
            txtUsername = new TextBox();
            cmbRole = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnDeleteUser = new Button();
            label4 = new Label();
            txtSearch = new TextBox();
            btnsearch = new Button();
            dgvUsers = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(867, 548);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(btnAddUser);
            tabPage1.Controls.Add(txtPassword);
            tabPage1.Controls.Add(txtFullName);
            tabPage1.Controls.Add(txtUsername);
            tabPage1.Controls.Add(cmbRole);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.ForeColor = Color.Cyan;
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(859, 510);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Add / Update User";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = Properties.Resources.images__3_;
            pictureBox1.Location = new Point(373, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(217, 141);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btnAddUser
            // 
            btnAddUser.Anchor = AnchorStyles.None;
            btnAddUser.BackColor = Color.Teal;
            btnAddUser.FlatStyle = FlatStyle.Popup;
            btnAddUser.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = SystemColors.ButtonHighlight;
            btnAddUser.Image = Properties.Resources.addUser;
            btnAddUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddUser.Location = new Point(395, 442);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(195, 38);
            btnAddUser.TabIndex = 3;
            btnAddUser.Text = "ADD USER";
            btnAddUser.UseVisualStyleBackColor = false;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.None;
            txtPassword.Location = new Point(392, 367);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(224, 35);
            txtPassword.TabIndex = 2;
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.None;
            txtFullName.Location = new Point(392, 256);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(224, 35);
            txtFullName.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.None;
            txtUsername.Location = new Point(392, 310);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(224, 35);
            txtUsername.TabIndex = 1;
            // 
            // cmbRole
            // 
            cmbRole.Anchor = AnchorStyles.None;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "User" });
            cmbRole.Location = new Point(392, 195);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(224, 38);
            cmbRole.TabIndex = 0;
            cmbRole.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(270, 256);
            label5.Name = "label5";
            label5.Size = new Size(119, 30);
            label5.TabIndex = 0;
            label5.Text = "Full Name:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(270, 367);
            label3.Name = "label3";
            label3.Size = new Size(111, 30);
            label3.TabIndex = 0;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(270, 310);
            label2.Name = "label2";
            label2.Size = new Size(116, 30);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(287, 198);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 0;
            label1.Text = "Role:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnDeleteUser);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtSearch);
            tabPage2.Controls.Add(btnsearch);
            tabPage2.Controls.Add(dgvUsers);
            tabPage2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.ForeColor = Color.Black;
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(859, 510);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "View Users";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(192, 255, 255);
            btnDeleteUser.FlatStyle = FlatStyle.Popup;
            btnDeleteUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = SystemColors.ActiveCaptionText;
            btnDeleteUser.Image = Properties.Resources.remove_25px;
            btnDeleteUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteUser.Location = new Point(573, 59);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(179, 32);
            btnDeleteUser.TabIndex = 2;
            btnDeleteUser.Text = "Delete";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(33, 58);
            label4.Name = "label4";
            label4.Size = new Size(127, 30);
            label4.TabIndex = 13;
            label4.Text = "Search User:";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(166, 62);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(192, 29);
            txtSearch.TabIndex = 0;
            // 
            // btnsearch
            // 
            btnsearch.BackColor = Color.FromArgb(192, 255, 255);
            btnsearch.FlatStyle = FlatStyle.Popup;
            btnsearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsearch.ForeColor = SystemColors.ActiveCaptionText;
            btnsearch.Image = Properties.Resources.search_25px;
            btnsearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnsearch.Location = new Point(374, 59);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(179, 34);
            btnsearch.TabIndex = 1;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = false;
            btnsearch.Click += btnsearch_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToResizeColumns = false;
            dgvUsers.AllowUserToResizeRows = false;
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.BackgroundColor = SystemColors.Control;
            dgvUsers.BorderStyle = BorderStyle.Fixed3D;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUsers.GridColor = SystemColors.InactiveBorder;
            dgvUsers.Location = new Point(51, 103);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsers.Size = new Size(655, 367);
            dgvUsers.TabIndex = 12;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 548);
            Controls.Add(tabControl1);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdminForm";
            WindowState = FormWindowState.Maximized;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtUsername;
        private ComboBox cmbRole;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private Button btnAddUser;
        private DataGridView dgvUsers;
        private Button btnsearch;
        private Label label4;
        private TextBox txtSearch;
        private Button btnDeleteUser;
        private PictureBox pictureBox1;
        private Button btnLogout;
        private TextBox txtFullName;
        private Label label5;
    }
}