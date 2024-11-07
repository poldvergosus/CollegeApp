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
            checkBox7 = new System.Windows.Forms.CheckBox();
            checkBox6 = new System.Windows.Forms.CheckBox();
            checkBox5 = new System.Windows.Forms.CheckBox();
            checkBox4 = new System.Windows.Forms.CheckBox();
            checkBox3 = new System.Windows.Forms.CheckBox();
            checkBox2 = new System.Windows.Forms.CheckBox();
            checkBox1 = new System.Windows.Forms.CheckBox();
            ButtonAddTeach = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            RadioButtonChemistry = new System.Windows.Forms.RadioButton();
            RadioButtonPhysics = new System.Windows.Forms.RadioButton();
            RadioButtonMath = new System.Windows.Forms.RadioButton();
            TextBoxTeachPass = new System.Windows.Forms.TextBox();
            TextBoxTeachLogin = new System.Windows.Forms.TextBox();
            TextNameTeach = new System.Windows.Forms.TextBox();
            GridViewTeachers = new System.Windows.Forms.DataGridView();
            Column1ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2Логин = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3Пароль = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4Предмет = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewStudents).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GridViewGrades).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            tabPage4.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewTeachers).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new System.Drawing.Point(16, 19);
            tabControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new System.Drawing.Size(1162, 669);
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
            tabPage1.Location = new System.Drawing.Point(4, 29);
            tabPage1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tabPage1.Size = new System.Drawing.Size(1154, 636);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Список студентов";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxChemistry
            // 
            checkBoxChemistry.AutoSize = true;
            checkBoxChemistry.Location = new System.Drawing.Point(319, 591);
            checkBoxChemistry.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            checkBoxChemistry.Name = "checkBoxChemistry";
            checkBoxChemistry.Size = new System.Drawing.Size(77, 24);
            checkBoxChemistry.TabIndex = 12;
            checkBoxChemistry.Text = "Химия";
            checkBoxChemistry.UseVisualStyleBackColor = true;
            checkBoxChemistry.CheckedChanged += checkBoxArt_CheckedChanged;
            // 
            // checkBoxPhysics
            // 
            checkBoxPhysics.AutoSize = true;
            checkBoxPhysics.Location = new System.Drawing.Point(319, 556);
            checkBoxPhysics.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            checkBoxPhysics.Name = "checkBoxPhysics";
            checkBoxPhysics.Size = new System.Drawing.Size(82, 24);
            checkBoxPhysics.TabIndex = 11;
            checkBoxPhysics.Text = "Физика";
            checkBoxPhysics.UseVisualStyleBackColor = true;
            checkBoxPhysics.CheckedChanged += checkBoxScience_CheckedChanged;
            // 
            // checkBoxMath
            // 
            checkBoxMath.AutoSize = true;
            checkBoxMath.Location = new System.Drawing.Point(319, 520);
            checkBoxMath.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            checkBoxMath.Name = "checkBoxMath";
            checkBoxMath.Size = new System.Drawing.Size(115, 24);
            checkBoxMath.TabIndex = 10;
            checkBoxMath.Text = "Математика";
            checkBoxMath.UseVisualStyleBackColor = true;
            checkBoxMath.CheckedChanged += checkBoxMath_CheckedChanged;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Location = new System.Drawing.Point(686, 512);
            ButtonDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new System.Drawing.Size(101, 36);
            ButtonDelete.TabIndex = 9;
            ButtonDelete.Text = "Delete";
            ButtonDelete.UseVisualStyleBackColor = true;
            ButtonDelete.Click += ButtonDelete_Click;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Location = new System.Drawing.Point(577, 512);
            ButtonEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(101, 36);
            ButtonEdit.TabIndex = 8;
            ButtonEdit.Text = "Edit";
            ButtonEdit.UseVisualStyleBackColor = true;
            ButtonEdit.Click += ButtonEdit_Click;
            // 
            // ButtonAdd
            // 
            ButtonAdd.Location = new System.Drawing.Point(470, 512);
            ButtonAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            ButtonAdd.Name = "ButtonAdd";
            ButtonAdd.Size = new System.Drawing.Size(101, 36);
            ButtonAdd.TabIndex = 7;
            ButtonAdd.Text = "Add";
            ButtonAdd.UseVisualStyleBackColor = true;
            ButtonAdd.Click += ButtonAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(314, 487);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 20);
            label2.TabIndex = 5;
            label2.Text = "Направления";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(200, 487);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(42, 20);
            label1.TabIndex = 4;
            label1.Text = "ФИО";
            // 
            // TextName
            // 
            TextName.Location = new System.Drawing.Point(165, 516);
            TextName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            TextName.Name = "TextName";
            TextName.Size = new System.Drawing.Size(132, 27);
            TextName.TabIndex = 1;
            // 
            // GridViewStudents
            // 
            GridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { FullName, Subject1, Subject2 });
            GridViewStudents.Location = new System.Drawing.Point(5, 9);
            GridViewStudents.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            GridViewStudents.Name = "GridViewStudents";
            GridViewStudents.RowHeadersWidth = 51;
            GridViewStudents.Size = new System.Drawing.Size(1137, 439);
            GridViewStudents.TabIndex = 0;
            // 
            // FullName
            // 
            FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            FullName.HeaderText = "ФИО";
            FullName.MaxInputLength = 100;
            FullName.MinimumWidth = 6;
            FullName.Name = "FullName";
            // 
            // Subject1
            // 
            Subject1.HeaderText = "направление 1";
            Subject1.MinimumWidth = 6;
            Subject1.Name = "Subject1";
            Subject1.Width = 170;
            // 
            // Subject2
            // 
            Subject2.HeaderText = "направление 2";
            Subject2.MinimumWidth = 6;
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
            tabPage2.Location = new System.Drawing.Point(4, 29);
            tabPage2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tabPage2.Size = new System.Drawing.Size(1154, 636);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Оценки";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(515, 20);
            label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(61, 20);
            label6.TabIndex = 9;
            label6.Text = "Оценка";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(346, 20);
            label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(101, 20);
            label5.TabIndex = 8;
            label5.Text = "Номер урока";
            // 
            // comboBoxLesson
            // 
            comboBoxLesson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxLesson.FormattingEnabled = true;
            comboBoxLesson.Location = new System.Drawing.Point(346, 43);
            comboBoxLesson.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboBoxLesson.Name = "comboBoxLesson";
            comboBoxLesson.Size = new System.Drawing.Size(159, 28);
            comboBoxLesson.TabIndex = 7;
            // 
            // buttonAddGrade
            // 
            buttonAddGrade.Location = new System.Drawing.Point(683, 41);
            buttonAddGrade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            buttonAddGrade.Name = "buttonAddGrade";
            buttonAddGrade.Size = new System.Drawing.Size(101, 36);
            buttonAddGrade.TabIndex = 6;
            buttonAddGrade.Text = "button1";
            buttonAddGrade.UseVisualStyleBackColor = true;
            buttonAddGrade.Click += buttonAddGrade_Click;
            // 
            // numericUpDownGrade
            // 
            numericUpDownGrade.Location = new System.Drawing.Point(515, 44);
            numericUpDownGrade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            numericUpDownGrade.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownGrade.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numericUpDownGrade.Name = "numericUpDownGrade";
            numericUpDownGrade.ReadOnly = true;
            numericUpDownGrade.Size = new System.Drawing.Size(160, 27);
            numericUpDownGrade.TabIndex = 5;
            numericUpDownGrade.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(174, 20);
            label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(70, 20);
            label4.TabIndex = 4;
            label4.Text = "Предмет";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(8, 20);
            label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(105, 20);
            label3.TabIndex = 3;
            label3.Text = "ФИО студента";
            // 
            // GridViewGrades
            // 
            GridViewGrades.ColumnHeadersHeight = 29;
            GridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            GridViewGrades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { StudentFullName, Sub1, Sub1Grades, Sub2, Sub2Grades });
            GridViewGrades.Location = new System.Drawing.Point(5, 88);
            GridViewGrades.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            GridViewGrades.Name = "GridViewGrades";
            GridViewGrades.RowHeadersWidth = 51;
            GridViewGrades.Size = new System.Drawing.Size(1137, 532);
            GridViewGrades.TabIndex = 2;
            // 
            // StudentFullName
            // 
            StudentFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            StudentFullName.HeaderText = "ФИО";
            StudentFullName.MinimumWidth = 6;
            StudentFullName.Name = "StudentFullName";
            // 
            // Sub1
            // 
            Sub1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sub1.HeaderText = "Направление 1";
            Sub1.MinimumWidth = 6;
            Sub1.Name = "Sub1";
            // 
            // Sub1Grades
            // 
            Sub1Grades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sub1Grades.HeaderText = "Оценки";
            Sub1Grades.MinimumWidth = 6;
            Sub1Grades.Name = "Sub1Grades";
            Sub1Grades.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sub2
            // 
            Sub2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sub2.HeaderText = "Направление 2";
            Sub2.MinimumWidth = 6;
            Sub2.Name = "Sub2";
            // 
            // Sub2Grades
            // 
            Sub2Grades.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Sub2Grades.HeaderText = "Оценки";
            Sub2Grades.MinimumWidth = 6;
            Sub2Grades.Name = "Sub2Grades";
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.Location = new System.Drawing.Point(177, 44);
            comboBoxSubjects.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new System.Drawing.Size(159, 28);
            comboBoxSubjects.TabIndex = 1;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new System.Drawing.Point(8, 44);
            comboBoxStudents.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new System.Drawing.Size(159, 28);
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
            tabPage3.Location = new System.Drawing.Point(4, 29);
            tabPage3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tabPage3.Size = new System.Drawing.Size(1154, 636);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Отчеты";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.ColumnHeadersHeight = 29;
            dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewReport.Location = new System.Drawing.Point(8, 96);
            dataGridViewReport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.RowHeadersWidth = 51;
            dataGridViewReport.Size = new System.Drawing.Size(1136, 487);
            dataGridViewReport.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn1.HeaderText = "ФИО";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn2.HeaderText = "Предмет";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Средний балл";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // labelReport2
            // 
            labelReport2.AutoSize = true;
            labelReport2.Location = new System.Drawing.Point(202, 20);
            labelReport2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelReport2.Name = "labelReport2";
            labelReport2.Size = new System.Drawing.Size(92, 20);
            labelReport2.TabIndex = 13;
            labelReport2.Text = "Сортировка";
            // 
            // comboBoxReport2
            // 
            comboBoxReport2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxReport2.FormattingEnabled = true;
            comboBoxReport2.Items.AddRange(new object[] { "от А до Я", "от Я до А", "по возраст", "по убыван" });
            comboBoxReport2.Location = new System.Drawing.Point(206, 44);
            comboBoxReport2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboBoxReport2.Name = "comboBoxReport2";
            comboBoxReport2.Size = new System.Drawing.Size(156, 28);
            comboBoxReport2.TabIndex = 12;
            // 
            // buttonReport1
            // 
            buttonReport1.Location = new System.Drawing.Point(783, 39);
            buttonReport1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            buttonReport1.Name = "buttonReport1";
            buttonReport1.Size = new System.Drawing.Size(123, 36);
            buttonReport1.TabIndex = 11;
            buttonReport1.Text = "Отсортировать";
            buttonReport1.UseVisualStyleBackColor = true;
            buttonReport1.Click += buttonSortStudents_Click;
            // 
            // labelReport1
            // 
            labelReport1.AutoSize = true;
            labelReport1.Location = new System.Drawing.Point(21, 21);
            labelReport1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            labelReport1.Name = "labelReport1";
            labelReport1.Size = new System.Drawing.Size(70, 20);
            labelReport1.TabIndex = 10;
            labelReport1.Text = "Предмет";
            // 
            // comboBoxReport1
            // 
            comboBoxReport1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxReport1.FormattingEnabled = true;
            comboBoxReport1.Items.AddRange(new object[] { "Математика", "Физика", "Химия" });
            comboBoxReport1.Location = new System.Drawing.Point(24, 45);
            comboBoxReport1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            comboBoxReport1.Name = "comboBoxReport1";
            comboBoxReport1.Size = new System.Drawing.Size(156, 28);
            comboBoxReport1.TabIndex = 8;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(checkBox7);
            tabPage4.Controls.Add(checkBox6);
            tabPage4.Controls.Add(checkBox5);
            tabPage4.Controls.Add(checkBox4);
            tabPage4.Controls.Add(checkBox3);
            tabPage4.Controls.Add(checkBox2);
            tabPage4.Controls.Add(checkBox1);
            tabPage4.Controls.Add(ButtonAddTeach);
            tabPage4.Controls.Add(groupBox1);
            tabPage4.Controls.Add(TextBoxTeachPass);
            tabPage4.Controls.Add(TextBoxTeachLogin);
            tabPage4.Controls.Add(TextNameTeach);
            tabPage4.Controls.Add(GridViewTeachers);
            tabPage4.Location = new System.Drawing.Point(4, 29);
            tabPage4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            tabPage4.Size = new System.Drawing.Size(1154, 636);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Преподаватели";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new System.Drawing.Point(830, 554);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new System.Drawing.Size(101, 24);
            checkBox7.TabIndex = 12;
            checkBox7.Text = "checkBox7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new System.Drawing.Point(723, 554);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new System.Drawing.Size(101, 24);
            checkBox6.TabIndex = 11;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new System.Drawing.Point(616, 554);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new System.Drawing.Size(101, 24);
            checkBox5.TabIndex = 10;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new System.Drawing.Point(937, 509);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new System.Drawing.Size(101, 24);
            checkBox4.TabIndex = 9;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new System.Drawing.Point(830, 509);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new System.Drawing.Size(101, 24);
            checkBox3.TabIndex = 8;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new System.Drawing.Point(723, 511);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new System.Drawing.Size(101, 24);
            checkBox2.TabIndex = 7;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new System.Drawing.Point(616, 511);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(101, 24);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // ButtonAddTeach
            // 
            ButtonAddTeach.Location = new System.Drawing.Point(497, 509);
            ButtonAddTeach.Name = "ButtonAddTeach";
            ButtonAddTeach.Size = new System.Drawing.Size(94, 29);
            ButtonAddTeach.TabIndex = 5;
            ButtonAddTeach.Text = "button1";
            ButtonAddTeach.UseVisualStyleBackColor = true;
            ButtonAddTeach.Click += ButtonAddTeach_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(RadioButtonChemistry);
            groupBox1.Controls.Add(RadioButtonPhysics);
            groupBox1.Controls.Add(RadioButtonMath);
            groupBox1.Location = new System.Drawing.Point(241, 496);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(250, 125);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Предмет";
            // 
            // RadioButtonChemistry
            // 
            RadioButtonChemistry.AutoSize = true;
            RadioButtonChemistry.Location = new System.Drawing.Point(15, 88);
            RadioButtonChemistry.Name = "RadioButtonChemistry";
            RadioButtonChemistry.Size = new System.Drawing.Size(117, 24);
            RadioButtonChemistry.TabIndex = 2;
            RadioButtonChemistry.TabStop = true;
            RadioButtonChemistry.Text = "radioButton3";
            RadioButtonChemistry.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPhysics
            // 
            RadioButtonPhysics.AutoSize = true;
            RadioButtonPhysics.Location = new System.Drawing.Point(15, 58);
            RadioButtonPhysics.Name = "RadioButtonPhysics";
            RadioButtonPhysics.Size = new System.Drawing.Size(117, 24);
            RadioButtonPhysics.TabIndex = 1;
            RadioButtonPhysics.TabStop = true;
            RadioButtonPhysics.Text = "radioButton2";
            RadioButtonPhysics.UseVisualStyleBackColor = true;
            // 
            // RadioButtonMath
            // 
            RadioButtonMath.AutoSize = true;
            RadioButtonMath.Location = new System.Drawing.Point(15, 28);
            RadioButtonMath.Name = "RadioButtonMath";
            RadioButtonMath.Size = new System.Drawing.Size(117, 24);
            RadioButtonMath.TabIndex = 0;
            RadioButtonMath.TabStop = true;
            RadioButtonMath.Text = "radioButton1";
            RadioButtonMath.UseVisualStyleBackColor = true;
            // 
            // TextBoxTeachPass
            // 
            TextBoxTeachPass.Location = new System.Drawing.Point(43, 575);
            TextBoxTeachPass.Name = "TextBoxTeachPass";
            TextBoxTeachPass.Size = new System.Drawing.Size(179, 27);
            TextBoxTeachPass.TabIndex = 3;
            // 
            // TextBoxTeachLogin
            // 
            TextBoxTeachLogin.Location = new System.Drawing.Point(43, 542);
            TextBoxTeachLogin.Name = "TextBoxTeachLogin";
            TextBoxTeachLogin.Size = new System.Drawing.Size(179, 27);
            TextBoxTeachLogin.TabIndex = 2;
            // 
            // TextNameTeach
            // 
            TextNameTeach.Location = new System.Drawing.Point(43, 509);
            TextNameTeach.Name = "TextNameTeach";
            TextNameTeach.Size = new System.Drawing.Size(179, 27);
            TextNameTeach.TabIndex = 1;
            // 
            // GridViewTeachers
            // 
            GridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Column1ФИО, Column2Логин, Column3Пароль, Column4Предмет, Column1, Column2, Column3, Column4, Column5 });
            GridViewTeachers.Location = new System.Drawing.Point(8, 7);
            GridViewTeachers.Name = "GridViewTeachers";
            GridViewTeachers.RowHeadersWidth = 51;
            GridViewTeachers.Size = new System.Drawing.Size(1138, 444);
            GridViewTeachers.TabIndex = 0;
            // 
            // Column1ФИО
            // 
            Column1ФИО.HeaderText = "ФИО";
            Column1ФИО.MinimumWidth = 6;
            Column1ФИО.Name = "Column1ФИО";
            Column1ФИО.Width = 125;
            // 
            // Column2Логин
            // 
            Column2Логин.HeaderText = "Логин";
            Column2Логин.MinimumWidth = 6;
            Column2Логин.Name = "Column2Логин";
            Column2Логин.Width = 125;
            // 
            // Column3Пароль
            // 
            Column3Пароль.HeaderText = "Пароль";
            Column3Пароль.MinimumWidth = 6;
            Column3Пароль.Name = "Column3Пароль";
            Column3Пароль.Width = 125;
            // 
            // Column4Предмет
            // 
            Column4Предмет.HeaderText = "Предмет";
            Column4Предмет.MinimumWidth = 6;
            Column4Предмет.Name = "Column4Предмет";
            Column4Предмет.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "ПН";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "ВТ";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "СР";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "ЧТ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "ПТ";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Main
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1176, 681);
            Controls.Add(tabControl1);
            Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            MaximumSize = new System.Drawing.Size(1194, 728);
            MinimumSize = new System.Drawing.Size(1082, 728);
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
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridViewTeachers).EndInit();
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
        private System.Windows.Forms.DataGridView GridViewTeachers;
        private System.Windows.Forms.TextBox TextBoxTeachPass;
        private System.Windows.Forms.TextBox TextBoxTeachLogin;
        private System.Windows.Forms.TextBox TextNameTeach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonAddTeach;
        private System.Windows.Forms.RadioButton RadioButtonChemistry;
        private System.Windows.Forms.RadioButton RadioButtonPhysics;
        private System.Windows.Forms.RadioButton RadioButtonMath;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Логин;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3Пароль;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4Предмет;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox7;
    }
}

