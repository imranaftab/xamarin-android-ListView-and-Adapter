using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Graphics;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace NKitchen.Utilities
{
    public class ImageUtil
    {
        public static Bitmap GetImgFromURL(string url)
        {
            Bitmap img = null;
            try
            {
                using (var client = new WebClient())
                {
                    var imageData = client.DownloadData(url);
                    if (imageData != null && imageData.Length > 0)
                        img = BitmapFactory.DecodeByteArray(imageData, 0, imageData.Length);

                }

            }
            catch (Exception ex)
            {

            }
            return img;
        }
    }
}