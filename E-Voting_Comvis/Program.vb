Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms

Namespace EVoting_Comvis
    Friend Module Program
        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread>
        Sub Main()
            'Application.EnableVisualStyles()
            'Application.SetCompatibleTextRenderingDefault(False)
            '         Application.Run(New Form1())
            'Application.Run(New Form2())

            Dim myform As New Form5
            myform.Show()
        End Sub
    End Module
End Namespace
