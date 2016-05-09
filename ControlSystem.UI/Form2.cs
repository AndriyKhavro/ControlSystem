using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSystem.BL;
using ControlSystem.Entities;

namespace ControlSystem.UI
{
    public partial class Form2 : Form
    {
        private readonly ITimeTableService _timeTableService;



        public Form2(ITimeTableService timeTableService)
        {
            _timeTableService = timeTableService;
            InitializeComponent();
        }

        public void InitializeForm(int[] diagnosesIDs, PatientState patientState)
        {
            exerciseGridView.DataSource = _timeTableService.GetExercises(diagnosesIDs, patientState).ToList();
            exerciseGridView.AutoGenerateColumns = false;
            foreach (DataGridViewColumn column in exerciseGridView.Columns)
            {
                column.Visible = false;
            }

            exerciseGridView.Columns["Name"].Visible = true;
            exerciseGridView.Columns["BodyRegion"].Visible = true;
            exerciseGridView.Columns["Description"].Visible = true;

            exerciseGridView.Columns["Name"].HeaderText = "Назва";
            exerciseGridView.Columns["BodyRegion"].HeaderText = "Частина тіла";
            exerciseGridView.Columns["Description"].HeaderText = "Опис";

            //foreach (var column in morningGridView.Columns)
            //{
            //    colum
            //}
        }

        private Exercise _currentExercise;

        private void exerciseGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (exerciseGridView.CurrentRow != null)
            {
                _currentExercise = (Exercise)exerciseGridView.CurrentRow.DataBoundItem;
                exerciseGridView.DoDragDrop(exerciseGridView.CurrentRow.ToString(), DragDropEffects.Copy);
            }
            else
            {
                _currentExercise = null;
            }
        }

        private void DragEnterMethod(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
            {
                e.Effect = DragDropEffects.None;
                _currentExercise = null;
            }
        }

        private void morningGridView_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterMethod(sender, e);
        }

        private void morningGridView_DragDrop(object sender, DragEventArgs e)
        {
            morningGridView.Rows.Add(new object[] { _currentExercise });
            _currentExercise = null;

        }

        private void dayGridView_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterMethod(sender, e);
        }

        private void dayGridView_DragDrop(object sender, DragEventArgs e)
        {
            dayGridView.Rows.Add(new object[] { _currentExercise });
            _currentExercise = null;
        }

        private void eveningGridView_DragEnter(object sender, DragEventArgs e)
        {
            DragEnterMethod(sender, e);
        }

        private void eveningGridView_DragDrop(object sender, DragEventArgs e)
        {
            eveningGridView.Rows.Add(new object[] { _currentExercise });
            _currentExercise = null;
        }

        private IEnumerable<ExerciseAssignment> GetAssignments(DataGridView gridView)
        {
            return
                gridView.Rows.Cast<DataGridViewRow>()
                    .Where(r => r.Cells[0].Value != null)
                    .Select(row => new ExerciseAssignment
                    {
                        Exercise = (Exercise) row.Cells[0].Value,
                        ExpectedSets = int.Parse((string) row.Cells[1].Value)
                    });
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var exerciseSchedule = new ExerciseSchedule
            {
                MorningWorkout = new Workout
                {
                    Assignments = GetAssignments(morningGridView).ToArray()
                },

                AfternoonWorkout = new Workout
                {
                    Assignments = GetAssignments(dayGridView).ToArray()
                },

                EveningWorkout = new Workout
                {
                    Assignments = GetAssignments(eveningGridView).ToArray()
                }
            };

            _timeTableService.SaveExerciseSchedule(exerciseSchedule);
        }


    }
}






