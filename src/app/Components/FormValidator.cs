// src: https://docs.microsoft.com/en-us/aspnet/core/blazor/forms-validation?view=aspnetcore-6.0#validator-components
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace KonSchool.App.Components;

public class FormValidator : ComponentBase
{
	private ValidationMessageStore? messageStore;

	[CascadingParameter]
	private EditContext? CurrentEditContext { get; set; }

	protected override void OnInitialized()
	{
		if (CurrentEditContext is null)
		{
			throw new InvalidOperationException(
				$"{nameof(FormValidator)} requires a cascading " +
				$"parameter of type {nameof(EditContext)}. " +
				$"For example, you can use {nameof(FormValidator)} " +
				$"inside an {nameof(EditForm)}.");
		}

		messageStore = new(CurrentEditContext);

		CurrentEditContext.OnValidationRequested += (s, e) =>
			messageStore?.Clear();
		CurrentEditContext.OnFieldChanged += (s, e) =>
			messageStore?.Clear(e.FieldIdentifier);
	}

	public void DisplayErrors(Dictionary<string, List<string>> errors)
	{
		if (CurrentEditContext is not null)
		{
			foreach (var err in errors)
			{
				messageStore?.Add(CurrentEditContext.Field(err.Key), err.Value);
			}

			CurrentEditContext.NotifyValidationStateChanged();
		}
	}

	public void ClearErrors()
	{
		messageStore?.Clear();
		CurrentEditContext?.NotifyValidationStateChanged();
	}
}
