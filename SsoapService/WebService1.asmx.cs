using SsoapService.Dtos;
using System.Web.Services;

namespace SsoapService
{
    /// <summary>
    /// WebService1 の概要の説明です
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // この Web サービスを、スクリプトから ASP.NET AJAX を使用して呼び出せるようにするには、次の行のコメントを解除します。
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public ParameterDto Search(ParameterDto inParameter)
        {
            var outParameter = new ParameterDto
            {
                id = inParameter.id,
                outputDto = new OutputDto
                {
                    output1 = inParameter.outputDto.output1,
                    output2 = inParameter.outputDto.output2
                }
            };
            return outParameter;
        }
    }
}
