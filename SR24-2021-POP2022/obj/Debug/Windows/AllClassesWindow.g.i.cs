#pragma checksum "..\..\..\Windows\AllClassesWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "BD5B379D1123DBB9CA58728AEA2172C106900B68CF1807A443F42CF0488C90E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using SR24_2021_POP2022.Windows;
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


namespace SR24_2021_POP2022.Windows {
    
    
    /// <summary>
    /// AllClassesWindow
    /// </summary>
    public partial class AllClassesWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 11 "..\..\..\Windows\AllClassesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miDodajCasovi;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\..\Windows\AllClassesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miIzmeniCasovi;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Windows\AllClassesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem miObrisiCasovi;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Windows\AllClassesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCasovi;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Windows\AllClassesWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtPretraga;
        
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
            System.Uri resourceLocater = new System.Uri("/SR24-2021-POP2022;component/windows/allclasseswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AllClassesWindow.xaml"
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
            this.miDodajCasovi = ((System.Windows.Controls.MenuItem)(target));
            
            #line 11 "..\..\..\Windows\AllClassesWindow.xaml"
            this.miDodajCasovi.Click += new System.Windows.RoutedEventHandler(this.miDodajCas_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.miIzmeniCasovi = ((System.Windows.Controls.MenuItem)(target));
            
            #line 12 "..\..\..\Windows\AllClassesWindow.xaml"
            this.miIzmeniCasovi.Click += new System.Windows.RoutedEventHandler(this.miIzmeniCas_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.miObrisiCasovi = ((System.Windows.Controls.MenuItem)(target));
            
            #line 13 "..\..\..\Windows\AllClassesWindow.xaml"
            this.miObrisiCasovi.Click += new System.Windows.RoutedEventHandler(this.miObrisiCas_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dgCasovi = ((System.Windows.Controls.DataGrid)(target));
            
            #line 15 "..\..\..\Windows\AllClassesWindow.xaml"
            this.dgCasovi.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.dgCasovi_AutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtPretraga = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Windows\AllClassesWindow.xaml"
            this.txtPretraga.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtPretraga_KeyUp);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

