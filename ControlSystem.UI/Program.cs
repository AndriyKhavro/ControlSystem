using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlSystem.DA;
using ControlSystem.Entities;

namespace ControlSystem.UI
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var context = new ControlSystemContext();
            Application.Run(new Form1(new Repository<Diagnosis>(context), new Repository<Exercise>(context),
                new Repository<ExerciseSchedule>(context)));
        }
    }
}
