using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Filter
{
    public class ExceptionFilterAttribute : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string errorMessage = $"\n\n***** {DateTime.Now} ******\n\n{context.Exception.Message}\n\n{context.Exception.InnerException?.Message}\n\n{context.Exception.StackTrace}";
            System.IO.File.AppendAllText("fellogg.txt", errorMessage);
        }
    }



    // Lägg in i Startup.cs:

   

}
