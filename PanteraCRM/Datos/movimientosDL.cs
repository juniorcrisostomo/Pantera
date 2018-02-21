﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
namespace Datos
{
    public abstract class movimientosDL
    {
        public static int MovimientoProductoCabeceraIngresar(movimientoproductoc registros)
        {
            return conexion.executeScalar("fn_moviproductocabecera_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidalamacen", registros.p_inidalamacen),
            new parametro("in_p_inidclase", registros.p_inidclase),
            new parametro("in_p_inidcorrevale", registros.p_inidcorrevale),
            new parametro("in_chvalefecha", registros.chvalefecha),
            new parametro("in_p_inidtipomoneda", registros.p_inidtipomoneda),
            new parametro("in_p_inidproveedor", registros.p_inidproveedor),
            new parametro("in_chguiaremision", registros.chguiaremision),
            new parametro("in_chboletafactura", registros.chboletafactura),
            new parametro("in_p_inidtipomoviemiento", registros.p_inidtipomoviemiento),
            new parametro("in_chobservacion", registros.chobservacion),
            new parametro("in_p_inidusuarioinsert", registros.p_inidusuarioinsert),
            new parametro("in_p_inidusuariodelete", registros.p_inidusuariodelete),
            new parametro("in_estado", registros.estado),
            new parametro("in_p_inidmovimiento", registros.p_inidmovimiento ));

        }
        public static int MovimientoProductoDetalleIngresar(movimientoproductod registros)
        {
            return conexion.executeScalar("fn_moviproductodetalle_ingresar",
            CommandType.StoredProcedure,
            new parametro("in_p_inidvalecebecera", registros.p_inidvalecebecera),
            new parametro("in_p_inidproducto", registros.p_inidproducto),
            new parametro("in_nucantidad", registros.nucantidad),
            new parametro("in_nucosto", registros.nucosto),
            new parametro("in_nutotal", registros.nutotal));

        }
    }
}