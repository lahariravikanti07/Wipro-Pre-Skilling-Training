using System;

namespace CompressionStrategyPattern
{
    // Step 1: Abstract Strategy
    public abstract class CompressionStrategy
    {
        public abstract void Compress(string inputPath, string outputPath);
    }

    // Step 2: Concrete Strategy - ZIP
    public class ZipCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($"Compressing '{inputPath}' to '{outputPath}' using ZIP compression.");
            // Add actual ZIP compression logic here
        }
    }

    // Step 3: Concrete Strategy - RAR
    public class RarCompression : CompressionStrategy
    {
        public override void Compress(string inputPath, string outputPath)
        {
            Console.WriteLine($"Compressing '{inputPath}' to '{outputPath}' using RAR compression.");
            // Add actual RAR compression logic here
        }
    }

    // Step 4: Context class
    public class Compressor
    {
        private CompressionStrategy _strategy;

        // Constructor accepting a strategy
        public Compressor(CompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        // Allows switching strategy at runtime
        public void SetStrategy(CompressionStrategy strategy)
        {
            _strategy = strategy;
        }

        // Executes compression using the current strategy
        public void Compress(string inputPath, string outputPath)
        {
            _strategy.Compress(inputPath, outputPath);
        }
    }

    // Step 5: Test the strategy pattern
    class Program
    {
        static void Main(string[] args)
        {
            // Using ZIP compression
            CompressionStrategy zip = new ZipCompression();
            Compressor compressor = new Compressor(zip);
            compressor.Compress("C:\\Data\\file.txt", "C:\\Compressed\\file.zip");

            // Switch to RAR compression at runtime
            CompressionStrategy rar = new RarCompression();
            compressor.SetStrategy(rar);
            compressor.Compress("C:\\Data\\file.txt", "C:\\Compressed\\file.rar");

            Console.ReadLine();
        }
    }
}
