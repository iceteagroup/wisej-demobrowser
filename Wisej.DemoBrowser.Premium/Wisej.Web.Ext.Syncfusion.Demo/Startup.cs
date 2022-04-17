
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Wisej.Core;

namespace Wisej.Web.Ext.Syncfusion.Demo
{
	/// <summary>
	/// The Startup class configures services and the app's request pipeline.
	/// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940.
	/// </summary>
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public IConfiguration Configuration { get; }

		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(new WebApplicationOptions
			{
				Args = args,
				WebRootPath = "./"
			});

			// If using Kestrel:
			builder.Services.Configure<KestrelServerOptions>(options =>
			{
				options.AllowSynchronousIO = true;
			});

			// If using IIS:
			builder.Services.Configure<IISServerOptions>(options =>
			{
				options.AllowSynchronousIO = true;
			});

			var app = builder.Build();
			app.UseWisej();
			app.UseFileServer();
			app.Run();
		}
	}
}
