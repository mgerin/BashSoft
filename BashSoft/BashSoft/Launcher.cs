namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Launcher
    {
        static void Main()
        {
            IOManager.TraverseDirectory(@"D:\SoftUni\BashSoft\BashSoft");
        }
    }
}
