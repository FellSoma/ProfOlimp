﻿#pragma checksum "..\..\CalculateMoney.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "23653059F038CD75C5B83C41047C9ED3F927B3A6ACE0BA3A41E63224957007B1"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ProfOlimp;
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


namespace ProfOlimp {
    
    
    /// <summary>
    /// CalculateMoney
    /// </summary>
    public partial class CalculateMoney : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal ProfOlimp.CalculateMoney Calc;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Money;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slSumm;
        
        #line default
        #line hidden
        
        
        #line 118 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Days;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slDays;
        
        #line default
        #line hidden
        
        
        #line 148 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox addMoney;
        
        #line default
        #line hidden
        
        
        #line 159 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Slider slPlus;
        
        #line default
        #line hidden
        
        
        #line 187 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbStability;
        
        #line default
        #line hidden
        
        
        #line 200 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbOptimal;
        
        #line default
        #line hidden
        
        
        #line 213 "..\..\CalculateMoney.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbStandart;
        
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
            System.Uri resourceLocater = new System.Uri("/ProfOlimp;component/calculatemoney.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\CalculateMoney.xaml"
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
            this.Calc = ((ProfOlimp.CalculateMoney)(target));
            return;
            case 2:
            this.Money = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.slSumm = ((System.Windows.Controls.Slider)(target));
            
            #line 106 "..\..\CalculateMoney.xaml"
            this.slSumm.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slAll_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Days = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.slDays = ((System.Windows.Controls.Slider)(target));
            
            #line 136 "..\..\CalculateMoney.xaml"
            this.slDays.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slAll_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.addMoney = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.slPlus = ((System.Windows.Controls.Slider)(target));
            
            #line 164 "..\..\CalculateMoney.xaml"
            this.slPlus.ValueChanged += new System.Windows.RoutedPropertyChangedEventHandler<double>(this.slAll_ValueChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.tbStability = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.tbOptimal = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            this.tbStandart = ((System.Windows.Controls.TextBox)(target));
            return;
            case 11:
            
            #line 221 "..\..\CalculateMoney.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Exemple);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

