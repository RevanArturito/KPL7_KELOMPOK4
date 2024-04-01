using System;
using System.Text.Json;

// Program bernama KPL7_KELOMPOK_4
namespace KPL7_KELOMPOK_4
{
    // deklarasi class bernamakan DataMahasiswa1302220093
    public class DataMahasiswa1302220093
    {
        // memanggil atau inisiasi firstName dari jurnal7_1_1302220093.json
        public string firstName { set; get; }

        // memanggil atau inisiasi lastName dari jurnal7_1_1302220093.json
        public string lastName { set; get; }

        // memanggil atau inisiasi genderName dari jurnal7_1_1302220093.json
        public string gender { set; get; }

        // memanggil atau inisiasi age dari jurnal7_1_1302220093.json
        public int age { set; get; }

        // memanggil atau inisiasi address dari jurnal7_1_1302220093.json
        public Address address { set; get; }

        // memanggil atau inisiasi courses dari jurnal7_1_1302220093.json
        public List<Courses> courses { set; get; }

        // deklarasi tipe data class Address untuk mengakses child dari class address
        public class Address
        {
            // memanggil atau inisiasi streetAddress dari jurnal7_1_1302220093.json
            public string streetAddress { set; get; }

            // memanggil atau inisiasi city dari jurnal7_1_1302220093.json
            public string city { set; get; }

            // memanggil atau inisiasi state dari jurnal7_1_1302220093.json
            public string state { set; get; }
        }

        // deklarasi tipe data class Courses untuk mengakses array dari class courses
        public class Courses
        {
            // memanggil atau inisiasi code dari jurnal7_1_1302220093.json
            public string code { set; get; }

            // memanggil atau inisiasi nama mata kuliah dari jurnal7_1_1302220093.json
            public string name { set; get; }
        }

        // deklarasi method ReadJSON()
        public void ReadJSON()
        {
            // memanggil filepath jurnal7_1_1302220093.json
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string jsonString = File.ReadAllText(path + "/jurnal7_1_1302220093.json");

            // deklarasi object mhs dan melakukan output
            DataMahasiswa1302220093 mhs = JsonSerializer.Deserialize<DataMahasiswa1302220093>(jsonString);
            Console.WriteLine($"Nama : {mhs.firstName} {mhs.lastName}");
            Console.WriteLine($"Jenis Kelamin : {mhs.gender}");
            Console.WriteLine($"Usia : {mhs.age}");
            Console.WriteLine($"Alamat : {mhs.address.streetAddress}, {mhs.address.city}, {mhs.address.state}");
            foreach (Courses course in courses) { 
               Console.WriteLine($"Code: {course.code}, Name: {course.name}"); 
            }
        }
    }
}