// Updated by XamlIntelliSenseFileGenerator 24.03.2021 10:14:49
#pragma checksum "..\..\Creadits.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9F1BFD627D9FE545D5ABECB0F7F5B497C4D67A5E351C066374ACEB228E5BE540"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using OdinDurak;
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


namespace OdinDurak
{


    /// <summary>
    /// Creadits
    /// </summary>
    public partial class Credits : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/OdinDurak;component/creadits.xaml", System.UriKind.Relative);

#line 1 "..\..\Creadits.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Media.Animation.Storyboard story;
        internal System.Windows.Controls.Viewport3D viewport3D1;
        internal System.Windows.Media.Media3D.PerspectiveCamera camMain;
        internal System.Windows.Media.Media3D.MeshGeometry3D meshMain;
        internal System.Windows.Media.Media3D.DiffuseMaterial matDiffuseMain;
        internal System.Windows.Media.Media3D.TranslateTransform3D TextPos;
        internal System.Windows.Media.Media3D.MeshGeometry3D meshShadow;
        internal System.Windows.Media.Media3D.DiffuseMaterial matDiffuseShade;
    }
}

