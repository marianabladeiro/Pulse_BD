﻿#pragma checksum "..\..\ExamesAnalises.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2957813D1EBAC487695F20D7151ACED7160EA0B380114AEA998E9BB9FEEF624B"
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
    /// ExamesAnalises
    /// </summary>
    public partial class ExamesAnalises : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\ExamesAnalises.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ArrowButtons;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ExamesAnalises.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Informacao;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\ExamesAnalises.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CodigoPrescitor;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\ExamesAnalises.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label PrescritorReceita;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\ExamesAnalises.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Analise;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\ExamesAnalises.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label id;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\ExamesAnalises.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Data;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\ExamesAnalises.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Descricao;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\ExamesAnalises.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Nome;
        
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
            System.Uri resourceLocater = new System.Uri("/Pulse;component/examesanalises.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ExamesAnalises.xaml"
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
            
            #line 8 "..\..\ExamesAnalises.xaml"
            ((Pulse.ExamesAnalises)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ArrowButtons = ((System.Windows.Controls.Grid)(target));
            return;
            case 3:
            
            #line 16 "..\..\ExamesAnalises.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Previous);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 17 "..\..\ExamesAnalises.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Next);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Informacao = ((System.Windows.Controls.Grid)(target));
            return;
            case 6:
            this.CodigoPrescitor = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.PrescritorReceita = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.Analise = ((System.Windows.Controls.Grid)(target));
            return;
            case 9:
            this.id = ((System.Windows.Controls.Label)(target));
            return;
            case 10:
            this.Data = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.Descricao = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 58 "..\..\ExamesAnalises.xaml"
            ((System.Windows.Controls.Label)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.Label_MouseUp);
            
            #line default
            #line hidden
            return;
            case 13:
            this.Nome = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
