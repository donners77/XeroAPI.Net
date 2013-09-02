using System.Collections.Generic;
using System.Xml.Serialization;
using XeroApi.Model;

namespace XeroApi.Interface
{
    public interface IModelBase
    {
        [XmlAttribute("status")]
        EValidationStatus ValidationStatus { get; set; }

        IList<RValidationError> ValidationErrors { get; set; }
        IList<RWarning> Warnings { get; set; }
    }
}