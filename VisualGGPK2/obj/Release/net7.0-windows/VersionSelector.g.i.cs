﻿#pragma checksum "..\..\..\VersionSelector.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47335403FE01F47B3457AC38D17CFEF703FBBB19"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using Wpf.Ui;
using Wpf.Ui.Common;
using Wpf.Ui.Controls;
using Wpf.Ui.Converters;
using Wpf.Ui.Markup;


namespace VisualGGPK2 {
    
    
    /// <summary>
    /// VersionSelector
    /// </summary>
    public partial class VersionSelector : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/VisualGGPK2;component/versionselector.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\VersionSelector.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.10.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 28 "..\..\..\VersionSelector.xaml"
            ((Wpf.Ui.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.International_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 37 "..\..\..\VersionSelector.xaml"
            ((Wpf.Ui.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Steam_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 46 "..\..\..\VersionSelector.xaml"
            ((Wpf.Ui.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Garena_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 55 "..\..\..\VersionSelector.xaml"
            ((Wpf.Ui.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Tencent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

