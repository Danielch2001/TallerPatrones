using Best_Practices.Models;
using System.Collections.Generic;

namespace Best_Practices
{
	public class MemoryCollection
	{
		// Instancia única del Singleton
		private static MemoryCollection _instance;

		// Propiedad para acceder a la colección de vehículos
		public ICollection<Vehicle> Vehicles { get; private set; }

		// Constructor privado para evitar la creación de instancias externas
		private MemoryCollection()
		{
			Vehicles = new List<Vehicle>();
		}

		// Propiedad estática para obtener la única instancia de la clase
		public static MemoryCollection Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new MemoryCollection();
				}
				return _instance;
			}
		}
	}

}
