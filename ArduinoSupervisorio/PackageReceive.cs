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
        public double DistanciaFrontal = 0;
        public double DistanciaTraseira = 0;
        public double Velocidade = 0;


        /// <summary>
        /// Método responsável por montar o objeto de acordo com os valores recebidos.
        /// </summary>
        /// <returns>string</returns>
        public PackageReceive ProcessPackage(string packageReceive)
        {
            //validar
        }
    }
}