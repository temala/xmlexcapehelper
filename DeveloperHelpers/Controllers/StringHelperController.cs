using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Iterator;
using Helpers.String.Modifiers;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperHelpers
{
    [ApiController]
    public class StringHelperController : ControllerBase
    {
        private readonly StringModifierCollection modifiers = new StringModifierCollection();
        
        [HttpPost]
        [Route("api/StringHelper/Process", Name = nameof(ProcessString))]
        public async Task<ActionResult<string>> ProcessString()
        {
            var source = await ReadBody();

            for (var i = 0; i < modifiers.Count; i++)
            {
                source = modifiers[i, source];
            }

            return source;
        }

        private async Task<string> ReadBody()
        {
            using var reader = new StreamReader(Request.Body, Encoding.UTF8);

            var source = await reader.ReadToEndAsync()
                .ConfigureAwait(false);
            return source;
        }
    }
}