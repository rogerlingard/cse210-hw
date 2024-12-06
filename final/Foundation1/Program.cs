using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Comment younderCommentsOne = new();
        Comment younderCommentsTwo = new();
        Comment younderCommentsThree = new();
        Comment younderCommentsFour = new();

        younderCommentsOne._commenter = "Gooberpatrol66";
        younderCommentsOne._commentText = "I really like the direction PBS has been going.";

        younderCommentsTwo._commenter = "darthventor1312";
        younderCommentsTwo._commentText = "I see Coach Z talks like normal, still.";

        younderCommentsThree._commenter = "Crystalluss";
        younderCommentsThree._commentText = "This is unsettlingly addicting to watch.";

        younderCommentsFour._commenter = "Nancy Frye";
        younderCommentsFour._commentText = "I need a blue t-shirt with a \"bend at the knees\" banner...";

        List<Comment> younderComments = new();

        younderComments.Add(younderCommentsOne);
        younderComments.Add(younderCommentsTwo);
        younderComments.Add(younderCommentsThree);
        younderComments.Add(younderCommentsFour);

        Video CharactersFromYounder = new();
        CharactersFromYounder._author = "homestarrunnerdotcom";
        CharactersFromYounder._title = "Characters from Yonder Website";
        CharactersFromYounder._videoLength = TimeSpan.FromMinutes(3) + TimeSpan.FromSeconds(32);
        CharactersFromYounder._videoComment = younderComments;

        Comment DarthSmallOne = new();
        Comment DarthSmallTwo = new();
        Comment DarthSmallThree = new();

        DarthSmallOne._commenter = "hugot99";
        DarthSmallOne._commentText = "Yoda: Ah yes, a worthy opponent I have. Legendary, our battle will be.";

        DarthSmallTwo._commenter = "DocuNamics";
        DarthSmallTwo._commentText = "Now he\'s half the man he\'s always been.";

        DarthSmallThree._commenter = "BaronYoungOfficial";
        DarthSmallThree._commentText = "\"Well Master, it looks like negotiations aren't the only things that are short.\" -Obi-Wan Kenobi, probably.";

        List<Comment> DarthComments = new();

        DarthComments.Add(DarthSmallOne);
        DarthComments.Add(DarthSmallTwo);
        DarthComments.Add(DarthSmallThree);

        Video DarthSmallVideo = new();
        DarthSmallVideo._author = "Janobot";
        DarthSmallVideo._title = "Darth Small";
        DarthSmallVideo._videoLength = TimeSpan.FromSeconds(31);
        DarthSmallVideo._videoComment = DarthComments;

        Comment StatueOne = new();
        Comment StatueTwo = new();
        Comment StatueThree = new();
        Comment StatueFour = new();

        StatueOne._commenter = "cryon7260";
        StatueOne._commentText = "Outstanding band, and this is one of their very best takes.";

        StatueTwo._commenter = "berrypepperroni";
        StatueTwo._commentText = "THE STATUE GOT ME HIIIIIIIIIIIIIIIIIIGH!!!!!!!!!!";

        StatueThree._commenter = "realcoolbreeze";
        StatueThree._commentText = "Great song despite it s simplicity.";

        StatueFour._commenter = "warrenellis1023";
        StatueFour._commentText = "I\'m sure weird Al is a fan";

        List<Comment> StatueComments = new();
        StatueComments.Add(StatueOne);
        StatueComments.Add(StatueTwo);
        StatueComments.Add(StatueThree);
        StatueComments.Add(StatueFour);

        Video StatueVideo = new();
        StatueVideo._author = "RHINO";
        StatueVideo._title = "They Might Be Giants - The Statue Got Me High (Official Music Video)";
        StatueVideo._videoLength = TimeSpan.FromMinutes(3) + TimeSpan.FromSeconds(7);
        StatueVideo._videoComment = StatueComments;


        List<Video> VideoList = new();
        VideoList.Add(CharactersFromYounder);
        VideoList.Add(DarthSmallVideo);
        VideoList.Add(StatueVideo);

        foreach(Video video in VideoList){
            video.displayVideo();
            Console.WriteLine();
        }
        
        




    }
}