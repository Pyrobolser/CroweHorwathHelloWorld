namespace HelloWorld.API
{
    /// <summary>
    /// Message provider interface.
    /// </summary>
    public interface IMessageProvider
    {
        /// <summary>
        /// Get the message returned by the provider.
        /// </summary>
        /// <returns>The message.</returns>
        string GetMessage();
    }
}
