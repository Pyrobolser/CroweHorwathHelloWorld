# CroweHorwathHelloWorld
'Hello World' program for the Crowe Horwath technical assignment.

## Instructions 
Write a ‘Hello World’ program.
1.  The program has 1 current business requirement – write “Hello World” to
the console/screen.
2. The program should have an API that is separated from the program logic
to eventually support mobile applications, web applications, or console
applications, or windows services.
3. The program should support future enhancements for writing to a
database, console application, etc.
   - Use common design patterns (inheritance, e.g.) to account for
these future concerns.  
   - Use configuration files or another industry-standard mechanism for
determining where to write the information to.
Write unit tests to support the API.  

## Explanations
* **HelloWorld.API** - I imagined this API as a library created to get a message from different possible sources. 
I used an interface that is implemented inside the library in some common providers examples.
It is now fully possible to extend the library from the outside if someone doesn't have access to its code for example.
* **HelloWorld.API.UnitTest** - It is the UnitTest class for the API. I use it to test the common providers correct implementation.
As of today's requirements, only the *StaticValueMsgProvider* should be correctly implemented and passing the test.
The other classes should return a *NotImplementedException*.
* **HelloWorld.Client** - The client is the core of the application, yet it should be only dedicated to getting a message from a provider
and putting it somewhere else. I used two different ways to configure it. I configure which writer to choose with the *App.config* file
and I configure which message provider to choose with an enumeration. Those differents choices have pros and cons that will be discussed with the team.
* **HelloWorld.Writer** - The writer is a library, contrary to the API, I used here an abstract class which is then inherited by the ConsoleWriter and the DatabaseWriter class.
