namespace BashSoft
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public static class RepositorySorters
    {
        public static void OrderAndTake(Dictionary<string, List<int>> wantedData, string comparison, int studentsToTake)
        {
            
        }

        private static void OrderAndTake(
            Dictionary<string, List<int>> wantedData,
            int studentsToTake,
            Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> comparisonFunc)
        {
            OutputWriter.DisplayStudent(GetSortedStudents(wantedData, studentsToTake, comparisonFunc));
        }

        private static Dictionary<string, List<int>> GetSortedStudents(
            Dictionary<string, List<int>> studentsWanted,
            int takeCount,
            Func<KeyValuePair<string, List<int>>, KeyValuePair<string, List<int>>, int> Comparison)
        {
            int valuesTaken = 0;
            Dictionary<string, List<int>> studentsSorted = new Dictionary<string, List<int>>();
            KeyValuePair<string, List<int>> nextInOrder = new KeyValuePair<string, List<int>>();
            bool isSorted = false;

            while (valuesTaken < takeCount)
            {
                isSorted = true;
                foreach (var studentWithScore in studentsWanted)
                {
                    if (!string.IsNullOrEmpty(nextInOrder.Key))
                    {
                        int comparisonResult = Comparison(studentWithScore, nextInOrder);
                        if (comparisonResult >= 0 && !studentsSorted.ContainsKey(studentWithScore.Key))
                        {
                            nextInOrder = studentWithScore;
                            isSorted = false;
                        }
                    }
                    else
                    {
                        if (!studentsSorted.ContainsKey(studentWithScore.Key))
                        {
                            nextInOrder = studentWithScore;
                            isSorted = false;
                        }
                    }
                }

                if (!isSorted)
                {
                    studentsSorted.Add(nextInOrder.Key, nextInOrder.Value);
                    valuesTaken++;
                    nextInOrder = new KeyValuePair<string, List<int>>();
                }
            }

            return studentsSorted;
        }

        private static int CompareInOrder(
            KeyValuePair<string, List<int>> firstValuePair,
            KeyValuePair<string, List<int>> secondValuePair)
        {
            int totalOfFirstMarks = 0;
            foreach (int i in firstValuePair.Value)
            {
                totalOfFirstMarks += i;
            }

            int totalOfSecondMarks = 0;
            foreach (int i in secondValuePair.Value)
            {
                totalOfSecondMarks += i;
            }

            return totalOfSecondMarks.CompareTo(totalOfFirstMarks);
        }

        private static int CompareDescendingOrder(
            KeyValuePair<string, List<int>> firstValuePair,
            KeyValuePair<string, List<int>> secondValuePair)
        {
            int totalOfFirstMarks = 0;
            foreach (int i in firstValuePair.Value)
            {
                totalOfFirstMarks += i;
            }

            int totalOfSecondMarks = 0;
            foreach (int i in secondValuePair.Value)
            {
                totalOfSecondMarks += i;
            }

            return totalOfFirstMarks.CompareTo(totalOfSecondMarks);
        }
    }
}
