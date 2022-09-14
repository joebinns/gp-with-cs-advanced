namespace Composition
{
    public class Enemy
    {
        public GameObject GameObject { get; private set; }
        public Life Life { get; private set; }

        public Enemy()
        {
            this.GameObject = new GameObject();
            this.Life = new Life();
        }
        
        public void Shoot()
        {
            // "Pew pew"
        }
    }
}