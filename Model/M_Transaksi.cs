﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projek_SimBuku.Model
{
    public class M_Transaksi
    {
        [Key]
        public int id_transaksi { get; set; }
        [Required]
        public string tanggal_tansaksi { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public decimal harga_sewa { get; set; }
        [Required]
        public decimal harga_denda { get; set; }
        [Required]
        public string tanggal_pengambilan { get; set; }
        [Required]
        public string tanggal_pengembalian { get; set; }
        [ForeignKey("M_Keranjang")] 
        public int id_keranjang { get; set; }
        [ForeignKey("M_MetodePembayaran")] 
        public int id_metode_pembayaran { get; set; }
        public virtual M_Keranjang Keranjang { get; set; }
        public virtual M_Metode_Pembayaran MetodePembayaran { get; set; }
        [NotMapped] 
        public string judul_buku => Keranjang?.Buku?.Judul_buku;
        [NotMapped]
        public string nama => Keranjang?.Akun?.nama;
    }
}
