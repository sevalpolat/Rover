namespace RoverController
{
    public interface IRover
    {
        public string Name { get; }
        public Position Position { get; }
        void TurnLeft();
        void TurnRight();
        void Move();
    }
}
