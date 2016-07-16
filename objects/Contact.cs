using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    private string _fullName;
    private string _phoneNumber;
    private string _address;
    private string _city;
    private string _state;
    private static List<Contact> _instances = new List<Contact> {};

    private int _id;

    public Contact(string fullName, string phoneNumber, string address, string city, string state )
    {
      _fullName = fullName;
      _phoneNumber = phoneNumber;
      _address = address;
      _city = city;
      _state = state;
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
      return _phoneNumber;
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
        return _instances;
      }


      public int GetId()
      {
        return _id;
      }

      public static Contact find(int searchId)
      {
        return _instances[searchId -1];
      }
  }
}
