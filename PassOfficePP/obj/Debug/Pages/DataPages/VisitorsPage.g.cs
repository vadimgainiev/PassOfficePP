﻿#pragma checksum "..\..\..\..\Pages\DataPages\VisitorsPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B82C89AB9E766BA8D979D9C3931FD02A168B1630F1925BA4AA9D4B42E99BF6E3"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
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


namespace PassOfficePP.Pages.DataPages {
    
    
    /// <summary>
    /// VisitorsPage
    /// </summary>
    public partial class VisitorsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 30 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SearchTextBox;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnExportToExcel;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CompareBtn;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid VisitorsGrid;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid VisitorProfile;
        
        #line default
        #line hidden
        
        
        #line 123 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProfilePhoto;
        
        #line default
        #line hidden
        
        
        #line 259 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnAdd;
        
        #line default
        #line hidden
        
        
        #line 265 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnDelete;
        
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
            System.Uri resourceLocater = new System.Uri("/PassOfficePP;component/pages/datapages/visitorspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
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
            
            #line 10 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
            ((PassOfficePP.Pages.DataPages.VisitorsPage)(target)).IsVisibleChanged += new System.Windows.DependencyPropertyChangedEventHandler(this.VisitorsPage_OnIsVisibleChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SearchTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 32 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
            this.SearchTextBox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.SearchTextBox_OnTextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.BtnExportToExcel = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
            this.BtnExportToExcel.Click += new System.Windows.RoutedEventHandler(this.BtnExportToExcel_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CompareBtn = ((System.Windows.Controls.Button)(target));
            
            #line 78 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
            this.CompareBtn.Click += new System.Windows.RoutedEventHandler(this.CompareBtn_OnClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.VisitorsGrid = ((System.Windows.Controls.DataGrid)(target));
            
            #line 88 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
            this.VisitorsGrid.SelectedCellsChanged += new System.Windows.Controls.SelectedCellsChangedEventHandler(this.VisitorsGrid_OnSelectedCellsChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.VisitorProfile = ((System.Windows.Controls.Grid)(target));
            return;
            case 8:
            this.ProfilePhoto = ((System.Windows.Controls.Image)(target));
            return;
            case 9:
            this.BtnAdd = ((System.Windows.Controls.Button)(target));
            
            #line 261 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
            this.BtnAdd.Click += new System.Windows.RoutedEventHandler(this.BtnAdd_OnClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.BtnDelete = ((System.Windows.Controls.Button)(target));
            
            #line 269 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
            this.BtnDelete.Click += new System.Windows.RoutedEventHandler(this.BtnDelete_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 6:
            
            #line 105 "..\..\..\..\Pages\DataPages\VisitorsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.BtnEdit_OnClick);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

