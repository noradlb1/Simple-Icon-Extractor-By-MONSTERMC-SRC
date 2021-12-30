Imports System.Runtime.InteropServices

Public Class Form1

    <DllImport("shell32.dll")> _
Private Shared Function ExtractIcon(ByVal hInst As IntPtr, ByVal lpszExeFileName As String, ByVal nIconIndex As Integer) As IntPtr
    End Function

    Structure IconInfo
        Dim IconImage As Icon
        Dim PbHash As Integer
    End Structure

    Private IcoList As New List(Of IconInfo)
    Sub ExtractIcons(ByVal xPath As String)
        Dim count As Integer = ExtractIcon(IntPtr.Zero, xPath, -1)
        For i As Integer = 0 To count - 1
            Dim Ico As Icon = Icon.FromHandle(ExtractIcon(IntPtr.Zero, xPath, i))
            Dim PB As New PictureBox With {.Size = Ico.Size, .SizeMode = PictureBoxSizeMode.CenterImage, .Image = Ico.ToBitmap}
            IcoList.Add(New IconInfo With {.IconImage = Ico, .PbHash = PB.GetHashCode})
            FlowLayoutPanel1.Controls.Add(PB)
            AddHandler PB.DoubleClick, AddressOf PB_DoubleClick
            AddHandler PB.MouseEnter, AddressOf PB_Menter
        Next
    End Sub

    Sub PB_Menter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each pb As PictureBox In FlowLayoutPanel1.Controls
            If pb.BorderStyle <> BorderStyle.None Then pb.BorderStyle = BorderStyle.None
        Next
        CType(sender, PictureBox).BorderStyle = BorderStyle.FixedSingle
    End Sub

    Sub PB_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For Each I As IconInfo In IcoList
            If I.PbHash = CType(sender, PictureBox).GetHashCode Then
                Using S As New SaveFileDialog With {.Filter = "(Icon) | *.ico"}
                    If S.ShowDialog = 1 Then
                        Using Fstream As New IO.FileStream(S.FileName, IO.FileMode.Create)
                            I.IconImage.Save(Fstream)
                        End Using
                    End If
                End Using
            End If
        Next
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Form2.Show()
        Me.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath)
    End Sub

    Private Sub SlCbtn1_Click(sender As Object, e As EventArgs) Handles SlCbtn1.Click
        Using O As New OpenFileDialog With {.Multiselect = True, .Title = "Select File(s)", .Filter = "(Exe / Dll) |*.exe; *.dll"}
            If O.ShowDialog = 1 Then
                For Each F As String In O.FileNames
                    ExtractIcons(F)
                Next
            End If
        End Using
    End Sub

    Private Sub SlcClose1_Click(sender As Object, e As EventArgs) Handles SlcClose1.Click
        End
    End Sub
End Class