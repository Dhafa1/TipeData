namespace TipeData
{
    internal class Program
    {
        static void Main()
        {
            // Numerik
            int umur = 16;
            float tinggi = 170.5f;
            Console.WriteLine("Umur: " + umur);
            Console.WriteLine("Tinggi: " + tinggi);

            // String
            string nama = "Budi";
            Console.WriteLine("Nama: " + nama);

            // Tanggal
            DateTime hariIni = DateTime.Now;
            Console.WriteLine("Hari ini: " + hariIni.ToString("dd/MM/yyyy"));

            // Boolean
            bool isLulus = true;
            Console.WriteLine("Apakah lulus? " + isLulus);
        }
    }
}
