using Lab06_5_.Factories.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Lab06_5_.Factories.Implementations
{
    internal class MoodFactoryImpl : MoodFactory
    {
        public override Mood GetMood(int happines)
        {
            if (happines < -5)
            {
                return ProduceAngry();
            }
            else if (happines <= 0)
            {
                return ProduceSad();
            }
            else if (happines <= 15)
            {
                return ProduceHappy();
            }
            else 
            {
                return ProduceJavaScript();
            }

        }

        private AngryMood ProduceAngry()
        {
            return new AngryMood();
        }

        private SadMood ProduceSad()
        {
            return new SadMood();
        }

        private HappyMood ProduceHappy()
        {
            return new HappyMood();
        }

        private JavaScriptMood ProduceJavaScript()
        {
            return new JavaScriptMood();
        }
    }
}
