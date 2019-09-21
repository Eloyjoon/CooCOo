using System;
using System.Collections.Generic;

namespace CooCoo
{
    public abstract class CommandBase
    {
        public abstract List<string> Keys { get; }
        public abstract List<string> Answers { get; }
        public abstract string Topic { get; }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(string)) return false;

            foreach (var key in this.Keys)
            {
                if (key.ToLower() == obj.ToString().ToLower()) return true;
            }

            return false;
        }
    }
}