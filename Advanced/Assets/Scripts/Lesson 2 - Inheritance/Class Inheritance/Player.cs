 namespace ClassInheritance
{
    public class Player : GameObject
    {
        private string _name;
        private int _life = 100;

        public void TakeDamage(int damage)
        {
            this._life -= damage;
        }

        public int GetLife()
        {
            return this._life;
        }

        public string GetName()
        {
            return this._name;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public void Shoot()
        {
            
        }
    }
}