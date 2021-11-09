using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;
using Microsoft.Maui.Controls.Hosting;
using DevExpress.Maui.Editors;
using DevExpress.Maui.CollectionView;

namespace EditorsGetStarted
{
	public static class MauiProgram
	{
		public static MauiApp CreateMauiApp()
		{
			var builder = MauiApp.CreateBuilder();
			builder
				.UseMauiApp<App>()
				.ConfigureMauiHandlers(handlers => handlers.AddHandler<TextEdit, TextEditHandler>())
				.ConfigureMauiHandlers(handlers => handlers.AddHandler<PasswordEdit, PasswordEditHandler>())
				.ConfigureMauiHandlers(handlers => handlers.AddHandler<DateEdit, DateEditHandler>())
				.ConfigureMauiHandlers(handlers => handlers.AddHandler<MultilineEdit, MultilineEditHandler>())
				.ConfigureMauiHandlers(handlers => handlers.AddHandler<SimpleButton, SimpleButtonHandler>())
				.ConfigureMauiHandlers(handlers => handlers.AddHandler<ComboBoxEdit, ComboBoxEditHandler>())
				.ConfigureMauiHandlers(handlers => handlers.AddHandler<DXCollectionView, DXCollectionViewHandler>())
				.ConfigureFonts(fonts =>
				{
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});

			return builder.Build();
		}
	}
}