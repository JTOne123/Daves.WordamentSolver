﻿using System;
using System.Collections.Generic;

namespace Daves.WordamentSolver.Models.WordSorters
{
    public sealed class WordLengthSorter : WordSorter, IComparer<Word>
    {
        public override string Name => "word length";

        public int Compare(Word x, Word y)
            => x.WordLength != y.WordLength
            ? y.WordLength.CompareTo(x.WordLength)
            : WordSorter.Alphabet.Compare(x, y);

        public override void Sort(Word[] words)
            => Array.Sort(words, comparer: this);
    }
}