using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_8
{
    internal class TeamMembers1302220098
    {
        public List<Members> members { get; set; }
        public class Members
        {
            public String firstName { get; set; }
            public String lastName { get; set; }
            public String gender { get; set; }
            public int age { get; set; }
            public String nim { get; set; }

        }

        public void ReadJSON()
        {
            string json = File.ReadAllText("C:\\MOD7-KPL\\modul7_kelompok8\\modul7_kelompok_8\\jurnal7_2_1302220098.json");
            var members = JsonSerializer.Deserialize<TeamMembers1302220098>(json);
            foreach (var member in members.members)
            {
                Console.WriteLine($"Name: {member.firstName} {member.lastName}" +
                    $"\ngender: {member.gender} \nnim: {member.nim}");
            }

        }
    }
}
