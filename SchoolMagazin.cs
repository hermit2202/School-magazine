namespace School_magazine
{
    public partial class SchoolMagazin : Form
    {
        public SchoolMagazin()
        {
            InitializeComponent();
            SetupDataGridView();
            Students();
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add("FullName", "ФИО");
            dataGridView1.Columns.Add("Gender", "Пол");
            dataGridView1.Columns.Add("BirthDate", "Дата рождения");
            dataGridView1.Columns.Add("Age", "Возраст");
            
            DataGridViewCheckBoxColumn isExpelledColumn = new DataGridViewCheckBoxColumn();
            isExpelledColumn.Name = "IsExpelled";
            isExpelledColumn.HeaderText = "Отчислен";
            dataGridView1.Columns.Add(isExpelledColumn);
            
            DataGridViewCheckBoxColumn hasDebtColumn = new DataGridViewCheckBoxColumn();
            hasDebtColumn.Name = "HasDebt";
            hasDebtColumn.HeaderText = "Имеет задолженность";
            dataGridView1.Columns.Add(hasDebtColumn);
        }
        
        private void Students()
        {
            var students = new List<Student>();

            students.Add(new Student
            {
                FullName = "Сидоров Аналотий Иванович",
                Gender = "М",
                BirthDate = new DateTime(2007, 5, 12),
                Grade = 4.6,
                IsExpelled = false,
                HasDebt = false
            });
            
            students.Add(new Student
            {
                FullName = "Петрова Анастасия Владимировна",
                Gender = "Ж",
                BirthDate = new DateTime(),
                Grade = 3.5,
                IsExpelled = false,
                HasDebt = true
            });
            
            students.Add(new Student
            {
                FullName = "Иванов Александр Фёдорович",
                Gender = "м",
                BirthDate = new DateTime(),
                Grade = 2.2,
                IsExpelled = true,
                HasDebt = true
            });

            foreach (var student in students)
            {
                dataGridView1.Rows.Add(
                    student.FullName,
                    student.Gender,
                    student.BirthDate,
                    student.Grade,
                    student.IsExpelled,
                    student.HasDebt);
            }
        }
    }
}
