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
        EmpleadosDAL empleadosDAL = new EmpleadosDAL();


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
            return empleadosDAL.GetEmpleados();
        }

        public int AddNewEmpleado(Empleado empleado)
        {
            // Aqui se validan los datos antes de enviarlos a la base de datos
            if (ValidarEmpleado(empleado) == -1)
                return -1;
            
            int reg = empleadosDAL.AddEmpleado(empleado);
            return reg;
        }

        private int ValidarEmpleado(Empleado empleado)
        {
            if (string.IsNullOrEmpty(empleado.Nombres))
                return -1;
            if (string.IsNullOrEmpty(empleado.Apellidos))
                return -1;
            if (empleado.Celular == 0 || empleado.Celular.ToString().Length < 10)
                return -1;
            if (empleado.TipoDocIdentificacion == 0)
                return -1;
            if (empleado.NumDocIdentificacion == 0)
                return -1;

            return 0;
        }

        public Empleado FindEmpleadoByIdentity(long docIdentificacion)
        {
            // Validamos
            if (docIdentificacion > 0)
                return empleadosDAL.FindEmpleadoByIdentity(docIdentificacion);
            else
                return new Empleado();
        }

        public int UpdateEmpleado(Empleado empleado)
        {
            // Aqui se validan los datos antes de enviarlos a la base de datos
            if (ValidarEmpleado(empleado) == -1)
                return -1;

            int reg = empleadosDAL.UpdateEmpleado(empleado);
            return reg;
        }

        public void Delete(long numeroIdentificacion)
        {
            empleadosDAL.DeleteEmpleado(numeroIdentificacion);
        }
    }
}
