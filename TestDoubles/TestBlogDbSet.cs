﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDoubles {
    class TestBlogDbSet : TestDbSet<Blog> {
        public override Blog Find(params object[] keyValues) {
            var id = (int)keyValues.Single();
            return this.SingleOrDefault(b => b.BlogId == id);
        }
    } 
}
