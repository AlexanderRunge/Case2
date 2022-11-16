Console.Write("Velkommen!\n");
bool check = true;
bool switchcheck;
do
{
    try
    {
        Console.Write("Vælg venligst hvad du vil søge efter.\n" +
                      "\n" +
                      "Klik [1] for at søge efter en lærer, [2] for at søge efter en elev, [3] for at søge efter et fag, eller [q] for at forlade programmet : ");
        do
        {
            switchcheck = true;
            var keyinput = Console.ReadKey();
            switch (keyinput.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    Console.Write("Du har valgt at søge efter en lærer.\n" +
                                  "Skriv venligst navnet på læreren du vil søge efter : ");
                    string? teacherName = Console.ReadLine();

                    InfoModel? teacherModel = null;
                    SearchTeacher? teacher = null;
                    teacherModel = new() { Name = teacherName };
                    teacher = new(teacherModel);
                    foreach (var item in teacher.Info.Description)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case ConsoleKey.D2:
                    Console.Clear();

                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.Write("Du har valgt at søge efter et fag.\n" +
                                  "Skriv venligst navnet på faget du vil søge efter : ");
                    string? subjectName = Console.ReadLine();

                    InfoModel? subjectModel = null;
                    SearchSubject? subject = null;
                    subjectModel = new() { Name = subjectName };
                    subject = new(subjectModel);
                    foreach (var item in subject.Info.Description)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case ConsoleKey.Q:
                    Console.WriteLine("Stopper program...");
                    check = false;
                    break;
                default:
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