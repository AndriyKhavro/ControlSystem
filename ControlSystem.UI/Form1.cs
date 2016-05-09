using System;
using System.Linq;
using System.Windows.Forms;
using ControlSystem.BL;
using ControlSystem.DA;
using ControlSystem.Entities;
using ControlSystem.Entities.Extensions;
using ControlSystem.Infrastructure;

namespace ControlSystem.UI
{
    public partial class Form1 : Form
    {
        private readonly IRepository<Diagnosis> _diagnosisRepository;
        private readonly IRepository<Exercise> _exerciseRepository;
        private readonly IRepository<ExerciseSchedule> _scheduleRepository; 

        public Form1(IRepository<Diagnosis> diagnosisRepository, IRepository<Exercise> exerciseRepository, IRepository<ExerciseSchedule> scheduleRepository)
        {
            //_context = new ControlSystemContext();
            //_diagnosisDiagnosisRepository = new Repository<Diagnosis>(_context);
            _diagnosisRepository = diagnosisRepository;
            _exerciseRepository = exerciseRepository;
            _scheduleRepository = scheduleRepository;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stateComboBox.DataSource =
                Enum.GetValues(typeof (PatientState))
                    .Cast<PatientState>()
                    .Select(o => new {Value = o, DisplayValue = o.ToFriendlyString()})
                    .ToArray();

            stateComboBox.DisplayMember = "DisplayValue";
            stateComboBox.ValueMember = "Value";

            diagnosisListBox.DataSource = _diagnosisRepository.GetAll().ToArray();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chooseExButton_Click(object sender, EventArgs e)
        {
            TimeTableService timeTableService = new TimeTableService(_exerciseRepository, _scheduleRepository);
            Form2 form2 = new Form2(timeTableService);
            var selectedDiagnosis = diagnosisListBox.SelectedItems.Cast<Diagnosis>();
            form2.InitializeForm(selectedDiagnosis.Select(d => d.DiagnosisId).ToArray(), (PatientState)stateComboBox.SelectedValue);
            form2.Show();
            this.Hide();
        }
    }
}
