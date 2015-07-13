using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoSupervisorio
{
    class Util
    {
        public const int SYSTEM_DESACTIVE = 0;
        public const int SYSTEM_ACTIVE = 1;

        public const string PACKAGE_START = "#";
        public const string PACKAGE_END = "#";
        public const string PACKAGE_SEPARATOR = ";";

        public const int ROTATE_BREAK = 0;
        public const int ROTATE_FORWARD = 1;
        public const int ROTATE_BACKWARD = 2;
    }
}
