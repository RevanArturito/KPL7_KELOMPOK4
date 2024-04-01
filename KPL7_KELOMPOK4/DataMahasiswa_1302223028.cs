using System;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace KPL7_KELOMPOK4
{
	internal class DataMahasiswa_1302223028
	{
		public class Mahasiswa_1302223028()
		{
			public Name nama {set; get;}
			public string gender { set; get;}
			public int age { set; get;}
			public address alamat { set; get;}
			public courses[] matkul { set; get;}

		}

		public class address
		{
			public string street { set; get;}
			public string city { set; get;}
			public string state { set; get;}
		}

		public class courses
		{
			[JsonPropertyName("code")]
			public string code { get; set;}
			[JsonPropertyName("name")]
			public string name { get; set;}
		}

		public class Name
		{
			public string depan { set; get; }
			public string belakang { set; get; }
		}
		public void ReadJSON()
		{
			string filepath = "D:\\JurnalMOD7\\KPL7_KELOMPOK4\\KPL7_KELOMPOK4\\jurnal7_1_1302223028.json";
			string jsonString = File.ReadAllText(filepath);

			Mahasiswa_1302223028 mahasiswa = JsonSerializer.Deserialize<Mahasiswa_1302223028>(jsonString);
			Console.WriteLine($"Nama : {mahasiswa.nama.depan} {mahasiswa.nama.belakang}");
            Console.WriteLine($"Gender : {mahasiswa.gender}");
			Console.WriteLine($"Age : {mahasiswa.age}");
			Console.WriteLine($"Address : {mahasiswa.alamat.street} {mahasiswa.alamat.city} {mahasiswa.alamat.state}");
			for ( int i = 0;i < 3;i++)
			{
				Console.WriteLine("Code = " + mahasiswa.matkul[i].code + " Name = " + mahasiswa.matkul[i].name);
			}
        }
	}
}
