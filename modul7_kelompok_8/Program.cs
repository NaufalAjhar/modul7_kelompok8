namespace modul7_kelompok_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302220098_praktikan dataMahasiswa = new DataMahasiswa1302220098_praktikan();
            dataMahasiswa.ReadJSON();

            TeamMembers1302220098 dataMember = new TeamMembers1302220098();
            dataMember.ReadJSON();
        }
    }
}
