public class Comment {
    public string _commenter;
    public string _commentText;


    public void displayComment(){
        Console.WriteLine($"Commenter: {_commenter}");
        Console.WriteLine($"Commnet: {_commentText}");
        Console.WriteLine();
    }
}