﻿namespace tpmodul10_103022300142.Models
    


{
    public class Mahasiswa
    {

        public string Nama { get; set; }
        public string Nim { get; set; }

        public Mahasiswa(string nama, string nim)
        {
            Nama = nama;
            Nim = nim;
        }
    }
}
