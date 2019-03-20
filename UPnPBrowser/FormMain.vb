Imports System.ComponentModel
Imports UPNPLib

Public Class FormMain

    Implements IUPnPDeviceFinderCallback

    Private DeviceFinder As New UPnPDeviceFinder
    Private fData As Integer = 0
    Private selectedURL As String = ""

    Private Sub MenuExit_Click(sender As Object, e As EventArgs) Handles MenuExit.Click
        Me.Close()
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles Me.Load

        StatusLabel.Text = "Searching for UPnP Devices..."

        fData = DeviceFinder.CreateAsyncFind("upnp:rootdevice", 0, Me)
        DeviceFinder.StartAsyncFind(fData)

    End Sub

    Public Sub DeviceAdded(lFindData As Integer, pDevice As UPnPDevice) Implements IUPnPDeviceFinderCallback.DeviceAdded

        Dim Node As TreeNode
        Dim CNode As TreeNode

        Node = TreeView.Nodes.Item(0).Nodes.Add(pDevice.UniqueDeviceName, pDevice.FriendlyName)
        Node.ToolTipText = pDevice.Description
        Node.Tag = pDevice.UniqueDeviceName
        If TreeView.Nodes.Item(0).Nodes.Count = 1 Then TreeView.Nodes.Item(0).Expand()
        If pDevice.HasChildren = True Then
            For Each CDev As UPnPDevice In pDevice.Children
                CNode = Node.Nodes.Add(CDev.UniqueDeviceName, CDev.FriendlyName)
                Node.ToolTipText = CDev.Description
                Node.Tag = CDev.UniqueDeviceName
            Next
        End If

    End Sub

    Public Sub DeviceRemoved(lFindData As Integer, bstrUDN As String) Implements IUPnPDeviceFinderCallback.DeviceRemoved

        TreeView.Nodes.Remove(TreeView.Nodes.Item(bstrUDN))

    End Sub

    Public Sub SearchComplete(lFindData As Integer) Implements IUPnPDeviceFinderCallback.SearchComplete
        StatusLabel.Text = ""
    End Sub

    Private Sub TreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView.AfterSelect

        If e.Node.Tag = "Root" Or IsNothing(e.Node.Tag) Then
            ListView.Items.Clear()
            ListView.View = View.LargeIcon
            selectedURL = ""
            Exit Sub
        End If

        StatusLabel.Text = "Reading Services from " & e.Node.Text & "..."
        ListView.Items.Clear()
        ListView.View = View.Details
        Dim Device As UPnPDevice
        Device = DeviceFinder.FindByUDN(e.Node.Tag)
        If IsNothing(Device) = False Then
            If Device.Services.Count > 0 Then
                Dim LVItem As ListViewItem
                Try
                    For Each Service As UPnPService In Device.Services
                        LVItem = ListView.Items.Add(New ListViewItem)
                        LVItem.SubItems(0).Text = Service.Id
                        LVItem.SubItems.Add(Service.ServiceTypeIdentifier)

                        Dim doc As IUPnPServiceDocumentAccess
                        doc = Service
                        If Not IsNothing(doc) Then
                            Dim url As String = ""
                            doc.GetDocumentURL(url)
                            LVItem.SubItems.Add(url)
                        End If
                    Next
                Catch
                    StatusLabel.Text = ""
                    selectedURL = ""
                    Exit Sub
                End Try
            Else
                selectedURL = ""
            End If
        Else
            selectedURL = ""
        End If
        StatusLabel.Text = ""

    End Sub

    Private Sub ListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView.ItemSelectionChanged

        selectedURL = e.Item.SubItems(2).Text

    End Sub

    Private Sub ListView_DoubleClick(sender As Object, e As EventArgs) Handles ListView.DoubleClick

        If selectedURL.Length > 0 Then
            Process.Start(selectedURL)
        End If

    End Sub
End Class
