Console.Write("Velkommen!\n");
bool check = true;
bool switchcheck;
do
{
    try
    {
        Console.WriteLine("Vælg venligst hvad du vil søge efter.\n" +
            "Klik på en af følgende knapper:\n" +
            "[1] : Lærer søgning\n" +
            "[2] : Elev søgning\n" +
            "[3] : Fag søgning\n" +
            "[Q] : Lukker Programmet");
        do
        {
            switchcheck = true;
            var keyinput = Console.ReadKey();
            switch (keyinput.Key)
            {
                case ConsoleKey.D1:
                    InfoModel? teacherModel = null;
                    SearchTeacher? teacher = null;
                    teacherModel = new();
                    teacher = new(teacherModel);
                    Console.Clear();
                    Console.Write("Du har valgt at søge efter en lærer.\n" +
                                  "Her er alle lærerne i systemet:\n" +
                                  $"{teacher.Info.List}\n" +
                                  "Skriv venligst navnet på læreren du vil søge efter : ");
                    string? teacherName = Console.ReadLine();
                    Console.Clear();

                    teacherModel = new() { Name = teacherName };
                    teacher = new(teacherModel);
                    if (teacher.Info.Description.Length != 0)
                    {
                        foreach (var item in teacher.Info.Description)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nLærer eksistere ikke\n");
                    }

                    Console.Write("Klik på en knap for at komme vidre : ");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case ConsoleKey.D2:
                    InfoModel? studentModel = null;
                    SearchStudent? student = null;
                    studentModel = new();
                    student = new(studentModel);
                    Console.Clear();
                    Console.Write("Du har valgt at søge efter en elev.\n" +
                                  "Her er alle eleverne i systemet:\n" +
                                  $"{student.Info.List}\n" +
                                  "Skriv venligst navnet på eleven du vil søge efter : ");
                    string? studentName = Console.ReadLine();
                    Console.Clear();

                    studentModel = new() { Name = studentName };
                    student = new(studentModel);
                    if (student.Info.Description.Length != 0)
                    {
                        foreach (var item in student.Info.Description)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nEleven eksistere ikke\n");
                    }

                    Console.Write("Klik på en knap for at komme vidre : ");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case ConsoleKey.D3:
                    InfoModel? subjectModel = null;
                    SearchSubject? subject = null; 
                    subjectModel = new();
                    subject = new(subjectModel);
                    Console.Clear();
                    Console.Write("Du har valgt at søge efter et fag.\n" +
                                  "Her er alle fagne i systemet:\n" +
                                  $"{subject.Info.List}\n" +
                                  "Skriv venligst navnet på faget du vil søge efter : ");
                    string? subjectName = Console.ReadLine();
                    Console.Clear();

                    subjectModel = new() { Name = subjectName };
                    subject = new(subjectModel);
                    if (subject.Info.Description.Length != 0) 
                    { 
                        foreach (var item in subject.Info.Description)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nFaget eksistere ikke\n");
                    }

                    Console.Write("Klik på en knap for at komme vidre : ");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case ConsoleKey.Q:
                    Console.WriteLine("\nStopper program...");
                    check = false;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Du klikkede ikke på en rigtig knap.\n");
                    switchcheck = false; 
                    break;
            }
        } while (switchcheck = false);
    }
    catch (Exception)
    {
        Console.WriteLine("Der skete en fejl. Prøv igen");
    }
} while (check == true);