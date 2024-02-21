using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản__lý_thư_viện.AppModel
{
    public class loaisach
    {
        public string MaLoai { get; set; }
        public string tenLoai {  get; set; }

        public virtual ICollection<sach> sachs { get; set; }

    }
}
