﻿#pragma checksum "D:\hackwro\trunk\StrefaKibica\StrefaKibica\Views\EventCreationView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5728D7631D9162596BBF0A043434427D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.544
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace StrefaKibicaGeek.Views {
    
    
    public partial class EventCreationView : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.TextBlock MatchChosen;
        
        internal System.Windows.Controls.TextBlock MatchDateChosen;
        
        internal System.Windows.Controls.TextBlock EventVenueChosen;
        
        internal System.Windows.Controls.TextBox EventName;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Strefa%20Kibica;component/Views/EventCreationView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.MatchChosen = ((System.Windows.Controls.TextBlock)(this.FindName("MatchChosen")));
            this.MatchDateChosen = ((System.Windows.Controls.TextBlock)(this.FindName("MatchDateChosen")));
            this.EventVenueChosen = ((System.Windows.Controls.TextBlock)(this.FindName("EventVenueChosen")));
            this.EventName = ((System.Windows.Controls.TextBox)(this.FindName("EventName")));
        }
    }
}

