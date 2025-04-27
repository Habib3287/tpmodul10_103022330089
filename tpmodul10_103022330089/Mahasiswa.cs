using System.Text.Json.Serialization;

namespace tpmodul10_103022330089
{
    public class Mahasiswa
    {
        private string nama;
        private string nim;

        public Mahasiswa(string nama, string nim)
        {
            this.nama = nama;
            this.nim = nim;
        }

        [JsonPropertyName("nama")]
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        [JsonPropertyName("nim")]
        public string Nim
        {
            get { return nim; }
            set { nim = value; }
        }
    }
}
