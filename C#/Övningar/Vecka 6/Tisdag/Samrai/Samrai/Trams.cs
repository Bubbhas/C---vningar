using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samrai
{
    class Trams
    {
        public class MyLoggerProvider : ILoggerProvider
        {
            public ILogger CreateLogger(string categoryName)
            {
                return new MyLogger();
            }

            public void Dispose()
            {
            }

            private class MyLogger : ILogger
            {

                public bool IsEnabled(LogLevel logLevel)
                {
                    return true;
                }

                public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception,
                  Func<TState, Exception, string> formatter)
                {
                    if (eventId.Name == "Microsoft.EntityFrameworkCore.Database.Command.CommandExecuting")
                    {
                        Console.WriteLine(formatter(state, exception));
                        Console.WriteLine();
                    }
                }

                public IDisposable BeginScope<TState>(TState state)
                {
                    return null;
                }
            }
        }
    }
}
