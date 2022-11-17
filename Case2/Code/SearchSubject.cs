using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Case2.Code;

internal class SearchSubject
{
    public InfoModel? Info { get; set; }

    public SearchSubject(InfoModel? subjectInfo)
    {
        Info = subjectInfo;
        Info.Description = SubjectSearch();
        Info.List = SubjectList();
    }
    public string[] SubjectSearch()
    {
        List<string> attendees = new List<string>();
        Array values = Enum.GetValues(typeof(EnumPeople));
        foreach (EnumPeople selectedEnum in values)
        {
            MemberInfo[] memberInfo = selectedEnum.GetType().GetMember(selectedEnum.ToString());
            SubjectAttribute subjectAttribute = memberInfo.First().GetCustomAttribute<SubjectAttribute>();
            if (Info.Name != null && subjectAttribute != null)
            {
                if (subjectAttribute.SubjectName.Equals(Info.Name, StringComparison.OrdinalIgnoreCase))
                {
                    string text = $"{string.Join(", ", subjectAttribute.Teacher)} er lærer for {subjectAttribute.SubjectName} som har eleverne:\n{string.Join(",\n", subjectAttribute.Attendees)}\n";
                    attendees.Add(text);
                }
            }
        }
        string[] result = attendees.ToArray();
        return result;
    }
    public string SubjectList()
    {
        List<string> subjects = new List<string>();
        Array values = Enum.GetValues(typeof(EnumPeople));
        foreach (EnumPeople selectedEnum in values)
        {
            MemberInfo[] memberInfo = selectedEnum.GetType().GetMember(selectedEnum.ToString());
            SubjectAttribute subjectAttribute = memberInfo.First().GetCustomAttribute<SubjectAttribute>();
            if (subjectAttribute != null)
            {
                if (!subjects.Contains(subjectAttribute.SubjectName, StringComparer.OrdinalIgnoreCase))
                {
                    subjects.Add(subjectAttribute.SubjectName);
                }
            }
        }
        string result = string.Join(", \n", subjects.ToArray());
        return result;
    }
}
