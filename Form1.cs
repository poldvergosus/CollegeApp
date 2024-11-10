using System;
using System.Data;
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

        public Teacher[] teachers;
        private string subject;

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

            public double AverageGrade
            {
                get
                {
                    int totalGrade1 = Subject1Grades.Sum();
                    int totalGrade2 = Subject2Grades.Sum();
                    int totalLessons = Subject1Grades.Length + Subject2Grades.Length;
                    return (totalGrade1 + totalGrade2) / (double)totalLessons;
                }
            }
        }

        public struct Teacher
        {
            public string Login;
            public string Password;
            public string Subject;

            public Teacher(string login, string password, string subject)
            {
                Login = login;
                Password = password;
                Subject = subject;
            }
        }

        private void InitializeArrays()
        {
            students = new Student[MaxStudents];
            teachers = new Teacher[MaxTeachers];

            teachers[0] = new Teacher("Aboba", "123", "Math");
            teachers[1] = new Teacher("Amogus", "qwerty", "Art");
        }



        //_________________________________Вкладка Студенты______________________________
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


        //_________________________________Вкладка Оценки______________________________


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

        private double CalculateAverageGrade(int studentIndex)//исп. в отчете или оценках
        {
            if (studentIndex >= 0 && studentIndex < currentStudents)
            {
                double sum = students[studentIndex].Subject1Grades.Sum() + students[studentIndex].Subject2Grades.Sum();
                int count = students[studentIndex].Subject1Grades.Length + students[studentIndex].Subject2Grades.Length;
                return sum / count;
            }
            return 0;
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



        //_________________________________Вкладка Отчеты______________________________


        private void UpdatedataGridViewReport()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ФИО");
            dataTable.Columns.Add("Предмет");
            dataTable.Columns.Add("Средний балл");

            foreach (Student student in students)
            {
                DataRow row1 = dataTable.NewRow();
                row1["ФИО"] = student.FullName;
                row1["Предмет"] = student.Subject1;
                row1["Средний балл"] = GetAverageGrade(student, student.Subject1);
                dataTable.Rows.Add(row1);

                DataRow row2 = dataTable.NewRow();
                row2["ФИО"] = student.FullName;
                row2["Предмет"] = student.Subject2;
                row2["Средний балл"] = GetAverageGrade(student, student.Subject2);
                dataTable.Rows.Add(row2);
            }
            dataGridViewReport.DataSource = dataTable;
        }

        private double GetAverageGrade(Student student, string subject)
        {
            if (subject == student.Subject1)
            {
                return student.Subject1Grades.Average();
            }
            else if (subject == student.Subject2)
            {
                return student.Subject2Grades.Average();
            }
            return 0;
        }

        //сортировка студентов
        private void SortStudents()
        {
            string Subject = comboBoxReport1.SelectedItem.ToString();
            string Sorting = comboBoxReport2.SelectedItem.ToString();

            switch (Sorting)
            {
                case "от А до Я":
                    students = students.OrderBy(s => s.FullName).ToArray();
                    break;
                case "от Я до А":
                    students = students.OrderByDescending(s => s.FullName).ToArray();
                    break;
                case "по возрастанию":
                    students = students.OrderBy(s => GetAverageGrade(s, subject)).ToArray();
                    break;
                case "по убыванию":
                    students = students.OrderByDescending(s => GetAverageGrade(s, subject)).ToArray();
                    break;
            }

            //фильтр студентов по предмету
            if (!string.IsNullOrEmpty(Subject))
            {
                students = students.Where(s => s.Subject1 == Subject || s.Subject2 == Subject).ToArray();
            }

            UpdatedataGridViewReport();
        }

        private void buttonReport1_Click(object sender, EventArgs e)
        {
            UpdatedataGridViewReport();
            SortStudents();
        }
    }
}