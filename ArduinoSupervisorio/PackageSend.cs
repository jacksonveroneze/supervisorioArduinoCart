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
    class PackageSend
    {
        public const string PACKAGE_START = "#";
        public const string PACKAGE_END = "#";
        public const string PACKAGE_SEPARATOR = ";";

        public int Active = 0;
        public int RodaDianteiraEsquerda = 0;
        public int RodaDianteiraDireita = 0;
        public int RodaTraseiraEsquerda = 0;
        public int RodaTraseiraDireita = 0;


        /// <summary>
        /// Método construtor da classe.
        /// </summary>
        public PackageSend()
        {

        }

        /// <summary>
        /// Método responsável por retornar o objeto como string.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(PACKAGE_START);
            str.Append(this.Active + PACKAGE_SEPARATOR);
            str.Append(this.RodaDianteiraEsquerda + PACKAGE_SEPARATOR);
            str.Append(this.RodaDianteiraDireita + PACKAGE_SEPARATOR);
            str.Append(this.RodaTraseiraEsquerda + PACKAGE_SEPARATOR);
            str.Append(this.RodaTraseiraDireita);
            str.Append(PACKAGE_END);

            return str.ToString();
        }
    }
}