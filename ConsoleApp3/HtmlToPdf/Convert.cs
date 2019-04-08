using iText.Html2pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlToPdf
{
  public static class Convertor
  {
    public static string Html(string stringHtml, string outPut)
    {
      if(!string.IsNullOrEmpty(outPut))
      {
        var name = Guid.NewGuid() + "_To_stream.pdf";
        FileStream to_stream = new FileStream(outPut + name, FileMode.CreateNew);
        HtmlConverter.ConvertToPdf(stringHtml, to_stream);
        return name;
      }
      return null;
    }
  }
}
