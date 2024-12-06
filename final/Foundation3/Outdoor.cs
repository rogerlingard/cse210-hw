using System.Security.Cryptography.X509Certificates;

class Outdoor : Event {
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title,  description,  date,  time,  address){
        
    }

    public void setWeather(string weather){
        _weather = weather;
    }
    public string getWeather(){
        return _weather;
    }

    public override string fullDetails(){
        return $"{standardDetails()}\nEvent Specific:\n\nWeather: {getWeather()}";
    }
    public override string shortDecription()
    {
        return $"Event Type: Outdoor\nTitle: {getEventTitle()}\nDate: {getDate()}";
    }
}