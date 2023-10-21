internal class Program
{
    private static void Main(string[] args)
    {
        Student s = new Student();
        StudentKeyListener skl = new StudentKeyListener();
        skl.Notify += s.DisplayMessage;
    }

    class Student
    {
        public void Jump()
        {
            Console.WriteLine("Jumping...");
        }
        public void Select()
        {
            Console.WriteLine("Selecting...");
        }
        public void Sleep()
        {
            Console.WriteLine("Sleeping...");
        }
        public void Info()
        {
            Console.WriteLine("This student is no more in our school");
        }
        public void MoveLeft()
        {
            Console.WriteLine("Moving left...");
        }
        public void MoveUp()
        {
            Console.WriteLine("Moving up...");
        }
        public void MoveRight()
        {
            Console.WriteLine("Moving right...");
        }
        public void MoveDown()
        {
            Console.WriteLine("Moving down...");
        }

        public void DisplayMessage(string message)
        {
            if (message == "Space")
            {
                Jump();
            }
            else if (message == "Enter")
            {
                Select();
            }
            else if (message == "Escape")
            {
                Sleep();
            }
            else if (message == "F1")
            {
                Info();
            }
            else if (message == "Left")
            {
                MoveLeft();
            }
            else if (message == "Up")
            {
                MoveUp();
            }
            else if (message == "Right")
            {
                MoveRight();
            }
            else if (message == "Down")
            {
                MoveDown();
            }
        }
    }

    class StudentKeyListener
    {
        public delegate void AccountHandler(string message);
        public event AccountHandler? Notify;
        public void Key()
        {
            var key = Console.ReadKey().KeyChar;
            if (key == 32) Notify?.Invoke("Space");
            else if (key == 13) Notify?.Invoke("Enter");
            else if (key == 112) Notify?.Invoke("F1");
            else if (key == 27) Notify?.Invoke("Escape");
            else if (key == 37) Notify?.Invoke("Left");
            else if (key == 38) Notify?.Invoke("Up");
            else if (key == 39) Notify?.Invoke("Right");
            else if (key == 40) Notify?.Invoke("Down");
        }
    }
}