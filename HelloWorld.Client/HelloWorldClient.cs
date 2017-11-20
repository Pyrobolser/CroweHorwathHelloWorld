using HelloWorld.API;
using HelloWorld.Writer;
using System.Configuration;

namespace HelloWorld.Client
{
    /// <summary>
    /// Hello World client for the Crowe Horwath technical assignment. 
    /// </summary>
    public class Program
    {
        private static IMessageProvider messageProviderService;
        private static MessageProviderServiceLocator msgProviderServiceLocator = new MessageProviderServiceLocator();
        private static MessageWriter messageWriter;

        /// <summary>
        /// Client entry point.
        /// </summary>
        /// <param name="args">The console arguments.</param>
        public static void Main(string[] args)
        {
            messageProviderService = msgProviderServiceLocator.LocateMessageService(MsgProviderServiceType.StaticValue);
            messageWriter = MessageWriter.GetMessageWriter(ConfigurationManager.AppSettings["MessageWriter"]);

            var message = messageProviderService.GetMessage();
            messageWriter.Write(message);
        }
    }
}
