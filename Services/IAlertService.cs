﻿namespace HelloMaui.Services;

public interface IAlertService
{
	Task ShowAlertAsync(string title, string message, string cancel);
}

