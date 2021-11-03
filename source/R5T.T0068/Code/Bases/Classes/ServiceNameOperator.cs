using System;


namespace R5T.T0068
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceNameOperator : IServiceNameOperator
    {
        #region Static
        
        public static ServiceNameOperator Instance { get; } = new();

        #endregion
    }
}