using RentCarCenter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentCarCenter.ViewModels
{
   public class RentDetailVM
    {
        public RentDetailVM(RentDetail rent)
        {
            Rentado = rent.RentDate;
            Devuelto = rent.ReturnDetail != null ? rent.ReturnDetail.Date.ToShortDateString() : "No";
            Cliente = rent.Customer.Name;
            CedulaCliente = rent.Customer.Identification;
            Empleado = rent.Employee.Name;
            Precio = "US$ " + string.Format("{0:#.00}", rent.PriceByDay);
            Vehiculo = rent.Vehicle.Description;
            Modelo = rent.Vehicle.VehicleModel.Description;
            Matricula = rent.Vehicle.NoLicensePlate;
            NoChasis = rent.Vehicle.NoChassis;
            NoMotor = rent.Vehicle.NoMotor;
            DiasRenta = rent.RentDays;
            Comentario = rent.Comment;
        }
        public DateTime Rentado { get; set; }
        public string Devuelto { get; set; }
        public string Cliente { get; set; }
        [DisplayName("Cedula cliente")]
        public string CedulaCliente { get; set; }
        [DisplayName("Atendido Por")]
        public string Empleado { get; set; }
        public string Precio { get; set; }
        public string Vehiculo { get; set; }
        public string Modelo { get; set; }
        [DisplayName("No. Chasis")]
        public string NoChasis { get; set; }
        public string Matricula { get; set; }
        [DisplayName("No. Motor")]
        public string NoMotor { get; set; }
        [DisplayName("Dias de renta")]
        public int DiasRenta { get; set; }
        public string Comentario { get; set; }
    }
}
