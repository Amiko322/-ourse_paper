﻿#pragma checksum "..\..\..\..\StaffDepartament.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7D9D6FE9A49E8F27B206ABB824BF47F7F529050F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Kursovay;
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


namespace Kursovay {
    
    
    /// <summary>
    /// StaffDepartament
    /// </summary>
    public partial class StaffDepartament : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\..\StaffDepartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DataGridStaff;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\..\StaffDepartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Surname;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\StaffDepartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Post;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\..\StaffDepartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StaffName;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\..\StaffDepartament.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Patronymic;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Kursovay;component/staffdepartament.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\StaffDepartament.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.DataGridStaff = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.Surname = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\..\StaffDepartament.xaml"
            this.Surname.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Validation_BlockNumbers);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Post = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.StaffName = ((System.Windows.Controls.TextBox)(target));
            
            #line 61 "..\..\..\..\StaffDepartament.xaml"
            this.StaffName.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Validation_BlockNumbers);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Patronymic = ((System.Windows.Controls.TextBox)(target));
            
            #line 70 "..\..\..\..\StaffDepartament.xaml"
            this.Patronymic.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.Validation_BlockNumbers);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 73 "..\..\..\..\StaffDepartament.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StaffAdd_Button);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 74 "..\..\..\..\StaffDepartament.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StaffChange_Button);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 75 "..\..\..\..\StaffDepartament.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StaffDelete_Button);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
