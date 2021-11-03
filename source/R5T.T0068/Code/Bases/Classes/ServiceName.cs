using System;


namespace R5T.T0068
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class ServiceName : IServiceName
    {
        #region Static
        
        public static ServiceName Instance { get; } = new();

        #endregion
    }
}