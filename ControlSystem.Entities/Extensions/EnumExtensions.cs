using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlSystem.Entities.Extensions
{
    public static class EnumExtensions
    {
        public static string ToFriendlyString(this PatientState state)
        {
            switch(state)
            {
                case PatientState.State1:
                    return "Стан 1";
                case PatientState.State2:
                    return "Стан 2";
                case PatientState.State3:
                    return "Стан 3";
                case PatientState.State4:
                    return "Стан 4";
                case PatientState.State5:
                    return "Стан 5";
                default:
                    return string.Empty;
            }
        }
    }
}
