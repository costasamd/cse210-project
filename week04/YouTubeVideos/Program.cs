using System;

class Program
{
    static void Main(string[] args)
    {
        //create instances of the classes

        Video vid1 = new Video();
        Video vid2 = new Video();
        Video vid3 = new Video();

        Comment comment1a = new Comment();
        Comment comment1b = new Comment();
        Comment comment1c = new Comment();
        Comment comment1d = new Comment();

        Comment comment2a = new Comment();
        Comment comment2b = new Comment();
        Comment comment2c = new Comment();

        Comment comment3a = new Comment();
        Comment comment3b = new Comment();
        Comment comment3c = new Comment();

        //fill the intance 1 with information and then reapeat the process to the other 2

        vid1._author = "Sam";
        vid1._title = "Biceps Curl";
        vid1._length = 90;

        comment1a._name = "Tom";
        comment1a._comment = "This is my favorite exercise, video has some good advice in it"; ;
        comment1b._name = "Jess";
        comment1b._comment = "I don't like how you explain things, you need use a better sound record as well";
        comment1c._name = "Theo";
        comment1c._comment = "Can you show different ways to train your biceps? I don't have dumbbells and I train at home";
        comment1d._name = "annonimous";
        comment1d._comment = "Your video is lame, there are loads of videos about exercise better than yours";


        vid1.AddComment(comment1a);
        vid1.AddComment(comment1b);
        vid1.AddComment(comment1c);
        vid1.AddComment(comment1d);
        //--------------------Video 2-------------------------------------------------------------
        vid2._author = "Veronica";
        vid2._title = "10 most used spanish words";
        vid2._length = 180;

        comment2a._name = "Mark";
        comment2a._comment = "Love your content, I am really learning something new every video"; ;
        comment2b._name = "Jacob";
        comment2b._comment = "Teach us some spanish words to flirt as well";
        comment2c._name = "Catherine";
        comment2c._comment = "Love it, but woud like to know how to put this words in sentences, also I am a newbie so needs to be easy to understand";

        vid2.AddComment(comment2a);
        vid2.AddComment(comment2b);
        vid2.AddComment(comment2c);

        //-------------------Video 3--------------------------------------------------------------------------

        vid3._author = "David";
        vid3._title = "Football - air control, tips and tricks";
        vid3._length = 300;

        comment3a._name = "Jack";
        comment3a._comment = "I really enjoy following your tutorials, getting better skills since I started"; ;
        comment3b._name = "Daniel";
        comment3b._comment = "I don't like air control, I always struggle with it, but I will give a go to your tricks.";
        comment3c._name = "Zac";
        comment3c._comment = "This is a really hard skill, you make look so easy.";

        vid3.AddComment(comment3a);
        vid3.AddComment(comment3b);
        vid3.AddComment(comment3c);

        //Add the videos to a list of videos and then iterates through the list to display 
        //the information about the video and it's comments

        List<Video> videos = new List<Video>();

        videos.Add(vid1);
        videos.Add(vid2);
        videos.Add(vid3);

        foreach (Video v in videos)
        {
            v.Display();
        }
    
    }
}