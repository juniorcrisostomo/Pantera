﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;
namespace Negocios
{
    public abstract class generarCodigoNE
    {
        public static string ObtenerUltimoCodigoPedido(int parametro)
        {
            return generarCodigoDL.ObtegerUltimocodigoPedido(parametro);
        }
        public static int ObtenerTipoCambio(string parametro)
        {
            return generarCodigoDL.ObetenertipoCambio(parametro);
        }
        public static string ObtenerCorrelativoBoleta(int parametro)
        {
            return generarCodigoDL.ObtenerCorrelativoBoleta(parametro);
        }
        public static string ObtenercorrelativoFactura(int parametro)
        {
            return generarCodigoDL.ObtenercorrelativoFactura(parametro);
        }
        public static string ObtenerCorrelativoGuia(int parametro)
        {
            return generarCodigoDL.ObtenerCorrelativoGuia(parametro);
        }
        public static string ObtenerCorrelativoNotaCredito(int parametro)
        {
            return generarCodigoDL.ObtenerCorrelativoNotaCredito(parametro);
        }
        public static string ObtenerCorrelativoNotaDebito(int parametro)
        {
            return generarCodigoDL.ObtenerCorrelativoNotaDebito(parametro);
        }
        public static string ObtenerCorrelativoNotaVenta(int parametro)
        {
            return generarCodigoDL.ObtenerCorrelativoNotaVenta(parametro);
        }
    }
}
