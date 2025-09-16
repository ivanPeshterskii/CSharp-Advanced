namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!students.ContainsKey(name))
                {
                    students[name] = new List<decimal>();
                }

                students[name].Add(grade);
            }

            foreach (var entry in students)
            {
                string name = entry.Key;
                var grades = entry.Value;

                var average = grades.Average();
                var fixedScores = grades.Select(st => st.ToString("F2"));
                var formattedScores = string.Join(" ", fixedScores);

                Console.WriteLine($"{name} -> {formattedScores} (avg: {average:F2})");
            }
        }
    }
}

