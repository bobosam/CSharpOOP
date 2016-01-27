namespace OOPExam
{
    using OOPExam.Core;
    using OOPExam.Core.Engines;
    using OOPExam.IO;

    public class BlobAplication
    {
        public static void Main(string[] args)
        {
            var db = new Database();
            var reader = new ConsoleReader();
            var writer = new ConsoleWriter();

            var engine = new BlobEngine(db, reader, writer);

            engine.Run();
        }
    }
}
