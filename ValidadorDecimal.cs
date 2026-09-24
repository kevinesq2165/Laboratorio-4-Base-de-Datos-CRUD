using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1_Productos
{
    public class ValidadorDecimal : IValidadorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor) ||
                !decimal.TryParse(valor, out decimal resultado) ||
                resultado < 0)
            {
                MensajeError = "Debe ingresar un número decimal válido";
                return false;
            }

            return true;
        }
    }
}
