using System;

namespace KitchenBlender
{
    class Program
    {
        static void Main(string[] args)
        {
            Blender blender = new Blender();
            Console.WriteLine(BlenderMessageHandler.Instructions);

            ConsoleKeyInfo PressedKey;
            do
            {
                PressedKey = Console.ReadKey();
                Console.Clear();
                try
                {
                    switch (PressedKey.Key)
                    {
                        case ConsoleKey.F:
                            blender.Fill();
                            Console.WriteLine(BlenderMessageHandler.Filled);
                            break;
                        case ConsoleKey.E:
                            blender.Empty();
                            Console.WriteLine(BlenderMessageHandler.Emptied);
                            break;
                        case ConsoleKey.L:
                            blender.SpeedUp();
                            Console.WriteLine(BlenderMessageHandler.SpeedUp(blender.Speed));
                            break;
                        case ConsoleKey.K:
                            blender.SpeedDown();
                            Console.WriteLine(BlenderMessageHandler.SpeedDown(blender.Speed));
                            break;
                        case ConsoleKey.I:
                            Console.WriteLine(BlenderMessageHandler.Instructions);
                            break;
                        default: continue;
                    }
                }
                catch (Exception e)
                {
                    switch (e.Message)
                    {
                        case "Below 0":
                            Console.WriteLine(BlenderMessageHandler.ErrorBelow0);
                            break;
                        case "Over 10":
                            Console.WriteLine(BlenderMessageHandler.ErrorOver10);
                            break;
                        case "Empty":
                            Console.WriteLine(BlenderMessageHandler.ErrorEmpty);
                            break;
                        case "EmptyFirst":
                            Console.WriteLine(BlenderMessageHandler.ErrorEmptyToFill);
                            break;
                        case "FillFirst":
                            Console.WriteLine(BlenderMessageHandler.ErrorFillToEmpty);
                            break;
                        case "DecreaseToEmpty":
                            Console.WriteLine(BlenderMessageHandler.ErrorDecreaseToEmpty);
                            break;
                        default:
                            Console.WriteLine(e.Message);
                            break;
                    }
                }
            } while (PressedKey.Key != ConsoleKey.Escape);
        }
    }
}