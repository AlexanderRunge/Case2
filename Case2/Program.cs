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
                    Console.Clear();
                    Console.Write("Du har valgt at søge efter en lærer.\n" +
                                  "Her er alle lærer i systemet:\n" +
                                  "Peter Lindenskov, Niels Olesen, Jan Johansen, Henrik Poulsen\n" +
                                  "Skriv venligst navnet på læreren du vil søge efter : ");
                    string? teacherName = Console.ReadLine();
                    Console.WriteLine("");

                    InfoModel? teacherModel = null;
                    SearchTeacher? teacher = null;
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
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    Console.Write("Du har valgt at søge efter en elev.\n" +
                                  "Her er alle elever i systemet: \n" +
                                  "Alexander Runge, Amanda Gudmand, Camilla Kløjgaard, Dennis Paaske, Iheb Boukthir, Jakob Rasmussen, Mhd Adil Ajak, \nMicki Olsen, Mikkel Rantala, Mikkel Jensen, Mikkel Kjærgaard, Niclas Jensen, Ozan Korkmaz, Rasmus Wiell, Rune Hansen, \nSanjit Poudel\n" +
                                  "Skriv venligst navnet på eleven du vil søge efter : ");
                    string? studentName = Console.ReadLine();
                    Console.WriteLine("");

                    InfoModel? studentModel = null;
                    SearchStudent? student = null;
                    studentModel = new() { Name = studentName };
                    student = new(studentModel);
                    if (student.Info.Description.Length != 0)
                    {
                        foreach (var item in student.Info.Description)
                        {
                            Console.WriteLine(item);
                        }
                    }
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    Console.Write("Du har valgt at søge efter et fag.\n" +
                                  "Her er alle fagne i systemet:\n" +
                                  "Clientsideprogrammering, Studieteknik, Grundlæggende programmering, OOP, Databaseprogrammering, Computerteknologi, Netværk\n" +
                                  "Skriv venligst navnet på faget du vil søge efter : ");
                    string? subjectName = Console.ReadLine();
                    Console.WriteLine("");

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