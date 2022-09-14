namespace MultipleInheritance
{
    public class Main
    {
        public void Run()
        {
            var player = new Player();
            player.Name = "Player1";

            var enemy = new Enemy();

            var obstacle = new Obstacle();
            obstacle.MoveTo(new Vector3(20, 0, 0));

            enemy.MoveTo(new Vector3(10, 0, 0));
            enemy.Shoot();
            player.TakeDamage(50);

            player.MoveTo(new Vector3(30, 0, 0));
            player.Shoot();
            obstacle.Destroy();
        }
    }
}