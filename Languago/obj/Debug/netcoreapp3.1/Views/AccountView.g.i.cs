﻿#pragma checksum "..\..\..\..\Views\AccountView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8D0BCF186F6FC801D1CDAAC1F4FE067AF33777DA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Languago.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Languago.Views {
    
    
    /// <summary>
    /// AccountView
    /// </summary>
    public partial class AccountView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TodayBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button StartTodayButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Revise1Box;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start1Button;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Revise3Box;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start3Button;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Revise7Box;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start7utton;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Revise30Box;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start30Button;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Revise90Box;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\..\..\Views\AccountView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Start90Button;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Languago;component/views/accountview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\AccountView.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.TodayBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 31 "..\..\..\..\Views\AccountView.xaml"
            this.TodayBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TodayBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StartTodayButton = ((System.Windows.Controls.Button)(target));
            
            #line 32 "..\..\..\..\Views\AccountView.xaml"
            this.StartTodayButton.Click += new System.Windows.RoutedEventHandler(this.StartTodayButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Revise1Box = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\..\Views\AccountView.xaml"
            this.Revise1Box.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TodayBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Start1Button = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Views\AccountView.xaml"
            this.Start1Button.Click += new System.Windows.RoutedEventHandler(this.Start1Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Revise3Box = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\..\Views\AccountView.xaml"
            this.Revise3Box.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TodayBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Start3Button = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\..\Views\AccountView.xaml"
            this.Start3Button.Click += new System.Windows.RoutedEventHandler(this.Start3Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Revise7Box = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\..\Views\AccountView.xaml"
            this.Revise7Box.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TodayBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Start7utton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\Views\AccountView.xaml"
            this.Start7utton.Click += new System.Windows.RoutedEventHandler(this.Start7utton_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Revise30Box = ((System.Windows.Controls.TextBox)(target));
            
            #line 67 "..\..\..\..\Views\AccountView.xaml"
            this.Revise30Box.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TodayBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.Start30Button = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\..\Views\AccountView.xaml"
            this.Start30Button.Click += new System.Windows.RoutedEventHandler(this.Start30Button_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Revise90Box = ((System.Windows.Controls.TextBox)(target));
            
            #line 76 "..\..\..\..\Views\AccountView.xaml"
            this.Revise90Box.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TodayBox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Start90Button = ((System.Windows.Controls.Button)(target));
            
            #line 77 "..\..\..\..\Views\AccountView.xaml"
            this.Start90Button.Click += new System.Windows.RoutedEventHandler(this.Start90Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

