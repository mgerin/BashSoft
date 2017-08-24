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
            // IOManager.TraverseDirectory(@"D:\SoftUni\BashSoft\BashSoft");
            // StudentsRepository.InitializeData();
            // StudentsRepository.GetAllStudentsFromCourse("Unity");
            // StudentsRepository.InitializeData();
            // StudentsRepository.GetStudentScoresFromCourse("Unity", "Ivan");
            Tester.CompareContent(
                @"D:\SoftUni\BashSoft\Advanced-CSharp\BashSoft-FirstWeek\test2.txt",
                @"D:\SoftUni\BashSoft\Advanced-CSharp\BashSoft-FirstWeek\test3.txt");
        }
    }
}
