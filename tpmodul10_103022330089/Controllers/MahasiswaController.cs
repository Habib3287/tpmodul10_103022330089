using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022330089;

namespace MahasiswaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MahasiswaController : ControllerBase
    {
        // Static list sebagai penyimpanan data
        private static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa ("Haafizd Alhabib Azwir","103022330089" ),
            new Mahasiswa ("Fauzul Akbar","103022300102" ),
            new Mahasiswa ("Hafidz Musyafa Azmi","103022300162" ),
            new Mahasiswa ("Fadhli Muhammad Dzaki", "103022330068" ),
            new Mahasiswa ("Gilang Tirta Kesumah", "103022330077" )
        };

        // GET: api/mahasiswa
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Mahasiswa>))]
        public IActionResult Get()
        {
            return Ok(daftarMahasiswa);
        }

        // GET api/mahasiswa/1
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetMahasiswaByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound("Mahasiswa tidak ditemukan");
            }
            return daftarMahasiswa[index];
        }

        // POST api/mahasiswa
        [HttpPost]
        public ActionResult<List<Mahasiswa>> Post(Mahasiswa mahasiswaBaru)
        {
            daftarMahasiswa.Add(mahasiswaBaru);
            return daftarMahasiswa;
        }

        // DELETE api/mahasiswa/1
        [HttpDelete("{index}")]
        public IActionResult DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
            {
                return NotFound("Mahasiswa tidak ditemukan");
            }
            daftarMahasiswa.RemoveAt(index);
            return Ok(daftarMahasiswa);
        }
    }
}