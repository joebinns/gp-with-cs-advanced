namespace Composition
{
    public class Player
    {
        public string Name { get; set; }
        public GameObject GameObject { get; private set; }
        public Life Life { get; private set; }

        public Player(string name) // Note that this it not void
        {
            this.GameObject = new GameObject();
            this.Life = new Life();
            this.Name = name;
        }

        public void Shoot()
        {
            // "Pew pew"
        }
    }
}