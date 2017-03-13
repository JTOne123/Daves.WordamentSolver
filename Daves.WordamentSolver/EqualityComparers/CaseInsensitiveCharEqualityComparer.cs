﻿using System.Collections.Generic;

namespace Daves.WordamentSolver.EqualityComparers
{
    public sealed class CaseInsensitiveCharEqualityComparer : IEqualityComparer<char>
    {
        public bool Equals(char x, char y)
            => char.ToUpperInvariant(x) == char.ToUpperInvariant(y);

        public int GetHashCode(char c)
            => char.ToUpperInvariant(c).GetHashCode();
    }
}
