using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace MyQ_Test
{
    public class Source
    {       
        public string[][] map { get; set; }
        public Position start { get; set; }
        public string[] commands { get; set; }
        public int battery { get; set; }
    }
}
