﻿using RH.Entities;
using System;
using System.Collections.Generic;
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
    }
}
