using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1_Productos
{
    public class ValidadorTexto : IValidadorCampo
    {
        public string MensajeError { get; private set; } = string.Empty;

        public bool EsValido(string? valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
            {
                MensajeError = "El campo de Texto no puede estar vacío";
                return false;
            }

            return true;
        }
    }
}
