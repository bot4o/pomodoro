using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro_app
{
    public class ShortBrake
    {
        public int Minutes { get; set; } = 15;
        public int Seconds { get; set; } = 0;
        public Color Theme { get; set; } = Color.FromArgb(33, 127, 83);
    }
}
