namespace _03BarracksFactory.Core.Factories
{
    using System;
    using System.Reflection;
    using _03BarracksFactory.Models.Units;
    using Contracts;

    public class UnitFactory : IUnitFactory
    {
        public IUnit CreateUnit(string unitType)
        {
            Type type = Type.GetType($"_03BarracksFactory.Models.Units.{unitType}", false);
            if (type == null || !typeof(IUnit).IsAssignableFrom(type))
            {
                throw new ArgumentException("Unknown type of warrior");
            }
            return (IUnit)type.GetConstructor(BindingFlags.Public | BindingFlags.DeclaredOnly
                | BindingFlags.Instance, Type.EmptyTypes).Invoke(null);

        }
    }
}
