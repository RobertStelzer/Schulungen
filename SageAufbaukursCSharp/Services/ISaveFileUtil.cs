using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SageAufbaukursCSharp.Services
{
    public interface ISaveFileUtil
    {
        Exception Fault { get; }
        string Message { get; }
        string FaultPath { get; }
        bool Save(object beleg);
        bool Save(object beleg, string path);
    }
}
