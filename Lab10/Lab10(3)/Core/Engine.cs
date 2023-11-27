namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;
    using _03BarracksFactory.Data;
    using System.Reflection;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // Refactored for Problem 4
        private string InterpredCommand(string[] data, string commandName)
        {

            Type commandType = Type.GetType($"_03BarracksFactory.Data.{commandName}", false, true);
            if (commandType == null || !typeof(Command).IsAssignableFrom(commandType))
            {
                throw new InvalidOperationException("Invalid command!");
            }
            ConstructorInfo constructor = commandType.GetConstructor(new Type[] { typeof(string), typeof(IRepository), typeof(IUnitFactory) });
            if (constructor != null)
            {
                Command command = (Command)constructor.Invoke(new object[] { data, this.repository, this.unitFactory });
                return command.Execute();
            }
            throw new NullReferenceException("Something went wrong");
        }
    }
}
