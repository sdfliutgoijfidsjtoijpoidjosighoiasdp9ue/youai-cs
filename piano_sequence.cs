using System;

public class Program
{
    public static void Main()
    {
        Random rand = new Random();

        string[] notes = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };
        string[] lengths = { "2", "4", "8", "16" };

        for (int i = 0; i < 16; i++)
        {
            int noteIndex = rand.Next(0, notes.Length);
            int lengthIndex = rand.Next(0, lengths.Length);

            Console.Write(notes[noteIndex] + lengths[lengthIndex] + " ");
        }
    }
}
