using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Octokit;
using System.Threading.Tasks;

namespace SimpleMarkdownCS
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        private async Task RenderTheMarkdown(GitHubClient client)
        {
            
            NewArbitraryMarkdown mkd = new NewArbitraryMarkdown(txtMkd.Text);
            string renderedMkd =  await client.Miscellaneous.RenderArbitraryMarkdown(mkd);

            lblrendered.Text = renderedMkd;

        }

        protected async void Unnamed2_Click(object sender, EventArgs e)
        {
            var ghClient = new GitHubClient(new ProductHeaderValue("Octokit-Test"));
            
            await RenderTheMarkdown(ghClient);

        }
    }
}
