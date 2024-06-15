using SignatureSense.Exceptions;
using SignatureSense.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureSense
{
    public static class FileSignatueValidationService
    {

        public static bool ValidateFile(byte[] fileBytes, FileTypeEnum fileType)
        {
            var validSignatures = ValidFileSignatures.GetValidFileSignatures(fileType);

            // No file signatures found for this file type
            if (validSignatures == null || validSignatures.Count == 0)
            {
                throw new NoFileSignaturesFoundException(ExceptionMessageResources.NoFileSignaturesFoundForFileType);
            }

            using var reader = new BinaryReader(new MemoryStream(fileBytes));
            var headerBytes = reader.ReadBytes(validSignatures.Max(f => f.ValidSignatures.Values.Max(validSignatures => validSignatures.Length)));

            return validSignatures.Any(validSignatures => validSignatures.ValidSignatures.Any(signature => headerBytes.Take(signature.Value.Length).SequenceEqual(signature.Value)));

        }

        public static bool ValidateFile(byte[] fileBytes, string fileExtension)
        {
            var validSignatures = ValidFileSignatures.GetValidFileSignatures(fileExtension);

            // No file signatures found for this file
            if (validSignatures == null || validSignatures.Count == 0)
            {
                throw new NoFileSignaturesFoundException(ExceptionMessageResources.NoFileSignaturesFoundForFileExtension);
            }

            using var reader = new BinaryReader(new MemoryStream(fileBytes));
            var headerBytes = reader.ReadBytes(validSignatures.Max(f => f.ValidSignatures.Values.Max(validSignatures => validSignatures.Length)));

            return validSignatures.Any(validSignatures => validSignatures.ValidSignatures.Any(signature => headerBytes.Take(signature.Value.Length).SequenceEqual(signature.Value)));

        }   

    }
}
