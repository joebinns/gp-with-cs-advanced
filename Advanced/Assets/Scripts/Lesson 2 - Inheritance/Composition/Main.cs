namespace Composition
{
    public class Main
    {
        public void Run()
        {
            var player = new Player("Player1");

            var enemy = new Enemy();

            var obstacle = new Obstacle();
            obstacle.GameObject.MoveTo(new Vector3(20, 0, 0));

            enemy.GameObject.MoveTo(new Vector3(10, 0, 0));
            enemy.Shoot();
            player.Life.TakeDamage(50);

            player.GameObject.MoveTo(new Vector3(30, 0, 0));
            player.Shoot();
            obstacle.Destroy();
        }
    }
}