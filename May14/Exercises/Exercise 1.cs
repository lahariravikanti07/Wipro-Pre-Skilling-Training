using System;

namespace MusicPlayerInterface
{
    // Step 1: Define the interface
    public interface IMusicPlayer
    {
        void Play(string song);
        void Pause();
        void Stop();
    }

    // Step 2a: Implement the interface in SpotifyPlayer
    public class SpotifyPlayer : IMusicPlayer
    {
        public void Play(string song)
        {
            Console.WriteLine($"Playing {song} on Spotify");
        }

        public void Pause()
        {
            Console.WriteLine("Spotify playback paused");
        }

        public void Stop()
        {
            Console.WriteLine("Spotify playback stopped");
        }
    }

    // Step 2b: Implement the interface in AppleMusicPlayer
    public class AppleMusicPlayer : IMusicPlayer
    {
        public void Play(string song)
        {
            Console.WriteLine($"Playing {song} on Apple Music");
        }

        public void Pause()
        {
            Console.WriteLine("Apple Music playback paused");
        }

        public void Stop()
        {
            Console.WriteLine("Apple Music playback stopped");
        }
    }

    // Step 3: Demonstrate functionality in Main
    class Program
    {
        static void Main(string[] args)
        {
            IMusicPlayer spotify = new SpotifyPlayer();
            IMusicPlayer appleMusic = new AppleMusicPlayer();

            Console.WriteLine("Spotify Player Actions:");
            spotify.Play("Shape of You");
            spotify.Pause();
            spotify.Stop();

            Console.WriteLine("\nApple music Player actions:");
            appleMusic.Play("Blinding Lights");
            appleMusic.Pause();
            appleMusic.Stop();
        }
    }
}