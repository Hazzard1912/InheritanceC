using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class ImagePost : Post
    {
        public string ImageUrl { get; set; }

        public ImagePost()
        {

        }

        public ImagePost(string title, string sendBy, bool isPublic, string imageUrl)
            : base(title, sendBy, isPublic)
        {
            ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", base.ToString(), ImageUrl);
        }
    }
}
