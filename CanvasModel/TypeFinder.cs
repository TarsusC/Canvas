using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CanvasModel.Colors;
using CanvasModel.Figures;

namespace CanvasModel
{
    /// <summary>
    /// Поиск типов фигур и цвета
    /// в ткущей библиотеке.
    /// Создание экземпляров таких типов.
    /// </summary>
   public static class TypeFinder 
    {
        /// <summary>
        /// Получение списка имен 
        /// экземпляров типа Т по свойству Name типа Т.
        /// </summary>
        public static List<string> GetNames<T>(List<T> instances) where T : ICast
        {
            return (from ins in instances
                    select ins.Name ).ToList();
        }

        /// <summary>
        /// Поиск и создание экземпляров
        /// заданого типа Т.
        /// </summary>
        public static List<T> CreateInstances<T>() where T : ICast
        {
            List<T> instances = new List<T>();
            var getInstances = (from type in Assembly.GetExecutingAssembly().GetTypes()
                                where type.IsClass && typeof(T).GetTypeInfo().IsAssignableFrom(type.GetTypeInfo())
                                select Activator.CreateInstance(type)).ToList();

            foreach (var item in getInstances)
            {
                instances.Add((T)item); ;
            }

            return instances;
        }
    }
}
