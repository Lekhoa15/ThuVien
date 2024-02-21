using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản__lý_thư_viện.AppModel
{
    public class ChiTietPhieuMuon
    {

        public int maCTPM
        {
            get; set;
        }

        public int MaPhieuMuon
        {
            get; set;
        }

       
        public int MaSach
        {
            get; set;
        }

        public int TrangThai { get; set; }


    }
}
