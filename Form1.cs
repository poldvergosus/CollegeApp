using System;
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
Предоставить возможность рейтинговой системы (список сильных и слабых обучающихся)*/



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
                Subject1Grades = new int[4];
                Subject2Grades = new int[4];
            }
        }

        private struct Teacher
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
                int index = GridViewStudents.SelectedRows[0].Index;
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

            UpdateSubjectSelection(checkBoxMath, "Math");
            UpdateSubjectSelection(checkBoxScience, "Science");
            UpdateSubjectSelection(checkBoxArt, "Art");
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
            checkBoxScience.Checked = false;
            checkBoxArt.Checked = false;

            selectedCount = 0;
            selectedSubjects[0] = null;
            selectedSubjects[1] = null;
        }

        private bool AreTwoSubjectsSelected()
        {
            return selectedCount == MaxSubjects;
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}