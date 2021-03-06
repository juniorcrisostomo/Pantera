﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public abstract class maestrodetalleDL
    {
        public static List<maestrodetalle> buscarPorCodigoMaestro(int codigomaestro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_maestrodetalle_buscar_por_codigomaestro", CommandType.StoredProcedure, new parametro("in_codigomaestro", codigomaestro)))
            {
                List<maestrodetalle> listado = new List<maestrodetalle>();
                while (datareader.Read())
                {
                    maestrodetalle registro = new maestrodetalle();
                    registro.idmaestrodetalle = Convert.ToInt32(datareader["idmaestrodetalle"]);
                    registro.idmaestro = Convert.ToInt32(datareader["idmaestro"]);
                    registro.codigoitem = Convert.ToString(datareader["codigoitem"]).Trim();
                    registro.nombreitem = Convert.ToString(datareader["nombreitem"]).Trim();
                    registro.libre = Convert.ToString(datareader["libre"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static maestrodetalle BuscarPorCodigoDetalle(int codigomaestro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_maestrodetalle_buscar_por_codigodetale", CommandType.StoredProcedure, new parametro("in_idmaestrodetalle", codigomaestro)))
            {
                maestrodetalle registro = new maestrodetalle();
                while (datareader.Read())
                {
                    registro.idmaestrodetalle = Convert.ToInt32(datareader["idmaestrodetalle"]);
                    registro.idmaestro = Convert.ToInt32(datareader["idmaestro"]);
                    registro.codigoitem = Convert.ToString(datareader["codigoitem"]).Trim();
                    registro.nombreitem = Convert.ToString(datareader["nombreitem"]).Trim();
                    registro.libre = Convert.ToString(datareader["libre"]).Trim();
                }
                return registro;
            }
        }
        
        public static List<maestrocabecera> MaestroCabeceraListar()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_maestrocabecera_listar", CommandType.StoredProcedure ))
            {
                List<maestrocabecera> listado = new List<maestrocabecera>();
                while (datareader.Read())
                {
                    maestrocabecera registro = new maestrocabecera();
                    registro.p_inidmaestrocabecera = Convert.ToInt32(datareader["p_inidmaestrocabecera"]);
                    registro.chdesmoestro = Convert.ToString(datareader["chdesmoestro"]).Trim();
                    registro.chobserbacion = Convert.ToString(datareader["chobserbacion"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.chcodigomaestrocab = Convert.ToString(datareader["chcodigomaestrocab"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);
                    
                    listado.Add(registro);
                }
                return listado;
            }
        }
        
            public static maestrocabecera MaestroCabeceraListarCodigo(int parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_maestrocabecera_listar_codigo", CommandType.StoredProcedure, new parametro("in_parametro", parametro)))
            {
                maestrocabecera registro = new maestrocabecera();
                while (datareader.Read())
                {
                    registro.p_inidmaestrocabecera = Convert.ToInt32(datareader["p_inidmaestrocabecera"]);
                    registro.chdesmoestro = Convert.ToString(datareader["chdesmoestro"]).Trim();
                    registro.chobserbacion = Convert.ToString(datareader["chobserbacion"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.chcodigomaestrocab = Convert.ToString(datareader["chcodigomaestrocab"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);

                }
                return registro;
            }
        }
        public static List<maestrocabecera> MaestroCabeceraListarParametro(string parametro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_maestrocabecera_listar_parametro", CommandType.StoredProcedure, new parametro("in_parametro",parametro)))
            {
                List<maestrocabecera> listado = new List<maestrocabecera>();
                while (datareader.Read())
                {
                    maestrocabecera registro = new maestrocabecera();
                    registro.p_inidmaestrocabecera = Convert.ToInt32(datareader["p_inidmaestrocabecera"]);
                    registro.chdesmoestro = Convert.ToString(datareader["chdesmoestro"]).Trim();
                    registro.chobserbacion = Convert.ToString(datareader["chobserbacion"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.chcodigomaestrocab = Convert.ToString(datareader["chcodigomaestrocab"]).Trim();
                    registro.p_inidusuarioinsert = Convert.ToInt32(datareader["p_inidusuarioinsert"]);
                    registro.p_inidusuariodelete = Convert.ToInt32(datareader["p_inidusuariodelete"]);

                    listado.Add(registro);
                }
                return listado;
            }
        }
        

        public static List<categoria> ListarCategorias()
        {
            using (IDataReader datareader = conexion.executeOperation("fn_categorias_listar", CommandType.StoredProcedure))
            {
                List<categoria> listado = new List<categoria>();
                while (datareader.Read())
                {
                    categoria catelist = new categoria();
                    catelist.p_inidcategoria = Convert.ToInt32(datareader["p_inidcategoria"]);
                    catelist.chcategoria = Convert.ToString(datareader["chcategoria"]).Trim();
                    listado.Add(catelist);
                }
                return listado;
            }
        }
        public static List<tipo> buscarTipoPorCategoria(string codigomaestro)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_TipoListarPorCategoriaN", CommandType.StoredProcedure, new parametro("in_p_inidcategoria", codigomaestro)))
            {
                List<tipo> listado = new List<tipo>();
                while (datareader.Read())
                {
                    tipo registro = new tipo();
                    registro.p_inidtipo = Convert.ToInt32(datareader["p_inidtipo"]);
                    registro.chtipo = Convert.ToString(datareader["chtipo"]).Trim();
                    listado.Add(registro);
                }
                return listado;
            }
        }
        public static int MaestroCabeceraIngresar(maestrocabecera registro)
        {
            return conexion.executeScalar("fn_maestrocabecera_ingresar",
            CommandType.StoredProcedure,

            //new parametro("in_chcodigoproducto", registro.p_inidmaestrocabecera = 0;
            new parametro("in_chdesmoestro", registro.chdesmoestro),
            new parametro("in_chobserbacion", registro.chobserbacion),
            new parametro("in_estado", registro.estado),
            new parametro("in_chcodigomaestrocab", registro.chcodigomaestrocab),
            new parametro("in_p_inidusuarioinsert", registro.p_inidusuarioinsert)
);

        }
        public static int MaestroDetalleIngresar(maestrodetalle registro)
        {
            return conexion.executeScalar("fn_maestrodetalle_ingresar",
            CommandType.StoredProcedure,

            //new parametro("in_chcodigoproducto", registro.idmaestrodetalle = 0;
            new parametro("in_p_inidmaestrocabecera", registro.idmaestro ),
            new parametro("in_chdesitem", registro.nombreitem),
            new parametro("in_chacroitem", registro.libre),
            new parametro("in_estado", registro.estado ));

        }
        public static int MaestroCabeceraModificar(maestrocabecera registro)
        {
            return conexion.executeScalar("fn_maestrocabecera_modificar",
            CommandType.StoredProcedure,

            new parametro("in_p_inidmaestrocabecera", registro.p_inidmaestrocabecera ),
            new parametro("in_chdesmoestro", registro.chdesmoestro),
            new parametro("in_chobserbacion", registro.chobserbacion),
            new parametro("in_estado", registro.estado),
            new parametro("in_chcodigomaestrocab", registro.chcodigomaestrocab),
            new parametro("in_p_inidusuarioinsert", registro.p_inidusuarioinsert) );

        }
        public static int MaestroDetalleFalsear(int codigo)
        {
            return conexion.executeScalar("fn_maestrodetalle_falsear",
            CommandType.StoredProcedure,
            new parametro("in_p_inidmaestrocabecera", codigo));

        }
    }
}
