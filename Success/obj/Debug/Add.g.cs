﻿#pragma checksum "c:\users\usanov_aa\documents\visual studio 2010\Projects\Success\Success\Add.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "6DB5BECDF26F30CB95172FEBE83722AF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.18034
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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


namespace Success {
    
    
    public partial class Add : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock ApplicationTitle;
        
        internal System.Windows.Controls.TextBlock DoText;
        
        internal System.Windows.Controls.TextBox NameToDo;
        
        internal System.Windows.Controls.TextBlock Cen;
        
        internal Microsoft.Phone.Controls.ListPicker Summ;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Success;component/Add.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ApplicationTitle = ((System.Windows.Controls.TextBlock)(this.FindName("ApplicationTitle")));
            this.DoText = ((System.Windows.Controls.TextBlock)(this.FindName("DoText")));
            this.NameToDo = ((System.Windows.Controls.TextBox)(this.FindName("NameToDo")));
            this.Cen = ((System.Windows.Controls.TextBlock)(this.FindName("Cen")));
            this.Summ = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("Summ")));
        }
    }
}
