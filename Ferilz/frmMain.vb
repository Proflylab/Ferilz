Imports Microsoft.Win32
Imports System.Threading

Public Class frmMain
    Dim st As New Thread(Sub() StatusText())
    Private Sub GetAppStartup()
        ListDetails.Items.Clear()
        'a) HKLM\SOFTWARE\Microsoft\Windows\CurrentVersion\Run,
        For Each valueName As String In Registry.LocalMachine.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run").GetValueNames()
            ListDetails.Items.Add(New ListViewItem(New String() {valueName, Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run").GetValue(valueName), "HKLM\Software\Microsoft\Windows\CurrentVersion\Run"}))
        Next
        'b) HKLM\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Run,
        For Each valueName As String In Registry.LocalMachine.OpenSubKey("Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Run").GetValueNames()
            ListDetails.Items.Add(New ListViewItem(New String() {valueName, Registry.LocalMachine.OpenSubKey("Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Run").GetValue(valueName), "HKLM\Software\Wow6432Node\Microsoft\Windows\CurrentVersion\Run"}))
        Next
        'c) HKCU\Software\Microsoft\Windows\CurrentVersion\Run, 
        For Each valueName As String In Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run").GetValueNames()
            ListDetails.Items.Add(New ListViewItem(New String() {valueName, Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run").GetValue(valueName), "HKCU\Software\Microsoft\Windows\CurrentVersion\Run"}))
        Next
        'f) HKU\.Default\Software\Microsoft\Windows\CurrentVersion\Run, (unlikely)
        For Each valueName As String In Registry.Users.OpenSubKey(".Default\Software\Microsoft\Windows\CurrentVersion\Run").GetValueNames()
            ListDetails.Items.Add(New ListViewItem(New String() {valueName, Registry.Users.OpenSubKey(".Default\Software\Microsoft\Windows\CurrentVersion\Run").GetValue(valueName), "HKU\.Default\Software\Microsoft\Windows\CurrentVersion\Run"}))
        Next
        'f) HKU\.Default\Software\Microsoft\Windows\CurrentVersion\Run, (unlikely)
        For Each valueName As String In Registry.Users.OpenSubKey(".Default\Software\Microsoft\Windows\CurrentVersion\Run").GetValueNames()
            ListDetails.Items.Add(New ListViewItem(New String() {valueName, Registry.Users.OpenSubKey(".Default\Software\Microsoft\Windows\CurrentVersion\Run").GetValue(valueName), "HKU\.Default\Software\Microsoft\Windows\CurrentVersion\Run"}))
        Next
        StatusTotal.Text = "Ferilz - Application(x64)"
    End Sub
    Private Sub StatusText()
        Do While True
            StatusTotal.Visible = True
            Thread.Sleep(500)
            StatusTotal.Visible = False
            Thread.Sleep(500)
        Loop
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAppStartup()
        st.Start()
    End Sub
    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        st.Abort()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListDetails.SelectedItems.Count <> 0 Then
            StatusTotal.Text = "Selected " + ListDetails.SelectedItems.Count.ToString
            If MsgBox("Are you sure ?", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "MsgBox") = vbYes Then
                For Each items As ListViewItem In ListDetails.SelectedItems
                    If items.Selected Then
                        If ListDetails.Items(items.Index).SubItems(2).Text.Contains("HKLM") Then
                            Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(ListDetails.Items(items.Index).SubItems(0).Text)
                        ElseIf ListDetails.Items(items.Index).SubItems(2).Text.Contains("HKCU") Then
                            Registry.CurrentUser.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(ListDetails.Items(items.Index).SubItems(0).Text)
                        ElseIf ListDetails.Items(items.Index).SubItems(2).Text.Contains("HKU") Then
                            Registry.Users.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True).DeleteValue(ListDetails.Items(items.Index).SubItems(0).Text)
                        End If
                    End If
                Next
            End If
            GetAppStartup()
        End If
    End Sub

End Class
