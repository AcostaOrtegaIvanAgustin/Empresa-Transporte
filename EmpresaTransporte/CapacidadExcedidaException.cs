using System;
using System.Runtime.Serialization;

	public class CapacidadExcedidaException : Exception, ISerializable
	{
		public CapacidadExcedidaException()
		{
		}

	 	public CapacidadExcedidaException(string message) : base(message)
		{
		}

		public CapacidadExcedidaException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// This constructor is needed for serialization.
		protected CapacidadExcedidaException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
