namespace HospitalAdministration
{
    partial class Form1
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
            this.grpPatient = new System.Windows.Forms.GroupBox();
            this.txtPatRemove = new System.Windows.Forms.TextBox();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnSearchPatient = new System.Windows.Forms.Button();
            this.dtpPat = new System.Windows.Forms.DateTimePicker();
            this.cmbPatTitle = new System.Windows.Forms.ComboBox();
            this.txtPatLastName = new System.Windows.Forms.TextBox();
            this.lblPatLastName = new System.Windows.Forms.Label();
            this.btnPatientNames = new System.Windows.Forms.Button();
            this.btnContact = new System.Windows.Forms.Button();
            this.btnShowPatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.txtPatPhone = new System.Windows.Forms.TextBox();
            this.lblPatPhone = new System.Windows.Forms.Label();
            this.txtPatEmail = new System.Windows.Forms.TextBox();
            this.lblPatEmail = new System.Windows.Forms.Label();
            this.txtPatID = new System.Windows.Forms.TextBox();
            this.lblPatID = new System.Windows.Forms.Label();
            this.lblPatDOB = new System.Windows.Forms.Label();
            this.txtPatFirstName = new System.Windows.Forms.TextBox();
            this.lblPatFirstName = new System.Windows.Forms.Label();
            this.lblPatTitle = new System.Windows.Forms.Label();
            this.grpStaff = new System.Windows.Forms.GroupBox();
            this.txtStaffRemove = new System.Windows.Forms.TextBox();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.dtpStaff = new System.Windows.Forms.DateTimePicker();
            this.cmbStaffTitle = new System.Windows.Forms.ComboBox();
            this.btnStaffContact = new System.Windows.Forms.Button();
            this.btnStaffNames = new System.Windows.Forms.Button();
            this.btnShowStaff = new System.Windows.Forms.Button();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.lblStaffPhone = new System.Windows.Forms.Label();
            this.txtStaffEmail = new System.Windows.Forms.TextBox();
            this.lblStaffEmail = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblStaffDOB = new System.Windows.Forms.Label();
            this.txtStaffLastName = new System.Windows.Forms.TextBox();
            this.lblStaffLastName = new System.Windows.Forms.Label();
            this.txtStaffFirstName = new System.Windows.Forms.TextBox();
            this.lblStaffFirstName = new System.Windows.Forms.Label();
            this.lblStaffTitle = new System.Windows.Forms.Label();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.lblDisplayRemarks = new System.Windows.Forms.Label();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.lblHospAdmin = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtPatSearch = new System.Windows.Forms.TextBox();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.grpPatient.SuspendLayout();
            this.grpStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPatient
            // 
            this.grpPatient.BackColor = System.Drawing.Color.PaleGreen;
            this.grpPatient.Controls.Add(this.txtPatSearch);
            this.grpPatient.Controls.Add(this.txtPatRemove);
            this.grpPatient.Controls.Add(this.btnDeletePatient);
            this.grpPatient.Controls.Add(this.btnSearchPatient);
            this.grpPatient.Controls.Add(this.dtpPat);
            this.grpPatient.Controls.Add(this.cmbPatTitle);
            this.grpPatient.Controls.Add(this.txtPatLastName);
            this.grpPatient.Controls.Add(this.lblPatLastName);
            this.grpPatient.Controls.Add(this.btnPatientNames);
            this.grpPatient.Controls.Add(this.btnContact);
            this.grpPatient.Controls.Add(this.btnShowPatient);
            this.grpPatient.Controls.Add(this.btnAddPatient);
            this.grpPatient.Controls.Add(this.txtPatPhone);
            this.grpPatient.Controls.Add(this.lblPatPhone);
            this.grpPatient.Controls.Add(this.txtPatEmail);
            this.grpPatient.Controls.Add(this.lblPatEmail);
            this.grpPatient.Controls.Add(this.txtPatID);
            this.grpPatient.Controls.Add(this.lblPatID);
            this.grpPatient.Controls.Add(this.lblPatDOB);
            this.grpPatient.Controls.Add(this.txtPatFirstName);
            this.grpPatient.Controls.Add(this.lblPatFirstName);
            this.grpPatient.Controls.Add(this.lblPatTitle);
            this.grpPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPatient.Location = new System.Drawing.Point(37, 98);
            this.grpPatient.Name = "grpPatient";
            this.grpPatient.Size = new System.Drawing.Size(333, 499);
            this.grpPatient.TabIndex = 0;
            this.grpPatient.TabStop = false;
            this.grpPatient.Text = "Add Patient";
            // 
            // txtPatRemove
            // 
            this.txtPatRemove.Location = new System.Drawing.Point(236, 463);
            this.txtPatRemove.Name = "txtPatRemove";
            this.txtPatRemove.Size = new System.Drawing.Size(84, 22);
            this.txtPatRemove.TabIndex = 22;
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Location = new System.Drawing.Point(155, 463);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePatient.TabIndex = 21;
            this.btnDeletePatient.Text = "Delete";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnSearchPatient
            // 
            this.btnSearchPatient.Location = new System.Drawing.Point(155, 433);
            this.btnSearchPatient.Name = "btnSearchPatient";
            this.btnSearchPatient.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPatient.TabIndex = 20;
            this.btnSearchPatient.Text = "Search";
            this.btnSearchPatient.UseVisualStyleBackColor = true;
            this.btnSearchPatient.Click += new System.EventHandler(this.btnSearchPatient_Click);
            // 
            // dtpPat
            // 
            this.dtpPat.Location = new System.Drawing.Point(92, 194);
            this.dtpPat.Name = "dtpPat";
            this.dtpPat.Size = new System.Drawing.Size(171, 22);
            this.dtpPat.TabIndex = 19;
            // 
            // cmbPatTitle
            // 
            this.cmbPatTitle.FormattingEnabled = true;
            this.cmbPatTitle.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs."});
            this.cmbPatTitle.Location = new System.Drawing.Point(92, 48);
            this.cmbPatTitle.Name = "cmbPatTitle";
            this.cmbPatTitle.Size = new System.Drawing.Size(100, 24);
            this.cmbPatTitle.TabIndex = 18;
            // 
            // txtPatLastName
            // 
            this.txtPatLastName.Location = new System.Drawing.Point(92, 149);
            this.txtPatLastName.Name = "txtPatLastName";
            this.txtPatLastName.Size = new System.Drawing.Size(100, 22);
            this.txtPatLastName.TabIndex = 17;
            // 
            // lblPatLastName
            // 
            this.lblPatLastName.AutoSize = true;
            this.lblPatLastName.Location = new System.Drawing.Point(9, 149);
            this.lblPatLastName.Name = "lblPatLastName";
            this.lblPatLastName.Size = new System.Drawing.Size(82, 16);
            this.lblPatLastName.TabIndex = 16;
            this.lblPatLastName.Text = "Last Name";
            // 
            // btnPatientNames
            // 
            this.btnPatientNames.Location = new System.Drawing.Point(10, 405);
            this.btnPatientNames.Name = "btnPatientNames";
            this.btnPatientNames.Size = new System.Drawing.Size(121, 23);
            this.btnPatientNames.TabIndex = 15;
            this.btnPatientNames.Text = "Patient Names";
            this.btnPatientNames.UseVisualStyleBackColor = true;
            this.btnPatientNames.Click += new System.EventHandler(this.btnPatientNames_Click);
            // 
            // btnContact
            // 
            this.btnContact.Location = new System.Drawing.Point(12, 461);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(75, 23);
            this.btnContact.TabIndex = 14;
            this.btnContact.Text = "Contact";
            this.btnContact.UseVisualStyleBackColor = true;
            this.btnContact.Click += new System.EventHandler(this.btnContact_Click);
            // 
            // btnShowPatient
            // 
            this.btnShowPatient.Location = new System.Drawing.Point(12, 434);
            this.btnShowPatient.Name = "btnShowPatient";
            this.btnShowPatient.Size = new System.Drawing.Size(108, 23);
            this.btnShowPatient.TabIndex = 13;
            this.btnShowPatient.Text = "Show Patient";
            this.btnShowPatient.UseVisualStyleBackColor = true;
            this.btnShowPatient.Click += new System.EventHandler(this.btnShowPatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(155, 404);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(97, 23);
            this.btnAddPatient.TabIndex = 12;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // txtPatPhone
            // 
            this.txtPatPhone.Location = new System.Drawing.Point(92, 345);
            this.txtPatPhone.Name = "txtPatPhone";
            this.txtPatPhone.Size = new System.Drawing.Size(100, 22);
            this.txtPatPhone.TabIndex = 11;
            // 
            // lblPatPhone
            // 
            this.lblPatPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatPhone.Location = new System.Drawing.Point(7, 348);
            this.lblPatPhone.Name = "lblPatPhone";
            this.lblPatPhone.Size = new System.Drawing.Size(52, 23);
            this.lblPatPhone.TabIndex = 10;
            this.lblPatPhone.Text = "Phone";
            // 
            // txtPatEmail
            // 
            this.txtPatEmail.Location = new System.Drawing.Point(92, 290);
            this.txtPatEmail.Name = "txtPatEmail";
            this.txtPatEmail.Size = new System.Drawing.Size(100, 22);
            this.txtPatEmail.TabIndex = 9;
            // 
            // lblPatEmail
            // 
            this.lblPatEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatEmail.Location = new System.Drawing.Point(7, 293);
            this.lblPatEmail.Name = "lblPatEmail";
            this.lblPatEmail.Size = new System.Drawing.Size(49, 23);
            this.lblPatEmail.TabIndex = 8;
            this.lblPatEmail.Text = "Email";
            // 
            // txtPatID
            // 
            this.txtPatID.Location = new System.Drawing.Point(92, 241);
            this.txtPatID.Name = "txtPatID";
            this.txtPatID.Size = new System.Drawing.Size(100, 22);
            this.txtPatID.TabIndex = 7;
            // 
            // lblPatID
            // 
            this.lblPatID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatID.Location = new System.Drawing.Point(10, 244);
            this.lblPatID.Name = "lblPatID";
            this.lblPatID.Size = new System.Drawing.Size(74, 23);
            this.lblPatID.TabIndex = 6;
            this.lblPatID.Text = "Patient ID";
            // 
            // lblPatDOB
            // 
            this.lblPatDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatDOB.Location = new System.Drawing.Point(7, 194);
            this.lblPatDOB.Name = "lblPatDOB";
            this.lblPatDOB.Size = new System.Drawing.Size(36, 23);
            this.lblPatDOB.TabIndex = 4;
            this.lblPatDOB.Text = "DOB";
            // 
            // txtPatFirstName
            // 
            this.txtPatFirstName.Location = new System.Drawing.Point(92, 97);
            this.txtPatFirstName.Name = "txtPatFirstName";
            this.txtPatFirstName.Size = new System.Drawing.Size(100, 22);
            this.txtPatFirstName.TabIndex = 3;
            // 
            // lblPatFirstName
            // 
            this.lblPatFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatFirstName.Location = new System.Drawing.Point(6, 96);
            this.lblPatFirstName.Name = "lblPatFirstName";
            this.lblPatFirstName.Size = new System.Drawing.Size(80, 23);
            this.lblPatFirstName.TabIndex = 2;
            this.lblPatFirstName.Text = "First Name";
            // 
            // lblPatTitle
            // 
            this.lblPatTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatTitle.Location = new System.Drawing.Point(7, 48);
            this.lblPatTitle.Name = "lblPatTitle";
            this.lblPatTitle.Size = new System.Drawing.Size(42, 19);
            this.lblPatTitle.TabIndex = 0;
            this.lblPatTitle.Text = "Title";
            // 
            // grpStaff
            // 
            this.grpStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grpStaff.Controls.Add(this.txtStaffSearch);
            this.grpStaff.Controls.Add(this.txtStaffRemove);
            this.grpStaff.Controls.Add(this.btnDeleteStaff);
            this.grpStaff.Controls.Add(this.btnSearchStaff);
            this.grpStaff.Controls.Add(this.dtpStaff);
            this.grpStaff.Controls.Add(this.cmbStaffTitle);
            this.grpStaff.Controls.Add(this.btnStaffContact);
            this.grpStaff.Controls.Add(this.btnStaffNames);
            this.grpStaff.Controls.Add(this.btnShowStaff);
            this.grpStaff.Controls.Add(this.btnStaffAdd);
            this.grpStaff.Controls.Add(this.txtStaffPhone);
            this.grpStaff.Controls.Add(this.lblStaffPhone);
            this.grpStaff.Controls.Add(this.txtStaffEmail);
            this.grpStaff.Controls.Add(this.lblStaffEmail);
            this.grpStaff.Controls.Add(this.txtStaffID);
            this.grpStaff.Controls.Add(this.lblStaffID);
            this.grpStaff.Controls.Add(this.lblStaffDOB);
            this.grpStaff.Controls.Add(this.txtStaffLastName);
            this.grpStaff.Controls.Add(this.lblStaffLastName);
            this.grpStaff.Controls.Add(this.txtStaffFirstName);
            this.grpStaff.Controls.Add(this.lblStaffFirstName);
            this.grpStaff.Controls.Add(this.lblStaffTitle);
            this.grpStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStaff.Location = new System.Drawing.Point(407, 98);
            this.grpStaff.Name = "grpStaff";
            this.grpStaff.Size = new System.Drawing.Size(331, 499);
            this.grpStaff.TabIndex = 1;
            this.grpStaff.TabStop = false;
            this.grpStaff.Text = "Add Staff";
            // 
            // txtStaffRemove
            // 
            this.txtStaffRemove.Location = new System.Drawing.Point(238, 463);
            this.txtStaffRemove.Name = "txtStaffRemove";
            this.txtStaffRemove.Size = new System.Drawing.Size(76, 21);
            this.txtStaffRemove.TabIndex = 22;
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.Location = new System.Drawing.Point(145, 463);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteStaff.TabIndex = 21;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = true;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(145, 432);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStaff.TabIndex = 20;
            this.btnSearchStaff.Text = "Search";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // dtpStaff
            // 
            this.dtpStaff.Location = new System.Drawing.Point(99, 199);
            this.dtpStaff.Name = "dtpStaff";
            this.dtpStaff.Size = new System.Drawing.Size(150, 21);
            this.dtpStaff.TabIndex = 19;
            // 
            // cmbStaffTitle
            // 
            this.cmbStaffTitle.FormattingEnabled = true;
            this.cmbStaffTitle.Items.AddRange(new object[] {
            "Mr.",
            "Ms.",
            "Mrs."});
            this.cmbStaffTitle.Location = new System.Drawing.Point(99, 48);
            this.cmbStaffTitle.Name = "cmbStaffTitle";
            this.cmbStaffTitle.Size = new System.Drawing.Size(100, 23);
            this.cmbStaffTitle.TabIndex = 18;
            // 
            // btnStaffContact
            // 
            this.btnStaffContact.Location = new System.Drawing.Point(12, 463);
            this.btnStaffContact.Name = "btnStaffContact";
            this.btnStaffContact.Size = new System.Drawing.Size(75, 23);
            this.btnStaffContact.TabIndex = 17;
            this.btnStaffContact.Text = "Contact";
            this.btnStaffContact.UseVisualStyleBackColor = true;
            this.btnStaffContact.Click += new System.EventHandler(this.btnStaffContact_Click);
            // 
            // btnStaffNames
            // 
            this.btnStaffNames.Location = new System.Drawing.Point(6, 405);
            this.btnStaffNames.Name = "btnStaffNames";
            this.btnStaffNames.Size = new System.Drawing.Size(93, 23);
            this.btnStaffNames.TabIndex = 16;
            this.btnStaffNames.Text = "Staff Names";
            this.btnStaffNames.UseVisualStyleBackColor = true;
            this.btnStaffNames.Click += new System.EventHandler(this.btnStaffNames_Click);
            // 
            // btnShowStaff
            // 
            this.btnShowStaff.Location = new System.Drawing.Point(9, 433);
            this.btnShowStaff.Name = "btnShowStaff";
            this.btnShowStaff.Size = new System.Drawing.Size(90, 23);
            this.btnShowStaff.TabIndex = 15;
            this.btnShowStaff.Text = "Show Staff";
            this.btnShowStaff.UseVisualStyleBackColor = true;
            this.btnShowStaff.Click += new System.EventHandler(this.btnShowStaff_Click);
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.Location = new System.Drawing.Point(145, 404);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(75, 23);
            this.btnStaffAdd.TabIndex = 14;
            this.btnStaffAdd.Text = "Add Staff";
            this.btnStaffAdd.UseVisualStyleBackColor = true;
            this.btnStaffAdd.Click += new System.EventHandler(this.btnStaffAdd_Click);
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(99, 352);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(100, 21);
            this.txtStaffPhone.TabIndex = 13;
            // 
            // lblStaffPhone
            // 
            this.lblStaffPhone.AutoSize = true;
            this.lblStaffPhone.Location = new System.Drawing.Point(9, 352);
            this.lblStaffPhone.Name = "lblStaffPhone";
            this.lblStaffPhone.Size = new System.Drawing.Size(48, 15);
            this.lblStaffPhone.TabIndex = 12;
            this.lblStaffPhone.Text = "Phone";
            // 
            // txtStaffEmail
            // 
            this.txtStaffEmail.Location = new System.Drawing.Point(99, 297);
            this.txtStaffEmail.Name = "txtStaffEmail";
            this.txtStaffEmail.Size = new System.Drawing.Size(100, 21);
            this.txtStaffEmail.TabIndex = 11;
            // 
            // lblStaffEmail
            // 
            this.lblStaffEmail.AutoSize = true;
            this.lblStaffEmail.Location = new System.Drawing.Point(9, 297);
            this.lblStaffEmail.Name = "lblStaffEmail";
            this.lblStaffEmail.Size = new System.Drawing.Size(44, 15);
            this.lblStaffEmail.TabIndex = 10;
            this.lblStaffEmail.Text = "Email";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(99, 245);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(100, 21);
            this.txtStaffID.TabIndex = 9;
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(6, 248);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(54, 15);
            this.lblStaffID.TabIndex = 8;
            this.lblStaffID.Text = "Staff ID";
            // 
            // lblStaffDOB
            // 
            this.lblStaffDOB.AutoSize = true;
            this.lblStaffDOB.Location = new System.Drawing.Point(9, 199);
            this.lblStaffDOB.Name = "lblStaffDOB";
            this.lblStaffDOB.Size = new System.Drawing.Size(36, 15);
            this.lblStaffDOB.TabIndex = 6;
            this.lblStaffDOB.Text = "DOB";
            // 
            // txtStaffLastName
            // 
            this.txtStaffLastName.Location = new System.Drawing.Point(99, 146);
            this.txtStaffLastName.Name = "txtStaffLastName";
            this.txtStaffLastName.Size = new System.Drawing.Size(100, 21);
            this.txtStaffLastName.TabIndex = 5;
            // 
            // lblStaffLastName
            // 
            this.lblStaffLastName.AutoSize = true;
            this.lblStaffLastName.Location = new System.Drawing.Point(6, 150);
            this.lblStaffLastName.Name = "lblStaffLastName";
            this.lblStaffLastName.Size = new System.Drawing.Size(76, 15);
            this.lblStaffLastName.TabIndex = 4;
            this.lblStaffLastName.Text = "Last Name";
            // 
            // txtStaffFirstName
            // 
            this.txtStaffFirstName.Location = new System.Drawing.Point(99, 98);
            this.txtStaffFirstName.Name = "txtStaffFirstName";
            this.txtStaffFirstName.Size = new System.Drawing.Size(100, 21);
            this.txtStaffFirstName.TabIndex = 3;
            // 
            // lblStaffFirstName
            // 
            this.lblStaffFirstName.Location = new System.Drawing.Point(6, 101);
            this.lblStaffFirstName.Name = "lblStaffFirstName";
            this.lblStaffFirstName.Size = new System.Drawing.Size(79, 20);
            this.lblStaffFirstName.TabIndex = 2;
            this.lblStaffFirstName.Text = "First Name";
            // 
            // lblStaffTitle
            // 
            this.lblStaffTitle.AutoSize = true;
            this.lblStaffTitle.Location = new System.Drawing.Point(6, 48);
            this.lblStaffTitle.Name = "lblStaffTitle";
            this.lblStaffTitle.Size = new System.Drawing.Size(35, 15);
            this.lblStaffTitle.TabIndex = 0;
            this.lblStaffTitle.Text = "Title";
            // 
            // lblRemarks
            // 
            this.lblRemarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblRemarks.Location = new System.Drawing.Point(19, 634);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(68, 23);
            this.lblRemarks.TabIndex = 2;
            this.lblRemarks.Text = "Remarks";
            // 
            // lblDisplayRemarks
            // 
            this.lblDisplayRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblDisplayRemarks.Location = new System.Drawing.Point(102, 634);
            this.lblDisplayRemarks.Name = "lblDisplayRemarks";
            this.lblDisplayRemarks.Size = new System.Drawing.Size(218, 23);
            this.lblDisplayRemarks.TabIndex = 3;
            // 
            // lstDisplay
            // 
            this.lstDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.Location = new System.Drawing.Point(75, 673);
            this.lstDisplay.Name = "lstDisplay";
            this.lstDisplay.Size = new System.Drawing.Size(582, 69);
            this.lstDisplay.TabIndex = 4;
            // 
            // lblHospAdmin
            // 
            this.lblHospAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHospAdmin.Location = new System.Drawing.Point(231, 22);
            this.lblHospAdmin.Name = "lblHospAdmin";
            this.lblHospAdmin.Size = new System.Drawing.Size(227, 44);
            this.lblHospAdmin.TabIndex = 5;
            this.lblHospAdmin.Text = "Hospital Administration";
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(75, 762);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(582, 78);
            this.dgv.TabIndex = 6;
            // 
            // txtPatSearch
            // 
            this.txtPatSearch.Location = new System.Drawing.Point(236, 433);
            this.txtPatSearch.Name = "txtPatSearch";
            this.txtPatSearch.Size = new System.Drawing.Size(84, 22);
            this.txtPatSearch.TabIndex = 23;
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.Location = new System.Drawing.Point(238, 434);
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.Size = new System.Drawing.Size(76, 21);
            this.txtStaffSearch.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 852);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblHospAdmin);
            this.Controls.Add(this.lstDisplay);
            this.Controls.Add(this.lblDisplayRemarks);
            this.Controls.Add(this.lblRemarks);
            this.Controls.Add(this.grpStaff);
            this.Controls.Add(this.grpPatient);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpPatient.ResumeLayout(false);
            this.grpPatient.PerformLayout();
            this.grpStaff.ResumeLayout(false);
            this.grpStaff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPatient;
        private System.Windows.Forms.Label lblPatDOB;
        private System.Windows.Forms.TextBox txtPatFirstName;
        private System.Windows.Forms.Label lblPatFirstName;
        private System.Windows.Forms.Label lblPatTitle;
        private System.Windows.Forms.GroupBox grpStaff;
        private System.Windows.Forms.TextBox txtPatEmail;
        private System.Windows.Forms.Label lblPatEmail;
        private System.Windows.Forms.TextBox txtPatID;
        private System.Windows.Forms.Label lblPatID;
        private System.Windows.Forms.Button btnPatientNames;
        private System.Windows.Forms.Button btnContact;
        private System.Windows.Forms.Button btnShowPatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.TextBox txtPatPhone;
        private System.Windows.Forms.Label lblPatPhone;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Label lblDisplayRemarks;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.TextBox txtPatLastName;
        private System.Windows.Forms.Label lblPatLastName;
        private System.Windows.Forms.Button btnStaffContact;
        private System.Windows.Forms.Button btnStaffNames;
        private System.Windows.Forms.Button btnShowStaff;
        private System.Windows.Forms.Button btnStaffAdd;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.Label lblStaffPhone;
        private System.Windows.Forms.TextBox txtStaffEmail;
        private System.Windows.Forms.Label lblStaffEmail;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblStaffDOB;
        private System.Windows.Forms.TextBox txtStaffLastName;
        private System.Windows.Forms.Label lblStaffLastName;
        private System.Windows.Forms.TextBox txtStaffFirstName;
        private System.Windows.Forms.Label lblStaffFirstName;
        private System.Windows.Forms.Label lblStaffTitle;
        private System.Windows.Forms.Label lblHospAdmin;
        private System.Windows.Forms.ComboBox cmbPatTitle;
        private System.Windows.Forms.ComboBox cmbStaffTitle;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DateTimePicker dtpPat;
        private System.Windows.Forms.DateTimePicker dtpStaff;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnSearchPatient;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.TextBox txtPatRemove;
        private System.Windows.Forms.TextBox txtStaffRemove;
        private System.Windows.Forms.TextBox txtPatSearch;
        private System.Windows.Forms.TextBox txtStaffSearch;
    }
}

