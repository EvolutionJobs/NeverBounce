﻿using System;
namespace NeverBounce.Exceptions
{
    [Serializable()]
    public class HttpClientException : Exception
    {
		public HttpClientException() : base() { }
		public HttpClientException(string message) : base(message) { }
		public HttpClientException(string message, Exception inner) : base(message, inner) { }

		// A constructor is needed for serialization when an
		// exception propagates from a remoting server to the client. 
		protected HttpClientException(System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context)
		{ }
    }
}