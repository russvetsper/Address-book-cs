using Nancy;
using Addressbook.objects;
using system.Collection.Generic;

namespace Addressbook
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
      Get["/view_all_contact"] = _ => {
        return View["view_all_contact.cshtml"];
      };

      post["/new_contact"] = _ => {
        return View["new_contact.cshtml"];
      };

      Get["/view_all_contact"] = _ = {
        List<Contact> allContacts = Contact.GetAll();
        return View["view_all_contact.cshtml", allContacts];
      };

      Get["/contact/{id}"] = parameters => {
        Contact oneContact = Contact.Find(parameters.id);
        return View["contact.cshtml",oneContact];
      };


      Post["/new_contact_add"] = _ => {
       Contact newContact = new Contact
       ( Request.Form["contact-fullName"],
         Request.Form["contact-phoneNumber"],
         Request.Form["contact-address1"],
         Request.Form["contact-city"],
         Request.Form["contact-state"]);
        return View["new_contact_add.cshtml", newContact];
      };
    }
  }
}
