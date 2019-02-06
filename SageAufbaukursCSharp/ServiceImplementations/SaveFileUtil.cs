using SageAufbaukursCSharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SageAufbaukursCSharp.ServiceImplementations
{
    public class SaveFileUtil : ISaveFileUtil
    {
        #region ISaveFileUtil
        public Exception Fault { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Message { get; private set; }

        public string FaultPath { get; private set; }

        public bool Save(object beleg)
        {
            try
            {
                using (var sw = new StreamWriter(FaultPath))
                {
                    
                    sw.Write("hallo sw");
                }
                return true;
            }
            catch(UnauthorizedAccessException uae)
            {
                Message = uae.Message;
                Fault = uae;
                return false;
            }
            catch(ArgumentException ae)
            {
                try
                {
                    FaultPath = (Path.Combine(Environment.GetEnvironmentVariables()["PROGRAMDATA"].ToString(), "Test.log"));
                    using (var sw = new StreamWriter(FaultPath))
                    {

                        sw.Write("hallo sw");
                    }
                    return true;
                }
                catch (Exception)
                {

                    Fault = ae;
                    return false;
                }
            }
            catch (PathTooLongException ptl)
            {
                return false;
            }
            catch (Exception e)
            {
                Fault = e;
                return false;
            }
        }

        public bool Save(object beleg, string path)
        {
            throw new NotImplementedException();
        }
        #endregion ISaveFileUtil
    }
}
