namespace Problem01DefineAClassDog
{
    public class PlayDog
    {
        public static void Main(string[] args)
        {
            Dog unnamed = new Dog();
            Dog sharo = new Dog("Sharo", "Melez");
            unnamed.Breed = "German Shepherd";

            unnamed.Bark();
            sharo.Bark();
        }
    }
}
