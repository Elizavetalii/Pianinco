using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int[] currentOctave = null;
        int currentOctaveIndex = 6; 

        int[][] octaves = new int[][]
        {
            new int[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 },
            new int[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3136, 3322, 3520, 3729, 3951 },
            new int[] { 4186, 4435, 4699, 4978, 5274, 5588, 5920, 6272, 6645, 7040, 7459, 7902 }
        };
        Console.WriteLine("Добро пожаловать в консольное пианино!");
        Console.WriteLine("ASDFGH - это белые клавиши, WERTYU - это черные клавиши");
        Console.WriteLine("Используйте F1, F2, F3 для переключения октав");


        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.A)
            {
                PlaySound(currentOctave, 0); 
            }
            else if (key.Key == ConsoleKey.S)
            {
                PlaySound(currentOctave, 2); 
            }
            else if (key.Key == ConsoleKey.D)
            {
                PlaySound(currentOctave, 4); 
            }
            else if (key.Key == ConsoleKey.F)
            {
                PlaySound(currentOctave, 6); 
            }
            else if (key.Key == ConsoleKey.G)
            {
                PlaySound(currentOctave, 8); 
            }
            else if (key.Key == ConsoleKey.H)
            {
                PlaySound(currentOctave, 10); 
            }
            else if (key.Key == ConsoleKey.W)
            {
                PlaySound(currentOctave, 1); 
            }
            else if (key.Key == ConsoleKey.E)
            {
                PlaySound(currentOctave, 3); 
            }
            else if (key.Key == ConsoleKey.R)
            {
                PlaySound(currentOctave, 5); 
            }
            else if (key.Key == ConsoleKey.T)
            {
                PlaySound(currentOctave, 7); 
            }
            else if (key.Key == ConsoleKey.Y)
            {
                PlaySound(currentOctave, 9); 
            }
            else if (key.Key == ConsoleKey.U)
            {
                PlaySound(currentOctave, 11); 
            }
            else if (key.Key == ConsoleKey.F1)
            {
                currentOctave = ChangeOctave(octaves, ref currentOctaveIndex, 0); // Переключиться на шестую октаву
                Console.WriteLine("Вы используйте 6 октаву");
            }
            else if (key.Key == ConsoleKey.F2)
            {
                currentOctave = ChangeOctave(octaves, ref currentOctaveIndex, 1); // Переключиться на седьмую октаву
                Console.WriteLine("Вы используйте 7 октаву");
            }
            else if (key.Key == ConsoleKey.F3)
            {
                currentOctave = ChangeOctave(octaves, ref currentOctaveIndex, 2); // Переключиться на восьмую октаву
                Console.WriteLine("Вы используйте 8 октаву");
            }
        }
    }

    static void PlaySound(int[] octave, int noteIndex)
    {
        if (octave != null && noteIndex >= 0 && noteIndex < octave.Length)
        {
            int frequency = octave[noteIndex];
            Console.Beep(frequency, 300);
        }
    }

    static int[] ChangeOctave(int[][] octaves, ref int currentOctaveIndex, int targetIndex)
    {
        if (targetIndex >= 0 && targetIndex < octaves.Length)
        {
            currentOctaveIndex = targetIndex;
            return octaves[currentOctaveIndex];
        }

        return null;
    }
}