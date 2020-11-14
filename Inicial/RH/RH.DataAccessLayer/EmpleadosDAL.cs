using RH.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH.DataAccessLayer
{
    /// <summary>
    /// Esta clase se encargara de persistir lso datos de empleados 
    /// en un archivo o en una base de datos
    /// </summary>
    public class EmpleadosDAL
    {
        #region  Manejo de Archivos 

        string path = @"E:\CCB\Inicial\RH\RH.WindowsApp\bin\Debug\Empleados.txt";
        public EmpleadosDAL()
        {
            if (!File.Exists(path))
            {
                // Crear el archivo
                StreamWriter swEmpleado = new StreamWriter(path);
                // swEmpleado.WriteLine("Archivo Empleados");
                swEmpleado.Flush();
                swEmpleado.Close();
                LlenarEmpleadosIniciales();
            }
        }

        private void LlenarEmpleadosIniciales()
        {
            StreamWriter swEmpleado = new StreamWriter(path);

            swEmpleado.WriteLine("Jaime" + "," + "Perez" + "," + "3003435566" + "," + new DateTime(1991, 02, 23).ToShortDateString() + "," + new DateTime(2000, 03, 23).ToShortDateString());
            swEmpleado.WriteLine("Jualian Enrique" + "," + "Martinez" + "," + "3203435566" + "," + new DateTime(2015, 06, 30).ToShortDateString() + "," + new DateTime(1973, 12, 30).ToShortDateString());
            swEmpleado.WriteLine("Maria" + "," + "Gonzalez" + "," + "3203435566" + "," + new DateTime(2018, 10, 01).ToShortDateString() + "," + new DateTime(1978, 10, 29).ToShortDateString());

            swEmpleado.Flush();
            swEmpleado.Close();
        }

        public int AdicionarEmpleado(Empleado empleado)
        {
            int registro = 0;
            // StreamWriter swEmpleado = new StreamWriter(path);
            FileStream file = new FileStream(path, FileMode.Append);
            try
            {
                StringBuilder sbEmpleado = new StringBuilder();
                sbEmpleado.Append(empleado.Nombres);
                sbEmpleado.Append(",");
                sbEmpleado.Append(empleado.Apellidos);
                sbEmpleado.Append(",");
                sbEmpleado.Append(empleado.Celular);
                sbEmpleado.Append(",");
                sbEmpleado.Append(empleado.FechaIngreso.ToShortDateString());
                sbEmpleado.Append(",");
                sbEmpleado.AppendLine(empleado.FechaNacimiento.ToShortDateString());

                //swEmpleado.WriteLine(sbEmpleado.ToString());
                //swEmpleado.Flush();
                byte[] bytes = Encoding.ASCII.GetBytes(sbEmpleado.ToString());
                file.Write(bytes, 0, bytes.Count());
                file.Flush();
                registro = 1;
            }
            catch (Exception ex)
            {
                // TODO: Agregar al log de errores
                string err = ex.Message;
            }
            finally
            {
                file.Close();
            }
            return registro;
        }

        public List<Empleado> DevolverEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();

            StreamReader srEmpleados = new StreamReader(path);

            string linea = srEmpleados.ReadLine();
            while (linea != null)
            {
                string[] array = linea.Split(',');
                try
                {
                    Empleado empleado = new Empleado
                    {
                        Nombres = array[0],
                        Apellidos = array[1],
                        Celular = Convert.ToInt64(array[2]),
                        FechaIngreso = Convert.ToDateTime(array[3]),
                        FechaNacimiento = Convert.ToDateTime(array[4])
                    };
                    empleados.Add(empleado);
                }
                catch (Exception ex)
                {
                    // TODO: Agregar al log de errores
                    string err = ex.Message;
                }

                linea = srEmpleados.ReadLine();
            }
            srEmpleados.Close();

            return empleados;
        }


        #endregion

        SQLDbManager db = new SQLDbManager();

        public void DeleteEmpleado(long numeroIdentificacion)
        {
            StringBuilder sbQuery = new StringBuilder();
            // Esta es la sentencia SQL con le lenguaje de BAse de Datos
            sbQuery.Append("DELETE FROM  Empleados  ");
            sbQuery.Append("WHERE  NumDocIdentificacion = " + numeroIdentificacion);

             db.AddOrUpdate(sbQuery.ToString());
        }

        public int UpdateEmpleado(Empleado empleado)
        {
            StringBuilder sbQuery = new StringBuilder();
            // Esta es la sentencia SQL con le lenguaje de BAse de Datos
            sbQuery.Append("UPDATE Empleados SET ");
            sbQuery.Append("Nombres = '" + empleado.Nombres  + "',  ");
            sbQuery.Append("Apellidos = '" + empleado.Apellidos + "', ");
            sbQuery.Append("FechaNAcimiento = '" + empleado.FechaNacimiento.ToString("yyyyMMdd") + "',  ");
            sbQuery.Append("TipoDocIdentificacion = " + empleado.TipoDocIdentificacion + ", ");
            sbQuery.Append("Celular = " + empleado.Celular + ",  ");
            sbQuery.Append("FechaIngreso = '" + empleado.FechaIngreso.ToString("yyyyMMdd") + "' ");
            sbQuery.Append("WHERE  NumDocIdentificacion = " + empleado.NumDocIdentificacion);

            return db.AddOrUpdate(sbQuery.ToString());
        }

        public Empleado FindEmpleadoByIdentity(long docIdentificacion)
        {
            //List<Empleado> Empleados = new List<Empleado>();
            //Empleados = GetEmpleados();
            //return Empleados
            //    .Where(e => e.NumDocIdentificacion == docIdentificacion)
            //    .FirstOrDefault();

            StringBuilder sbQuery = new StringBuilder();
            // Esta es la sentencia SQL con le lenguaje de BAse de Datos
            sbQuery.Append("SELECT ");
            sbQuery.Append("Id, Nombres, Apellidos, ");
            sbQuery.Append("FechaNAcimiento, TipoDocIdentificacion, ");
            sbQuery.Append("NumDocIdentificacion, Celular, FechaIngreso  ");
            sbQuery.Append("FROM Empleados ");
            sbQuery.Append("WHERE  NumDocIdentificacion = " + docIdentificacion);

            SqlDataReader reader = db.ReadData(sbQuery.ToString());

            Empleado empleado = new Empleado();

            while (reader.Read())
            {
                empleado = new Empleado()
                {
                    Apellidos = reader["Apellidos"].ToString(),
                    Nombres = reader["Nombres"].ToString(),
                    Celular = Convert.ToInt64(reader["Celular"]),
                    Id = Convert.ToInt32(reader["Id"]),
                    TipoDocIdentificacion = Convert.ToInt32(reader["TipoDocIdentificacion"]),
                    NumDocIdentificacion = Convert.ToInt64(reader["NumDocIdentificacion"]),
                    FechaIngreso = !DBNull.Value.Equals(reader["FechaIngreso"]) ? Convert.ToDateTime(reader["FechaIngreso"]) : DateTime.Now,
                    FechaNacimiento = !DBNull.Value.Equals(reader["FechaNacimiento"]) ? Convert.ToDateTime(reader["FechaNacimiento"]) : DateTime.Now
                };
            }

            reader.Close();
            return empleado;
        }

        public List<Empleado> GetEmpleados()
        {
            List<Empleado> Empleados = new List<Empleado>();

            StringBuilder sbQuery = new StringBuilder();
            // Esta es la sentencia SQL con le lenguaje de BAse de Datos
            sbQuery.Append("SELECT ");
            sbQuery.Append("Id, Nombres, Apellidos, ");
            sbQuery.Append("FechaNAcimiento, TipoDocIdentificacion, ");
            sbQuery.Append("NumDocIdentificacion, Celular, Salario  ");
            sbQuery.Append("FROM Empleados ");

            SqlDataReader reader = db.ReadData(sbQuery.ToString());

            Empleado empleado = new Empleado();

            while (reader.Read())
            {
                empleado = new Empleado()
                {
                    Apellidos = reader["Apellidos"].ToString(),
                    Nombres = reader["Nombres"].ToString(),
                    Celular = Convert.ToInt64(reader["Celular"]),
                    Id = Convert.ToInt32(reader["Id"]),
                    TipoDocIdentificacion = Convert.ToInt32(reader["TipoDocIdentificacion"]),
                    NumDocIdentificacion = Convert.ToInt64(reader["NumDocIdentificacion"])
                };

                Empleados.Add(empleado);
            }

            reader.Close();
            return Empleados;
        }


        public int AddEmpleado(Empleado empleado)
        {
            StringBuilder sbQuery = new StringBuilder();
            // Esta es la sentencia SQL con le lenguaje de BAse de Datos
            sbQuery.Append("INSERT INTO Empleados ( ");
            sbQuery.Append(" Nombres, Apellidos, ");
            sbQuery.Append("FechaNAcimiento, TipoDocIdentificacion, ");
            sbQuery.Append("NumDocIdentificacion, Celular, FechaIngreso  ");
            sbQuery.Append(" ) VALUES ( ");
            sbQuery.Append("'" + empleado.Nombres + "', ");
            sbQuery.Append("'" + empleado.Apellidos + "', ");
            // Esto para guardar la fecha no importa el formato de fecha del PC
            // sbQuery.Append( empleado.FechaNacimiento.ToOADate() + ", ");
            sbQuery.Append("'" + empleado.FechaNacimiento.ToString("yyyyMMdd") + "', ");
            sbQuery.Append(empleado.TipoDocIdentificacion + ", ");
            sbQuery.Append(empleado.NumDocIdentificacion + ", ");
            sbQuery.Append(empleado.Celular + ", ");
            if (empleado.FechaIngreso != null)
                sbQuery.Append("'" + empleado.FechaIngreso.ToString("yyyyMMdd") + "' ");
            else
                sbQuery.Append("'" + DateTime.Now.ToString("yyyyMMdd") + "' ");
            sbQuery.Append(" ) ");

            return db.AddOrUpdate(sbQuery.ToString());
        }
    }
}
