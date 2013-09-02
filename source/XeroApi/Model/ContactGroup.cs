using System;
using XeroApi.Interface;

namespace XeroApi.Model
{

    public class ContactGroup : ModelBase, IDsoContactGroup
    {
        public Guid ContactGroupID { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public IDsoContacts Contacts { get; set; }
    }
}