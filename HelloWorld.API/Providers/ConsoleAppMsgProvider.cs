namespace HelloWorld.API.Providers
{
    /// <summary>
    /// Implementation of the <see cref="IMessageProvider"/> interface for a console application.
    /// </summary>
    public class ConsoleAppMsgProvider : IMessageProvider
    {
        /// <summary>
        /// Return the message from a console application.
        /// </summary>
        /// <returns>Returns the message from the console application.</returns>
        public string GetMessage() => throw new System.NotImplementedException();
    }
}