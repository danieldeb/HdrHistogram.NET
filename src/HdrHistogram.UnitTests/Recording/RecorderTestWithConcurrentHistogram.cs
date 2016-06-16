using NUnit.Framework;

namespace HdrHistogram.UnitTests.Recording
{
    [TestFixture]
    public sealed class RecorderTestWithConcurrentHistogram : RecorderTestsBase
    {
        protected override HistogramBase Create(long id, long min, long max, int sf)
        {
            return new LongConcurrentHistogram(id, min, max, sf);
        }
    }
}