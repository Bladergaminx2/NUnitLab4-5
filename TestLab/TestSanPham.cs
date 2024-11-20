using NUnitLab4_5;
namespace TestLab
{
    public class TestSanPHam
    {
        private SanPhamService _service;

        [SetUp]
        public void Setup()
        {
            _service = new SanPhamService();
        }

        [Test]
        public void ThemSanPham_Nintendo()
        {
            var sp = new SanPham("1", "SP01", "Nintendo Switch", 5000, "Do", "Smol", 150);
            Assert.Throws<ArgumentException>(() => _service.ThemSanPham(sp));
        }

        [Test]
        public void ThemSanPham_Oto()
        {
            var sp = new SanPham("2", "SP02", "Ferrari", 6000, "Xanh", "Chungus", 0);
            Assert.Throws<ArgumentException>(() => _service.ThemSanPham(sp));
        }

        [Test]
        public void ThemSanPham_CaiCua()
        {
            var sp = new SanPham("3", "SP03", "Cai cua", 7000, "Vang", "S", 100);
            Assert.Throws<ArgumentException>(() => _service.ThemSanPham(sp));
        }

        [Test]
        public void ThemSanPham_ConMeo()
        {
            var sp = new SanPham("4", "04", "San Pham 4", 8000, "Trang", "Smol", 120);
            Assert.Throws<ArgumentException>(() => _service.ThemSanPham(sp));
        }

        [Test]
        public void ThemSanPham_Ao()
        {
            var sp = new SanPham("5", "SP05", "AO polo nam 1999", 9000, "Den", "XXL", 99);
            Assert.Throws<ArgumentException>(() => _service.ThemSanPham(sp));
        }


//test sua

        [Test]
        public void SuaSanPham_Ok()
        {
            var sp = new SanPham("1", "SP01", "Nintendo Switch", 5000, "Do", "Smol", 150);
            _service.ThemSanPham(sp);

            Assert.Throws<ArgumentException>(() => _service.SuaSanPham("1", "SP44", "Nintendo Switch lite", 5000, "Xanh", "Smol", 150));
        }

        [Test]
        public void SuaSanPham_KoSP()
        {
            var sp = new SanPham("2", "SP02", "San Pham 2", 6000, "Do", "M", 50);
            _service.ThemSanPham(sp);

            Assert.Throws<ArgumentException>(() => _service.SuaSanPham("2", "01", "San Pham Moi", 6000, "Xanh", "L", 20));
        }

        [Test]
        public void SuaSanPham_TonTai()
        {
            var sp1 = new SanPham("1", "SP01", "Oto 1", 5000, "Do", "M", 50);
            var sp2 = new SanPham("2", "SP02", "Oto 2", 6000, "Xanh", "L", 30);
            _service.ThemSanPham(sp1);
            _service.ThemSanPham(sp2);

            Assert.Throws<ArgumentException>(() => _service.SuaSanPham("1", "SP02", "oto 1", 6000, "Vang", "S", 20));
        }

        [Test]
        public void SuaSanPham_IDKhongTonTai()
        {
            Assert.Throws<ArgumentException>(() => _service.SuaSanPham("3", "SP03", "Limbus company", 7000, "Trang", "XL", 40));
        }

        [Test]
        public void SuaSanPham_ThongTinHopLe_SuaThanhCong()
        {
            var sp = new SanPham("1", "SP01", "San Pham 1", 5000, "Do", "M", 50);
            _service.ThemSanPham(sp);

            Assert.Throws<ArgumentException>(() => _service.SuaSanPham("1", "SP03", "No le", 6000, "Xanh", "L", 20));
        }
    }
}