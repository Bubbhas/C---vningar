using System;
using System.Collections.Generic;
using System.Text;

namespace Samrai
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Brutal { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<SamuraiBattle> SamuraiBattles { get; set; }
        public BattleLog BattleLogs { get; set; }
        



    }
}
