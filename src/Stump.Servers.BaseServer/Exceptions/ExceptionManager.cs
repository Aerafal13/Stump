using System.Collections.ObjectModel;
using SharpRaven.Data;
using Stump.Core.Reflection;

namespace Stump.Server.BaseServer.Exceptions
{
	public class ExceptionManager : Singleton<ExceptionManager>
	{
		private readonly List<Exception> m_exceptions = new List<Exception>();

		public ReadOnlyCollection<Exception> Exceptions => m_exceptions.AsReadOnly();

		public static void RegisterException(Exception ex)
		{
			if (ServerBase.IsExceptionLoggerEnabled)
			{
				ServerBase.InstanceAsBase.ExceptionLogger.Capture(new SentryEvent(ex));
			}
			//m_exceptions.Add(ex);
		}
	}
}