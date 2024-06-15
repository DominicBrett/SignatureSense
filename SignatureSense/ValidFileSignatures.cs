using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureSense
{
    static class ValidFileSignatures
    {
        public static readonly List<ValidFileSignatues> ValidSignatures = new List<ValidFileSignatues>()
        {
            new ValidFileSignatues()
            {
                FileExtension = "jpg",
                FileType = FileTypeEnum.Image,
                ValidSignatures = new Dictionary<string, byte[]>()
                {
                    { "jpg", new byte[] { 0xFF, 0xD8, 0xFF, 0xE0 } },
                    { "jpg", new byte[] { 0xFF, 0xD8, 0xFF, 0xE1 } },
                    { "jpg", new byte[] { 0xFF, 0xD8, 0xFF, 0xE8 } },
                }
            },
            new ValidFileSignatues()
            {
                FileExtension = "png",
                FileType = FileTypeEnum.Image,
                ValidSignatures = new Dictionary<string, byte[]>()
                {
                    { "png", new byte[] { 0x89, 0x50, 0x4E, 0x47 } },
                }
            },
            new ValidFileSignatues()
            {
                FileExtension = "gif",
                FileType = FileTypeEnum.Image,
                ValidSignatures = new Dictionary<string, byte[]>()
                {
                    { "gif", new byte[] { 0x47, 0x49, 0x46, 0x38 } },
                }
            },
            new ValidFileSignatues()
            {
                FileExtension = "bmp",
                FileType = FileTypeEnum.Image,
                ValidSignatures = new Dictionary<string, byte[]>()
                {
                    { "bmp", new byte[] { 0x42, 0x4D } },
                }
            },
            new ValidFileSignatues()
            {
                FileExtension = "mp4",
                FileType = FileTypeEnum.Video,
                ValidSignatures = new Dictionary<string, byte[]>()
                {
                    { "mp4", new byte[] { 0x66, 0x74, 0x79, 0x70 } },
                }
            },
            new ValidFileSignatues()
            {
                FileExtension = "mp3",
                FileType = FileTypeEnum.Audio,
                ValidSignatures = new Dictionary<string, byte[]>()
                {
                    { "mp3", new byte[] { 0x49, 0x44, 0x33 } },
                }
            },
            new ValidFileSignatues()
            {
                FileExtension = "pdf",
                FileType = FileTypeEnum.Document,
                ValidSignatures = new Dictionary<string, byte[]>()
                {
                    { "pdf", new byte[] { 0x25, 0x50, 0x44, 0x46 } },

                }
            },
            new ValidFileSignatues()
            {
                FileExtension = "exe",
                FileType = FileTypeEnum.Executable,
                ValidSignatures = new Dictionary<string, byte[]>()
                {
                    { "exe", new byte[] { 0x4D, 0x5A } },
                }
            },
        };
        public static List<ValidFileSignatues> GetValidFileSignatures() => ValidSignatures;
        public static List<ValidFileSignatues> GetValidFileSignatures(FileTypeEnum FileType) => ValidSignatures.Where(x => x.FileType == FileType).ToList();
        public static List<ValidFileSignatues> GetValidFileSignatures(string FileExtension) => ValidSignatures.Where(x => x.FileExtension == FileExtension).ToList();
    }
}
