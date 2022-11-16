using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2.Code;

internal enum EnumPeople
{
    [Subject(SubjectName = "Clientside", Teacher = new string[] { "Peter" }, Attendees = new string[] { "Alexander Runge", "Ozan Korkmaz", "Rasmus Wiell", "Rune Hansen" })] Clientside,
    [Subject(SubjectName = "Studieteknik", Teacher = new string[] { "Niels Olesen" }, Attendees = new string[] { "Alexander Runge", "Rasmus Wiell", "Rune Hansen" })] Studieteknik,
    [Subject(SubjectName = "Grundlæggende Programmering", Teacher = new string[] { "Niels Olesen" }, Attendees = new string[] { "Alexander Runge", "Ozan Korkmaz", "Rasmus Wiell", "Rune Hansen" })] GrundlæggendeProgrammering,
    [Subject(SubjectName = "Object Orienteret Programmering", Teacher = new string[] { "Niels Olesen" }, Attendees = new string[] { "Alexander Runge", "Ozan Korkmaz", "Rasmus Wiell", "Rune Hansen" })] ObjectOrienteretProgrammering,
}

public class SubjectAttribute : Attribute
{
    public string? SubjectName { get; set; }
    public string[]? Teacher { get; set; }
    public string[]? Attendees { get; set;}
}
