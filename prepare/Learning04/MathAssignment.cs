class MathAssignment : Assignment {
    string _textBookSection;
    string _problems;

     public MathAssignment(string name, string topic, string problems,  string textBookSection) : base(name, topic) {
      _problems = problems;
      _textBookSection = textBookSection;       


     }
     public string getProblem(){
        return _problems;
     }
     public void setProblem(string problem){
      _problems = problem;

     }

     public string getTextBook(){
        return _textBookSection;
     }

    public void setTextBook(string textBook){
        _textBookSection = textBook;
    }

    public string GetHomeworkList(){
      string student_name = GetSummary();
      return student_name + $"\n{_textBookSection} {_problems}";

    }

}