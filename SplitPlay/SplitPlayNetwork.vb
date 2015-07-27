Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System.Net

Public Class VideoStream
    Private objUDPClient As UdpClient
    Private objReceivingUDP As UdpClient
    Private objReceivingEndpoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
    Private trdReceiver As Thread
    Private strDestIP As String
    Private shtPort As UShort
    Private m_isactive As Boolean = False

    Public bmpCurrentFrame As Bitmap


    Public Sub New(destip As String, port As UShort)
        strDestIP = destip
        shtPort = port

        objUDPClient = New UdpClient
        objUDPClient.AllowNatTraversal(True)
    End Sub

    Public Sub New(port As UShort)
        objReceivingUDP = New UdpClient(port)
        objReceivingUDP.AllowNatTraversal(True)
        trdReceiver = New Thread(New ThreadStart(AddressOf ReceiveFrame))
        trdReceiver.Start()
    End Sub

    Private Sub ReceiveFrame()
        While True
            Dim bytReceive() As Byte = objReceivingUDP.Receive(objReceivingEndpoint)

            Dim ms As New MemoryStream()
            ms.Write(bytReceive, 0, bytReceive.Length)

            bmpCurrentFrame = CType(Bitmap.FromStream(ms), Bitmap)
            RaiseEvent FrameReady()
        End While
    End Sub

    Public Sub Start()
        m_isactive = True
        Try
            objUDPClient.Connect(strDestIP, shtPort)
        Catch ex As Exception
            Throw New Exception("Exception occurred.")
        End Try
    End Sub

    Public Sub Send(bytes As Byte())
        Try
            objUDPClient.Send(bytes, bytes.Length)
        Catch ex As Exception

        End Try
    End Sub

    Public Sub Cleanup()
        Try
            objUDPClient.Close()
        Catch ex As NullReferenceException

        End Try

        Try
            objReceivingUDP.Close()
        Catch ex As NullReferenceException

        End Try
    End Sub

    Public ReadOnly Property IsActive As Boolean
        Get
            Return m_isactive
        End Get
    End Property

    Public Event FrameReady()
End Class


Public Class KeyStream
    Private objUDPClient As UdpClient
    Private objReceivingUDP As UdpClient
    Private objReceivingEndpoint As IPEndPoint = New IPEndPoint(IPAddress.Any, 0)
    Private trdReceiver As Thread
    Private strDestIP As String
    Private shtPort As UShort
    Private m_isactive As Boolean = False

    Public bytData As Byte()


    Public Sub New(destip As String, port As UShort)
        strDestIP = destip
        shtPort = port

        objUDPClient = New UdpClient
        objUDPClient.AllowNatTraversal(True)
    End Sub

    Public Sub New(port As UShort)
        objReceivingUDP = New UdpClient(port)
        objReceivingUDP.AllowNatTraversal(True)
        trdReceiver = New Thread(New ThreadStart(AddressOf ReceiveFrame))
        trdReceiver.Start()
    End Sub

    Private Sub ReceiveFrame()
        While True
            Dim bytReceive() As Byte = objReceivingUDP.Receive(objReceivingEndpoint)

            bytData = bytReceive
            RaiseEvent FrameReady()
        End While
    End Sub

    Public Sub Start()
        m_isactive = True
        Try
            objUDPClient.Connect(strDestIP, shtPort)
        Catch ex As Exception
            Throw New Exception("Exception Occured")
        End Try
    End Sub

    Public Sub Send(bytes As Byte())
        objUDPClient.Send(bytes, bytes.Length)
    End Sub

    Public Sub Cleanup()
        Try
            objUDPClient.Close()
        Catch ex As NullReferenceException

        End Try

        Try
            objReceivingUDP.Close()
        Catch ex As NullReferenceException

        End Try
    End Sub

    Public ReadOnly Property IsActive As Boolean
        Get
            Return m_isactive
        End Get
    End Property

    Public Event FrameReady()
End Class