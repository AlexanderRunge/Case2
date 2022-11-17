using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case2.Code;

internal enum EnumPeople
{
    [Subject(SubjectName = "Clientside", Teacher = new string[] { "Peter Lindenskov" }, Attendees = new string[] { "Alexander Runge", "Amanda Gudmand", "Camilla Kløjgaard", "Dennis Paaske", "Iheb Boukthir", "Jakob Rasmussen", "Mhd Adil Ajak", "Micki Olsen", "Mikkel Rantala", "Mikkel Jensen", "Mikkel Kjærgaard", "Niclas Jensen", "Ozan Korkmaz", "Rasmus Wiell", "Rune Hansen", "Sanjit Poudel" })] Clientside,
    [Subject(SubjectName = "Studieteknik", Teacher = new string[] { "Niels Olesen" }, Attendees = new string[] { "Alexander Runge", "Amanda Gudmand", "Dennis Paaske", "Iheb Boukthir", "Jakob Rasmussen", "Mhd Adil Ajak", "Micki Olsen", "Mikkel Rantala", "Mikkel Jensen", "Mikkel Kjærgaard", "Niclas Jensen", "Rasmus Wiell", "Rune Hansen", "Sanjit Poudel" })] Studieteknik,
    [Subject(SubjectName = "Grundlæggende Programmering", Teacher = new string[] { "Niels Olesen" }, Attendees = new string[] { "Alexander Runge", "Amanda Gudmand", "Camilla Kløjgaard", "Dennis Paaske", "Iheb Boukthir", "Mhd Adil Ajak", "Jakob Rasmussen", "Micki Olsen", "Mikkel Rantala", "Mikkel Jensen", "Mikkel Kjærgaard", "Niclas Jensen", "Ozan Korkmaz", "Rasmus Wiell", "Rune Hansen", "Sanjit Poudel" })] GrundlæggendeProgrammering,
    [Subject(SubjectName = "OOP", Teacher = new string[] { "Niels Olesen" }, Attendees = new string[] {"Alexander Runge", "Amanda Gudmand", "Camilla Kløjgaard", "Dennis Paaske", "Iheb Boukthir", "Jakob Rasmussen", "Mhd Adil Ajak", "Micki Olsen", "Mikkel Rantala", "Mikkel Jensen", "Mikkel Kjærgaard", "Niclas Jensen", "Ozan Korkmaz", "Rasmus Wiell", "Rune Hansen", "Sanjit Poudel" })] ObjektOrienteretProgrammering,
    [Subject(SubjectName = "Databaseprogrammering", Teacher = new string[] { "Niels Olesen" }, Attendees = new string[] {"Alexander Runge", "Amanda Gudmand", "Camilla Kløjgaard", "Dennis Paaske", "Iheb Boukthir", "Jakob Rasmussen", "Mhd Adil Ajak", "Micki Olsen", "Mikkel Rantala", "Mikkel Jensen", "Mikkel Kjærgaard", "Niclas Jensen", "Ozan Korkmaz", "Rasmus Wiell", "Rune Hansen", "Sanjit Poudel" })] Databaseprogrammering,
    [Subject(SubjectName = "Computerteknologi", Teacher = new string[] { "Jan Johansen" }, Attendees = new string[] {"Alexander Runge", "Amanda Gudmand", "Camilla Kløjgaard", "Dennis Paaske", "Iheb Boukthir", "Jakob Rasmussen", "Mhd Adil Ajak", "Micki Olsen", "Mikkel Rantala", "Mikkel Jensen", "Mikkel Kjærgaard", "Niclas Jensen", "Ozan Korkmaz", "Rasmus Wiell", "Rune Hansen", "Sanjit Poudel" })] Computerteknologi,
    [Subject(SubjectName = "Netværk", Teacher = new string[] { "Henrik Poulsen" }, Attendees = new string[] {"Alexander Runge", "Amanda Gudmand", "Camilla Kløjgaard", "Dennis Paaske", "Iheb Boukthir", "Jakob Rasmussen", "Mhd Adil Ajak", "Micki Olsen", "Mikkel Rantala", "Mikkel Jensen", "Mikkel Kjærgaard", "Niclas Jensen", "Ozan Korkmaz", "Rasmus Wiell", "Rune Hansen", "Sanjit Poudel" })] Netværk,
} 

public class SubjectAttribute : Attribute
{
    public string? SubjectName { get; set; }
    public string[]? Teacher { get; set; }
    public string[]? Attendees { get; set;}
}
