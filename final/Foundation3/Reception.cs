class Reception : Event {
    private string _RSVP;


    public Reception(string title, string description, string date, string time, Address address, string RSVP) : base(title,  description,  date,  time,  address){
        setRSVP(RSVP);
    }
    public void setRSVP(string RSVP){
        _RSVP = RSVP;
    }
    public string getRSVP(){
        return _RSVP;
    }

    public override string fullDetails(){
        return $"{standardDetails()}\nEvent Specific:\nEmail: {getRSVP()}";
    }
    public override string shortDecription()
    {
        return $"Event Type: Reception\nTitle: {getEventTitle()}\nDate: {getDate()}";
    }

}