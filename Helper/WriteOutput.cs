using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreativeCashDraw.Helper
{
    public class WriteOutput
    {
        private static WriteOutput instance;
        private WriteOutput() { }

        public static WriteOutput Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WriteOutput();
                }
                return instance;
            }
        }

        public void WriteOutputFile(string outputPath, string output)
        {
            System.IO.File.WriteAllText(outputPath + @"\output.txt", output);
        }
    }
}
