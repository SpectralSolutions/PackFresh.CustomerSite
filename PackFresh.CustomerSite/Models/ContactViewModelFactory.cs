using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackFresh.CustomerSite.Models
{
    public class ContactViewModelFactory
    {
        public Contact generateContactFromCreateContactViewModel(Contact model)
        {
            Contact returnValue = new Contact();

            returnValue.Name = model.Name;
            returnValue.Email = model.Email;
            returnValue.Phone = model.Phone;
            returnValue.Name = model.Name;
            returnValue.Subject = model.Subject;
            returnValue.Message = model.Message;

            return returnValue;
        }

    }
}
