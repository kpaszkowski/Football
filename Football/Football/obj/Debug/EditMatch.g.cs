﻿#pragma checksum "..\..\EditMatch.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E315C6A1ED857256307C453944EB9465"
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
    /// EditMatch
    /// </summary>
    public partial class EditMatch : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 44 "..\..\EditMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbStadiumMatch;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\EditMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbHostClub;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\EditMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbGuestClub;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\EditMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbMainReffere;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\EditMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbTechnicalReffere;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\EditMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbLinearReffere;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\EditMatch.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbObserverReffere;
        
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
            System.Uri resourceLocater = new System.Uri("/Football;component/editmatch.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditMatch.xaml"
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
            this.cbStadiumMatch = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.cbHostClub = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.cbGuestClub = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cbMainReffere = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cbTechnicalReffere = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.cbLinearReffere = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.cbObserverReffere = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 74 "..\..\EditMatch.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Cancel);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

