﻿namespace CollegeApp
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param studentName="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxChemistry = new System.Windows.Forms.CheckBox();
            this.checkBoxPhysics = new System.Windows.Forms.CheckBox();
            this.checkBoxMath = new System.Windows.Forms.CheckBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.GridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridViewGrades = new System.Windows.Forms.DataGridView();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub1Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub2Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            this.buttonAddGrade = new System.Windows.Forms.Button();
            this.comboBoxLesson = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudents)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxChemistry);
            this.tabPage1.Controls.Add(this.checkBoxPhysics);
            this.tabPage1.Controls.Add(this.checkBoxMath);
            this.tabPage1.Controls.Add(this.ButtonDelete);
            this.tabPage1.Controls.Add(this.ButtonEdit);
            this.tabPage1.Controls.Add(this.ButtonAdd);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TextName);
            this.tabPage1.Controls.Add(this.GridViewStudents);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список студентов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxChemistry
            // 
            this.checkBoxChemistry.AutoSize = true;
            this.checkBoxChemistry.Location = new System.Drawing.Point(239, 384);
            this.checkBoxChemistry.Name = "checkBoxChemistry";
            this.checkBoxChemistry.Size = new System.Drawing.Size(59, 17);
            this.checkBoxChemistry.TabIndex = 12;
            this.checkBoxChemistry.Text = "Химия";
            this.checkBoxChemistry.UseVisualStyleBackColor = true;
            this.checkBoxChemistry.CheckedChanged += new System.EventHandler(this.checkBoxArt_CheckedChanged);
            // 
            // checkBoxPhysics
            // 
            this.checkBoxPhysics.AutoSize = true;
            this.checkBoxPhysics.Location = new System.Drawing.Point(239, 361);
            this.checkBoxPhysics.Name = "checkBoxPhysics";
            this.checkBoxPhysics.Size = new System.Drawing.Size(67, 17);
            this.checkBoxPhysics.TabIndex = 11;
            this.checkBoxPhysics.Text = "Физика";
            this.checkBoxPhysics.UseVisualStyleBackColor = true;
            this.checkBoxPhysics.CheckedChanged += new System.EventHandler(this.checkBoxScience_CheckedChanged);
            // 
            // checkBoxMath
            // 
            this.checkBoxMath.AutoSize = true;
            this.checkBoxMath.Location = new System.Drawing.Point(239, 338);
            this.checkBoxMath.Name = "checkBoxMath";
            this.checkBoxMath.Size = new System.Drawing.Size(89, 17);
            this.checkBoxMath.TabIndex = 10;
            this.checkBoxMath.Text = "Математика";
            this.checkBoxMath.UseVisualStyleBackColor = true;
            this.checkBoxMath.CheckedChanged += new System.EventHandler(this.checkBoxMath_CheckedChanged);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(514, 333);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 9;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(433, 333);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 8;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(352, 333);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Направления";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(123, 335);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(100, 20);
            this.TextName.TabIndex = 1;
            // 
            // GridViewStudents
            // 
            this.GridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName,
            this.Subject1,
            this.Subject2});
            this.GridViewStudents.Location = new System.Drawing.Point(3, 6);
            this.GridViewStudents.Name = "GridViewStudents";
            this.GridViewStudents.Size = new System.Drawing.Size(853, 285);
            this.GridViewStudents.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.comboBoxLesson);
            this.tabPage2.Controls.Add(this.buttonAddGrade);
            this.tabPage2.Controls.Add(this.numericUpDownGrade);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.GridViewGrades);
            this.tabPage2.Controls.Add(this.comboBoxSubjects);
            this.tabPage2.Controls.Add(this.comboBoxStudents);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridViewGrades
            // 
            this.GridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentFullName,
            this.Sub1,
            this.Sub1Grades,
            this.Sub2,
            this.Sub2Grades});
            this.GridViewGrades.Location = new System.Drawing.Point(3, 57);
            this.GridViewGrades.Name = "GridViewGrades";
            this.GridViewGrades.Size = new System.Drawing.Size(853, 346);
            this.GridViewGrades.TabIndex = 2;
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(133, 29);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubjects.TabIndex = 1;
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(6, 29);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudents.TabIndex = 0;
            this.comboBoxStudents.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudents_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(864, 409);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчеты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 409);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Преподаватели";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.HeaderText = "ФИО";
            this.FullName.MaxInputLength = 100;
            this.FullName.Name = "FullName";
            // 
            // Subject1
            // 
            this.Subject1.HeaderText = "направление 1";
            this.Subject1.Name = "Subject1";
            this.Subject1.Width = 170;
            // 
            // Subject2
            // 
            this.Subject2.HeaderText = "направление 2";
            this.Subject2.Name = "Subject2";
            this.Subject2.Width = 170;
            // 
            // StudentFullName
            // 
            this.StudentFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StudentFullName.HeaderText = "ФИО";
            this.StudentFullName.Name = "StudentFullName";
            // 
            // Sub1
            // 
            this.Sub1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sub1.HeaderText = "Направление 1";
            this.Sub1.Name = "Sub1";
            // 
            // Sub1Grades
            // 
            this.Sub1Grades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sub1Grades.HeaderText = "Оценки";
            this.Sub1Grades.Name = "Sub1Grades";
            this.Sub1Grades.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sub2
            // 
            this.Sub2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sub2.HeaderText = "Направление 2";
            this.Sub2.Name = "Sub2";
            // 
            // Sub2Grades
            // 
            this.Sub2Grades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sub2Grades.HeaderText = "Оценки";
            this.Sub2Grades.Name = "Sub2Grades";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО студента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Предмет";
            // 
            // numericUpDownGrade
            // 
            this.numericUpDownGrade.Location = new System.Drawing.Point(387, 29);
            this.numericUpDownGrade.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownGrade.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownGrade.Name = "numericUpDownGrade";
            this.numericUpDownGrade.ReadOnly = true;
            this.numericUpDownGrade.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownGrade.TabIndex = 5;
            this.numericUpDownGrade.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // buttonAddGrade
            // 
            this.buttonAddGrade.Location = new System.Drawing.Point(513, 27);
            this.buttonAddGrade.Name = "buttonAddGrade";
            this.buttonAddGrade.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGrade.TabIndex = 6;
            this.buttonAddGrade.Text = "button1";
            this.buttonAddGrade.UseVisualStyleBackColor = true;
            this.buttonAddGrade.Click += new System.EventHandler(this.buttonAddGrade_Click);
            // 
            // comboBoxLesson
            // 
            this.comboBoxLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLesson.FormattingEnabled = true;
            this.comboBoxLesson.Location = new System.Drawing.Point(260, 28);
            this.comboBoxLesson.Name = "comboBoxLesson";
            this.comboBoxLesson.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLesson.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(260, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Номер урока";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Оценка";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(900, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main";
            this.Text = "Эл. деканат";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudents)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGrade)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView GridViewStudents;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.DataGridView GridViewGrades;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBoxChemistry;
        private System.Windows.Forms.CheckBox checkBoxPhysics;
        private System.Windows.Forms.CheckBox checkBoxMath;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject2;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub1Grades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub2Grades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLesson;
        private System.Windows.Forms.Button buttonAddGrade;
        private System.Windows.Forms.NumericUpDown numericUpDownGrade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

