using System.ComponentModel;
using System.Net.Sockets;

abstract class  Event {
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address){
        setEventTitle(title);
        setDescription(description);
        setDate(date);
        setTime(time);
        setAddress(address);
    }

    public Address getAddress(){
        return _address;
    }
    public void setAddress(Address address){
        _address = address;
    }

    public void setTime(string time){
        _time = time;
    }
    public string getTime(){
        return _time;
    }
    
    public void setDate(string date){
        _date = date;
    }
    public string getDate(){
        return _date;
    }

    public void setDescription(string descrption){
        _description = descrption;
    }
    public string getDescription(){
        return _description;
    }

    public void setEventTitle(string eventTitle){
        _eventTitle = eventTitle;

    }
    public string getEventTitle(){
        return _eventTitle;
    }

    public string standardDetails(){
        return $"Title: {getEventTitle()}\nDescrption: {getDescription()}\nDate: {getDate()} Time: {getTime()}\nAddress: {getAddress().fullAddress()}";
    }
    public virtual string fullDetails(){
        return $"{standardDetails()}";

    }
    public virtual string shortDecription(){
        return $"Event: event\nTitle: {getEventTitle()}\nDate: {getDate()}";
    }

}