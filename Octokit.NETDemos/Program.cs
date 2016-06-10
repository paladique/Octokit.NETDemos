using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit.NETDemos
{
    class Program
    {

        static void Main(string[] args)
        {
            var ghClient = new GitHubClient(new ProductHeaderValue("Octokit-Test"));
            Task task = new Task(async () => await ListUserRepos(ghClient));
            task.Start();
            Console.ReadLine();
        }

        private static async Task ListUserRepos(GitHubClient client)
        {
            User githubUser = await client.User.Get("paladique");
            IReadOnlyList<Repository> gitubUserRepos = await client.Repository.GetAllForUser(githubUser.Login);
            foreach (Repository r in gitubUserRepos)
            {
                Console.WriteLine(r.Name);
           }
        }

    }
}