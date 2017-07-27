using System;
namespace CsWriter.Util
{
    public class Do
    {
        private Do() { }


        public static string[] Clone(string[] arr)
        {
            if (arr == null) return null;

            string[] newArray = new string[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = new string(arr[i].ToCharArray());
            }
            return newArray;
        }
    }
}
