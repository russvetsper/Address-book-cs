using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Get["/new_contact_add"] = _ => {
        return View["new_contact_add.cshtml"];
      };
      Get["/view_all_contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        return View["view_all_contacts.cshtml",allContacts];
      };

      Get["/new_contact"] = _ => {
        return View["new_contact.cshtml"];
      };


      Get["/contact/{id}"] = parameters => {
        Contact oneContact = Contact.find(parameters.id);
        return View["contact.cshtml",oneContact];
      };


      Post["/new_contact_add"] = _ => {
       Contact newContact = new Contact(
       Request.Form["contact-fullName"],
       Request.Form["contact-phoneNumber"],
       Request.Form["contact-address"],
       Request.Form["contact-city"],
       Request.Form["contact-state"]);
        return View["new_contact_add.cshtml", newContact];
      };

      Post["/clear_contacts"] = _ => {
        Contact.ClearAll();
        return View["clear_contacts.cshtml"];
      };
    }
  }
}
