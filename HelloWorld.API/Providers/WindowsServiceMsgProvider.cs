namespace HelloWorld.API.Providers
{
    /// <summary>
    /// Implementation of the <see cref="IMessageProvider"/> interface for a Windows service.
    /// </summary>
    public class WindowsServiceMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Return the message from a Windows service.
        /// </summary>
        /// <returns>Returns the message from the Windows service.</returns>
        public string GetMessage() => throw new System.NotImplementedException();
    }
}