using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDoubles {
    public class BlogService {
        private IBloggingContext _context;

        public BlogService(IBloggingContext context) {
            _context = context;
        }

        public Blog AddBlog(string name, string url) {
            var blog = new Blog { Name = name, Url = url };
            _context.Blogs.Add(blog);
            _context.SaveChanges();

            return blog;
        }

        public List<Blog> GetAllBlogs() {
            var query = from b in _context.Blogs
                        orderby b.Name
                        select b;

            return query.ToList();
        }
    }
}
