﻿#pragma checksum "..\..\..\ErrorWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ED3323BA0CA288202745DDD2F6EE1592F1DD5C6"
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
    /// ErrorWindow
    /// </summary>
    public partial class ErrorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ErrorBox;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button ButtonCopy;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button ButtonGitHub;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button ButtonResume;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\ErrorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Wpf.Ui.Controls.Button ButtonStop;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/VisualGGPK2;V1.8.0.0;component/errorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ErrorWindow.xaml"
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
            
            #line 10 "..\..\..\ErrorWindow.xaml"
            ((VisualGGPK2.ErrorWindow)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.OnClosing);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ErrorBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.ButtonCopy = ((Wpf.Ui.Controls.Button)(target));
            
            #line 49 "..\..\..\ErrorWindow.xaml"
            this.ButtonCopy.Click += new System.Windows.RoutedEventHandler(this.OnCopyClick);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonGitHub = ((Wpf.Ui.Controls.Button)(target));
            
            #line 61 "..\..\..\ErrorWindow.xaml"
            this.ButtonGitHub.Click += new System.Windows.RoutedEventHandler(this.OnGitHubClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonResume = ((Wpf.Ui.Controls.Button)(target));
            
            #line 73 "..\..\..\ErrorWindow.xaml"
            this.ButtonResume.Click += new System.Windows.RoutedEventHandler(this.OnResumeClick);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ButtonStop = ((Wpf.Ui.Controls.Button)(target));
            
            #line 86 "..\..\..\ErrorWindow.xaml"
            this.ButtonStop.Click += new System.Windows.RoutedEventHandler(this.OnStopClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

