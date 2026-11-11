using System;
using System.Collections.Generic;



public class Chofer
	{
		private string nombre, direccion, estadoCivil;
		private int dni;
		private DateTime fechaDeNacimiento;
		private double sueldoBasico;
		public List<Viaje> listaViajes;
		public Chofer(string nombre, string direccion, string estadoCivil, int dni, DateTime fechaDeNacimiento, double sueldoBasico, List<Viaje> listaViajes)
		{
			this.nombre=nombre;
			this.direccion=direccion;
			this.estadoCivil=estadoCivil;
			this.dni=dni;
			this.fechaDeNacimiento=fechaDeNacimiento;
			this.sueldoBasico=sueldoBasico;
			listaViajes = new List<Viaje>();
		}
		public double SueldoBasico{
			get{return sueldoBasico;}
		}
		public double calcularSueldoNeto(){
			return sueldoBasico * 0.81;
		}
		public int calcularEdad(){
			int edad = DateTime.Today.Year - fechaDeNacimiento.Year;
    		if (fechaDeNacimiento.Date > DateTime.Today.AddYears(-edad))
    		{
        		edad--;
    		}
    		return edad;
		}
		public bool disponible(DateTime inicio, DateTime fin){
			foreach (Viaje viaje in listaViajes){
        		if (inicio < viaje.FechaFin && fin > viaje.FechaProgramada){
            		return false;
        		}
    		}
    		return true;
		}
	}