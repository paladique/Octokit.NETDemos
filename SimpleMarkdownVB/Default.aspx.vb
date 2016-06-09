Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
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

    Protected Async Sub Unnamed2_Click(sender As Object, e As EventArgs)
        Dim ghClient = New GitHubClient(New ProductHeaderValue("Octokit-Test"))
        Await RenderTheMarkdown(ghClient)
    End Sub

End Class