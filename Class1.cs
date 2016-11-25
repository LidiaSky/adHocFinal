using System;

internal static class Arrays
{
    internal static T[] InitializeWithDefaultInstances<T>(int length) where T : new()
    {
        T[] array = new T[length];
        for (int i = 0; i < length; i++)
        {
            array[i] = new T();
        }
        return array;
    }
}

