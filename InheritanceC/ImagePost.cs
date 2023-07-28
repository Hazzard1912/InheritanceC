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
            ImageUrl = string.Empty;
        }

        public ImagePost(string title, string sendBy, bool isPublic, string imageUrl)
        {
            ID = GetNextID();
            Title = title;
            SendBy = sendBy;
            IsPublic = isPublic;
            ImageUrl = imageUrl;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", base.ToString(), ImageUrl);
        }
    }
}
