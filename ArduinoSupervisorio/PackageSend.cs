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
        public int Active = Util.DESACTIVE_SYSTEM;
        public int RodaDianteiraEsquerda = Util.BREAK_ROTATE;
        public int RodaDianteiraDireita = Util.BREAK_ROTATE;
        public int RodaTraseiraEsquerda = Util.BREAK_ROTATE;
        public int RodaTraseiraDireita = Util.BREAK_ROTATE;

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