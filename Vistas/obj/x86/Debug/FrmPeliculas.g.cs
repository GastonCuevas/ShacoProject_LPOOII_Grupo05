﻿#pragma checksum "..\..\..\FrmPeliculas.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9B181CF1DCCDA9C5E34EB99F9A5F1E152719394C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using ClasesBase;
using FontAwesome.WPF;
using FontAwesome.WPF.Converters;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace Vistas {
    
    
    /// <summary>
    /// FrmPeliculas
    /// </summary>
    public partial class FrmPeliculas : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView grdPeliculas;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblCodigo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtCodigo;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTitulo;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTitulo;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblGenero;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbGenero;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblduracion;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDuracion;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblclase;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbClase;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAgregar;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModificar;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgVistaPrevia;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCargar;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCargarVideo;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblImagen;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirmarAgregar;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirmarModificar;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnConfirmarEliminar;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelar;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTrailer;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblRutavideo;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblSinopsis;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSinopsis;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement video;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPlay;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\FrmPeliculas.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnPause;
        
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
            System.Uri resourceLocater = new System.Uri("/Vistas;component/frmpeliculas.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\FrmPeliculas.xaml"
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
            this.grdPeliculas = ((System.Windows.Controls.ListView)(target));
            return;
            case 2:
            this.lblCodigo = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.txtCodigo = ((System.Windows.Controls.TextBox)(target));
            
            #line 36 "..\..\..\FrmPeliculas.xaml"
            this.txtCodigo.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtCodigo_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblTitulo = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.txtTitulo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.lblGenero = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.cbGenero = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.lblduracion = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.txtDuracion = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\FrmPeliculas.xaml"
            this.txtDuracion.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.txtDuracion_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 10:
            this.lblclase = ((System.Windows.Controls.Label)(target));
            return;
            case 11:
            this.cbClase = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.btnAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\..\FrmPeliculas.xaml"
            this.btnAgregar.Click += new System.Windows.RoutedEventHandler(this.btnAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            this.btnModificar = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\FrmPeliculas.xaml"
            this.btnModificar.Click += new System.Windows.RoutedEventHandler(this.btnModificar_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\FrmPeliculas.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            this.imgVistaPrevia = ((System.Windows.Controls.Image)(target));
            return;
            case 16:
            this.btnCargar = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\FrmPeliculas.xaml"
            this.btnCargar.Click += new System.Windows.RoutedEventHandler(this.btnCargar_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            this.btnCargarVideo = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\FrmPeliculas.xaml"
            this.btnCargarVideo.Click += new System.Windows.RoutedEventHandler(this.btnCargarVideo_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            this.lblImagen = ((System.Windows.Controls.Label)(target));
            return;
            case 19:
            this.btnConfirmarAgregar = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\FrmPeliculas.xaml"
            this.btnConfirmarAgregar.Click += new System.Windows.RoutedEventHandler(this.btnConfirmarAgregar_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            this.btnConfirmarModificar = ((System.Windows.Controls.Button)(target));
            
            #line 53 "..\..\..\FrmPeliculas.xaml"
            this.btnConfirmarModificar.Click += new System.Windows.RoutedEventHandler(this.btnConfirmarModificar_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            this.btnConfirmarEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\FrmPeliculas.xaml"
            this.btnConfirmarEliminar.Click += new System.Windows.RoutedEventHandler(this.btnConfirmarEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            this.btnCancelar = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\FrmPeliculas.xaml"
            this.btnCancelar.Click += new System.Windows.RoutedEventHandler(this.btnCancelar_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            this.lblTrailer = ((System.Windows.Controls.Label)(target));
            return;
            case 24:
            this.lblRutavideo = ((System.Windows.Controls.Label)(target));
            return;
            case 25:
            this.lblSinopsis = ((System.Windows.Controls.Label)(target));
            return;
            case 26:
            this.txtSinopsis = ((System.Windows.Controls.TextBox)(target));
            return;
            case 27:
            this.video = ((System.Windows.Controls.MediaElement)(target));
            return;
            case 28:
            this.btnPlay = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\FrmPeliculas.xaml"
            this.btnPlay.Click += new System.Windows.RoutedEventHandler(this.btnPlay_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            this.btnPause = ((System.Windows.Controls.Button)(target));
            
            #line 72 "..\..\..\FrmPeliculas.xaml"
            this.btnPause.Click += new System.Windows.RoutedEventHandler(this.btnPause_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

