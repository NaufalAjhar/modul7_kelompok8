namespace modul7_kelompok_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataMahasiswa1302223040 dataMahasiswa = new DataMahasiswa1302223040();
            dataMahasiswa.ReadJSON();

            TeamMembers1302223040 dataMember = new TeamMembers1302223040();
            dataMember.ReadJSON();
        }
    }
}
