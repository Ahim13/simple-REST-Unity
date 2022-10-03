using System;

namespace WebRequest
{
	public class RestResponseException : Exception
	{
		public long ResponseCode;

		public RestResponseException()
		{
		}

		public RestResponseException(string message) : base(message)
		{
		}

		public RestResponseException(string message, Exception innerException) : this(message)
		{
		}
		
		public RestResponseException(string message, long responseCode)
			: this(message)
		{
			ResponseCode = responseCode;
		}
	}
}