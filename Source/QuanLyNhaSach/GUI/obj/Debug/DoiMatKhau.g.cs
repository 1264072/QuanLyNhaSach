﻿#pragma checksum "..\..\DoiMatKhau.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "525B50E86FB76F5694FA030744D93C39"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
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


namespace GUI {
    
    
    /// <summary>
    /// DoiMatKhau
    /// </summary>
    public partial class DoiMatKhau : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\DoiMatKhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtMatKhauCu;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\DoiMatKhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtMatKhauMoi;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\DoiMatKhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtNhapLai;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\DoiMatKhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnXacNhan;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\DoiMatKhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnHuyBo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\DoiMatKhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ThongBao1;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\DoiMatKhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ThongBao2;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\DoiMatKhau.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ThongBao3;
        
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
            System.Uri resourceLocater = new System.Uri("/GUI;component/doimatkhau.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DoiMatKhau.xaml"
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
            this.txtMatKhauCu = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 2:
            this.txtMatKhauMoi = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.txtNhapLai = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.btnXacNhan = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\DoiMatKhau.xaml"
            this.btnXacNhan.Click += new System.Windows.RoutedEventHandler(this.btnXacNhan_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnHuyBo = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\DoiMatKhau.xaml"
            this.btnHuyBo.Click += new System.Windows.RoutedEventHandler(this.btnHuyBo_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.ThongBao1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.ThongBao2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.ThongBao3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
