#pragma checksum "..\..\..\..\Pages\ExportPages\ExportVisitorsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A0606E9C50AA4EB29C357B4DA03CF51015B71C4B6F78731281CEE80CB94B7FF6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using PassOfficePP.Pages.ExportPages;
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


namespace PassOfficePP.Pages.ExportPages {
    
    
    /// <summary>
    /// ExportVisitorsPage
    /// </summary>
    public partial class ExportVisitorsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\..\Pages\ExportPages\ExportVisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid VisitorsGrid;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Pages\ExportPages\ExportVisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExport;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Pages\ExportPages\ExportVisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/PassOfficePP;component/pages/exportpages/exportvisitorspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\ExportPages\ExportVisitorsPage.xaml"
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
            this.VisitorsGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.BtnExport = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Pages\ExportPages\ExportVisitorsPage.xaml"
            this.BtnExport.Click += new System.Windows.RoutedEventHandler(this.BtnExport_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\..\..\Pages\ExportPages\ExportVisitorsPage.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

