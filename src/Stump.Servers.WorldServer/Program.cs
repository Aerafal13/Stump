
using System.Diagnostics;
using Stump.Server.WorldServer;

var server = new WorldServer();

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