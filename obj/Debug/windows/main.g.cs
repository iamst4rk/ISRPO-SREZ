﻿#pragma checksum "..\..\..\windows\main.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8C37535D9AAFD4675CA7E59D4A3291D54FE7F553F0D67942FAC6AC26CC635BD2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using iamst4rk.windows;


namespace iamst4rk.windows {
    
    
    /// <summary>
    /// main
    /// </summary>
    public partial class main : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\windows\main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbReaders;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\windows\main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image CSV;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\windows\main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView LvReaders;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\windows\main.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ImgBilet_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/iamst4rk;component/windows/main.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\windows\main.xaml"
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
            this.TbReaders = ((System.Windows.Controls.TextBox)(target));
            
            #line 17 "..\..\..\windows\main.xaml"
            this.TbReaders.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TbReaders_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CSV = ((System.Windows.Controls.Image)(target));
            
            #line 20 "..\..\..\windows\main.xaml"
            this.CSV.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.CSV_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 23 "..\..\..\windows\main.xaml"
            ((System.Windows.Controls.Image)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Image_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LvReaders = ((System.Windows.Controls.ListView)(target));
            return;
            case 5:
            this.ImgBilet_Copy = ((System.Windows.Controls.Image)(target));
            
            #line 48 "..\..\..\windows\main.xaml"
            this.ImgBilet_Copy.MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ImgBilet_Copy_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

