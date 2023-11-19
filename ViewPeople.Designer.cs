namespace Collegexxx
{
    partial class ViewPeople
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnShowStudents = new System.Windows.Forms.Button();
            this.btnShowLecturers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 86);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(681, 352);
            this.dgv.TabIndex = 0;
            // 
            // btnShowStudents
            // 
            this.btnShowStudents.Location = new System.Drawing.Point(12, 12);
            this.btnShowStudents.Name = "btnShowStudents";
            this.btnShowStudents.Size = new System.Drawing.Size(142, 52);
            this.btnShowStudents.TabIndex = 1;
            this.btnShowStudents.Text = "Show Students";
            this.btnShowStudents.UseVisualStyleBackColor = true;
            this.btnShowStudents.Click += new System.EventHandler(this.btnShowStudents_Click);
            // 
            // btnShowLecturers
            // 
            this.btnShowLecturers.Location = new System.Drawing.Point(289, 12);
            this.btnShowLecturers.Name = "btnShowLecturers";
            this.btnShowLecturers.Size = new System.Drawing.Size(142, 52);
            this.btnShowLecturers.TabIndex = 2;
            this.btnShowLecturers.Text = "Show Lecturers";
            this.btnShowLecturers.UseVisualStyleBackColor = true;
            this.btnShowLecturers.Click += new System.EventHandler(this.btnShowLecturers_Click);
            // 
            // ViewPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowLecturers);
            this.Controls.Add(this.btnShowStudents);
            this.Controls.Add(this.dgv);
            this.Name = "ViewPeople";
            this.Text = "ViewPeople";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnShowStudents;
        private System.Windows.Forms.Button btnShowLecturers;
    }
}