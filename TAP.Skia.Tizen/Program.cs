using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace TAP.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new TAP.App(), args);
		host.Run();
	}
}
}
