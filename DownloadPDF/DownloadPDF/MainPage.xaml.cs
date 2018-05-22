﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DownloadPDF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        protected void webOnNavigating(object sender, WebNavigatingEventArgs e)
        {
            if (e.Url.Contains(".pdf"))
            {
                // Retrieving the URL
                var pdfUrl = new Uri(e.Url);

                // Open PDF URL with device browser to download
                Device.OpenUri(pdfUrl);

                // Cancel the navigation on click actions (retains in the same page.)
                e.Cancel = true;
            }
        }
    }
}
