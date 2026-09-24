using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1_Productos
{
    public class ValidadorEntero : IValidadorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor) ||
                !int.TryParse(valor, out int resultado) ||
                resultado < 0)
            {
                MensajeError = "Debe ingresar un número entero válido";
                return false;
            }

            return true;
        }
    }
}
