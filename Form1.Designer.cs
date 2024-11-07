namespace CollegeApp
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
            tabControl1 = new System.Windows.Forms.TabControl();
            tabPage1 = new System.Windows.Forms.TabPage();
            checkBoxChemistry = new System.Windows.Forms.CheckBox();
            checkBoxPhysics = new System.Windows.Forms.CheckBox();
            checkBoxMath = new System.Windows.Forms.CheckBox();
            ButtonDelete = new System.Windows.Forms.Button();
            ButtonEdit = new System.Windows.Forms.Button();
            ButtonAdd = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            TextName = new System.Windows.Forms.TextBox();
            GridViewStudents = new System.Windows.Forms.DataGridView();
            FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Subject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Subject2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabPage2 = new System.Windows.Forms.TabPage();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            comboBoxLesson = new System.Windows.Forms.ComboBox();
            buttonAddGrade = new System.Windows.Forms.Button();
            numericUpDownGrade = new System.Windows.Forms.NumericUpDown();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            GridViewGrades = new System.Windows.Forms.DataGridView();
            StudentFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sub1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sub1Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sub2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Sub2Grades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            comboBoxSubjects = new System.Windows.Forms.ComboBox();
            comboBoxStudents = new System.Windows.Forms.ComboBox();
            tabPage3 = new System.Windows.Forms.TabPage();
            dataGridViewReport = new System.Windows.Forms.DataGridView();
            dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            labelReport2 = new System.Windows.Forms.Label();
            comboBoxReport2 = new System.Windows.Forms.ComboBox();
            buttonReport1 = new System.Windows.Forms.Button();
            labelReport1 = new System.Windows.Forms.Label();
            comboBoxReport1 = new System.Windows.Forms.ComboBox();
            tabPage4 = new System.Windows.Forms.TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewStudents).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridViewGrades).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new System.Drawing.Point(14, 14);
            tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1017, 502);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(checkBoxChemistry);
            tabPage1.Controls.Add(checkBoxPhysics);
            tabPage1.Controls.Add(checkBoxMath);
            tabPage1.Controls.Add(ButtonDelete);
            tabPage1.Controls.Add(ButtonEdit);
            tabPage1.Controls.Add(ButtonAdd);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(TextName);
            tabPage1.Controls.Add(GridViewStudents);
            tabPage1.Location = new System.Drawing.Point(4, 24);
            tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage1.Size = new System.Drawing.Size(1009, 474);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Список студентов";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxChemistry
            // 
            checkBoxChemistry.AutoSize = true;
            checkBoxChemistry.Location = new System.Drawing.Point(279, 443);
            checkBoxChemistry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxChemistry.Name = "checkBoxChemistry";
            checkBoxChemistry.Size = new System.Drawing.Size(62, 19);
            checkBoxChemistry.TabIndex = 12;
            checkBoxChemistry.Text = "Химия";
            checkBoxChemistry.UseVisualStyleBackColor = true;
            checkBoxChemistry.CheckedChanged += checkBoxArt_CheckedChanged;
            // 
            // checkBoxPhysics
            // 
            checkBoxPhysics.AutoSize = true;
            checkBoxPhysics.Location = new System.Drawing.Point(279, 417);
            checkBoxPhysics.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxPhysics.Name = "checkBoxPhysics";
            checkBoxPhysics.Size = new System.Drawing.Size(66, 19);
            checkBoxPhysics.TabIndex = 11;
            checkBoxPhysics.Text = "Физика";
            checkBoxPhysics.UseVisualStyleBackColor = true;
            checkBoxPhysics.CheckedChanged += checkBoxScience_CheckedChanged;
            // 
            // checkBoxMath
            // 
            checkBoxMath.AutoSize = true;
            checkBoxMath.Location = new System.Drawing.Point(279, 390);
            checkBoxMath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            checkBoxMath.Name = "checkBoxMath";
            checkBoxMath.Size = new System.Drawing.Size(93, 19);
            checkBoxMath.TabIndex = 10;
            checkBoxMath.Text = "Математика";
            checkBoxMath.UseVisualStyleBackColor = true;
            checkBoxMath.CheckedChanged += checkBoxMath_CheckedChanged;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new System.Drawing.Point(600, 384);
            ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new System.Drawing.Size(88, 27);
            ButtonDelete.TabIndex = 9;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new System.Drawing.Point(505, 384);
            ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(88, 27);
            ButtonEdit.TabIndex = 8;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new System.Drawing.Point(411, 384);
            ButtonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new System.Drawing.Size(88, 27);
            ButtonAdd.TabIndex = 7;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(275, 365);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 15);
            label2.TabIndex = 5;
            label2.Text = "Направления";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(175, 365);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(34, 15);
            label1.TabIndex = 4;
            label1.Text = "ФИО";
            // 
            // TextName
            // 
            TextName.Location = new System.Drawing.Point(144, 387);
            TextName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextName.Name = "TextName";
            TextName.Size = new System.Drawing.Size(116, 23);
            TextName.TabIndex = 1;
            // 
            // GridViewStudents
            // 
            GridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FullName, Subject1, Subject2 });
            GridViewStudents.Location = new System.Drawing.Point(4, 7);
            GridViewStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GridViewStudents.Name = "GridViewStudents";
            GridViewStudents.Size = new System.Drawing.Size(995, 329);
            GridViewStudents.TabIndex = 0;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            FullName.HeaderText = "ФИО";
            FullName.MaxInputLength = 100;
            FullName.Name = "FullName";
            // 
            // Subject1
            // 
            Subject1.HeaderText = "направление 1";
            Subject1.Name = "Subject1";
            Subject1.Width = 170;
            // 
            // Subject2
            // 
            Subject2.HeaderText = "направление 2";
            Subject2.Name = "Subject2";
            Subject2.Width = 170;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(comboBoxLesson);
            tabPage2.Controls.Add(buttonAddGrade);
            tabPage2.Controls.Add(numericUpDownGrade);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(GridViewGrades);
            tabPage2.Controls.Add(comboBoxSubjects);
            tabPage2.Controls.Add(comboBoxStudents);
            tabPage2.Location = new System.Drawing.Point(4, 24);
            tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage2.Size = new System.Drawing.Size(1009, 474);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Оценки";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(451, 15);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 15);
            label6.TabIndex = 9;
            label6.Text = "Оценка";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(303, 15);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(80, 15);
            label5.TabIndex = 8;
            label5.Text = "Номер урока";
            // 
            // comboBoxLesson
            // 
            comboBoxLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLesson.FormattingEnabled = true;
            comboBoxLesson.Location = new System.Drawing.Point(303, 32);
            comboBoxLesson.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxLesson.Name = "comboBoxLesson";
            comboBoxLesson.Size = new System.Drawing.Size(140, 23);
            comboBoxLesson.TabIndex = 7;
            // 
            // buttonAddGrade
            // 
            buttonAddGrade.Location = new System.Drawing.Point(598, 31);
            buttonAddGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonAddGrade.Name = "buttonAddGrade";
            buttonAddGrade.Size = new System.Drawing.Size(88, 27);
            buttonAddGrade.TabIndex = 6;
            buttonAddGrade.Text = "button1";
            buttonAddGrade.UseVisualStyleBackColor = true;
            buttonAddGrade.Click += buttonAddGrade_Click;
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Location = new System.Drawing.Point(451, 33);
            numericUpDownGrade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            numericUpDownGrade.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.ReadOnly = true;
            numericUpDownGrade.Size = new System.Drawing.Size(140, 23);
            numericUpDownGrade.TabIndex = 5;
            numericUpDownGrade.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(152, 15);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "Предмет";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 15);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(84, 15);
            label3.TabIndex = 3;
            label3.Text = "ФИО студента";
            // 
            // GridViewGrades
            // 
            GridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { StudentFullName, Sub1, Sub1Grades, Sub2, Sub2Grades });
            GridViewGrades.Location = new System.Drawing.Point(4, 66);
            GridViewGrades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GridViewGrades.Name = "GridViewGrades";
            GridViewGrades.Size = new System.Drawing.Size(995, 399);
            GridViewGrades.TabIndex = 2;
            // 
            // StudentFullName
            // 
            StudentFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            StudentFullName.HeaderText = "ФИО";
            StudentFullName.Name = "StudentFullName";
            // 
            // Sub1
            // 
            Sub1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sub1.HeaderText = "Направление 1";
            Sub1.Name = "Sub1";
            // 
            // Sub1Grades
            // 
            Sub1Grades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sub1Grades.HeaderText = "Оценки";
            Sub1Grades.Name = "Sub1Grades";
            Sub1Grades.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sub2
            // 
            Sub2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sub2.HeaderText = "Направление 2";
            Sub2.Name = "Sub2";
            // 
            // Sub2Grades
            // 
            Sub2Grades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sub2Grades.HeaderText = "Оценки";
            Sub2Grades.Name = "Sub2Grades";
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.Location = new System.Drawing.Point(155, 33);
            comboBoxSubjects.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new System.Drawing.Size(140, 23);
            comboBoxSubjects.TabIndex = 1;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new System.Drawing.Point(7, 33);
            comboBoxStudents.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new System.Drawing.Size(140, 23);
            comboBoxStudents.TabIndex = 0;
            comboBoxStudents.SelectedIndexChanged += comboBoxStudents_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridViewReport);
            tabPage3.Controls.Add(labelReport2);
            tabPage3.Controls.Add(comboBoxReport2);
            tabPage3.Controls.Add(buttonReport1);
            tabPage3.Controls.Add(labelReport1);
            tabPage3.Controls.Add(comboBoxReport1);
            tabPage3.Location = new System.Drawing.Point(4, 24);
            tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage3.Size = new System.Drawing.Size(1009, 474);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Отчеты";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewReport.Location = new System.Drawing.Point(7, 72);
            dataGridViewReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.Size = new System.Drawing.Size(994, 365);
            dataGridViewReport.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Средний балл";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labelReport2
            // 
            labelReport2.AutoSize = true;
            labelReport2.Location = new System.Drawing.Point(177, 15);
            labelReport2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelReport2.Name = "labelReport2";
            labelReport2.Size = new System.Drawing.Size(73, 15);
            labelReport2.TabIndex = 13;
            labelReport2.Text = "Сортировка";
            // 
            // comboBoxReport2
            // 
            comboBoxReport2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxReport2.FormattingEnabled = true;
            comboBoxReport2.Items.AddRange(new object[] { "от А до Я", "от Я до А", "по возраст", "по убыван" });
            comboBoxReport2.Location = new System.Drawing.Point(180, 33);
            comboBoxReport2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxReport2.Name = "comboBoxReport2";
            comboBoxReport2.Size = new System.Drawing.Size(137, 23);
            comboBoxReport2.TabIndex = 12;
            // 
            // buttonReport1
            // 
            buttonReport1.Location = new System.Drawing.Point(685, 29);
            buttonReport1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            buttonReport1.Name = "buttonReport1";
            buttonReport1.Size = new System.Drawing.Size(108, 27);
            buttonReport1.TabIndex = 11;
            buttonReport1.Text = "Отсортировать";
            buttonReport1.UseVisualStyleBackColor = true;
            // 
            // labelReport1
            // 
            labelReport1.AutoSize = true;
            labelReport1.Location = new System.Drawing.Point(18, 16);
            labelReport1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelReport1.Name = "labelReport1";
            labelReport1.Size = new System.Drawing.Size(55, 15);
            labelReport1.TabIndex = 10;
            labelReport1.Text = "Предмет";
            // 
            // comboBoxReport1
            // 
            comboBoxReport1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxReport1.FormattingEnabled = true;
            comboBoxReport1.Items.AddRange(new object[] { "Математика", "Физика", "Химия" });
            comboBoxReport1.Location = new System.Drawing.Point(21, 34);
            comboBoxReport1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxReport1.Name = "comboBoxReport1";
            comboBoxReport1.Size = new System.Drawing.Size(137, 23);
            comboBoxReport1.TabIndex = 8;
            // 
            // tabPage4
            // 
            tabPage4.Location = new System.Drawing.Point(4, 24);
            tabPage4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPage4.Size = new System.Drawing.Size(1009, 474);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Преподаватели";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1031, 519);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximumSize = new System.Drawing.Size(1047, 558);
            MinimumSize = new System.Drawing.Size(949, 558);
            Name = "Main";
            Text = "Эл. деканат";
            Load += Main_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewStudents).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)GridViewGrades).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
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
        private System.Windows.Forms.Button buttonReport1;
        private System.Windows.Forms.Label labelReport1;
        private System.Windows.Forms.ComboBox comboBoxReport1;
        private System.Windows.Forms.Label labelReport2;
        private System.Windows.Forms.ComboBox comboBoxReport2;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

