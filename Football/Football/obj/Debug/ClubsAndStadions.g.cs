﻿#pragma checksum "..\..\ClubsAndStadions.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "71FC2466731E46220FBC25C3D42EB185"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Football;
using Football.Converter;
using Football.ViewModel.Window;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Football {
    
    
    /// <summary>
    /// ClubsAndStadions
    /// </summary>
    public partial class ClubsAndStadions : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\ClubsAndStadions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStadium;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\ClubsAndStadions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditStadium;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ClubsAndStadions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteStadium;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\ClubsAndStadions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddClub;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\ClubsAndStadions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditClub;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\ClubsAndStadions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteClub;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\ClubsAndStadions.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button HistoryClub;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Football;component/clubsandstadions.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ClubsAndStadions.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.AddStadium = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\ClubsAndStadions.xaml"
            this.AddStadium.Click += new System.Windows.RoutedEventHandler(this.AddStadium_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.EditStadium = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.DeleteStadium = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.AddClub = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\ClubsAndStadions.xaml"
            this.AddClub.Click += new System.Windows.RoutedEventHandler(this.AddClub_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.EditClub = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.DeleteClub = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.HistoryClub = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

