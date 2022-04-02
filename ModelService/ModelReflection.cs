using System;

namespace fekon_repository_datamodel.ModelService
{
    public class ModelReflection
    {
        public Type GetTypeOfModel(string name)
        {
            Type t = Type.GetType($"fekon_repository_datamodel.Models.{name}");
            return t;
        }
    }
}
