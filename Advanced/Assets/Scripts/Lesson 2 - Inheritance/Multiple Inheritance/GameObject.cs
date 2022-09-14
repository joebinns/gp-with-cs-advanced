namespace MultipleInheritance
{
    public class GameObject
    {
        private string _id;
        
        // Automatic property instead of field
        protected Vector3 Position {get; private set;}

        public void MoveTo(Vector3 newPosition)
        {
            
        }

        private void UpdatePosition()
        {
            
        }
    }
}