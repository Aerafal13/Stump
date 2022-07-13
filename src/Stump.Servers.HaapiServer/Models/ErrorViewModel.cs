namespace Stump.Servers.HaapiServer.Models;

public class ErrorViewModel
{
	public string? RequestId { get; set; }

	public bool ShowRequestId =>
		!string.IsNullOrEmpty(RequestId);
}
