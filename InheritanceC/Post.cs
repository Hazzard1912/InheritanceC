using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceC
{
    internal class Post
    {
        private static int currentPostId;

        protected int ID { get; set; }
        protected string Title { get; set; }
        protected string SendBy { get; set; }
        public bool IsPublic { get; set; }

        public Post()
        {
            ID = 0;
            Title = "My First Post";
            SendBy = "Jhonnier Hernandez";
            IsPublic = true;
        }

        public Post(string title, string sendBy, bool isPublic)
        {
            ID = GetNextID();
            Title = title;
            SendBy = sendBy;
            IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostId;
        }

        public void Update(string title, bool isPublic)
        {
            Title = title;
            IsPublic = isPublic;
        }

        public override string ToString()
        {
            return $"{ID}, {Title}, {SendBy}";
        }
    }
}
