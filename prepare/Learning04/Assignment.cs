class Assignment{
    private string _studentName; 
    private string _topic;

    public Assignment(string name, string topic) {
        setStudentName(name);
        setTopic(topic);

    }

    public string getStudentName(){
        return _studentName;
    }
    
    public void setStudentName(string set){
        _studentName = set;
    }

    public string getTopic(){
        return _topic;
    }

    public void setTopic(string set){
        _topic = set;
    }
    public string GetSummary(){

        return _studentName + " - "+ _topic;

    }
}