using GraphQL;

using System;
using System.Collections;

namespace Api.GraphQL.ExecutionErrors
{
	public class DatabaseExecutionError	: ExecutionError
	{
		public DatabaseExecutionError(string message) : base(message) { }
		public DatabaseExecutionError(string message, IDictionary data) : base(message, data) { }
		public DatabaseExecutionError(string message, Exception exception) : base(message, exception) { }
	}
}
