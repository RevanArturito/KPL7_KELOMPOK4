using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KPL7_KELOMPOK4
{
    //deklarasi class datamahasiswa
    internal class DataMahasiswa1302223057
    {

        //deklarasi class mahasiswa untuk menampung data dari file json 1
        public class Mahasiswa1302223057
        {
            // mngembil data first name
            public string firstName { get; set; }

            // mngemabil data //lastname
            public string lastName { get; set; }

            //mengambil data gender
            public string gender { get; set; }

            //mengambil data umut
            public int age { get; set; }

            // mengambil data dari class Address
            public Address address {  get; set; }


            //megngambil data dari class courses
            [JsonPropertyName("courses")]
            public courses[] course1302223057 { get; set; }
        }

        // deklarasi class address
        public class Address
        {
            // mengambil data streetaddress
            public string streetAddress { get; set; }

            //mengambil data kota
            public string city { get; set; }

            //mengambil data provinsi
            public string state { get; set; }
        }

        //deklarasi class courses
        public class courses
        {
            //megambil data kode matakuliah
            [JsonPropertyName("code")]
            public string code { get; set; }

            //mengambil data nama mata kuliah
            [JsonPropertyName("name")]
            public string name { get; set; }
        }

        //method untuk menampilkna seluruh data dari file json 1
        public void ReadJSON()
        {
            string filePath = "D:\\REVAN\\MATERI KULIAH\\SEMESTER 4\\PRAKTIKUM KPL\\KPL7_KELOMPOK4\\KPL7_KELOMPOK4\\jurnal7_1_1302223057.json";
            string jsonString = File.ReadAllText(filePath);

            Mahasiswa1302223057 mahasiswa = JsonSerializer.Deserialize<Mahasiswa1302223057>(jsonString);
            Console.WriteLine($"Nama : {mahasiswa.firstName} {mahasiswa.lastName}");
            Console.WriteLine($"Gender : {mahasiswa.gender}");
            Console.WriteLine($"Age : {mahasiswa.age}");
            Console.WriteLine($"Address : Jl.{mahasiswa.address.streetAddress} Kota {mahasiswa.address.city} Provinsi {mahasiswa.address.state}");
            Console.WriteLine();
            Console.WriteLine("Daftar mata kuliah yang diambil : ");
            for (int i = 0;i<2;i++)
            {
                Console.WriteLine(i+1 + mahasiswa.course1302223057[i].code + " - " + mahasiswa.course1302223057[i].name );
            }
        }
    }
}
