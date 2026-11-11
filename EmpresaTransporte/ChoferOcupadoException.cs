using System;
using System.Runtime.Serialization;

	public class ChoferOcupadoException : Exception, ISerializable
	{
		public ChoferOcupadoException()
		{
		}

	 	public ChoferOcupadoException(string message) : base(message)
		{
		}

		public ChoferOcupadoException(string message, Exception innerException) : base(message, innerException)
		{
		}

		// This constructor is needed for serialization.
		protected ChoferOcupadoException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
