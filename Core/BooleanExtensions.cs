using System;

namespace Core
{

    public static class BooleanExtensions
    {
        public static bool IfTrue(this bool value, Action action)
        {
            if (value) action();

            return value;
        }

        public static bool IfFalse(this bool value, Action action)
        {
            if (!value) action();

            return value;
        }

        public static bool Not(this bool value)
        {
            return !value;
        }
    }
}
