using System;

namespace KitchenBlender
{
    public class Blender
    {
        public int Speed { get; private set; }
        public bool IsFull { get; private set; }

        private bool canIncreaseSpeed() => Speed <= 9;
        private bool canDecreaseSpeed() => Speed >= 1;
        private bool canFill() => !IsFull && Speed == 0;
        private bool canEmpty() => IsFull && Speed == 0;

        private void stepSpeedUp() => Speed++;
        private void stepSpeedDown() => Speed--;

        private bool canChangeSpeed(string direction)
        {
            if (!IsFull)
                throw new InvalidOperationException("Empty");
            return direction == "UP" && canIncreaseSpeed() ||
                   direction == "DOWN" && canDecreaseSpeed();
        }

        public void Fill()
        {
            if (IsFull) throw new InvalidOperationException("EmptyFirst");
            if (canFill())
                IsFull = true;
        }

        public void Empty()
        {
            if (!IsFull) throw new InvalidOperationException("FillFirst");
            if (canEmpty())
                IsFull = false;
            else throw new InvalidOperationException("DecreaseToEmpty");
        }
        
        public void SpeedUp()
        {
            if (canChangeSpeed("UP")) stepSpeedUp();
            else throw new InvalidOperationException("Over 10");
        }

        public void SpeedDown()
        {
            if (canChangeSpeed("DOWN")) stepSpeedDown();
            else throw new InvalidOperationException("Below 0");
        }
    }
}