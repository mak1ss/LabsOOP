using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab06_5_.Factories.Implementations;

namespace Lab06_5_.Factories.Abstractions
{
    internal abstract class MoodFactory
    {
        public abstract Mood GetMood(int happines);

    }
}
