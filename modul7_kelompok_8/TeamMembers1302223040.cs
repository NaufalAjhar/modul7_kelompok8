using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace modul7_kelompok_8
{
    internal class TeamMembers1302223040
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
            string json = File.ReadAllText("D:\\1.Programming\\modul7_kelompok_8\\modul7_kelompok_8\\jurnal7_2_1302223040.json");
            var members = JsonSerializer.Deserialize<TeamMembers1302223040>(json);
            foreach (var member in members.members)
            {
                Console.WriteLine($"Name: {member.firstName} {member.lastName}" +
                    $"\ngender: {member.gender} \nnim: {member.nim}" );
            }

        }
    }
}
