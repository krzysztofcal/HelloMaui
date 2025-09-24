using System.Linq;
using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;

namespace HelloMaui.Services;

public class AlertService : IAlertService
{
	public Task ShowAlertAsync(string title, string message, string cancel)
	{
		return MainThread.InvokeOnMainThreadAsync(() =>
		{
			var page = Application.Current?.Windows.FirstOrDefault()?.Page;
			return page?.DisplayAlert(title, message, cancel) ?? Task.CompletedTask;
		});
	}
}

