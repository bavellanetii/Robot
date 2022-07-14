using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Robot.Classes
{
    class BB
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Product { get; set; }

        public int Weight { get; set; }

        public string Bin { get; set; }

        public string LotNumber { get; set; }
    }
}
