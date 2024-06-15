using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureSense.Extensions
{
    public static class StringExtensions
    {
        public static bool ValidateFile(this string filePath, FileTypeEnum fileType) => FileSignatueValidationService.ValidateFile(File.ReadAllBytes(filePath), fileType);

        public static bool ValidateFile(this string filePath, string fileExtension) => FileSignatueValidationService.ValidateFile(File.ReadAllBytes(filePath), fileExtension);
    }
}
