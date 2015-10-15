namespace RomanNumeralKata
{
    using Xunit;

    public class RomanNumeralTests
    {
        private readonly RomanNumerals subject = new RomanNumerals();

        [Fact]
        public void Converts1ToI()
        {
            Assert.Equal("i", subject.Convert(1));
        }

        [Fact]
        public void Converts2ToII()
        {
            Assert.Equal("ii", subject.Convert(2));
        }

        [Fact]
        public void Converts3ToIII()
        {
            Assert.Equal("iii", subject.Convert(3));
        }

        [Fact]
        public void Converts4ToIV()
        {
            Assert.Equal("iv", subject.Convert(4));
        }

        [Fact]
        public void Converts5ToV()
        {
            Assert.Equal("v", subject.Convert(5));
        }

        [Fact]
        public void Converts6ToVI()
        {
            Assert.Equal("vi", subject.Convert(6));
        }

        [Fact]
        public void Converts8ToVIII()
        {
            Assert.Equal("viii", subject.Convert(8));
        }

        [Fact]
        public void Converts9ToIX()
        {
            Assert.Equal("ix", subject.Convert(9));
        }

        [Fact]
        public void Converts10ToX()
        {
            Assert.Equal("x", subject.Convert(10));
        }

        [Fact]
        public void Converts20ToXX()
        {
            Assert.Equal("xx", subject.Convert(20));
        }

        [Fact]
        public void Converts25ToXXV()
        {
            Assert.Equal("xxv", subject.Convert(25));
        }

        [Fact]
        public void Converts40ToXL()
        {
            Assert.Equal("xl", subject.Convert(40));
        }

        [Fact]
        public void Converts50ToL()
        {
            Assert.Equal("l", subject.Convert(50));
        }

        [Fact]
        public void Converts90ToXC()
        {
            Assert.Equal("xc", subject.Convert(90));
        }

        [Fact]
        public void Converts100ToC()
        {
            Assert.Equal("c", subject.Convert(100));
        }

        [Fact]
        public void Converts400ToX()
        {
            Assert.Equal("cd", subject.Convert(400));
        }

        [Fact]
        public void Converts500ToC()
        {
            Assert.Equal("d", subject.Convert(500));
        }

        [Fact]
        public void Converts900ToCM()
        {
            Assert.Equal("cm", subject.Convert(900));
        }

        [Fact]
        public void Converts1000ToM()
        {
            Assert.Equal("m", subject.Convert(1000));
        }

        [Fact]
        public void Converts2012ToMMXII()
        {
            Assert.Equal("mmxii", subject.Convert(2012));
        }

        [Fact]
        public void Converts42ToXLII()
        {
            Assert.Equal("xlii", subject.Convert(42));
        }
    }
}
