namespace Collegexxx
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
            this.grpStudent = new System.Windows.Forms.GroupBox();
            this.btnAddToDB = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboCourse = new System.Windows.Forms.ComboBox();
            this.cboCounty = new System.Windows.Forms.ComboBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddLec = new System.Windows.Forms.Button();
            this.txtLecSN = new System.Windows.Forms.TextBox();
            this.txtLecFN = new System.Windows.Forms.TextBox();
            this.cboLecCourse = new System.Windows.Forms.ComboBox();
            this.cboLecCounty = new System.Windows.Forms.ComboBox();
            this.dtpLecDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLecHours = new System.Windows.Forms.TextBox();
            this.lblLecHours = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.grpStudent.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStudent
            // 
            this.grpStudent.Controls.Add(this.btnView);
            this.grpStudent.Controls.Add(this.btnAddToDB);
            this.grpStudent.Controls.Add(this.txtSurname);
            this.grpStudent.Controls.Add(this.txtName);
            this.grpStudent.Controls.Add(this.cboCourse);
            this.grpStudent.Controls.Add(this.cboCounty);
            this.grpStudent.Controls.Add(this.dtp1);
            this.grpStudent.Controls.Add(this.lblCourse);
            this.grpStudent.Controls.Add(this.lblCounty);
            this.grpStudent.Controls.Add(this.lblSurname);
            this.grpStudent.Controls.Add(this.lblDOB);
            this.grpStudent.Controls.Add(this.lblName);
            this.grpStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudent.Location = new System.Drawing.Point(12, 12);
            this.grpStudent.Name = "grpStudent";
            this.grpStudent.Size = new System.Drawing.Size(655, 514);
            this.grpStudent.TabIndex = 0;
            this.grpStudent.TabStop = false;
            this.grpStudent.Text = "Add Student";
            // 
            // btnAddToDB
            // 
            this.btnAddToDB.Location = new System.Drawing.Point(21, 328);
            this.btnAddToDB.Name = "btnAddToDB";
            this.btnAddToDB.Size = new System.Drawing.Size(186, 54);
            this.btnAddToDB.TabIndex = 10;
            this.btnAddToDB.Text = "Add to DB";
            this.btnAddToDB.UseVisualStyleBackColor = true;
            this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(160, 89);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(340, 32);
            this.txtSurname.TabIndex = 9;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(340, 32);
            this.txtName.TabIndex = 8;
            // 
            // cboCourse
            // 
            this.cboCourse.FormattingEnabled = true;
            this.cboCourse.Location = new System.Drawing.Point(160, 262);
            this.cboCourse.Name = "cboCourse";
            this.cboCourse.Size = new System.Drawing.Size(340, 34);
            this.cboCourse.TabIndex = 7;
            // 
            // cboCounty
            // 
            this.cboCounty.FormattingEnabled = true;
            this.cboCounty.Location = new System.Drawing.Point(160, 197);
            this.cboCounty.Name = "cboCounty";
            this.cboCounty.Size = new System.Drawing.Size(340, 34);
            this.cboCounty.TabIndex = 6;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(160, 141);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(340, 32);
            this.dtp1.TabIndex = 5;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(18, 270);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(88, 26);
            this.lblCourse.TabIndex = 4;
            this.lblCourse.Text = "Course:";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(16, 205);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(87, 26);
            this.lblCounty.TabIndex = 3;
            this.lblCounty.Text = "County:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(18, 89);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(107, 26);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(18, 146);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(136, 26);
            this.lblDOB.TabIndex = 1;
            this.lblDOB.Text = "Date of birth:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 39);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // btnAddLec
            // 
            this.btnAddLec.Location = new System.Drawing.Point(21, 392);
            this.btnAddLec.Name = "btnAddLec";
            this.btnAddLec.Size = new System.Drawing.Size(186, 54);
            this.btnAddLec.TabIndex = 10;
            this.btnAddLec.Text = "Add to DB";
            this.btnAddLec.UseVisualStyleBackColor = true;
            this.btnAddLec.Click += new System.EventHandler(this.btnAddLec_Click);
            // 
            // txtLecSN
            // 
            this.txtLecSN.Location = new System.Drawing.Point(160, 89);
            this.txtLecSN.Name = "txtLecSN";
            this.txtLecSN.Size = new System.Drawing.Size(340, 32);
            this.txtLecSN.TabIndex = 9;
            // 
            // txtLecFN
            // 
            this.txtLecFN.Location = new System.Drawing.Point(160, 33);
            this.txtLecFN.Name = "txtLecFN";
            this.txtLecFN.Size = new System.Drawing.Size(340, 32);
            this.txtLecFN.TabIndex = 8;
            // 
            // cboLecCourse
            // 
            this.cboLecCourse.FormattingEnabled = true;
            this.cboLecCourse.Location = new System.Drawing.Point(160, 262);
            this.cboLecCourse.Name = "cboLecCourse";
            this.cboLecCourse.Size = new System.Drawing.Size(340, 34);
            this.cboLecCourse.TabIndex = 7;
            // 
            // cboLecCounty
            // 
            this.cboLecCounty.FormattingEnabled = true;
            this.cboLecCounty.Location = new System.Drawing.Point(160, 197);
            this.cboLecCounty.Name = "cboLecCounty";
            this.cboLecCounty.Size = new System.Drawing.Size(340, 34);
            this.cboLecCounty.TabIndex = 6;
            // 
            // dtpLecDOB
            // 
            this.dtpLecDOB.Location = new System.Drawing.Point(160, 141);
            this.dtpLecDOB.Name = "dtpLecDOB";
            this.dtpLecDOB.Size = new System.Drawing.Size(340, 32);
            this.dtpLecDOB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Course:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "County:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 26);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date of birth:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLecHours);
            this.groupBox1.Controls.Add(this.lblLecHours);
            this.groupBox1.Controls.Add(this.btnAddLec);
            this.groupBox1.Controls.Add(this.txtLecSN);
            this.groupBox1.Controls.Add(this.txtLecFN);
            this.groupBox1.Controls.Add(this.cboLecCourse);
            this.groupBox1.Controls.Add(this.cboLecCounty);
            this.groupBox1.Controls.Add(this.dtpLecDOB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(673, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 514);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Lecturer";
            // 
            // txtLecHours
            // 
            this.txtLecHours.Location = new System.Drawing.Point(160, 328);
            this.txtLecHours.Name = "txtLecHours";
            this.txtLecHours.Size = new System.Drawing.Size(340, 32);
            this.txtLecHours.TabIndex = 12;
            // 
            // lblLecHours
            // 
            this.lblLecHours.AutoSize = true;
            this.lblLecHours.Location = new System.Drawing.Point(18, 328);
            this.lblLecHours.Name = "lblLecHours";
            this.lblLecHours.Size = new System.Drawing.Size(76, 26);
            this.lblLecHours.TabIndex = 11;
            this.lblLecHours.Text = "Hours:";
            // 
            // btnView
            // 
            this.btnView.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnView.Location = new System.Drawing.Point(21, 439);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(186, 54);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "View People";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 538);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpStudent.ResumeLayout(false);
            this.grpStudent.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpStudent;
        private System.Windows.Forms.Button btnAddToDB;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboCourse;
        private System.Windows.Forms.ComboBox cboCounty;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddLec;
        private System.Windows.Forms.TextBox txtLecSN;
        private System.Windows.Forms.TextBox txtLecFN;
        private System.Windows.Forms.ComboBox cboLecCourse;
        private System.Windows.Forms.ComboBox cboLecCounty;
        private System.Windows.Forms.DateTimePicker dtpLecDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLecHours;
        private System.Windows.Forms.Label lblLecHours;
        private System.Windows.Forms.Button btnView;
    }
}

