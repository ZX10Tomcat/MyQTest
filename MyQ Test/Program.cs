using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQ_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args[0] == null || args[1] == null)
            {
                Console.WriteLine("Missing argument(s)");
                return;
            }
            var Source = args[0];
            var Result = args[1];
            foreach (string arg in args)
            {
                Console.WriteLine(arg);
            }

            Dictionary<string, DVector> Direction = new Dictionary<string, DVector>();
            Direction.Add("N", new DVector() { x = 0, y = -1});
            Direction.Add("E", new DVector() { x = 1, y = 0 });
            Direction.Add("S", new DVector() { x = 0, y = 1 });
            Direction.Add("W", new DVector() { x = -1, y = -1 });


            var SourceObj = InitStart(Source);

            MoveRobot(SourceObj);
            

            Console.ReadLine();
        }

        private static void MoveRobot(Source sourceObj)
        {
            foreach (string command in sourceObj.commands)
            {
                if (checkMove(command))
                {
                    ExecuteCommand(command);
                }
                else
                {
                    ExecuteEmergency();
                }

            }

        }

        private static void ExecuteEmergency()
        {
            throw new NotImplementedException();
        }

        private static void ExecuteCommand(string command)
        {
            switch (command) {

            }
        }

        private static bool checkMove(string command)
        {
            throw new NotImplementedException();
        }

        private static Source InitStart(string source)
        {
            // Defend
            var SourceObj = new Source();
            SourceObj = JsonConvert.DeserializeObject<Source>(File.ReadAllText(source));

            var dest = SourceObj.map[2][2];

            return SourceObj;
        }

       
    }

    public class DVector
    {
        public int x { get; set; }
        public int y { get; set; }


    }
}
