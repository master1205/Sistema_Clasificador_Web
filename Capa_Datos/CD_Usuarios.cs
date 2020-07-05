using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CD_Usuarios
    {
        private CD_Conexion conect = new CD_Conexion();
        SqlDataReader leer;
        SqlCommand comando=new SqlCommand();
        DataTable tabla;

        public DataTable muestraTabla() {
            tabla = new DataTable();
            comando.Connection = conect.AbrirConexion();
            comando.CommandText= "SELECT  Usuario,Clave, Nombre + ' ' + Apellido as Nombre,Area,Correo,Telefono, Rol FROM Usuarios";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conect.CerrarConexion();
            return tabla;
        }

        public void RegistrarUsuario(string nom, string ape, string usu, string cla, string tel, string corr, string are, string rol)
        {
            string instruccion = "insert into Usuarios values('" + nom + "', '" + ape + "', '" + usu + "', '" + cla + "', '" + are + "', '" + corr + "', '" + tel + "', '" + rol + "');";
            Utilidades.Ejecutar(instruccion);
        }

        public void ModificarUsuario(string orig, string nom, string ape, string cla, string tel, string corr, string are, string rol)
        {
            string instruccion = "update Usuarios set Nombre='" + ape + "', Apellido='" + cla + "', Clave='" + nom + "', Telefono='" + tel + "', Correo='" + corr + "', Area='" + are + "', Rol='" + rol + "' where Usuario='" + orig + "';";
            Utilidades.Ejecutar(instruccion);
        }

        public void EliminarUsuario(string usu)
        {
            string instruccion = "delete from Usuarios where Usuario='" + usu + "';";
            Utilidades.Ejecutar(instruccion);
        }

        public DataSet CargarArea()
        {
            string instruccion = "Select Descripcion from Area order by Descripcion;";
            return Utilidades.Ejecutar(instruccion);
        }
        public SqlDataReader CargarNombreApellido( string usuario)
        {
            comando.Connection = conect.AbrirConexion();
            comando = new SqlCommand("select Nombre, Apellido from Usuarios where Usuario='" + usuario + "'", conect.conex);
            leer = comando.ExecuteReader();
            leer.Close();
            return comando.ExecuteReader();
        }

        public DataSet CargarRol()
        {
            string instruccion = "Select Rol from Rol;";
            return Utilidades.Ejecutar(instruccion);
        }
    }
}
