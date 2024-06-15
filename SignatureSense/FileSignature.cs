using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureSense
{
    internal class ValidFileSignatues
    {
        public string FileExtension { get; set; }
        public FileTypeEnum FileType { get; set; }
        public Dictionary<string, byte[]> ValidSignatures { get; set; }
    }
}
