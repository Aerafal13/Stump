using System.Diagnostics;
using Stump.Server.AuthServer;

var server = new AuthServer();

if (!Debugger.IsAttached)
{
	try
	{
		server.Initialize();
		server.Start();

		GC.Collect();

		while (true)
		{
			Thread.Sleep(5000);
		}
	}
	catch (Exception e)
	{
		server.HandleCrashException(e);
	}
	finally
	{
		server.Shutdown();
	}
}
else
{
	server.Initialize();
	server.Start();

	GC.Collect();

	while (true)
	{
		Thread.Sleep(5000);
	}
}