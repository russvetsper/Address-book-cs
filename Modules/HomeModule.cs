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
    }
  }
}
