using System;

namespace SocialMediaApp
{
    // Base class
    class SocialMedia
    {
        // Virtual method to be overridden
        public virtual void Post()
        {
            Console.WriteLine("Posting on social media");
        }
    }

    // Derived class - Facebook
    class facebookPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting on Facebook");
        }
    }

    // Derived class - Twitter
    class TwitterPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Tweeting on Twitter");
        }
    }

    // Derived class - Instagram
    class InstagramPost : SocialMedia
    {
        public override void Post()
        {
            Console.WriteLine("Posting on Instagram");
        }
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of derived classes
            SocialMedia fb = new facebookPost();
            SocialMedia tw = new TwitterPost();
            SocialMedia insta = new InstagramPost();

            // Calling the overridden Post() methods using polymorphism
            fb.Post();
            tw.Post();
            insta.Post();

            // Keep the console window open
            Console.readLine();
        }
    }
}