using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using UAParser;
using Microsoft.Extensions.DependencyInjection;
using Exam_answerWeb.Models;

namespace Exam_answerWeb.Extensions
{
    public static class HttpContextExtensions
    {
        public static bool IsMobileBrowser(this HttpContext httpContext)
        {
            // Do not use this. Amp cache can (will) load html without caring if it is a mobile or desktop.
            // As a result a desktop version will be shown on mobile device.
            return false;
            bool result = true;

            if (httpContext?.Request?.Headers?.ContainsKey("User-Agent") == true)
            {
                string uaString = httpContext.Request.Headers["User-Agent"].ToString();

                // get a parser with the embedded regex patterns
                Parser uaParser = Parser.GetDefault();

                // get a parser using externally supplied yaml definitions
                // var uaParser = Parser.FromYaml(yamlString);

                ClientInfo c = uaParser.Parse(uaString);

                if (c?.UA?.Family?.Contains("Mobile", StringComparison.InvariantCultureIgnoreCase) != true)
                {
                    result = false;
                }
            }

            return result;
                 
        }

        public static EaImageViewModel GetPngSize(this HttpContext httpContext, string fileName)
        {
            EaImageViewModel eaImageViewModel = new EaImageViewModel();
            var env = httpContext.RequestServices.GetService<IWebHostEnvironment>();

            var files = Directory.GetFiles(env.ContentRootPath, "*.png", SearchOption.AllDirectories);
            var filePath = files.FirstOrDefault(f => f.Contains(fileName, StringComparison.InvariantCultureIgnoreCase));
            using BinaryReader br = new BinaryReader(File.OpenRead(filePath));
            br.BaseStream.Position = 16;
            byte[] widthbytes = new byte[sizeof(int)];
            for (int i = 0; i < sizeof(int); i++) widthbytes[sizeof(int) - 1 - i] = br.ReadByte();
            int width = BitConverter.ToInt32(widthbytes, 0);
            byte[] heightbytes = new byte[sizeof(int)];
            for (int i = 0; i < sizeof(int); i++) heightbytes[sizeof(int) - 1 - i] = br.ReadByte();
            int height = BitConverter.ToInt32(heightbytes, 0);
            eaImageViewModel.Size = new Size(width, height);
            eaImageViewModel.RelativePathFromWwwRoot = filePath
                .Replace(env.ContentRootPath, string.Empty)
                .Replace("\\", "/")
                .Replace("/wwwroot", string.Empty)
                .ToLowerInvariant();

            return eaImageViewModel;
        }


        /*
         * BinaryReader br = new BinaryReader(File.OpenRead("az-301-q1.PNG"));
            br.BaseStream.Position = 16;
            byte[] widthbytes = new byte[sizeof(int)];
            for (int i = 0; i < sizeof(int); i++) widthbytes[sizeof(int) - 1 - i] = br.ReadByte();
            int width = BitConverter.ToInt32(widthbytes, 0);
            byte[] heightbytes = new byte[sizeof(int)];
            for (int i = 0; i < sizeof(int); i++) heightbytes[sizeof(int) - 1 - i] = br.ReadByte();
            int height = BitConverter.ToInt32(heightbytes, 0);
         */
    }
}
