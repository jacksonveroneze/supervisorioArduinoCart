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
        public int Active = Util.SYSTEM_DESACTIVE;
        public int RodaDianteiraEsquerda = Util.ROTATE_BREAK;
        public int RodaDianteiraDireita = Util.ROTATE_BREAK;
        public int RodaTraseiraEsquerda = Util.ROTATE_BREAK;
        public int RodaTraseiraDireita = Util.ROTATE_BREAK;

        /// <summary>
        /// Método responsável por retornar o objeto como string.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append(Util.PACKAGE_START);
            str.Append(this.Active + Util.PACKAGE_SEPARATOR);
            str.Append(this.RodaDianteiraEsquerda + Util.PACKAGE_SEPARATOR);
            str.Append(this.RodaDianteiraDireita + Util.PACKAGE_SEPARATOR);
            str.Append(this.RodaTraseiraEsquerda + Util.PACKAGE_SEPARATOR);
            str.Append(this.RodaTraseiraDireita);
            str.Append(Util.PACKAGE_END);

            return str.ToString();
        }
    }
}