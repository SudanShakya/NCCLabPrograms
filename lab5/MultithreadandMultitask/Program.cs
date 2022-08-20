namespace MultithreadAndMultitask
{
    public class Program
    {
        static void Main()
        {
            Mt m = new Mt();
            Console.WriteLine("Main Threads starts now");
            ThreadStart s1 = m.count;
            ThreadStart s2 = m.Alphabet;
            Thread thread1 = new Thread(s1);
            Thread thread2 = new Thread(s2);
            thread1.Start();
            thread2.Start();
            Console.WriteLine("Main threads Ends now");
            Console.ReadLine();
        }
    }
}