using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Case2.Code;

internal class SearchTeacher : IInfo
{
    public InfoModel? Info { get; set; }

    public SearchTeacher(InfoModel? teacherInfo)
    {
        Info = teacherInfo;
        Info.Description = TeacherSearch();
    }
    public string[] TeacherSearch()
    {
        List<string> subjects = new List<string>();
        Array values = Enum.GetValues(typeof(EnumPeople));
        foreach (EnumPeople selectedEnum in values)
        {
            MemberInfo[] memberInfo = selectedEnum.GetType().GetMember(selectedEnum.ToString());
            SubjectAttribute subjectAttribute = memberInfo.First().GetCustomAttribute<SubjectAttribute>();
            if (Info.Name != null && subjectAttribute != null)
            {
                if (subjectAttribute.Teacher.Contains(Info.Name, StringComparer.OrdinalIgnoreCase))
                {
                    string text = $"{string.Join(", ", subjectAttribute.Teacher)} er lærer for {subjectAttribute.SubjectName} som har eleverne:\n{string.Join(",\n", subjectAttribute.Attendees)}\n";
                    subjects.Add(text);
                }
            }
        }
        string[] result = subjects.ToArray();
        return result;
    }
}
