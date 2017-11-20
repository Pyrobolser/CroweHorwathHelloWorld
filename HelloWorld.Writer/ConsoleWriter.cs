using System;

namespace HelloWorld.Writer
{
    /// <summary>
    /// <see cref="MessageWriter"/> using the standard console output.
    /// </summary>
    public class ConsoleWriter : MessageWriter
    {
        /// <summary>
        /// Write the given <paramref name="message"/> into the console.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public override void Write(string message) => Console.WriteLine(message);
    }
}
