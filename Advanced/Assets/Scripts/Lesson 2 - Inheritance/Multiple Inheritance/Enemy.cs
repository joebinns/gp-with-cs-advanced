namespace MultipleInheritance
{
    public class Enemy : GameObject, ILife
    {
        public int Life { get; set; } = 50;

        public void TakeDamage(int damage)
        {
            this.Life -= damage;
        }

        public void Shoot()
        {
            // "Pew pew"
        }
    }
}