using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnPrototype.Classes
{
    class Blog
    {
        
        public int BlogId;
        public DateTime PublishDate;
        public string URL;
        public Post Post;

        public Blog ShallowCopy()
        {
            return (Blog)this.MemberwiseClone();
        }

        public Blog DeepCopy()
        {
            Blog clone = (Blog)this.MemberwiseClone();
            clone.Post = new Post(Post.Title);
            clone.URL = String.Copy(URL);
            return clone;
        }
    }
}

