using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Exercise_Interface.Interface
{
    public interface IStudent : IUser
    {
        List<int> Grades { get; set; }

        new void PrintUser();
        
    }
}
