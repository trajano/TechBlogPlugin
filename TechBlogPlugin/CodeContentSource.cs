using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using WindowsLive.Writer.Api;

namespace TechBlogPlugin
{
    [WriterPluginAttribute("11293a99-23ba-487a-97da-4696e47ac4b8",
    "Simple Insert Code",
    PublisherUrl = "http://www.trajano.net",
    Description = "Insert code or pre tags to a blog post selection")]
    [InsertableContentSourceAttribute("Insert Code", SidebarText = "Insert code tags to a blog post selection.")]
    public class CodeContentSource : ContentSource
    {
        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content)
        {
            if (content.Length == 0)
            {
                content = "<code>code</code>";
            }
            else
            {
                content = "<code>" + content + "</code>";
            }
            return DialogResult.OK;
        }
    }
}
