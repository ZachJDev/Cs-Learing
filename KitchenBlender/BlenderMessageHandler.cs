namespace KitchenBlender
{
    public class BlenderMessageHandler
    {
        public static string Instructions =
            @"Press: 
'F' to fill the Blender, 
'E' to Empty the blender, 
'L' to increase the speed, and 
'K' to decrease the speed.
Press 'I' to see the instructions again.
Press 'ESC' to Exit.";

        public static string Filled = "Blender Filled!";
        public static string Emptied = "Blender Emptied!";
        public static string SpeedUp(int speed) => $"Speed Up! current speed: {speed} of 10";
        public static string SpeedDown(int speed) => $"Speed Down! current speed: {speed} of 10";

        public static string ErrorBelow0 = "Cannot Decrease Speed Below 0!";
        public static string ErrorOver10 = "Cannot Increase Speed Over 10!";
        public static string ErrorEmpty = "Cannot Use the Blender When it's Empty!";
        public static string ErrorDecreaseToEmpty = "Decrease the speed to empty the blender";
        public static string ErrorEmptyToFill = "Empty the Blender before you fill it...";
        public static string ErrorFillToEmpty = "Fill the Blender before you empty it...";
    }
}