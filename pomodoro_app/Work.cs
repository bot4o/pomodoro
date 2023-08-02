using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pomodoro_app
{
    public class Work
    {
        public int Minutes { get; set; } = 25;
        public int Seconds { get; set; } = 0;
        public Color Theme { get; set; } = Color.FromArgb(24, 24, 127);
    }
}
