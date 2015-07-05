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
        public const int RODA_DIANTEIRA_ESQUERDA_FRENTE = 8;
        public const int RODA_DIANTEIRA_ESQUERDA_RE = 9;
        public const int RODA_DIANTEIRA_DIREITA_FRENTE = 11;
        public const int RODA_DIANTEIRA_DIREITA_RE = 10;

        public const int RODA_TRASEIRA_ESQUERDA_FRENTE = 2;
        public const int RODA_TRASEIRA_ESQUERDA_RE = 3;
        public const int RODA_TRASEIRA_DIREITA_FRENTE = 4;
        public const int RODA_TRASEIRA_DIREITA_RE = 5;

        public const int BREAK_ROTATE = 0;
        public const int ROTATE_FORWARD = 1;
        public const int ROTATE_BACKWARD = 2;

    }
}
