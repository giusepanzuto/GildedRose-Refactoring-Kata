using System;
using System.Collections.Generic;

namespace csharp
{
    public class ItemQuality : IEquatable<ItemQuality>
    {
        int _value;

        public ItemQuality(int value)
        {
            _value = value;
        }

        public static implicit operator ItemQuality(int value) => new ItemQuality(value);

        public static bool operator ==(ItemQuality left, ItemQuality right)
        {
            return EqualityComparer<ItemQuality>.Default.Equals(left, right);
        }

        public static bool operator !=(ItemQuality left, ItemQuality right)
        {
            return !(left == right);
        }

        public void Decrease()
        {
            if (_value > 0)
            {
                _value--;
            }
        }

        public void Reset()
        {
            _value = 0;
        }

        public void Increase()
        {
            if (_value < 50)
            {
                _value++;
            }
        }

        public override string ToString()
        {
            return _value.ToString();
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as ItemQuality);
        }

        public bool Equals(ItemQuality other)
        {
            return !(other is null) &&
                   _value == other._value;
        }
    }
}
