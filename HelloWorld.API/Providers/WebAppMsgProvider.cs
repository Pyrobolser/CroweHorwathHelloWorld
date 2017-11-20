namespace HelloWorld.API.Providers
{
    /// <summary>
    /// Implementation of the <see cref="IMessageProvider"/> interface for a web application.
    /// </summary>
    public class WebAppMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Return the message from a web application.
        /// </summary>
        /// <returns>Returns the message from the web application.</returns>
        public string GetMessage() => throw new System.NotImplementedException();
    }
}