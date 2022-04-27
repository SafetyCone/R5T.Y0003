using System;


namespace R5T.Y0003
{
    public static partial class Documentation
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public static class ForIndentation
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            /// <summary>
            /// Conversion from <inheritdoc cref="Glossary.ForIndentation.LineIndentation" path="/name"/> to <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/> by removing everything at the beginning of the <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/> up to and including the last line break found in the <inheritdoc cref="Glossary.ForIndentation.LineIndentation" path="/name"/>.
            /// </summary>
            public static readonly object ConversionToIndentationFromLineIndentation;

            /// <summary>
            /// Conversion from <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/> to <inheritdoc cref="Glossary.ForIndentation.LineIndentation" path="/name"/> is done by prefixing a line break to the <inheritdoc cref="Glossary.ForIndentation.Indentation" path="/name"/>.
            /// </summary>
            public static readonly object ConversionToLineIndentationFromIndentation;
        }
    }
}
