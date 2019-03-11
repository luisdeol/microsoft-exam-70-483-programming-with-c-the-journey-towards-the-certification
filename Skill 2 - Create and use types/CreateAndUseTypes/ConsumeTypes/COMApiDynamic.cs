namespace ConsumeTypes
{
    class COMApiDynamic
    {
        //static void Main(string[] args)
        //{

        //    var students = new List<dynamic>
        //    {
        //        new { Name = "Luis", School = "School A" },
        //        new { Name = "Felipe", School = "School B" },
        //        new { Name = "Shurato", School = "School C" },
        //        new { Name = "Bucky", School = "School D" }
        //    };

        //    ExportStudentDataToExcel(students);
        //    Console.ReadKey();
        //}

        //static void ExportStudentDataToExcel (IEnumerable<dynamic> students)
        //{
        //    var excelApplication = new Excel.Application();
        //    excelApplication.Visible = true;
        //    excelApplication.Workbooks.Add();
        //    dynamic workSheet = excelApplication.ActiveSheet;

        //    workSheet.Cells[1, "A"] = "Student";
        //    workSheet.Cells[1, "B"] = "School";

        //    var count = 1;
        //    foreach (var student in students)
        //    {
        //        count++;
        //        workSheet.Cells[count, "A"] = student.Name;
        //        workSheet.Cells[count, "B"] = student.School;
        //    }

        //    workSheet.Columns[1].AutoFit();
        //    workSheet.Columns[2].AutoFit();
        //}
    }
}
