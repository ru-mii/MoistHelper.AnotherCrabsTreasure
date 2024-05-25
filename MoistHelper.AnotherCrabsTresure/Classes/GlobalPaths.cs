using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GlobalPaths
{
    internal static readonly string ProgramDataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "rumii", "MoistHelper.AnotherCrabsTreasure");


}
