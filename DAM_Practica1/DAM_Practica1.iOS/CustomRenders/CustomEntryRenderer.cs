﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreAnimation;
using CoreGraphics;
using DAM_Practica1.iOS.CustomRenders;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Entry), typeof(CustomEntryRenderer))]
namespace DAM_Practica1.iOS.CustomRenders
{
    public class CustomEntryRenderer : EntryRenderer
    {
        private CALayer _line;
        

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            _line = null;

            if (Control == null || e.NewElement == null)
                return;

            Control.BorderStyle = UITextBorderStyle.None;

            _line = new CALayer
            {
                BorderColor = UIColor.FromRGB(83, 83, 83).CGColor,
                BackgroundColor = UIColor.FromRGB(83, 83, 83).CGColor,
                Frame = new CGRect(0, Frame.Height / 2, Frame.Width * 2, 1f)
            };

            Control.Layer.AddSublayer(_line);
            Control.Frame = new CoreGraphics.CGRect(0f, Frame.Height - 10, UIScreen.MainScreen.Bounds.Size.Width - 50, 1f);
        }
    }
}