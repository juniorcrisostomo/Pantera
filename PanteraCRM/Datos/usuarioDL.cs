﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entidades;

namespace Datos
{
    public abstract class usuarioDL
    {
        //public static List<usuario> usuarioListar()
        //{
        //    using (IDataReader datareader = conexion.executeOperation("fn_usuario_listar", CommandType.StoredProcedure))
        //    {
        //        List<usuario> listado = new List<usuario>();
        //        while (datareader.Read())
        //        {
        //            usuario registro = new usuario();
        //            registro.idusuario = Convert.ToInt32(datareader["idusuario"]);
        //            registro.nombre = Convert.ToString(datareader["nombre"]).Trim();
        //            registro.login = Convert.ToString(datareader["login"]).Trim();
        //            registro.clave = Convert.ToString(datareader["clave"]).Trim();
        //            registro.estadousuario = Convert.ToBoolean(datareader["estadousuario"]);
        //            registro.idperfil = Convert.ToInt32(datareader["idperfil"]);
        //            registro.descripcion = Convert.ToString(datareader["descripcion"]);
        //            listado.Add(registro);
        //        }
        //        return listado;
        //    }
        //}

        public static usuario buscarPorLoginClave(string login, string clave)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_usuario_buscar_por_login_y_clave", CommandType.StoredProcedure, new parametro("in_login", login),
                new parametro("in_clave", clave)))
            {
                while (datareader.Read())
                {
                    return convertirRegistro(datareader);
                }
            }
            return null;
        }
        private static usuario convertirRegistro(IDataReader datareader)
        {
            usuario registro = new usuario();
            registro.p_inidusuario = Convert.ToInt32(datareader["idusuario"]);
            registro.nombre = Convert.ToString(datareader["nombre"]).Trim();
            registro.chusuario = Convert.ToString(datareader["login"]).Trim();
            registro.estado = Convert.ToBoolean(datareader["estadousuario"]);
            registro.p_inidperfil = Convert.ToInt32(datareader["idperfil"]);
            registro.descripcion = Convert.ToString(datareader["descripcion"]).Trim();
            return registro;
        }
        public static usuario buscarPorCodigo(int idusuario)
        {
            using (IDataReader datareader = conexion.executeOperation("fn_usuario_busqueda_codigo", CommandType.StoredProcedure, new parametro("in_parametro", idusuario)))
            {
                while (datareader.Read())
                {
                    usuario registro = new usuario();

                    registro.p_inidusuario = Convert.ToInt32(datareader["p_inidusuario"]);
                    registro.p_inidpersona = Convert.ToInt32(datareader["p_inidpersona"]);
                    registro.chusuario = Convert.ToString(datareader["chusuario"]).Trim();
                    registro.chclave = Convert.ToString(datareader["chclave"]).Trim();
                    registro.estado = Convert.ToBoolean(datareader["estado"]);
                    registro.p_inidpuntoventa = Convert.ToInt32(datareader["p_inidpuntoventa"]);
                    registro.p_inidperfil = Convert.ToInt32(datareader["p_inidperfil"]);                    
                    return registro;

                }
            }
            return null;
        }
        //private static usuariosesion convertirRegistroParcial(IDataReader datareader)
        //{
        //    usuariosesion registro = new usuariosesion();
        //    registro.idusuario = Convert.ToInt32(datareader["idusuario"]);
        //    registro.nombre = Convert.ToString(datareader["nombre"]);
        //    registro.login = Convert.ToString(datareader["login"]);
        //    registro.idperfil = Convert.ToInt32(datareader["idperfil"]);
        //    return registro;
        //}
        //public static int usuarioInsertar(usuario usuario)
        //{
        //        return conexion.executeScalar("fn_usuario_insertar",
        //        CommandType.StoredProcedure,
        //        new parametro("in_nombre", usuario.nombre),
        //        new parametro("in_login", usuario.login),
        //        new parametro("in_clave", usuario.clave),
        //        new parametro("in_estadousuario", usuario.estadousuario),
        //        new parametro("in_idperfil", usuario.idperfil));
        //}

        //public static int usuarioActualizar(usuario usuario)
        //{
        //        return conexion.executeScalar("fn_usuario_actualizar",
        //        CommandType.StoredProcedure,
        //        new parametro("in_idusuario", usuario.idusuario),
        //        new parametro("in_nombre", usuario.nombre),
        //        new parametro("in_login", usuario.login),
        //        new parametro("in_clave", usuario.clave),
        //        new parametro("in_estadousuario", usuario.estadousuario),
        //        new parametro("in_idperfil", usuario.idperfil));
        //}
    }
}
