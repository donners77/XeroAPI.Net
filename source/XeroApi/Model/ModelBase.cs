using System.Collections.Generic;
using System.Xml.Serialization;
using XeroApi.Interface;

namespace XeroApi.Model
{
    public abstract class ModelBase : IModelBase
    {
        [XmlAttribute("status")]
        public EValidationStatus ValidationStatus 
        { 
            get; 
            set; 
        }

        public IList<RValidationError> ValidationErrors
        { 
            get;
            set;
        }
        
        public IList<RWarning> Warnings
        {
            get; 
            set;
        }
    }
}
