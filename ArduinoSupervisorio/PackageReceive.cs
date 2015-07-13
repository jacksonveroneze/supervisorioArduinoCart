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
        public PackageReceive ProcessPackage(string packageReceive)
        {
            if(this.ValidPackageReceive(data) == false)
            {
                return null;
            }

            packageReceive = packageReceive.Remove(0, 2);
            packageReceive = packageReceive.Remove(data.Length - 1);
            packageReceive = packageReceive.Remove(packageReceive1.Length - 1);

            string[] packageReceiveSplit = packageReceive.Split(char.Parse(Util.PACKAGE_SEPARATOR));

            this.DistanciaDianteira = double.Parse(packageReceiveSplit[0]);
            this.DistanciaTraseira = double.Parse(packageReceiveSplit[1]);

            return this;
        }

        /// <summary>
        /// Método responsável por validar os valores recebidos.
        /// </summary>
        /// <returns>bool</returns>
        public bool ValidPackageReceive(string data)
        {
            if("".equals(data))
            {
                return false;
            }

            string packageReceive = data.Remove(data.Length - 1);

            if(!packageReceive.StartsWith(Util.PACKAGE_START))
            {
                return false;
            }

            if(!packageReceive.EndsWith(Util.PACKAGE_END))
            {
                return false;
            }

            if(!packageReceive.Contains(Util.PACKAGE_SEPARATOR))
            {
                return false;
            }

            return true;
        }
    }
}