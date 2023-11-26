namespace P01_HarvestingFields
{
    using System;
    using System.Reflection;

    public class HarvestingFieldsTest
    {
        public static void Main()
        {
            string input;
            Type type = new HarvestingFields().GetType();
            FieldInfo[] fieldsInfo;
            while (!(input = Console.ReadLine()).Equals("HARVEST"))
            {
                fieldsInfo = type.GetFields();
                switch (input)
                {
                    case "private":
                        foreach (FieldInfo field in fieldsInfo)
                        {
                            if (field.IsPrivate)
                            {
                                Console.WriteLine($"private {field.FieldType.Name} {field.Name}");
                            }
                        }
                        break;
                    case "protected":
                        foreach (FieldInfo field in fieldsInfo)
                        {
                            if (field.IsFamily)
                            {
                                Console.WriteLine($"protected {field.FieldType.Name} {field.Name}");
                            }
                        }
                        break;
                    case "public":
                        foreach (FieldInfo field in fieldsInfo)
                        {
                            if (field.IsPublic)
                            {
                                Console.WriteLine($"public {field.FieldType.Name} {field.Name}");
                            }
                        }
                        break;
                    case "all":
                        string modifier;
                        foreach (FieldInfo field in fieldsInfo)
                        {
                            modifier = field.IsPrivate ? "private" : field.IsPublic ? "public" : field.IsFamily ? "protected" : "internal";
                            Console.WriteLine($" {field.FieldType.Name} {field.Name}");
                        }
                        break;
                }
            }
        }
    }
}
