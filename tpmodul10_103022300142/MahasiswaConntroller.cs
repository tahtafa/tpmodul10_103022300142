using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300142.Models;


namespace tpmodul10_103022300142.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        
        private static List<Mahasiswa> listMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("M. Tahtafaiz Madani", "103022300142"),
            new Mahasiswa("Dian Fardiansyah", "1030220300"),
            new Mahasiswa("Putri Afni Azkiya", "1030220300125"),
            new Mahasiswa("Fathian Alfiana Rahman", "103022300084"),
            new Mahasiswa("Nawra Nazli Kirana", "1030220300054")
            
        };

        
        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return listMahasiswa;
        }

        
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= listMahasiswa.Count)
            {
                return NotFound();
            }
            return listMahasiswa[index];
        }

        
        [HttpPost]
        public void Post([FromBody] Mahasiswa mhs)
        {
            listMahasiswa.Add(mhs);
        }

        
        [HttpDelete("{index}")]
        public void Delete(int index)
        {
            if (index >= 0 && index < listMahasiswa.Count)
            {
                listMahasiswa.RemoveAt(index);
            }
        }
    }
}
