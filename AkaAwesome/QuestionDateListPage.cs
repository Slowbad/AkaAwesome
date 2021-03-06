﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AkaAwesome
{
	public class QuestionDateListPage : ContentPage
	{
		public QuestionDateListPage ()
		{
			Title = "Xamarin Questions";
			List<string> datesToDisplay = new List<string> ();

			for (int i = 0; i < 14; i++) {
				datesToDisplay.Add (DateTime.Now.AddDays (i * -1).ToString ("D"));
			}

			ListView dateslist = new ListView { ItemsSource = datesToDisplay };

			dateslist.ItemTapped += async (sender, e) => {
				DateTime dateToDisplay = DateTime.Parse(e.Item.ToString());

				await Navigation.PushAsync(new QuestionListPage(dateToDisplay));
			};

			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.FillAndExpand,
				Children = {
					dateslist
				}
			};
		}
	}
}


