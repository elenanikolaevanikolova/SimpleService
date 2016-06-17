using System.ServiceModel;
using System.ServiceModel.Web;

namespace SimpleService
{
    [ServiceContract]
    public interface ISimpleService
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "/MultiplyByTen/{number}",
                           RequestFormat = WebMessageFormat.Xml,
                           BodyStyle = WebMessageBodyStyle.Wrapped)]
        int MultiplyByTen(string number);

    }


}
