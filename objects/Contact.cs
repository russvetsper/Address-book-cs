using System.Collection.Generic;

namespace Addressbook.objects
{
  public class contact
  {
    private string _fullName;
    private string _phoneNumber;
    private string _address;
    private string _city;
    private string _state;

    private int _id;

    private contact(string fullName, string phoneNumber, string address, string city, string state )
    {
      _fullName = fullName;
      _phoneNumber = phoneNumber;
      _address = address;
      _city = city
      _state = state
      _instances.Add(this);
      _id = _instances.Count;
    }

    public string GetFullName()
    {
      return _fullName;
    }
    public void SetFullName(string newFullName)
    {
      _fullName =newFullName;
    }


    public string getPhoneNumber()
    {
      return PhoneNumber
    }
      public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }


    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }


      public string GetCity()
      {
        return _city;
      }
      public void SetCity(string newCity)
      {
        _city = newCity;
      }


      public string GetState()
      {
        return _state;
      }
      public void SetState(string newState)
      {
        _state = newState;
      }

      public static List<Contact> GetAll()
      {
        return _instances
      }
  }
}
