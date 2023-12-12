namespace _07LaboratoryExercise1
{
    partial class frmUpdateMember
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
            this.components = new System.ComponentModel.Container();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.comboBoxProgram = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.clubMembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clubDBDataSet = new _07LaboratoryExercise1.ClubDBDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMIddleName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.clubMembersTableAdapter = new _07LaboratoryExercise1.ClubDBDataSetTableAdapters.ClubMembersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clubMembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(156)))), ((int)(((byte)(250)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(133, 663);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(165, 54);
            this.btnConfirm.TabIndex = 33;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // comboBoxProgram
            // 
            this.comboBoxProgram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.comboBoxProgram.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxProgram.FormattingEnabled = true;
            this.comboBoxProgram.Items.AddRange(new object[] {
            "BS in Information Technology",
            "BS in Hospitality Management",
            "BS in Computer Science",
            "BS in Education"});
            this.comboBoxProgram.Location = new System.Drawing.Point(79, 596);
            this.comboBoxProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxProgram.Name = "comboBoxProgram";
            this.comboBoxProgram.Size = new System.Drawing.Size(312, 35);
            this.comboBoxProgram.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 559);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 27);
            this.label5.TabIndex = 31;
            this.label5.Text = "Program:";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(79, 507);
            this.comboBoxGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(265, 35);
            this.comboBoxGender.TabIndex = 30;
            // 
            // clubMembersBindingSource
            // 
            this.clubMembersBindingSource.DataMember = "ClubMembers";
            this.clubMembersBindingSource.DataSource = this.clubDBDataSet;
            // 
            // clubDBDataSet
            // 
            this.clubDBDataSet.DataSetName = "ClubDBDataSet";
            this.clubDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 470);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 27);
            this.label7.TabIndex = 29;
            this.label7.Text = "Gender:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.textBoxAge.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(79, 415);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(221, 34);
            this.textBoxAge.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 27);
            this.label6.TabIndex = 27;
            this.label6.Text = "Age:";
            // 
            // textBoxMIddleName
            // 
            this.textBoxMIddleName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.textBoxMIddleName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMIddleName.Location = new System.Drawing.Point(79, 324);
            this.textBoxMIddleName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMIddleName.Name = "textBoxMIddleName";
            this.textBoxMIddleName.Size = new System.Drawing.Size(312, 34);
            this.textBoxMIddleName.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(75, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 27);
            this.label4.TabIndex = 25;
            this.label4.Text = "Middle Name:";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.textBoxFirstname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstname.Location = new System.Drawing.Point(79, 230);
            this.textBoxFirstname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(312, 34);
            this.textBoxFirstname.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 23;
            this.label3.Text = "First Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(79, 138);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(312, 34);
            this.textBoxLastName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 21;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Student ID:";
            // 
            // cbStudent
            // 
            this.cbStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.cbStudent.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(77, 63);
            this.cbStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(313, 35);
            this.cbStudent.TabIndex = 34;
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.cbStudent_SelectedIndexChanged);
            // 
            // clubMembersTableAdapter
            // 
            this.clubMembersTableAdapter.ClearBeforeFill = true;
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(187)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(485, 736);
            this.Controls.Add(this.cbStudent);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.comboBoxProgram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxMIddleName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxFirstname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUpdateMember";
            this.Text = "frmUpdateMember";
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clubMembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox comboBoxProgram;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMIddleName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStudent;
        private ClubDBDataSet clubDBDataSet;
        private System.Windows.Forms.BindingSource clubMembersBindingSource;
        private ClubDBDataSetTableAdapters.ClubMembersTableAdapter clubMembersTableAdapter;
    }
}