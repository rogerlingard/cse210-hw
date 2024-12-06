class Lecture : Event{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title,  description,  date,  time,  address){
        setSpeaker(speaker);
        setCapacity(capacity);

    }
    public void setSpeaker(string speaker){
        _speaker = speaker;
    }
    public string getSpeaker(){
        return _speaker;
    }

    public void setCapacity(int capacity){
        _capacity = capacity;
    }
    public int getCapacity(){
        return _capacity;
    }

    public override string fullDetails(){
        return $"{standardDetails()}\nEvent Specific:\n\nSpeaker Name: {getSpeaker()}\n Capacity: {getCapacity()}";
    }
    public override string shortDecription()
    {
        return $"Event Type: Lecture\nTitle: {getEventTitle()}\nDate: {getDate()}";
    }
}