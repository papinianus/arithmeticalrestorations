using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace ExtensionMethods
{
    public sealed class DigitDescriptor
    {
        private DigitDescriptor() { throw new InvalidOperationException(); }
        public int Length { get; private set; } = 0;
        public IReadOnlyDictionary<int, int> Restrictions { get; private set; }
        private readonly char WildCard = 'X';
        public DigitDescriptor(string Format) : this(Format, 'X') { } 
        public DigitDescriptor(string Format, char WildCard)
        {
            if(!IsValidFormat(Format, WildCard)) { throw new ArgumentException($"Invalid Format:{Format}"); }
            Length = Format.Length;
            Restrictions = new ReadOnlyDictionary<int,int>(Format.Select((ch, idx) => new { Index = idx, Number = ch }).Where(pair => pair.Number != WildCard).ToDictionary(numpair => numpair.Index, numpair=>(int)char.GetNumericValue(numpair.Number)));
        }
        private static bool IsValidFormat(string format, char wildcard) => !string.IsNullOrWhiteSpace(format) && format.All(x => x == wildcard || char.IsDigit(x));
    }
}
