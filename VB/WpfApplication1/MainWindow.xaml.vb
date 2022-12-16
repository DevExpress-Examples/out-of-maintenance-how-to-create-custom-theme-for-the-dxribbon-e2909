' Developer Express Code Central Example:
' How to create custom theme for the DXRibbon
' 
' Override our themes' templates, and embed your templates to the
' BarManager.Resources.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2909
Imports System.Windows
Imports System.Windows.Controls
Imports System.ComponentModel
Imports System.Diagnostics.CodeAnalysis

Namespace WpfApplication1

    ''' <summary>
    ''' Interaction logic for MainWindow.xaml
    ''' </summary>
    ''' 
    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class
End Namespace
