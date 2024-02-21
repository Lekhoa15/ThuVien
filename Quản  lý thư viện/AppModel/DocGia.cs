using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản__lý_thư_viện.AppModel
{
    public class DocGia
    {
        public int MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public virtual ICollection<PhieuMuon> phieuMuons { get; set; }


    }
}
