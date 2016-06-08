open System
open System.Threading.Tasks
open Octokit


[<EntryPoint>]
let main argv = 
    let client = GitHubClient(new ProductHeaderValue("Octokit-Test"))
    
    let task (t: Task) = t.ContinueWith (fun listUserRepos -> ()) |> Async.AwaitTask

    let ListUserRepos =
        Console.WriteLine("hello");
    0 // return an integer exit code

    

