namespace HelloWorld.API.Providers
{
    /// <summary>
    /// Implementation of the <see cref="IMessageProvider"/> interface for a mobile application.
    /// </summary>
    public class MobileAppMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Return the message from a mobile application.
        /// </summary>
        /// <returns>Returns the message from the mobile application.</returns>
        public string GetMessage() => throw new System.NotImplementedException();
    }
}