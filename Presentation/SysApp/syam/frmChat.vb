Imports System.Net.Sockets
Imports System.Text
Public Class frmChat
    Dim clientSocket As New System.Net.Sockets.TcpClient()
    Dim serverStream As NetworkStream
    Dim readData As String
    Dim infiniteCounter As Integer
    Dim t As Threading.Thread
    Dim ctThread As Threading.Thread
    Private Sub Button1_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles Button1.Click
        Dim psn As String = ""
        Dim user As String = "][PRIVATE]$"

        user = String.Concat("[", LBUSER.Text, user)
        If ckSelected.Checked Then
            psn = String.Concat(TextBox2.Text, user)
        Else
            psn = TextBox2.Text & "$"
        End If
        Dim outStream As Byte() = _
        System.Text.Encoding.ASCII.GetBytes(psn)
        serverStream.Write(outStream, 0, outStream.Length)
        serverStream.Flush()
    End Sub

    Private Sub msg()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf msg))
        Else
            If clientSocket.Connected Then
                If readData.Contains("{PSN}") Then
                    readData = readData.Replace("{PSN}", "")
                ElseIf readData.Contains("{MEMBER LIST}") Then
                    readData = readData.Replace("{MEMBER LIST}", "")
                    LBUSER.Items.Clear()
                    If readData = textID.Text Then readData = ""
                    For Each item As String In readData.Split("/")
                        If item <> textID.Text Then
                            LBUSER.Items.Add(item)
                        End If
                    Next
                    readData = ""
                End If
                If readData <> "" Then TextBox1.Text = TextBox1.Text + Environment.NewLine + " >> " + readData
            Else
                Label2.Text = "Lost Conntact"
                ctThread.Suspend()
            End If
        End If


    End Sub
    Private Sub ConnectToChatServer()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ConnectToChatServer))
        Else
            Try
                clientSocket.Connect("127.0.0.1", 8888)
                serverStream = clientSocket.GetStream()
                Dim outStream As Byte() = _
                System.Text.Encoding.ASCII.GetBytes(textID.Text + "$")
                serverStream.Write(outStream, 0, outStream.Length)
                serverStream.Flush()

                ctThread = New Threading.Thread(AddressOf getMessage)
                ctThread.Start()
                Label2.Text = "Connected"
                t.Suspend()
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub TimerTick()
        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            ConnectToChatServer()
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles Button2.Click
        readData = "Conecting to Chat Server ..."
        'msg()
        Label2.Text = readData
        clientSocket = New System.Net.Sockets.TcpClient()
        t = New Threading.Thread(AddressOf TimerTick)
        t.Start()
        'clientSocket.Connect("127.0.0.1", 8888)
        ''Label1.Text = "Client Socket Program - Server Connected ..."
        'serverStream = clientSocket.GetStream()

        'Dim outStream As Byte() = _
        'System.Text.Encoding.ASCII.GetBytes(textID.Text + "$")
        'serverStream.Write(outStream, 0, outStream.Length)
        'serverStream.Flush()

        'Dim ctThread As Threading.Thread = New Threading.Thread(AddressOf getMessage)
        'ctThread.Start()
    End Sub

    Private Sub getMessage()
        For infiniteCounter = 1 To 2
            infiniteCounter = 1
            If clientSocket.Connected Then
                serverStream = clientSocket.GetStream()
                Dim buffSize As Integer
                Dim inStream(10024) As Byte
                buffSize = clientSocket.ReceiveBufferSize
                Try
                    serverStream.Read(inStream, 0, buffSize)
                    Dim returndata As String = _
                    System.Text.Encoding.ASCII.GetString(inStream)
                    readData = "" + returndata
                    msg()
                Catch ex As Exception
                    clientSocket.Close()
                    readData = ""
                    msg()
                End Try
            End If
        Next
    End Sub
End Class
