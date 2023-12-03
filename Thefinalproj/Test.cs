using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thefinalproj
{
    public class Test
    {
        public Test()
        {
            CheckIfTableFileExists();
            CheckIfPlayerFileExists();
        }

        private void CheckIfTableFileExists()
        {
            Debug.Assert(File.Exists("Table.txt"));
        }
        private void CheckIfPlayerFileExists()
        {
            Debug.Assert(File.Exists("PlayerList.txt"));
        }
    }
}
