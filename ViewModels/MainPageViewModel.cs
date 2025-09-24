using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HelloMaui.Core;
using HelloMaui.Services;
using Microsoft.Maui.Accessibility;

namespace HelloMaui.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
	private readonly IAlertService alertService;
	private int count;
	private string counterButtonText = CounterMessageFormatter.GetMessage(0);

	public MainPageViewModel(IAlertService alertService)
	{
		this.alertService = alertService;
	}

	public int Count
	{
		get => count;
		private set => SetProperty(ref count, value);
	}

	public string CounterButtonText
	{
		get => counterButtonText;
		private set => SetProperty(ref counterButtonText, value);
	}

	[RelayCommand]
	private void Increment()
	{
		Count++;

		CounterButtonText = CounterMessageFormatter.GetMessage(Count);

		SemanticScreenReader.Announce(CounterButtonText);
	}

	[RelayCommand]
	private async Task ShowAboutAsync()
	{
		const string message = "Author: Sample Author\nContact: sample@example.com";
		await alertService.ShowAlertAsync("About", message, "OK");
	}
}


