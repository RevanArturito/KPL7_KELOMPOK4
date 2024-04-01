using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KPL7_KELOMPOK4
{
    internal class DataMahasiswa_1302223010
    {
        public class Mahasiswa_1302223010()
        {
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string gender { get; set; }
            public int age { get; set; }
            public Address alamat { get; set; }
            [JsonPropertyName("courses")]
            public courses[] course { get; set; }
        }

        public class Address
        {
            public string streetAddress { get; set; }
            public string city { get; set; }
            public string state { get; set; }
        }

        public class courses
        {
            [JsonPropertyName("code")]
            public string code { get; set; }
            [JsonPropertyName("name")]
            public string name { get; set; }
        }

        public void ReadJSON()
        {
            string filePath = "D:\\r\\KPL7_KELOMPOK4\\KPL7_KELOMPOK4\\jurnal7_1_1302223010.json";
            string jsonString = File.ReadAllText(filePath);

            Mahasiswa_1302223010 mahasiswa = JsonSerializer.Deserialize<Mahasiswa_1302223010>(jsonString);
            Console.WriteLine($"Nama:  { mahasiswa.firstName} { mahasiswa.lastName} ");
            Console.WriteLine($"Gender: { mahasiswa.gender }");
            Console.WriteLine($"Age: { mahasiswa.age }");
            Console.WriteLine($"Street Address: {mahasiswa.alamat.streetAddress}");
            Console.WriteLine($"City: {mahasiswa.alamat.city}");
            Console.WriteLine($"State: {mahasiswa.alamat.state}");
            Console.WriteLine("Daftar Mata Kuliah yang diambil: ");
            for (int i = 0; i < mahasiswa.course.Length; i++)
            {
                Console.WriteLine((i + 1) + " " + mahasiswa.course[i].code + " " + mahasiswa.course[i].name);
            }
        }
    }
}
