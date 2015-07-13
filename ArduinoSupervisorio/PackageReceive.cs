using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoSupervisorio
{
    /// <summary>
    /// Classe responsável por montar o pacote a ser enviado para o dispositivo.
    /// </summary>
    class PackageReceive
    {
        public double DistanciaDianteira = 0;
        public double DistanciaTraseira = 0;
        public double Velocidade = 0;

        /// <summary>
        /// Método responsável por montar o objeto de acordo com os valores recebidos.
        /// </summary>
        /// <returns>string</returns>
        public PackageReceive ProcessPackage(string data)
        {
            if("".equals(data))
            {
                return null;
            }

            string packageReceive = data.Remove(data.Length - 1);

            if(!packageReceive.StartsWith(Util.PACKAGE_START))
            {
                return null;
            }

            if(!packageReceive.EndsWith(Util.PACKAGE_END))
            {
                return null;
            }

            if(!packageReceive.Contains(Util.PACKAGE_SEPARATOR))
            {
                return null;
            }

            string packageReceive1 = packageReceive.Remove(0, 2);
            string packageReceive2 = packageReceive1.Remove(packageReceive1.Length - 1);

            string[] packageReceiveSplit = packageReceive2.Split(char.Parse(Util.PACKAGE_SEPARATOR));

            this.DistanciaDianteira = double.Parse(packageReceiveSplit[0]);
            this.DistanciaTraseira = double.Parse(packageReceiveSplit[1]);

            return this;
        }
    }
}