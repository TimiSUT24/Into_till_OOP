
//Tim Petersen SUT24
namespace Into_till_OOP
{
    internal class Program
    {
        static void Main()
        {
            var circle = new Circle(5);           
            Console.WriteLine($"Arean på cirkel 1 är: {circle.GetArea()}");

            var circle2 = new Circle(6); 
            Console.WriteLine($"Arean på cirkel 2 är: {circle2.GetArea()}");

        }
        public class Circle
        {
             float _pi = 3.141f;
             int Radius;
                      
            public Circle(int radius)
            {
                Radius = radius;
            }
            
            public float GetArea()
            {
                return Radius * Radius * _pi;
            }
            

        }

        
    }

    
}
