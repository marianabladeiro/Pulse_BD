﻿#pragma checksum "..\..\Calendario.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C36FF92842F6CF7456D5ED260C8E44FC8FD271BD45DDE11BA5B3C7B46CA3ECC9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pulse;
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


namespace Pulse {
    
    
    /// <summary>
    /// Calendario
    /// </summary>
    public partial class Calendario : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar CalendarioConsultas;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer ListView1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ItemsControl ListViewConsultas;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid marcacao;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox medicList;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label HorasLabel;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel Horas;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox hoursList;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MarcarButton;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\Calendario.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Book;
        
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
            System.Uri resourceLocater = new System.Uri("/Pulse;component/calendario.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Calendario.xaml"
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
            
            #line 8 "..\..\Calendario.xaml"
            ((Pulse.Calendario)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 15 "..\..\Calendario.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseUp);
            
            #line default
            #line hidden
            return;
            case 3:
            this.CalendarioConsultas = ((System.Windows.Controls.Calendar)(target));
            
            #line 19 "..\..\Calendario.xaml"
            this.CalendarioConsultas.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.CalendarioConsultas_SelectedDatesChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ListView1 = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 5:
            this.ListViewConsultas = ((System.Windows.Controls.ItemsControl)(target));
            return;
            case 6:
            this.marcacao = ((System.Windows.Controls.Grid)(target));
            return;
            case 7:
            this.medicList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 74 "..\..\Calendario.xaml"
            this.medicList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.HorasLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.Horas = ((System.Windows.Controls.StackPanel)(target));
            return;
            case 10:
            this.hoursList = ((System.Windows.Controls.ComboBox)(target));
            
            #line 85 "..\..\Calendario.xaml"
            this.hoursList.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.hoursList_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.MarcarButton = ((System.Windows.Controls.Button)(target));
            
            #line 94 "..\..\Calendario.xaml"
            this.MarcarButton.Click += new System.Windows.RoutedEventHandler(this.MarcarConsulta);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Book = ((System.Windows.Controls.Grid)(target));
            return;
            case 13:
            
            #line 105 "..\..\Calendario.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
