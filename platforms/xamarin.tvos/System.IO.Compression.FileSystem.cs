namespace System.IO.Compression
{
    public static partial class ZipFile
    {
        public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName) { }
        public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory) { }
        public static void CreateFromDirectory(string sourceDirectoryName, string destinationArchiveFileName, System.IO.Compression.CompressionLevel compressionLevel, bool includeBaseDirectory, System.Text.Encoding entryNameEncoding) { }
        public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName) { }
        public static void ExtractToDirectory(string sourceArchiveFileName, string destinationDirectoryName, System.Text.Encoding entryNameEncoding) { }
        public static System.IO.Compression.ZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode) { throw null; }
        public static System.IO.Compression.ZipArchive Open(string archiveFileName, System.IO.Compression.ZipArchiveMode mode, System.Text.Encoding entryNameEncoding) { throw null; }
        public static System.IO.Compression.ZipArchive OpenRead(string archiveFileName) { throw null; }
    }
    public static partial class ZipFileExtensions
    {
        public static System.IO.Compression.ZipArchiveEntry CreateEntryFromFile(this System.IO.Compression.ZipArchive destination, string sourceFileName, string entryName) { throw null; }
        public static System.IO.Compression.ZipArchiveEntry CreateEntryFromFile(this System.IO.Compression.ZipArchive destination, string sourceFileName, string entryName, System.IO.Compression.CompressionLevel compressionLevel) { throw null; }
        public static void ExtractToDirectory(this System.IO.Compression.ZipArchive source, string destinationDirectoryName) { }
        public static void ExtractToFile(this System.IO.Compression.ZipArchiveEntry source, string destinationFileName) { }
        public static void ExtractToFile(this System.IO.Compression.ZipArchiveEntry source, string destinationFileName, bool overwrite) { }
    }
}
