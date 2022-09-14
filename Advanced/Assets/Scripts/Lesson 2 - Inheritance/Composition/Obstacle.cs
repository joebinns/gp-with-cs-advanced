namespace Composition
{
    public class Obstacle
    {
        public GameObject GameObject { get; private set; }

        public Obstacle()
        {
            this.GameObject = new GameObject();
        }

        public void Destroy()
        {
            // "Nooo..."
        }
    }
}