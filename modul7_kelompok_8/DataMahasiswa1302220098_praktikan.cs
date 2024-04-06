using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace modul7_kelompok_8
{
    internal class DataMahasiswa1302220098_praktikan
    {
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String gender { get; set; }
        public int age { get; set; }
        public Address address { get; set; }
        public List<Courses> courses { get; set; }

        public class Address
        {
            public String streetAddress { get; set; }
            public String city { get; set; }
            public String state { get; set; }
        }

        public class Courses
        {
            public String code { get; set; }
            public String name { get; set; }
        }

        public void ReadJSON()
        {
            string json = File.ReadAllText("C:\\MOD7-KPL\\modul7_kelompok8\\modul7_kelompok_8\\jurnal7_1_1302220098.json");
            var mahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302220098_praktikan>(json);
            int i = 1;
            Console.WriteLine($"Name: {mahasiswa.firstName} {mahasiswa.lastName}" +
                $"\nage: {mahasiswa.age} \nAddress: {mahasiswa.address.streetAddress} {mahasiswa.address.city} {mahasiswa.address.state}" +
                $"\nCourses: ");

            foreach (var course in mahasiswa.courses)
            {
                Console.WriteLine($"courses: {i} {course.code} - {course.name}");
            }

        }

    }

}

