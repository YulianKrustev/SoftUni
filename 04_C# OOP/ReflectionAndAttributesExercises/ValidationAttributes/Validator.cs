namespace ValidationAttributes
{
    using System.Reflection;
    using System.Linq;
    using System.Collections.Generic;

    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] objPropertyies = obj.GetType().GetProperties();

            foreach (var property in objPropertyies)
            {
                IEnumerable<MyValidationAttribute> propertyAtributes = property
                    .GetCustomAttributes()
                    .Where(a => a is MyValidationAttribute)
                    .Cast<MyValidationAttribute>();

                foreach (var propertyAttribute in propertyAtributes)
                {
                    bool result = propertyAttribute.IsValid(property.GetValue(obj));

                    if (!result)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
