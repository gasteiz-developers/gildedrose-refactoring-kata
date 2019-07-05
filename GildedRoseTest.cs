﻿using System.Collections.Generic;
using Xunit;

namespace GildedRoseRefactoringKata
{
    public class GildedRoseTest
    {
        [Fact]
        public void foo()
        {
            IList<Item> Items = new List<Item> {new Item {Name = "foo", SellIn = 0, Quality = 0}};
            var app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.Equal("foo", Items[0].Name);
        }
    }
}