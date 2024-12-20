﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;



/*Цель: Разработка настольного приложения с применением массивов.
Задачи:
Проанализировать предметную область
Определить подходящий массив.
Разработать интерфейс
Протестировать приложение


Задание:
 Центру дополнительного образования необходимо фиксировать успехи обучающихся.
Занятия посещают малые группы в количестве 5-8 человек.
В центре обучают по трем направлениям и 6 разных преподавателей (по графику).
Каждый преподаватель входит в систему по  заранее заданному администратором логину и паролю без права изменения.
 Количество занятий в месяц -4 по каждому направлению.
Обучающийся может быть записан одновременно не более чем на два направления.
Каждые 3 месяца подготавливается сводная ведомость оценок и определением среднего балла. 
Предоставить возможность рейтинговой системы (список сильных и слабых обучающихся)
*/



namespace CollegeApp
{
    public partial class Main : Form
    {
        private const int MaxStudents = 100;
        private const int MaxTeachers = 6;
        private const int MaxSubjects = 2;

        private Student[] students;

        private string studentName;
        private string[] selectedSubjects = new string[MaxSubjects];
        private int selectedCount;

        private int currentStudents;

        private Teacher[] teachers;

        public Main()
        {
            InitializeComponent();
            InitializeArrays();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            InitializeLessonComboBox();
        }

        private struct Student
        {
            public string FullName;
            public string Subject1;
            public string Subject2;
            public int[] Subject1Grades;
            public int[] Subject2Grades;

            public Student(string fullName, string subject1, string subject2)
            {
                FullName = fullName;
                Subject1 = subject1;
                Subject2 = subject2;
                Subject1Grades = new int[12];
                Subject2Grades = new int[12];
            }


            public double CalculateAverageGrade()
            {
                double total = 0;
                int count = 0;

                foreach (int grade in Subject1Grades)
                {
                    if (grade > 0)
                    {
                        total += grade;
                        count++;
                    }
                }

                foreach (int grade in Subject2Grades)
                {
                    if (grade > 0)
                    {
                        total += grade;
                        count++;
                    }
                }

                return count > 0 ? total / count : 0;
            }
        }

        internal struct Teacher

        {
            public string FullName;
            public string Login;
            public string Password;
            public string Subject;
            public string WorkDays;

            public Teacher(string fullName, string login, string password, string subject, string workdays = "-------")
            {
                FullName = fullName;
                Login = login;
                Password = password;
                Subject = subject;
                WorkDays = workdays;


            }
        }

        private void InitializeArrays()
        {
            students = new Student[MaxStudents];
            teachers = new Teacher[MaxTeachers];
        }


        //_________________________________Вкладка Студенты______________________________

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            studentName = TextName.Text;

            if (AreTwoSubjectsSelected())
            {
                AddStudent(studentName, selectedSubjects[0], selectedSubjects[1]);
                TextName.Clear();
            }
            else
            {
                ShowError("Пожалуйста, выберите ровно два предмета.");
            }
        }

        private void AddStudent(string fullName, string subject1, string subject2)
        {
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(subject1) || string.IsNullOrWhiteSpace(subject2))
            {
                ShowError("Пожалуйста, заполните все поля.");
                return;
            }

            if (currentStudents < MaxStudents)
            {
                students[currentStudents++] = new Student(fullName, subject1, subject2);
                UpdateDataGridView();
                UpdateGradesGridView();
                ClearSubjectSelection();

            }
            else
            {
                ShowError("Достигнуто максимальное количество студентов.");
            }
        }

        //_______________________________Изменить студента___________________________________________
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            if (GridViewStudents.SelectedRows.Count > 0)
            {
                int index = GridViewStudents.SelectedRows[0].Index;
                studentName = TextName.Text;

                if (AreTwoSubjectsSelected())
                {
                    EditStudent(index, studentName, selectedSubjects[0], selectedSubjects[1]);
                    TextName.Clear();
                }
                else
                {
                    ShowError("Пожалуйста, выберите ровно два предмета.");
                }
            }
            else
            {
                ShowError("Пожалуйста, выберите студента для редактирования.");
            }
        }

        private void EditStudent(int index, string fullName, string subject1, string subject2)
        {
            if (index >= 0 && index < currentStudents)
            {
                students[index] = new Student(fullName, subject1, subject2);
                UpdateDataGridView();
                UpdateGradesGridView();
            }
            else
            {
                ShowError("Недопустимый индекс студента.");
            }
        }

        //______________________________Удалить Студента__________________________________________

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (GridViewStudents.SelectedRows.Count > 0)
            {
                int index = GridViewStudents.SelectedRows[0].Index;//выбирает только один выбранный индекс, если выделено несколько
                DeleteStudent(index);
            }
            else
            {
                ShowError("Пожалуйста, выберите студента для удаления.");
            }
        }

        private void DeleteStudent(int index)
        {
            if (index >= 0 && index < currentStudents)
            {
                for (int i = index; i < currentStudents - 1; i++)
                {
                    students[i] = students[i + 1];
                }
                currentStudents--;
                UpdateDataGridView();
                UpdateGradesGridView();
            }
            else
            {
                ShowError("Недопустимый индекс студента.");
            }
        }

        private void UpdateDataGridView()
        {
            GridViewStudents.Rows.Clear();
            for (int i = 0; i < currentStudents; i++)
            {
                GridViewStudents.Rows.Add(students[i].FullName, students[i].Subject1, students[i].Subject2);
            }
        }



        // чет намудрила, возможно, есть способ проще
        private void UpdateSelectedSubjects()
        {
            selectedCount = 0;
            selectedSubjects[0] = null;
            selectedSubjects[1] = null;

            UpdateSubjectSelection(checkBoxMath, "Математика");
            UpdateSubjectSelection(checkBoxPhysics, "Физика");
            UpdateSubjectSelection(checkBoxChemistry, "Химия");
        }

        private void UpdateSubjectSelection(CheckBox checkBox, string subject)
        {
            if (checkBox.Checked)
            {
                if (selectedCount < MaxSubjects)
                {
                    selectedSubjects[selectedCount++] = subject;
                }
                else
                {
                    checkBox.Checked = false;
                    ShowError("Вы можете выбрать только два предмета.");
                }
            }
        }

        private void checkBoxMath_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedSubjects();
        }

        private void checkBoxScience_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedSubjects();
        }

        private void checkBoxArt_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSelectedSubjects();
        }

        private void ClearSubjectSelection()
        {
            checkBoxMath.Checked = false;
            checkBoxPhysics.Checked = false;
            checkBoxChemistry.Checked = false;

            selectedCount = 0;
            selectedSubjects[0] = null;
            selectedSubjects[1] = null;
        }

        private bool AreTwoSubjectsSelected()
        {
            return selectedCount == MaxSubjects;
        }

        //_________________________________Вкладка Оценки_________________________________

        private void InitializeLessonComboBox()
        {
            comboBoxLesson.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                comboBoxLesson.Items.Add(i);
            }
        }

        private void AddGrade(int studentIndex, string subject, int lessonIndex, int grade)
        {
            if (studentIndex >= 0 && studentIndex < currentStudents)
            {
                if (subject == students[studentIndex].Subject1)
                {
                    students[studentIndex].Subject1Grades[lessonIndex] = grade;
                }
                else if (subject == students[studentIndex].Subject2)
                {
                    students[studentIndex].Subject2Grades[lessonIndex] = grade;
                }
                UpdateGradesGridView();
            }
        }

        private void UpdateGradesGridView()
        {
            GridViewGrades.Rows.Clear();
            for (int i = 0; i < currentStudents; i++)
            {
                    GridViewGrades.Rows.Add(
                    students[i].FullName,
                    students[i].Subject1,
                    string.Join(", ", students[i].Subject1Grades),
                    students[i].Subject2,
                    string.Join(", ", students[i].Subject2Grades)
                );
            }
            UpdateStudentsComboBox();
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int GetSelectedLessonIndex()
        {
            if (comboBoxLesson.SelectedItem != null)
            {
                return (int)comboBoxLesson.SelectedItem - 1; // Индексы начинаются с 0
            }
            return -1; // Возвращаем -1, если ничего не выбрано
        }

        private int GetSelectedStudentIndex()
        {
            return comboBoxStudents.SelectedIndex;
        }

        private string GetSelectedSubject()
        {
            return comboBoxSubjects.SelectedItem as string;
        }

        private int GetSelectedGrade()
        {
            return (int)numericUpDownGrade.Value;
        }

        private void buttonAddGrade_Click(object sender, EventArgs e)
        {
            int studentIndex = GetSelectedStudentIndex();
            string subject = GetSelectedSubject();
            int lessonIndex = GetSelectedLessonIndex();
            int grade = GetSelectedGrade();

            if (studentIndex >= 0 && !string.IsNullOrEmpty(subject) && lessonIndex >= 0)
            {
                AddGrade(studentIndex, subject, lessonIndex, grade);
            }
            else
            {
                ShowError("Пожалуйста, выберите студента, предмет и номер занятия.");
            }
        }

        private void UpdateStudentsComboBox()
        {
            comboBoxStudents.Items.Clear();
            for (int i = 0; i < currentStudents; i++)
            {
                comboBoxStudents.Items.Add(students[i].FullName);
            }
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBoxStudents.SelectedIndex;
            if (selectedIndex >= 0 && selectedIndex < currentStudents)
            {
                comboBoxSubjects.Items.Clear();
                comboBoxSubjects.Items.Add(students[selectedIndex].Subject1);
                comboBoxSubjects.Items.Add(students[selectedIndex].Subject2);
            }
        }

      ////_________________________________Вкладка Отчеты______________________________

        private void buttonSortStudents_Click(object sender, EventArgs e)
        {
            string sortType = comboBoxReport2.SelectedItem?.ToString();

            //проверка
            if (string.IsNullOrEmpty(sortType))
            {
                MessageBox.Show("Выберите тип сортировки");
                return;
            }

            //созд копию
            Student[] studentsToSort = new Student[currentStudents];
            Array.Copy(students, studentsToSort, currentStudents);

            //сортировка
            if (sortType == "по возрастан")
            {
                Array.Sort(studentsToSort, (x, y) => x.CalculateAverageGrade().CompareTo(y.CalculateAverageGrade()));
            }
            else if (sortType == "по убыван")
            {
                Array.Sort(studentsToSort, (x, y) => y.CalculateAverageGrade().CompareTo(x.CalculateAverageGrade()));
            }
            else if (sortType == "от А до Я")
            {
                Array.Sort(studentsToSort, (x, y) => string.Compare(x.FullName, y.FullName, StringComparison.OrdinalIgnoreCase));
            }
            else if (sortType == "от Я до А")
            {
                Array.Sort(studentsToSort, (x, y) => string.Compare(y.FullName, x.FullName, StringComparison.OrdinalIgnoreCase));
            }

            DisplaySortedStudents(studentsToSort);
        }

        private void DisplaySortedStudents(Student[] sortedStudents)
        {
            dataGridViewReport.Rows.Clear();

            foreach (var student in sortedStudents)
            {
                int rowIndex = dataGridViewReport.Rows.Add(student.FullName, student.CalculateAverageGrade().ToString("F2"));

                //изменение цвета текста, если средний балл меньше 3
                if (student.CalculateAverageGrade() < 3)
                {
                    dataGridViewReport.Rows[rowIndex].Cells[1].Style.ForeColor = Color.Red;
                }
            }
        }


        //_________________________________Вкладка Преподаватели______________________________

        int currentTeachers = 0;
        //______________________________Добавление нового препода________________________________________________________
        private void ButtonAddTeach_Click(object sender, EventArgs e)
        {
            string fullName = TextNameTeach.Text;
            string login = TextBoxTeachLogin.Text;
            string password = TextBoxTeachPass.Text;
            string subject;

            if (RadioButtonMath.Checked)
            {
                subject = RadioButtonMath.Text;
            }
            else if (RadioButtonPhysics.Checked)
            {
                subject = RadioButtonPhysics.Text;
            }
            else if (RadioButtonChemistry.Checked)
            {
                subject = RadioButtonChemistry.Text;
            }
            else
            {
                ShowError("Выберите предмет.");
                return;
            }

            char[] workDays = "-------".ToCharArray();
            workDays[0] = checkBox1.Checked ? '+' : '-';
            workDays[1] = checkBox2.Checked ? '+' : '-';
            workDays[2] = checkBox3.Checked ? '+' : '-';
            workDays[3] = checkBox4.Checked ? '+' : '-';
            workDays[4] = checkBox5.Checked ? '+' : '-';

            AddTeacher(fullName, login, password, subject, workDays);
        }

        private void AddTeacher(string fullName, string login, string password, string subject, char[] workDays)//Изменение и добавление совмещено
        {
            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(subject))
            {
                ShowError("Пожалуйста, заполните все поля.");
                return;
            }

            string workdays = new string(workDays);

            for (int i = 0; i < currentTeachers; i++)
            {
                if (teachers[i].Login == login)
                {
                    teachers[i] = new Teacher(fullName, login, password, subject, workdays);
                    UpdateDataGridViewTeachers();
                    return;
                }
            }

            if (currentTeachers < MaxTeachers)
            {
                teachers[currentTeachers++] = new Teacher(fullName, login, password, subject, workdays);
                UpdateDataGridViewTeachers();
            }
            else
            {
                ShowError("Достигнуто максимальное количество преподавателей.");
            }
        }

        private void UpdateDataGridViewTeachers()
        {

            GridViewTeachers.Rows.Clear();
            for (int i = 0; i < currentTeachers; i++)
            {
                GridViewTeachers.Rows.Add(teachers[i].FullName, teachers[i].Login, teachers[i].Password, teachers[i].Subject,
            teachers[i].WorkDays[0],// Пн
            teachers[i].WorkDays[1],// Вт
            teachers[i].WorkDays[2],// Ср
            teachers[i].WorkDays[3],// Чт
            teachers[i].WorkDays[4] // Пт
            );
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}