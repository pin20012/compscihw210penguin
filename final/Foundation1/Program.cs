using System;

class Program
{
    static void Main(string[] args)
    {
        // Video 1
        List<Video> _videoList = new List<Video>();
        List<Comment> _commentList = new List<Comment>();

        // Video 2
        List<Video> _videoList2 = new List<Video>();
        List<Comment> _commentList2 = new List<Comment>();

        // Video 3
        List<Video> _videoList3 = new List<Video>();
        List<Comment> _commentList3 = new List<Comment>();


        // Video 1
        Video video1 = new Video("NCAA week 1 recap", "Michael Jordan", 15);
        _videoList.Add(video1);

        Comment comment1 = new Comment("Jackson Thomas", "Wow! Duke is on fire!");
        _commentList.Add(comment1);

        Comment comment2 = new Comment("Susie Franks", "BYU has been impressive so far");
        _commentList.Add(comment2);

        Comment comment3 = new Comment("Demaryius Zimmer", "March madness has been entertaining");
        _commentList.Add(comment3);

        // This displays the video name along with the details and the comments
        foreach (Video v in _videoList)
        {
            Console.WriteLine();
            v.DisplayVideo();

            int count = 0;

            foreach (Comment c in _commentList)
            {
                c.DisplayCommment();

                count +=1;
            }

            Console.WriteLine($"Number of Comments: {count}");
        }


        // Video 2
        Video video2 = new Video("How to make the best brownies", "Mariah Freeman", 7);
        _videoList2.Add(video2);

        Comment comment4 = new Comment("Tommy fiddlesticks", "I made these myself and they are so deliciious");
        _commentList2.Add(comment4);

        Comment comment5 = new Comment("Harry Bateman", "I love your videos. So easy to follow");
        _commentList2.Add(comment5);

        Comment comment6 = new Comment("Danny Ivy", "These look SOOOO goood!");
        _commentList2.Add(comment6);

        foreach (Video v in _videoList2)
        {
            Console.WriteLine();
            v.DisplayVideo();

            int count = 0;

            foreach (Comment c in _commentList2)
            {
                c.DisplayCommment();

                count +=1;
            }
        
            Console.WriteLine($"Number of Comments: {count}");
        }


        // Video 3
        Video video3 = new Video("Ultimate Guide to Pizza Making", "Bene Guadalupe", 20);
        _videoList3.Add(video3);

        Comment comment7 = new Comment("Olivia Green", "This recipe is life-changing! Best pizza ever");
        _commentList3.Add(comment7);

        Comment comment8 = new Comment("Samuel Lee", "I tried it, and it was incredible! Thanks for the tips");
        _commentList3.Add(comment8);

        Comment comment9 = new Comment("Ariana Hughes", "I have never made pizza from scratch before, but this was easy and delicious");
        _commentList3.Add(comment9);

        foreach (Video v in _videoList3)
        {
            Console.WriteLine();
            v.DisplayVideo();

            int count = 0;

            foreach (Comment c in _commentList3)
            {
                c.DisplayCommment();

                count +=1;
            }

            Console.WriteLine($"Number of Comments: {count}");
        }   
    }
}