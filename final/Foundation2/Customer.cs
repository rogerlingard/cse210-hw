using System.Dynamic;
using System.Runtime.InteropServices;

public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, Address address){
        setAddress(address);
        setName(name);
    }

    public void setName(string name){
        _name = name;
    }
    public string getName(){
        return _name;
    }

    public void setAddress(Address address){
        _address = address;
    }
    public Address getAddress(){
        return _address;
    }

    public bool inUSA(){
        return getAddress().inUSA();
    }
}