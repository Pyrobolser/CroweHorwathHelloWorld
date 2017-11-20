namespace HelloWorld.Writer
{
    /// <summary>
    /// Abstract message writer class to inherit.
    /// </summary>
    public abstract class MessageWriter
    {
        /// <summary>
        /// Return the chosen <see cref="MessageWriter"./>
        /// </summary>
        /// <param name="messageWriter">The desired writer.</param>
        /// <returns>The inherited <see cref="MessageWriter"/>.</returns>
        public static MessageWriter GetMessageWriter(string messageWriter)
        {
            switch(messageWriter)
            {
                case "Console":
                    return new ConsoleWriter();
                case "Database":
                    return new DatabaseWriter();
                default:
                    return new ConsoleWriter();
            }
        }
        /// <summary>
        /// Write the given <paramref name="message"/> into the desired output.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public abstract void Write(string message);
    }
}
