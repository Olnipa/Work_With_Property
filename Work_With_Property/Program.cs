namespace Work_With_Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int characterPositionX = 5;
            int characterPositionY = 10;

            Renderer renderer1 = new Renderer();
            Character character1 = new Character(characterPositionX, characterPositionY);

            renderer1.DrawCharacter(character1.PositionX, character1.PositionY);
        }
    }

    class Character
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Character(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
        }
    }

    class Renderer
    {
        public void DrawCharacter(int positionX, int positionY, char characterView = 'Я')
        {
            Console.SetCursorPosition(positionY, positionX);
            Console.WriteLine(characterView);
        }
    }
}