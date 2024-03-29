﻿using System;

using R5T.T0156;


namespace R5T.Y0003
{
    public static partial class Glossary
    {
        [DocumentationMarker]
        public static class ForIndentation
        {
            /// <summary>
            /// <inheritdoc cref="Indentation" path="/definition"/>
            /// </summary>
            /// <definition>Indentation is the series of tabs and spaces at the beginning of a line.</definition>
            /// <name><i>indentation</i></name>
            public static readonly object Indentation;

            /// <summary>
            /// <inheritdoc cref="LineIndentation" path="/definition"/>
            /// </summary>
            /// <definition>Line indentation is <inheritdoc cref="Indentation" path="/name"/> that begins with zero or more line breaks.</definition>
            /// <name><i>line indentation</i></name> 
            public static readonly object LineIndentation;

            /// <summary>
            /// <inheritdoc cref="Tabination" path="/definition"/>
            /// </summary>
            /// <definition>The spacing for <inheritdoc cref="Indentation" path="/name"/> should be made up of tabs.</definition>
            /// <name><i>tabination</i></name>
            public static readonly object Tabination;
        }
    }
}
