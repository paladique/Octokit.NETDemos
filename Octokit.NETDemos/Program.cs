using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Octokit;

namespace Octokit.NETDemos
{
    class Program
    {

        static void Main(string[] args)
        {
            var ghClient = new GitHubClient(new ProductHeaderValue("Octokit-Test"));
            Task task = new Task(() => ListUserRepos(ghClient));
            task.Start();
            task.Wait();
            Console.ReadLine();

        }

        private static async void ListUserRepos(GitHubClient client)
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