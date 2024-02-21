using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản__lý_thư_viện.AppModel
{
    public class sach
    {

        public int MaSach { get; set; }
        public string TenSach { get; set; }

        public int SoLuong { get; set; }

        public String tacgia { get; set; }
        public DateTime ngayNhap { get; set; }

        public int namXuatBan { get; set; }

        public int dem  {get; set;}
        public string MaLoai { get; set; }
        [ForeignKey(nameof(MaLoai))]

        public virtual loaisach LoaiSach { get; set; }

      //  public virtual ICollection<ChiTietPhieuMuon> ctpms { get; set; }



    }
}
