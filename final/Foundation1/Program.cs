using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video("Cat Memes", "short humorus clips of cats", 184);
        Video v2 = new Video("Cat Memes vol 2", "more short humorus clips of cats", 184);
        Video v3 = new Video("Windows Repair Aid", "Long walkthrough of fixing your device", 25324);

        Comment c1 = new Comment("Bob","first comment!");
        Comment c2 = new Comment("Mike","first comment!");
        Comment c3 = new Comment("Josh","You cant both have first comment");
        Comment c4 = new Comment("Jake","Very funny!");

        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);
        v1.AddComment(c4);

        Comment c21 = new Comment("Bob","first comment again!");
        Comment c22 = new Comment("Jake","I liked the first one.");
        Comment c23 = new Comment("Mike","Beware Evil Larry");

        v2.AddComment(c21);
        v2.AddComment(c22);
        v2.AddComment(c23);

        Comment c31 = new Comment("Bob","Needed this!");
        Comment c32 = new Comment("Jake","It still dosent work.");
        Comment c33 = new Comment("Mike","Does this work on Mac?");
        Comment c34 = new Comment("Josh","Please watch my video.");

        v3.AddComment(c31);
        v3.AddComment(c32);
        v3.AddComment(c33);
        v3.AddComment(c34);

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach(Video video in videos)
        {
            video.Display();
        }
    }
}