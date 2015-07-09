using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoSupervisorio
{
    class Util
    {
        public const string PACKAGE_START = "#";
        public const string PACKAGE_END = "#";
        public const string PACKAGE_SEPARATOR = ";";

        public const int ACTIVE_SYSTEM = 1;
        public const int DESACTIVE_SYSTEM = 0;

        public const int BREAK_ROTATE = 0;
        public const int ROTATE_FORWARD = 1;
        public const int ROTATE_BACKWARD = 2;
    }
}
