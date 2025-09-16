using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM225409_NguyenPhamDangDuong_Real01_Singleton
{
    public string Server
    {
        get
        {
            int r = random.Next(servers.Count);
            return servers[r].ToString();
        }
    }
}
