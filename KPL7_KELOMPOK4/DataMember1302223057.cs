using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static KPL7_KELOMPOK4.DataMahasiswa1302223057;

namespace KPL7_KELOMPOK4
{
    //deklarasi class dataMember1302223057
    internal class DataMember1302223057
    {


        // deklarasi class member untuk mengambil data dari file json 2
        public class Member1302223057
        {
            // mengambil data member dari class member
            [JsonPropertyName("members")]
            public members[] member1302223057 {  get; set; }
        }

        //deklarasi class member
        public class members
        {
            //mengambil data member berupa nama depan
            public string firstName { get; set; }

            //mengambil data member berupa nama belakang
            public string lastName { get; set; }    

            //mengambil data membeer berupa gender
            public string gender { get; set; }

            //mengambil data member berupa umur
            public int age { get; set; }

            //mengambil data member berupa nim
            public string nim {  get; set; }
        }

        //method untuk menampilkan seluruh data member dari file json 2
        public void ReadJSON()
        {
            string filePath = "D:\\REVAN\\MATERI KULIAH\\SEMESTER 4\\PRAKTIKUM KPL\\KPL7_KELOMPOK4\\KPL7_KELOMPOK4\\jurnal7_2_1302223057.json";
            string jsonString = File.ReadAllText(filePath);

            Member1302223057 member = JsonSerializer.Deserialize<Member1302223057>(jsonString);
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Member {i + 1}");
                Console.WriteLine($"Nama : {member.member1302223057[i].firstName}  {member.member1302223057[i].lastName}");
                Console.WriteLine($"Gender : {member.member1302223057[i].gender}");
                Console.WriteLine($"Age : {member.member1302223057[i].age}");
                Console.WriteLine($"NIM : {member.member1302223057[i].nim}");
                Console.WriteLine();
            }
        }

    }
}
