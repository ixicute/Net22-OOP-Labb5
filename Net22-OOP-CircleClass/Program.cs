namespace Net22_OOP_CircleClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Making 2 objects that hold different values for the radius.
            var circle_1 = new Circle(5);
            var circle_2 = new Circle(6);

            Console.WriteLine("En cirkel med radie 5 ger följande resultat: \n" +
                              "Arean är: {0}\n" +
                              "Volymen blir: {1}\n" +
                              "Omkretsen blir: {2}",
                              circle_1.GetArea(), circle_1.GetVolume(), circle_1.GetCircumference());

            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("En cirkel med radie 6 ger följande resultat: \n" +
                              "Arean är: {0}\n" +
                              "Volymen blir: {1}\n" +
                              "Omkretsen blir: {2}",
                              circle_2.GetArea(), circle_2.GetVolume(), circle_2.GetCircumference());

        }
    }
}