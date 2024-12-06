using System.Dynamic;

public class Address{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public Address(string address, string city, string stateOrProvince, string country){
        setAddress(address);
        setCity(city);
        setStateOrProvince(stateOrProvince);
        setCountry(country);
    }

    public string getAddress(){
        return _streetAddress;

    }
    public void setAddress(string address){
        _streetAddress = address;
    }
    public string getCity(){
        return _city;
    }
    public void setCity(string city){
        _city = city;
    }
    public string getStateOrProvince(){
        return _stateOrProvince;
    }
    public void setStateOrProvince(string stateOrProvince){
        _stateOrProvince = stateOrProvince;
    }

    public string getCountry(){
        return _country;
    }   

    public void setCountry(string country){
        _country = country;
    }

    public bool inUSA(){
        if(getCountry() == "USA" || getCountry() == "United States of America"){
            return true;
        }
        else return false;
    }

    public string fullAddress(){
        return $"{getAddress()}, \n{getCity()}, {getStateOrProvince()},\n{getCountry()}";
    }
}