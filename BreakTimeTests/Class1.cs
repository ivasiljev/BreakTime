﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace BreakTimeTests
{
    public class Class1
    {
        [Fact]
        public void test1()
        {
            Assert.Equal(4, Add(2, 2));
        }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
