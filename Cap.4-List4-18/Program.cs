using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap._4_List4_18
{
    class Program
    {
        static void Main(string[] args)
        {
            string folder = @"C:\temp";

            CompressingGZipStream(folder);
            ReadbyBufferedStream(folder);
        }

        public static void CompressingGZipStream(string folder)
        {
            //Compressing by GZipStream

            string uncompressedFilePath = Path.Combine(folder, "uncompressed.dat");
            string compressedFilePath = Path.Combine(folder, "compressed.gz");

            byte[] dataTocompress = Enumerable.Repeat((byte)'a', 1024 * 1024).ToArray();

            using (FileStream fs = File.Create(uncompressedFilePath))
            {
                fs.Write(dataTocompress, 0, dataTocompress.Length);
            }

            using (FileStream compressedFileStream = File.Create(compressedFilePath))
            {
                using (GZipStream gzip = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    gzip.Write(dataTocompress, 0, dataTocompress.Length);
                }
            }

            FileInfo uncompressedFile = new FileInfo(uncompressedFilePath);
            FileInfo compressedFile = new FileInfo(compressedFilePath);

            Console.WriteLine(uncompressedFile.Length);
            Console.WriteLine(compressedFile.Length);
        }

        public static void ReadbyBufferedStream(string folder)
        {
            /*
             * BufferedStream let reading larger blocks of data.
             * Read byte by byte can be slower then reading big chunks of data
             * */

            string path = Path.Combine(folder, "bufferedStream.txt");

            using(FileStream fs = File.Create(path))
            {
                using(BufferedStream bs = new BufferedStream(fs))
                {
                    using(StreamWriter sw = new StreamWriter(bs))
                    {
                        sw.WriteLine("A Line of Text.");
                    }
                }
            }
        }
    }
}
