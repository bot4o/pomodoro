using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro_app.Classes
{
    public class LongBrake
    {
        public int Minutes { get; set; } = 60;
        public int Seconds { get; set; } = 0;
        public Color Theme { get; set; } = Color.FromArgb(91, 33, 127);
    }

}
