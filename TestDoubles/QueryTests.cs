using Xunit;

namespace TestDoubles {
    public class QueryTests {
        [Fact]
        public void GetAllBlogs_orders_by_name() {
            var context = new TestContext();
            context.Blogs.Add(new Blog { Name = "BBB" });
            context.Blogs.Add(new Blog { Name = "ZZZ" });
            context.Blogs.Add(new Blog { Name = "AAA" });

            var service = new BlogService(context);
            var blogs = service.GetAllBlogs();

            Assert.Equal(3, blogs.Count);
            Assert.Equal("AAA", blogs[0].Name);
            Assert.Equal("BBB", blogs[1].Name);
            Assert.Equal("ZZZ", blogs[2].Name);
        }
    }
}
