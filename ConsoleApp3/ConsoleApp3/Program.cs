using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using IronPdf;
using System.Net;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;
using System.Web;

//using PdfSharp;
//using PdfSharp.Drawing;
//using PdfSharp.Pdf;
//using PdfSharp.Pdf.IO;

using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using iTextSharp.text.html;
using iText.Html2pdf;
using HtmlToPdf;
using System.Reflection;
using System.Text.RegularExpressions;

namespace ConsoleApp3
{
  class Program
  {

    static void Main(string[] args)
    {
      var exePath = Path.GetDirectoryName(System.Reflection
                   .Assembly.GetExecutingAssembly().CodeBase);
      Regex appPathMatcher = new Regex(@"(?<!fil)[A-Za-z]:\\+[\S\s]*?(?=\\+bin)");
      var root= appPathMatcher.Match(exePath).Value;
      var output = root + "\\"+ "OutPut\\";
      var templatePath = root + "\\" + "Template.html";
      string html_content = File.ReadAllText(templatePath);

      var name = Convertor.Html(html_content, output);
    }




  }
}
