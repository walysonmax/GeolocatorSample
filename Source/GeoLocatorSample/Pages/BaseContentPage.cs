﻿using Xamarin.Forms;

namespace GeoLocatorSample
{
	public abstract class BaseContentPage<TViewModel> : ContentPage where TViewModel : BaseViewModel, new()
	{
		protected BaseContentPage()
		{
			BindingContext = ViewModel;
			BackgroundColor = ColorConstants.PageBackgroundColor;
		}

		protected TViewModel ViewModel { get; } = new TViewModel();
	}
}
