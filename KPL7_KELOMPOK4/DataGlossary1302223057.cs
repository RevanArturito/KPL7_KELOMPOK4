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
    // deklarasi class dataGlossary1302223057
    internal class DataGlossary1302223057
    {
        //deklarasi class glossary
        public class Glossary1302223057
        {
            //mengambil data title
            [JsonPropertyName("title")]
            public String title { get; set; }

            //mengambil data dari class glossaryDiv
            [JsonPropertyName("GlossDiv")]
            public GlossDiv glossDiv { get; set; }
        }

        //deklarasi class glossaryDiv
        public class GlossDiv
        {

            //mengambil data title
            [JsonPropertyName("title")]
            public string title { get; set; }

            //mengambil data dari class Gloss List
            [JsonPropertyName("GlossList")]
            public GlossList glossList { get; set; }

        }

        //deklarasi class Glosslist
        public class GlossList
        {
            // de
            [JsonPropertyName("GlossEntry")]
            public GlossEntry glossEntry { get; set; }
        }

        public class GlossEntry
        {
            public string ID { get; set; }
            public string SortAs { get; set; }
            public string GlossTerm { get; set; }
            public string Acronym { get; set; }
            public string Abbrev {  get; set; }
            
            [JsonPropertyName("GlossDef")]
            public GlossDef GlossDef { get; set; }
            public string GlossSee { get; set; }

        }

        public class GlossDef
        {
            public string para { get; set; }
            public string GlossSeeAlso { get; set; }
        }

        // method untuk menampilkan data dari file json 3
        public void ReadJSON()
        {
            string filePath = "D:\\REVAN\\MATERI KULIAH\\SEMESTER 4\\PRAKTIKUM KPL\\KPL7_KELOMPOK4\\KPL7_KELOMPOK4\\jurnal7_3_1302223057.json";
            string jsonString = File.ReadAllText(filePath);

            Glossary1302223057 glossary = JsonSerializer.Deserialize<Glossary1302223057>(jsonString);
            Console.WriteLine($"Glossary : {glossary.title}");
            Console.WriteLine();
            Console.WriteLine($"GlossDiv : ");
            Console.WriteLine($"    Title : {glossary.glossDiv.title} ");
            Console.WriteLine();
            Console.WriteLine($"GlossList : ");
            Console.WriteLine($"    GlossEntry : ");
            Console.WriteLine($"        ID : {glossary.glossDiv.glossList.glossEntry.ID}");
            Console.WriteLine($"        SortAs : {glossary.glossDiv.glossList.glossEntry.SortAs}");
            Console.WriteLine($"        Glossterm : {glossary.glossDiv.glossList.glossEntry.GlossTerm}");
            Console.WriteLine($"        Acronym : {glossary.glossDiv.glossList.glossEntry.Acronym}");
            Console.WriteLine($"        Abbrev : {glossary.glossDiv.glossList.glossEntry.Abbrev}");



            
        }
    }
}
