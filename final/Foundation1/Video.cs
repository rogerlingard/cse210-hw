using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

public class Video{
    public string _title;
    public string _author;
    public TimeSpan _videoLength;
    public List<Comment> _videoComment;

    public void displayVideo(){
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_videoLength}");
        Console.WriteLine($"Number of Comments: {commentTotal()} ");
        Console.WriteLine("Comments \n------- \n");
    
        foreach(Comment comment in _videoComment){
            comment.displayComment();
        }

    }
    public int commentTotal(){
        int total = 0;

        foreach(Comment comment in _videoComment){
            total += 1;
        }

        return total;
    }
}