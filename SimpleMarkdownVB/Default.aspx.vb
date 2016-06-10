Imports Octokit
Imports System.Threading.Tasks

Public Class _Default
    Inherits UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Private Async Function RenderTheMarkdown(client As GitHubClient) As Task

        Dim mkd As NewArbitraryMarkdown = New NewArbitraryMarkdown(txtMkd.Text)
        Dim renderedMkd As String = Await client.Miscellaneous.RenderArbitraryMarkdown(mkd)
        lblrendered.Text = renderedMkd

    End Function

    Protected Async Function Unnamed2_Click(sender As Object, e As EventArgs) As Task
        Dim ghClient = New GitHubClient(New ProductHeaderValue("Octokit-Test"))
        Await RenderTheMarkdown(ghClient)
    End Function

End Class