namespace WindowsFormsUniversity
{
    partial class GroupForm
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
            System.Windows.Forms.Label faculty_nameLabel;
            this.sceduleDataSet = new WindowsFormsUniversity.SceduleDataSet();
            this.facultyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultyTableAdapter = new WindowsFormsUniversity.SceduleDataSetTableAdapters.FacultyTableAdapter();
            this.tableAdapterManager = new WindowsFormsUniversity.SceduleDataSetTableAdapters.TableAdapterManager();
            this.faculty_nameComboBox = new System.Windows.Forms.ComboBox();
            faculty_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sceduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // sceduleDataSet
            // 
            this.sceduleDataSet.DataSetName = "SceduleDataSet";
            this.sceduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultyBindingSource
            // 
            this.facultyBindingSource.DataMember = "Faculty";
            this.facultyBindingSource.DataSource = this.sceduleDataSet;
            // 
            // facultyTableAdapter
            // 
            this.facultyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuditoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CourseTableAdapter = null;
            this.tableAdapterManager.DirectionTableAdapter = null;
            this.tableAdapterManager.FacultyTableAdapter = this.facultyTableAdapter;
            this.tableAdapterManager.Group_CourseTableAdapter = null;
            this.tableAdapterManager.GroupTableAdapter = null;
            this.tableAdapterManager.Lesson_timeTableAdapter = null;
            this.tableAdapterManager.Lesson_typeTableAdapter = null;
            this.tableAdapterManager.LessonTableAdapter = null;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsUniversity.SceduleDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // faculty_nameLabel
            // 
            faculty_nameLabel.AutoSize = true;
            faculty_nameLabel.Location = new System.Drawing.Point(11, 58);
            faculty_nameLabel.Name = "faculty_nameLabel";
            faculty_nameLabel.Size = new System.Drawing.Size(70, 13);
            faculty_nameLabel.TabIndex = 1;
            faculty_nameLabel.Text = "faculty name:";
            faculty_nameLabel.Click += new System.EventHandler(this.faculty_nameLabel_Click);
            // 
            // faculty_nameComboBox
            // 
            this.faculty_nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.facultyBindingSource, "faculty_name", true));
            this.faculty_nameComboBox.FormattingEnabled = true;
            this.faculty_nameComboBox.Location = new System.Drawing.Point(118, 41);
            this.faculty_nameComboBox.Name = "faculty_nameComboBox";
            this.faculty_nameComboBox.Size = new System.Drawing.Size(121, 21);
            this.faculty_nameComboBox.TabIndex = 2;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(faculty_nameLabel);
            this.Controls.Add(this.faculty_nameComboBox);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sceduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SceduleDataSet sceduleDataSet;
        private System.Windows.Forms.BindingSource facultyBindingSource;
        private SceduleDataSetTableAdapters.FacultyTableAdapter facultyTableAdapter;
        private SceduleDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox faculty_nameComboBox;
    }
}