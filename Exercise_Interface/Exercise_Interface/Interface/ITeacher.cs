using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_Interface.Interface
{
    public interface ITeacher : IUser
    {
        List<string> Subjects { get; set; }

        new void PrintUser();
     
    }
}
