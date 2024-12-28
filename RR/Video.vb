Imports System.Windows.Forms
Imports Microsoft.Web.WebView2.WinForms

Public Class Video
    Inherits UserControl

    Private WithEvents webView As New WebView2()

    ' Constructor that accepts a YouTube URL
    Public Sub New(youtubeUrl As String)
        InitializeComponent()
        InitializeWebView(youtubeUrl)
    End Sub

    Private Async Sub InitializeWebView(youtubeUrl As String)
        webView.Size = New Size(800, 450)
        webView.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Me.Controls.Add(webView)

        ' Ensure the WebView2 environment is initialized
        Await webView.EnsureCoreWebView2Async(Nothing)

        ' Load the video after the WebView2 is initialized
        LoadVideo(youtubeUrl)
    End Sub

    Private Sub LoadVideo(youtubeUrl As String)
        Dim videoId As String = ExtractVideoId(youtubeUrl)
        If Not String.IsNullOrEmpty(videoId) Then
            Dim htmlContent As String = $"
                <html>
                    <body style='margin:0;'>
                        <iframe width='420' height='300' src='https://www.youtube-nocookie.com/embed/{videoId}' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share' referrerpolicy='strict-origin-when-cross-origin' allowfullscreen></iframe>
                    </body>
                </html>"
            webView.NavigateToString(htmlContent)
        Else
            MessageBox.Show("Invalid YouTube URL.")
        End If
    End Sub

    Private Function ExtractVideoId(youtubeUrl As String) As String
        Dim videoId As String = String.Empty

        If youtubeUrl.Contains("youtube.com/watch?v=") Then
            videoId = youtubeUrl.Split(New String() {"watch?v="}, StringSplitOptions.None)(1).Split("&"c)(0)
        ElseIf youtubeUrl.Contains("youtu.be/") Then
            videoId = youtubeUrl.Split(New String() {"youtu.be/"}, StringSplitOptions.None)(1).Split("?"c)(0)
        End If

        Return videoId
    End Function
    Public Async Sub StopVideo()
        Dim script As String = "var player = document.getElementById('youtubePlayer'); " &
                            "if (player) { player.contentWindow.postMessage('{" &
                            """event"":""command""," &
                            """func"":""stopVideo""," &
                            """args"":""""}', '*'); }"
        Await webView.ExecuteScriptAsync(script)
    End Sub

    Private Sub Video_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class