using RH.DataAccessLayer;
using RH.Entities;
using System;
using System.Collections.Generic;

namespace RH.BusinessLogic
{
    /// <summary>
    /// Esta clase se encraga de las operaciones de los empleados
    /// en la capa de Business Logic
    /// </summary>
    public class EmpleadosBL
    {
        List<Empleado> empleados = new List<Empleado>();

        public EmpleadosBL()
        {
            //empleados = new List<Empleado> {
            //    new Empleado { Nombres="Jaime", Apellidos="Perez", Celular=3003435566, FechaNacimiento= new DateTime(1991,02,23), FechaIngreso=new DateTime(2000,03,23) },
            //    new Empleado { Nombres="Jualian Enrique", Apellidos="Martinez", FechaIngreso=new DateTime(2015,06,30), FechaNacimiento=new DateTime(1973,12,30)},
            //    new Empleado { Nombres="Maria", Apellidos="Gonzalez", FechaIngreso=new DateTime(2018,10,01), FechaNacimiento=new DateTime(1978,10,29)}
            //    };
        }

        public List<Empleado> DevolverListaEmpleados()
        {
            EmpleadosDAL empleadosDAL = new EmpleadosDAL();
            empleados = empleadosDAL.DevolverEmpleados();

            // var infiere el tipo de datos que esta al lado derecho del igual
            return empleados;
        }

        public int AdicionarNuevoEmpleado(Empleado empleado)
        {
            int registrosAfectados = 0;
            EmpleadosDAL empleadosDAL = new EmpleadosDAL();

            // Aqui controlamos algun error que pueda ocurrir al momento de adicionar
            try
            {
                registrosAfectados = empleadosDAL.AdicionarEmpleado(empleado);
                //empleados.Add(empleado);
                //registrosAfectados = 1;
            }
            catch (Exception ex)
            {
                // TODO: Guardar en un log de errores
                var error = ex.Message;
            }

            return registrosAfectados;
        }

        public List<Empleado> EmpleadosDesdeBD()
        {
            EmpleadosDAL empleadosDAL = new EmpleadosDAL();

            return empleadosDAL.GetEmpleados();
        }
    }
}
