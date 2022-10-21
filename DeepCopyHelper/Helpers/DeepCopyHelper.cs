using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace DeepCopyHelper.Helpers
{
    public static class DeepCopyHelper
    {
#pragma warning disable SYSLIB0011
#pragma warning disable CS8604
        /// <summary>
        /// DeepCopy
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <returns></returns>
        // Disable the warning.
        public static T DeepCopy<T>(this T param)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                var binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(memoryStream, param);
                memoryStream.Position = 0;

                return (T)binaryFormatter.Deserialize(memoryStream);
            }
        }
    }
}
