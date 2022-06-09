using System;

using R5T.T0068;

using Instances = R5T.T0068.X001.Instances;


namespace System
{
    public static class IServiceNameOperatorExtensions
    {
        public static string GetServiceDefinitionInterfaceTypeName(this IServiceNameOperator _,
            string serviceNameStem)
        {
            var output = $"{Instances.TypeNameAffix.InterfacePrefix()}{serviceNameStem}";
            return output;
        }

        public static string GetServiceImplementationClassTypeName(this IServiceNameOperator _,
            string serviceNameStem)
        {
            // Just the service name stem.
            var output = serviceNameStem;
            return output;
        }

        /// <summary>
        /// Appends the provider suffix to the service name stem to get a provider service name stem.
        /// </summary>
        public static string GetProviderServiceNameStem(this IServiceNameOperator _,
            string serviceNameStem)
        {
            var output = serviceNameStem + Instances.TypeNameAffix.ProviderSuffix();
            return output;
        }

        /// <summary>
        /// The service name stem is the same as a class name.
        /// </summary>
        public static string GetServiceNameStem_FromClassTypeName(this IServiceNameOperator _,
            string className)
        {
            return className;
        }
    }
}
