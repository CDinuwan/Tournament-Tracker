namespace TrackerUI
{
    partial class frmCreateTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateTeam));
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeamMember = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCellPhone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.listTeamMembers = new System.Windows.Forms.ListBox();
            this.btnScore = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Blue;
            this.lblHeader.Location = new System.Drawing.Point(30, 18);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(196, 45);
            this.lblHeader.TabIndex = 2;
            this.lblHeader.Text = "Create Team";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(38, 117);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(273, 35);
            this.txtTeamName.TabIndex = 12;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTeamName.Location = new System.Drawing.Point(31, 77);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(157, 37);
            this.lblTeamName.TabIndex = 11;
            this.lblTeamName.Text = "Team Name";
            // 
            // btnAddMember
            // 
            this.btnAddMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.Blue;
            this.btnAddMember.Location = new System.Drawing.Point(87, 261);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(182, 46);
            this.btnAddMember.TabIndex = 19;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(38, 205);
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(273, 38);
            this.cboSelectTeam.TabIndex = 18;
            // 
            // lblSelectTeamMember
            // 
            this.lblSelectTeamMember.AutoSize = true;
            this.lblSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSelectTeamMember.Location = new System.Drawing.Point(31, 165);
            this.lblSelectTeamMember.Name = "lblSelectTeamMember";
            this.lblSelectTeamMember.Size = new System.Drawing.Size(263, 37);
            this.lblSelectTeamMember.TabIndex = 17;
            this.lblSelectTeamMember.Text = "Select Team Member";
            this.lblSelectTeamMember.Click += new System.EventHandler(this.lblSelectTeam_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateTeam);
            this.groupBox1.Controls.Add(this.txtCellPhone);
            this.groupBox1.Controls.Add(this.lblCellphone);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Location = new System.Drawing.Point(38, 326);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 264);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // txtCellPhone
            // 
            this.txtCellPhone.Location = new System.Drawing.Point(164, 168);
            this.txtCellPhone.Name = "txtCellPhone";
            this.txtCellPhone.Size = new System.Drawing.Size(150, 35);
            this.txtCellPhone.TabIndex = 28;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCellphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCellphone.Location = new System.Drawing.Point(14, 165);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(138, 37);
            this.lblCellphone.TabIndex = 27;
            this.lblCellphone.Text = "Cellphone";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 35);
            this.textBox1.TabIndex = 26;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(14, 124);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(82, 37);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(164, 86);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 35);
            this.txtLastName.TabIndex = 24;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblLastName.Location = new System.Drawing.Point(14, 83);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(142, 37);
            this.lblLastName.TabIndex = 23;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(164, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(150, 35);
            this.txtFirstName.TabIndex = 22;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblFirstName.Location = new System.Drawing.Point(12, 44);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(144, 37);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "First Name";
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.ForeColor = System.Drawing.Color.Blue;
            this.btnCreateTeam.Location = new System.Drawing.Point(69, 210);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(182, 46);
            this.btnCreateTeam.TabIndex = 21;
            this.btnCreateTeam.Text = "Create Member";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            // 
            // listTeamMembers
            // 
            this.listTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listTeamMembers.FormattingEnabled = true;
            this.listTeamMembers.ItemHeight = 30;
            this.listTeamMembers.Location = new System.Drawing.Point(394, 117);
            this.listTeamMembers.Name = "listTeamMembers";
            this.listTeamMembers.Size = new System.Drawing.Size(332, 452);
            this.listTeamMembers.TabIndex = 21;
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.Blue;
            this.btnScore.Location = new System.Drawing.Point(762, 281);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(114, 71);
            this.btnScore.TabIndex = 22;
            this.btnScore.Text = "Delete Selected Member";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(326, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "Create Team";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmCreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 673);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.listTeamMembers);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.cboSelectTeam);
            this.Controls.Add(this.lblSelectTeamMember);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmCreateTeam";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox cboSelectTeam;
        private System.Windows.Forms.Label lblSelectTeamMember;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCellPhone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.ListBox listTeamMembers;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Button button1;
    }
}