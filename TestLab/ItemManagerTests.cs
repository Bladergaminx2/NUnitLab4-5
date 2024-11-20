using NUnitLab4_5;

namespace TestLab
{
    public class ItemManagerTests
    {
        private ItemManager _itemManager;

        [SetUp]
        public void Setup()
        {
            _itemManager = new ItemManager();
        }

        // Add 
        [Test]
        public void AddItems1()
        {
            var item = new Items(1, "ValidProductName");
            Assert.DoesNotThrow(() => _itemManager.AddItems(item));
        }

        [Test]
        public void AddItems2()
        {
            var item = new Items(2, "qweiojdokfoisjdoijo123");
            Assert.DoesNotThrow(() => _itemManager.AddItems(item));
        }

        [Test]
        public void AddItems3()
        {
            var item = new Items(3, "sadoiqiwksxcjioikdodoiejiorjqwooiqjeoijqwoijsddojqoijwiqoidjx12");
            Assert.Throws<ArgumentException>(() => _itemManager.AddItems(item),
                "Name must be alphabetic and less than 50 word.");
        }

        // Update
        [Test]
        public void UpdateItems1()
        {
            var item = new Items(1, "OldSpice");
            _itemManager.AddItems(item);

            Assert.DoesNotThrow(() => _itemManager.UpdateItems(1, "NewSpice"));
        }

        [Test]
        public void UpdateItems2()
        {
            var item = new Items(2, "OldSpice");
            _itemManager.AddItems(item);

            Assert.DoesNotThrow(() => _itemManager.UpdateItems(2, "FoulSpice"));
        }

        [Test]
        public void UpdateItems3()
        {
            var item = new Items(3, "OldSpice");
            _itemManager.AddItems(item);

            Assert.Throws<ArgumentException>(() => _itemManager.UpdateItems(3, "123123"));
        }

        // Delete
        [Test]
        public void DeleteItemss()
        {
            var item = new Items(1, "ProductToDelete");
            _itemManager.AddItems(item);

            Assert.DoesNotThrow(() => _itemManager.DeleteItems(1));
        }

        [Test]
        public void DeleteItems2()
        {
            var item = new Items(2, "ProductToDelete");
            _itemManager.AddItems(item);

            Assert.DoesNotThrow(() => _itemManager.DeleteItems(2));
        }

        [Test]
        public void DeleteItems3()
        {
            Assert.Throws<ArgumentException>(() => _itemManager.DeleteItems(99),
                "Item does not exist.");
        }
    }
}