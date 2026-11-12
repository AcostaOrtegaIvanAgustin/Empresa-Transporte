using System;
using System.Collections.Generic;
using System.IO;

namespace EmpresaTransporte
{
	class Program
	{
		
		//static EmpresaTransporte et1 = new EmpresaTransporte("EmpresaTransporte", "28645984562");
		public static void Menu(EmpresaTransporte et1){
		
			int opcion; //opcion a elegir
			do{
				
				//		Despliegue del Menu		//
				Console.WriteLine("====================================");
    			Console.WriteLine("      SISTEMA DE GESTIÓN				");
    			Console.WriteLine("====================================");
    			Console.WriteLine("1. Registrar chofer nuevo");
    			Console.WriteLine("2. Registrar vehículo nuevo");
    			Console.WriteLine("3. Planificar viaje");
    			Console.WriteLine("4. Eliminar chofer/vehículo");
    			Console.WriteLine("5. Submenú de impresión / reportes");
    			Console.WriteLine("6. Salir");
    			Console.WriteLine("====================================");
    			Console.WriteLine("Seleccione una opción: ");
    			opcion = int.Parse(Console.ReadLine());
    			
				switch(opcion)
				{
					case 1:
						et1.RegistrarChofer(ObtenerChofer());
						break;
					case 2:
						et1.RegistrarVehiculo(ObtenerVehiculo());
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						Submenu();
						break;
					case 6:
						break;
					default:
            			Console.WriteLine("Opción inválida.");
            			break;
				
				
				}
			}while(opcion!=6);
		}
		
		public static void Submenu(){
			int opcion;
			do{
				Console.WriteLine("====================================");
    			Console.WriteLine("        SISTEMA DE GESTIÓN		   ");
    			Console.WriteLine("====================================");
    			Console.WriteLine("   SUBMENÚ DE IMPRESION / REPORTES  ");
    			Console.WriteLine("====================================");
    			Console.WriteLine("1. Listado de choferes: mostrar nombre, edad, sueldo básico y viajes asignados");
    			Console.WriteLine("2. Listar vehículos");
    			Console.WriteLine("3. Viajes programados por fecha: mostrar código, ruta, distancia, y costo estimado");
    			Console.WriteLine("4. Listar viajes asociadas a un chofer");
    			Console.WriteLine("5. Listar viajes asociados a un vehículo");
    			Console.WriteLine("6. Regresar al Menú");
    			Console.WriteLine("====================================");
    			Console.WriteLine("Seleccione una opción: ");
				opcion = int.Parse(Console.ReadLine());
				switch(opcion)
				{
					case 1:
						break;
					case 2:
						break;
					case 3:
						break;
					case 4:
						break;
					case 5:
						break;
					case 6:
						break;
					default:
            			Console.WriteLine("Opción inválida.");
            			break;
				}
				
			}while(opcion!=6);
			
		}
		
		public static Chofer ObtenerChofer()
		{
    		string nombre;
    		string direccion;
    		string estadoCivil;
    		int dni;
    		DateTime fechaNacimiento;
    		double sueldo;

    		Console.Write("Escriba el nombre completo: ");
    		nombre = Console.ReadLine();

    		Console.Write("Escriba la dirección: ");
    		direccion = Console.ReadLine();

    		Console.Write("Escriba el estado civil: ");
    		estadoCivil = Console.ReadLine();

    		Console.Write("Escriba el número de DNI: ");
    		dni = Convert.ToInt32(Console.ReadLine());

    		Console.Write("Escriba la fecha de nacimiento: ");
    		fechaNacimiento = Convert.ToDateTime(Console.ReadLine());

    		Console.Write("Escriba el sueldo bruto: ");
    		sueldo = Convert.ToDouble(Console.ReadLine());

    		return new Chofer(nombre, direccion, estadoCivil, dni, fechaNacimiento, sueldo);
		}
		
		public static Vehiculo ObtenerVehiculo()
		{
    		Console.WriteLine("Tipo de vehículo:");
    		Console.WriteLine("1. Moto");
    		Console.WriteLine("2. Furgón");

    		int tipo = Convert.ToInt32(Console.ReadLine());

    		Console.Write("Código interno: ");
    		string codigo = Console.ReadLine();

    		Console.Write("Matrícula: ");
    		string matricula = Console.ReadLine();

    		Console.Write("Capacidad de carga: ");
    		int capacidad = Convert.ToInt32(Console.ReadLine());

    		Console.Write("Kilometraje: ");
    		double kilometraje = Convert.ToDouble(Console.ReadLine());

    		Console.Write("Costo base: ");
    		double costo = Convert.ToDouble(Console.ReadLine());

    		Console.Write("Estado: ");
    		string estado = Console.ReadLine();

    		if (tipo == 1)
    		{
        		return new MotoReparto(codigo, matricula, capacidad, kilometraje, costo, estado);
    		}
    		else
    		{
        		return new Furgon(codigo, matricula, capacidad, kilometraje, costo, estado);
    		}
		}
		
		public static Viaje ObtenerViaje(EmpresaTransporte et1)
		{
    		Console.Write("Código del viaje: ");
    		string codigo = Console.ReadLine();

    		Console.Write("Origen: ");
    		string origen = Console.ReadLine();

    		Console.Write("Destino: ");
    		string destino = Console.ReadLine();

    		Console.Write("Distancia (km): ");
    		double distancia = Convert.ToDouble(Console.ReadLine());

    		Console.Write("Fecha programada: ");
    		DateTime fechaProgramada = Convert.ToDateTime(Console.ReadLine());

    		Console.Write("Fecha de finalización: ");
    		DateTime fechaFin = Convert.ToDateTime(Console.ReadLine());

    		Console.Write("Carga a transportar: ");
    		double carga = Convert.ToDouble(Console.ReadLine());

    		// Seleccionar vehículo
    		Console.WriteLine("Vehículos disponibles:");

			for (int i = 0; i < et1.Vehiculos.Count; i++)
			{
    			Console.WriteLine((i + 1) + ". " + et1.Vehiculos[i].Matricula);
			}

			Console.Write("Seleccione un vehículo: ");
			int opcion = Convert.ToInt32(Console.ReadLine());

			Vehiculo vehiculo = et1.Vehiculos[opcion - 1];

    		// Seleccionar choferes
    		List<Chofer> listaChoferes = new List<Chofer>();

			Console.Write("¿Cuántos choferes tendrá el viaje?: ");
			int cantidad = Convert.ToInt32(Console.ReadLine());

			for (int i = 0; i < cantidad; i++)
			{
    			Console.WriteLine("Seleccione el chofer " + (i + 1));

    			for (int j = 0; j < et1.Choferes.Count; j++)
    			{
        			Console.WriteLine((j + 1) + ". " + et1.Choferes[j].Nombre);
    			}

    		int op = Convert.ToInt32(Console.ReadLine());

    		listaChoferes.Add(et1.Choferes[op - 1]);
}

    		return new Viaje(codigo, origen, destino, distancia, fechaProgramada, fechaFin, carga, vehiculo, listaChoferes);
}
		
		public static void Main(string[] args)
		{
			EmpresaTransporte et1 = new EmpresaTransporte("EmpresaTransporte", "28645984562");
			Menu(et1);
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}