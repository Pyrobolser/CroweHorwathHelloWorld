namespace HelloWorld.Writer
{
    /// <summary>
    /// <see cref="MessageWriter"/> using a database.
    /// </summary>
    public class DatabaseWriter : MessageWriter
    {
        /// <summary>
        /// Write the given <paramref name="message"/> into the database.
        /// </summary>
        /// <param name="message">The message to write.</param>
        public override void Write(string message) => throw new System.NotImplementedException();
    }
}
