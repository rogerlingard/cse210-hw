class GoalList {
    private List<Goals> _goalList;

    public GoalList(){
        _goalList = new();
    }

    public void addGoal(Goals goal){
        _goalList.Add(goal);
    }

    public void displayGoals(){
        Console.WriteLine("The goals are:");

        for (int i = 0; i < _goalList.Count; i++){
            Console.WriteLine("The goals are:");
            _goalList[i].displayGoals();

        }
    }
}