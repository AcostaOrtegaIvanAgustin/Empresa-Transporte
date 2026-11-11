using System;
using System.IO;
using System.Collections.Generic;

namespace EmpresaTransporte
{
	/// <summary>
	/// Description of Class1.
	/// </summary>
	public class EmpresaTransporte
	{
		private string nombre;
		private string cuit;
		private List<Viaje> viajes = new List<Viaje>();
		private List<Chofer> choferes = new List<Chofer>();
		private List<Vehiculo> vehiculos = new List<Vehiculo>();
		
		public EmpresaTransporte(string nombre, string cuit)
		{
			this.nombre = nombre;
			this.cuit = cuit;
		}
		
		public void RegistrarChofer(Chofer chofer)
	{
		choferes.Add(chofer);
	}
		public void RegistrarVehiculo(Vehiculo vehiculo)
	{
		vehiculos.Add(vehiculo);
	}
		public void PlanificarViaje(Viaje viaje)
		{
			viajes.Add(viaje);
		}
		public void EliminarChofer(int dni){}
		
		public void EliminarVehiculo(string matricula){}
		
		//public double CalcularMontoNetoTotalSueldos(){}
		
		//public double CalcularCostosOperativosSemana(){}
		
		//public double CalcularTotalFacturablePeriodo(){}
		
		public void ListarChoferes(){}
		
		public void ListarVehiculos(){}
		
		public void ListarViajesPorFecha(){}
		
		public void ListarViajesPorChofer(){}
		
		public void ListarViajesdeChofer(){}
		
		public void ListarViajesDeVehiculo(){}
		
		public void GuadarDatos(){}
		
		public void CargarDatos(){}
			
	}
}
