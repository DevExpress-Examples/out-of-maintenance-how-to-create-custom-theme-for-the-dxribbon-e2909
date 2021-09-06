' Developer Express Code Central Example:
' How to create custom theme for the DXRibbon
' 
' Override our themes' templates, and embed your templates to the
' BarManager.Resources.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2909

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Bars
Imports DevExpress.Xpf.Core
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.ComponentModel
Imports System.Windows.Interop
Imports System.Windows.Threading
Imports System.Threading
Imports System.Diagnostics.CodeAnalysis
Imports System.Reflection

Namespace WpfApplication1
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	''' 
	Partial Public Class MainWindow
		Inherits Window

		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
