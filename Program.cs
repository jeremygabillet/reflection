using System;
using System.Collections.Generic;
using System.Reflection;

namespace reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = "";
            GetAllProperties(i);
            GetAllFields(i);
            GetAllMethods(i);
        }
        private static void GetAllProperties(object reflected)
        {
            Type objectType = reflected.GetType();
            PropertyInfo[] propertyInfos = objectType.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic);
            System.Console.WriteLine("Properties : ");
            foreach (PropertyInfo propertyInfo in propertyInfos)
            {
                Console.WriteLine("\t" + propertyInfo);
            }
            System.Console.WriteLine("\n");
        }
        private static void GetAllFields(object reflected)
        {
            Type objectType = reflected.GetType();
            FieldInfo[] fieldInfos = objectType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);
            System.Console.WriteLine("Fields : ");
            foreach (FieldInfo fieldInfo in fieldInfos)
            {
                System.Console.WriteLine("\t" + fieldInfo);
            }
            System.Console.WriteLine("\n");
        }
        private static void GetAllMethods(object reflected)
        {   
            Type objectType = reflected.GetType();
            MethodInfo[] methodInfos = objectType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            System.Console.WriteLine("Methods : ");
            foreach (MethodInfo methodInfo in methodInfos)
            {
                System.Console.WriteLine("\t" + methodInfo);
            }
            System.Console.WriteLine("\n");
        }
    }
}
