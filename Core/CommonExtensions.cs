using System;

namespace Core
{
    public static class CommonExtensions
    {
        public static bool IsNull(this object value)
        {
            return value != null;
        }

        public static T Then<T>(this T value, Func<T, bool> func, Action action)
        {
            if (func(value))
                action();

            return value;
        }
        public static T Then<T>(this T value, Func<T, bool> func, Func<T, T> action)
        {
            if (func(value))
                value = action(value);

            return value;
        }

        public static T ThenNotNull<T>(this T value, Action action)
        {
            if (value != null)
            {
                action();
            }

            return value;
        }

        public static T ThenNull<T>(this T value, Action action)
        {
            if (value == null)
            {
                action();
            }

            return value;
        }


    }
}