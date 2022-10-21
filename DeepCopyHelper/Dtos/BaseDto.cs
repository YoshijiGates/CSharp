using System;

namespace DeepCopyHelper.Dtos
{
    [Serializable]
    public abstract class BaseDto<T> where T : BaseDto<T>
    {
#pragma warning disable CS8765
#pragma warning disable CS8604
#pragma warning disable CS8625
        public override bool Equals(object obj)
        {
            var t = obj as T;
            if (t == null)
            {
                return false;
            }

            return EqualsCore(t);
        }

        public static bool operator ==(BaseDto<T> obj1, BaseDto<T> obj2)
        {
            return Equals(obj1, obj2);
        }

        public static bool operator !=(BaseDto<T> obj1, BaseDto<T> obj2)
        {
            return !Equals(obj1, obj2);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        protected abstract bool EqualsCore(T other);
    }
}
