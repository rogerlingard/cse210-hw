    using System.Reflection.Metadata;
    using System.IO;

    class GoalList {
        private List<Goals> _goalList;

        private int _totalPoints;

        public GoalList(){
            _goalList = new();
        }

        public void addGoal(Goals goal){
            _goalList.Add(goal);
        }
        public List<Goals> getGoalList(){
            return _goalList; 
        }



        public void displayGoals(){
            for (int i = 0; i < _goalList.Count; i++){
                Console.Write($"{i + 1}. ");
                _goalList[i].displayGoals();

            }
        }

        public void completeGoal(){
            for (int i = 0; i < _goalList.Count; i++){
                Console.WriteLine($"{i + 1}. {_goalList[i].getGoalName()}");
            }
            
            Console.Write("Which goal did you accomplish? ");
            int goalChoice = int.Parse(Console.ReadLine()) - 1;

            

            if (goalChoice >= 0 && goalChoice < _goalList.Count){

                Goals goal = _goalList[goalChoice];

                if(goal is Checklist checklist){

                    checklist.setAmountOfTimesDone(checklist.getAmountOfTimesDone() + 1);
                    if(checklist.getAmountOfTimesDone() == checklist.getHowMuchItNeedsToBeDone()){

                        checklist.setPoints(checklist.getPoints() + checklist.getBonusPoints());   
                        setTotalPoint(_goalList[goalChoice].getPoints() + getTotalPoint());


                        Console.WriteLine($"Congratulations! You have earned {checklist.getPoints()} points!");
                        Console.WriteLine();
                        Console.WriteLine($"You now have {getTotalPoint()} points.");
                        Console.WriteLine();
                        Console.WriteLine($"You have {getTotalPoint()} points.");
                        Console.WriteLine();             
                        checklist.setComplete(true);
                    }
                    else if(checklist.getCompleted()){

                        Console.WriteLine("This goal is already completed.");
                        Console.WriteLine();

                    }
                    else{
                        setTotalPoint(_goalList[goalChoice].getPoints() + getTotalPoint()); 
                                            Console.WriteLine($"Congratulations! You have earned {checklist.getPoints()} points!");
                        Console.WriteLine();
                        Console.WriteLine($"You now have {getTotalPoint()} points.");
                        Console.WriteLine();
                        Console.WriteLine($"You have {getTotalPoint()} points.");
                        Console.WriteLine();                           

                    }

                    
                }
                else{
                
                goal.setComplete(true);
            setTotalPoint(_goalList[goalChoice].getPoints() + getTotalPoint());
                    
                    Console.WriteLine($"Congratulations! You have earned {goal.getPoints()} points!");
                    Console.WriteLine();
                    Console.WriteLine($"You now have {getTotalPoint()} points.");
                    Console.WriteLine();
                    Console.WriteLine($"You have {getTotalPoint()} points.");
                    Console.WriteLine();
                    }
            }
            else {
                Console.WriteLine("This goal is already completed.");
            }
        }



        public void setTotalPoint(int totalPoint){
            _totalPoints = totalPoint;
        }
        public int getTotalPoint(){
            return _totalPoints;
        }

        public int readPoints(){
            int totalPoints = 0;
            for (int i = 0; i < _goalList.Count; i++){
                if(_goalList[i].getCompleted()){
                    totalPoints +=_goalList[i].getPoints();
                }                        
            }
            return totalPoints;
        }

        public void goalWrite(){

            Console.WriteLine();
            Console.Write("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();

            using(StreamWriter outputFile  = new(fileName)){
                
                outputFile.WriteLine($"{getTotalPoint()}");
                foreach(Goals goal in getGoalList()){
                    outputFile.WriteLine($"{goal.writeGoal()}");
                
                }
            }
        }

        public void goalRead(){
            Console.WriteLine();
            Console.Write("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(fileName);

            _goalList.Clear();


            
            if (lines.Length > 0){
                setTotalPoint(int.Parse(lines[0]));
            }

            for(int i = 1; i < lines.Length; i++){
                string[] header = lines[i].Split(":");
                string goalType = header[0];
                string goalInfo = header[1];
                string[] parts = goalInfo.Split(",");

                if(goalType == "ChecklistGoal"){
                    Checklist goal = new(); 
                    goal.setGoalName(parts[0]);
                    goal.setDescription(parts[1]);
                    goal.setPoints(int.Parse(parts[2]));
                    goal.setBonusPoints(int.Parse(parts[3]));
                    goal.setHowMuchItNeedsToBeDone(int.Parse(parts[4]));
                    goal.setAmountOfTimesDone(int.Parse(parts[5]));

                    _goalList.Add(goal);
                }
                else if(goalType == "EternalGoal"){
                    Eternal goal = new();
                    goal.setGoalName(parts[0]);
                    goal.setDescription(parts[1]);
                    goal.setPoints(int.Parse(parts[2]));
                    
                    _goalList.Add(goal);
                }
                else if(goalType == "SimpleGoal"){
                    Simple goal = new();

                    goal.setGoalName(parts[0]);
                    goal.setDescription(parts[1]);
                    goal.setPoints(int.Parse(parts[2]));
                    goal.setComplete(bool.Parse(parts[3]));
                    
                    _goalList.Add(goal);
                }
                
                
            }

            
            
        }

    }