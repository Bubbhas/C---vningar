using System;
using System.Collections.Generic;
using System.Text;

namespace Samrai
{
    public class BattleEvent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public BattleLog BattleLogs { get; set; }

    }
}
