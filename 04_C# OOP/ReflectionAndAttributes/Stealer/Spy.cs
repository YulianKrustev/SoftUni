using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;


    public class Spy
    {
        public string StealFieldInfo(string name, params string[] fieldsToInvestigate)
        {

            Type classType = Type.GetType(name);
            FieldInfo[] classFields = classType.GetFields
                (BindingFlags.Instance | BindingFlags.Static
            | BindingFlags.NonPublic | BindingFlags.Public);

            StringBuilder builder = new StringBuilder();

            Object classInstance = Activator.CreateInstance(classType, new object[] { });

            builder.AppendLine($"Class under investigation: {name}");

            foreach (FieldInfo field in classFields.Where(f => fieldsToInvestigate.Contains(f.Name)))
            {
                builder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
            }

            return builder.ToString().Trim();



        }
    }
