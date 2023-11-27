namespace P02_BlackBoxInteger
{
    using System;
    using System.Reflection;

    public class BlackBoxIntegerTests
    {
        public static void Main()
        {
            Type type = typeof(BlackBoxInteger);
            ConstructorInfo constructor = type.GetConstructor(BindingFlags.Instance |
                BindingFlags.NonPublic, null, Type.EmptyTypes, null);
            if (constructor != null)
            {
                BlackBoxInteger blackBox = (BlackBoxInteger)constructor.Invoke(null);
                FieldInfo innerValue = type.GetField("innerValue", BindingFlags.NonPublic | BindingFlags.Instance);
                List<MethodInfo> methodInfos = type.GetMethods(BindingFlags.Instance
                    | BindingFlags.NonPublic | BindingFlags.DeclaredOnly).ToList();

                string input;
                while (!(input = Console.ReadLine()).Equals("END"))
                {
                    string[] command = input.Split("_");
                    if (!(command[0].Equals("Add") || command[0].Equals("Subtract") || command[0].Equals("Divide") 
                        || command[0].Equals("Multiply") || command[0].Equals("LeftShift") || command[0].Equals("RightShift")))
                    {
                        Console.WriteLine("Unknown operation");
                        continue;
                    }
                    methodInfos.Find(m => m.Name == command[0]).Invoke(blackBox, new object[] { int.Parse(command[1]) });
                    Console.WriteLine(innerValue.GetValue(blackBox));

                }
            }

        }
    }
}
