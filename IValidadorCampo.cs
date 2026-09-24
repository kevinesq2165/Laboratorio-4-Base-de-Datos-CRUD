using System;
using System.Collections.Generic;
using System.Text;

namespace Problema1_Productos
{
    public interface IValidadorCampo
    {
        bool EsValido(string? valor);
        string MensajeError { get; }
    }
}
