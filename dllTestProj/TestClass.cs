using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dllTestProj
{
    public class TestClass
    {

        public string AddString(string str)
        {
            str = str + "_dll_Test_Return@@@";

            return str;
        }


    }
}
