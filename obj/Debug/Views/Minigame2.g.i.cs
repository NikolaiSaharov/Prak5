﻿#pragma checksum "..\..\..\Views\Minigame2.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B9AF1E18DCFA903105796D71612C1D879A04C428DFE3519BAEB3B1D9AE8B3FEE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Novella;
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


namespace Novella {
    
    
    /// <summary>
    /// Minigame2
    /// </summary>
    public partial class Minigame2 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Views\Minigame2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RockButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Views\Minigame2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PaperButton;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Views\Minigame2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ScissorsButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\Minigame2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock resultTextBlock;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\Minigame2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock playerWinsTextBlock;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Views\Minigame2.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock computerWinsTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/Novella;component/views/minigame2.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\Minigame2.xaml"
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
            this.RockButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\..\Views\Minigame2.xaml"
            this.RockButton.Click += new System.Windows.RoutedEventHandler(this.RockButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.PaperButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Views\Minigame2.xaml"
            this.PaperButton.Click += new System.Windows.RoutedEventHandler(this.PaperButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.ScissorsButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\Minigame2.xaml"
            this.ScissorsButton.Click += new System.Windows.RoutedEventHandler(this.ScissorsButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.resultTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.playerWinsTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.computerWinsTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

