using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Case2.Code;

internal class SearchStudent : IInfo
{
    public InfoModel? Info { get; set; }

    public SearchStudent(InfoModel? studentInfo)
    {
        Info = studentInfo;
        Info.Description = StudentSearch();
        Info.List = StudentList();
    }
    public string[] StudentSearch()
    {
        List<string> students = new List<string>();
        Array values = Enum.GetValues(typeof(EnumPeople));
        foreach (EnumPeople selectedEnum in values)
        {
            MemberInfo[] memberInfo = selectedEnum.GetType().GetMember(selectedEnum.ToString());
            SubjectAttribute subjectAttribute = memberInfo.First().GetCustomAttribute<SubjectAttribute>();
            if (Info.Name != null && subjectAttribute != null)
            {
                if (subjectAttribute.Attendees.Contains(Info.Name, StringComparer.OrdinalIgnoreCase))
                {
                    foreach (string student in subjectAttribute.Attendees)
                    {
                        if (student.Equals(Info.Name, StringComparison.OrdinalIgnoreCase))
                        {
                            string text = $"{student} har faget {subjectAttribute.SubjectName} og læren til dette fag er {subjectAttribute.Teacher[0]}\n";
                            students.Add(text);
                        }
                    }
                }
            }
        }
        string[] result = students.ToArray();
        return result;
    }
    public string StudentList()
    {
        List<string> students = new List<string>();
        Array values = Enum.GetValues(typeof(EnumPeople));
        foreach (EnumPeople selectedEnum in values)
        {
            MemberInfo[] memberInfo = selectedEnum.GetType().GetMember(selectedEnum.ToString());
            SubjectAttribute subjectAttribute = memberInfo.First().GetCustomAttribute<SubjectAttribute>();
            if (subjectAttribute != null)
            {
                foreach (string student in subjectAttribute.Attendees)
                {
                    if (!students.Contains(student, StringComparer.OrdinalIgnoreCase))
                    {
                        students.Add(student);
                    }
                }
            }
        }
        string result = string.Join(", \n", students.ToArray());
        return result;
    }
}
