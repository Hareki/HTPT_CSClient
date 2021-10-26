using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTPTCSClient.Model
{
    public class FileInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public DateTime UploadedDate { get; set; }
    }
}
