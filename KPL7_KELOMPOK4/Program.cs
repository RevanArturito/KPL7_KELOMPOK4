// See https://aka.ms/new-console-template for more information


using KPL7_KELOMPOK4;

public class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa1302223057 mahasiswa = new DataMahasiswa1302223057();
        mahasiswa.ReadJSON();

        Console.WriteLine();
        DataMember1302223057 member = new DataMember1302223057();
        member.ReadJSON();  
    }
}
