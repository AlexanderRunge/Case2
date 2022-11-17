using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Case2.Code
{
    internal class SearchStudent : IInfo
    {
        public InfoModel? Info { get; set; }

        public SearchStudent(InfoModel? studentInfo)
        {
            Info = studentInfo;
            Info.Description = StudentSearch();
        }
        public string[] StudentSearch()
        {
            List<string> subjects = new List<string>();
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
                                subjects.Add(text);
                            }
                        }
                    }
                    
                }
            }
            string[] result = subjects.ToArray();
            return result;
        }
    }
}
