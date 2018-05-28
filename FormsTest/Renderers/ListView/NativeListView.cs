using System;
using System.Collections.Generic;
using FormsTest.Models;
using Xamarin.Forms;

namespace FormsTest.Renderers
{
	/// <summary>
    /// Xamarin.Forms representation for a custom-renderer that uses 
    /// the native list control on each platform.
    /// </summary>

	public class NativeListView : ListView
    {
		public NativeListView()
		{
			SeparatorVisibility = SeparatorVisibility.Default;
			BackgroundColor = Color.Transparent;               
		}



    }
}
