Imports Octokit

Module Module1

    Sub Main()
        Dim ghClient = New GitHubClient(New ProductHeaderValue("Octokit-Test"))
        Dim Task As Task = New Task(Sub() ListUserRepos(ghClient))


        Task.Start()
        Task.Wait()
        Console.ReadLine()
    End Sub

    Private Async Sub ListUserRepos(client As GitHubClient)
        Dim githubUser As User = Await client.User.Get("paladique")
        Dim gitubUserRepos As IReadOnlyList(Of Repository) = Await client.Repository.GetAllForUser(githubUser.Login)

        For Each r As Repository In gitubUserRepos
            Console.WriteLine(r.Name)
        Next
    End Sub

End Module
