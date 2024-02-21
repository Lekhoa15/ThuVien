using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản__lý_thư_viện.AppModel
{
    public class PhieuMuon
    {
        public int MaPhieuMuon { get; set; }
        public DateTime NgayMuon { get; set; } 

        public int MaDocGia { get; set; }
        [ForeignKey(nameof(MaDocGia))]
        public virtual DocGia DocGia { get; set; } // Changed property name to follow conventional naming

       
    }
}
