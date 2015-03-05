using System.ComponentModel;

namespace NMockaroo.Attributes
{
    /// <summary>
    ///     Represents the Mockaroo Sentences type
    /// </summary>
    public class MockarooSentencesAttribute : MockarooInfoAttribute
    {
        /// <summary>
        ///     The minimum number of sentences
        /// </summary>
        [DefaultValue(1)]
        public int Min { get; set; }

        /// <summary>
        ///     The maximum number of sentences
        /// </summary>
        [DefaultValue(10)]
        public int Max { get; set; }
    }
}