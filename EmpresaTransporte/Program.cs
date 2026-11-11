using System;
using System.Collections.Generic;
using System.IO;

namespace EmpresaTransporte
{
	class Program
	{
		public static void Menu(){
		
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
						break;
					case 2:
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
		
		public static void Main(string[] args)
		{
			Menu();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}