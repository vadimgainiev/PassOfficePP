﻿#pragma checksum "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "64F33C46992B481D0C7450AC9EC3FF44BEF14435CE6A9BB30B1F1C1F56F3AABB"
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


namespace PassOfficePP.AddEditWindows {
    
    
    /// <summary>
    /// AddEditVisitorWindow
    /// </summary>
    public partial class AddEditVisitorWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProfilePhoto;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SetImage;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox WorkPlaceComboBox;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CategoryComboBox;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox WorkScheduleComboBox;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PostComboBox;
        
        #line default
        #line hidden
        
        
        #line 110 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox AccessLevelComboBox;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnCancel;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BtnSave;
        
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
            System.Uri resourceLocater = new System.Uri("/PassOfficePP;component/windows/addeditwindows/addeditvisitorwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
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
            this.ProfilePhoto = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.SetImage = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
            this.SetImage.Click += new System.Windows.RoutedEventHandler(this.SetImage_OnClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.WorkPlaceComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.CategoryComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.WorkScheduleComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.PostComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.AccessLevelComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.BtnCancel = ((System.Windows.Controls.Button)(target));
            
            #line 122 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
            this.BtnCancel.Click += new System.Windows.RoutedEventHandler(this.BtnCancel_OnClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.BtnSave = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\..\Windows\AddEditWindows\AddEditVisitorWindow.xaml"
            this.BtnSave.Click += new System.Windows.RoutedEventHandler(this.BtnSave_OnClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

