using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace KPL7_KELOMPOK4
{
    public class DataMahasiswa1302220064
    {

        public class Name
        {
            public String depan { get; set; }
            public String belakang { get; set; }
        }

        public class Address { 
        
            public String street { get; set; }
            public String city { get; set; }

            public String state { get; set; }
        
        }

        public class course { 
            public String code {  get; set; }
            public String NamaClass { get; set; }
        }
        public class Mahasiswa1302220064() {
            public Name nama {  get; set; }

            public int age { get; set; }
            
            public Address alamat {  get; set; }

            public  course matkul { get; set; }

        }

        public void ReadJSON()
        {
        
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string jsonString = File.ReadAllText(path + "\\jurnal7_1_1302220064.json");

            Mahasiswa1302220064 mahasiswa = JsonSerializer.Deserialize<Mahasiswa1302220064>(jsonString);
            Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang} ");
            Console.WriteLine($"Age : {mahasiswa.age}");
            Console.WriteLine($"Alamat : {mahasiswa.alamat.street} {mahasiswa.alamat.city} {mahasiswa.alamat.state}");
            Console.WriteLine($"course : {mahasiswa.matkul.code} {mahasiswa.matkul.NamaClass}");
            Console.WriteLine();
        }
    }
}
