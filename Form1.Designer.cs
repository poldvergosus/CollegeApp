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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.checkBoxArt = new System.Windows.Forms.CheckBox();
            this.checkBoxScience = new System.Windows.Forms.CheckBox();
            this.checkBoxMath = new System.Windows.Forms.CheckBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.GridViewStudents = new System.Windows.Forms.DataGridView();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GridViewGrades = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudents)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGrades)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(776, 435);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.checkBoxArt);
            this.tabPage1.Controls.Add(this.checkBoxScience);
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
            this.tabPage1.Size = new System.Drawing.Size(768, 409);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список студентов";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // checkBoxArt
            // 
            this.checkBoxArt.AutoSize = true;
            this.checkBoxArt.Location = new System.Drawing.Point(239, 384);
            this.checkBoxArt.Name = "checkBoxArt";
            this.checkBoxArt.Size = new System.Drawing.Size(80, 17);
            this.checkBoxArt.TabIndex = 12;
            this.checkBoxArt.Text = "checkBox3";
            this.checkBoxArt.UseVisualStyleBackColor = true;
            this.checkBoxArt.CheckedChanged += new System.EventHandler(this.checkBoxArt_CheckedChanged);
            // 
            // checkBoxScience
            // 
            this.checkBoxScience.AutoSize = true;
            this.checkBoxScience.Location = new System.Drawing.Point(239, 361);
            this.checkBoxScience.Name = "checkBoxScience";
            this.checkBoxScience.Size = new System.Drawing.Size(80, 17);
            this.checkBoxScience.TabIndex = 11;
            this.checkBoxScience.Text = "checkBox2";
            this.checkBoxScience.UseVisualStyleBackColor = true;
            this.checkBoxScience.CheckedChanged += new System.EventHandler(this.checkBoxScience_CheckedChanged);
            // 
            // checkBoxMath
            // 
            this.checkBoxMath.AutoSize = true;
            this.checkBoxMath.Location = new System.Drawing.Point(239, 338);
            this.checkBoxMath.Name = "checkBoxMath";
            this.checkBoxMath.Size = new System.Drawing.Size(80, 17);
            this.checkBoxMath.TabIndex = 10;
            this.checkBoxMath.Text = "checkBox1";
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
            this.GridViewStudents.Size = new System.Drawing.Size(759, 285);
            this.GridViewStudents.TabIndex = 0;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "ФИО";
            this.FullName.Name = "FullName";
            this.FullName.Width = 200;
            // 
            // Subject1
            // 
            this.Subject1.HeaderText = "направление 1";
            this.Subject1.Name = "Subject1";
            this.Subject1.Width = 150;
            // 
            // Subject2
            // 
            this.Subject2.HeaderText = "направление 2";
            this.Subject2.Name = "Subject2";
            this.Subject2.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GridViewGrades);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 409);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Оценки";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GridViewGrades
            // 
            this.GridViewGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewGrades.Location = new System.Drawing.Point(6, 33);
            this.GridViewGrades.Name = "GridViewGrades";
            this.GridViewGrades.Size = new System.Drawing.Size(756, 370);
            this.GridViewGrades.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(133, 6);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 409);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main";
            this.Text = "Эл. деканат";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewStudents)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewGrades)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBoxArt;
        private System.Windows.Forms.CheckBox checkBoxScience;
        private System.Windows.Forms.CheckBox checkBoxMath;
    }
}

