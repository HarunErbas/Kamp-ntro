 namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // interface onu imlament eden clasın referans numarasını tutabilir
            
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();            
            IKrediManager tasitKrediManager = new TasitKrediManager();           
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKrediManager = new EsnafKredisiManager();

            ILoggerService databaseLogger = new DatabaseLoggerService();
            ILoggerService filebaseLogger = new FileLoggerService();
            ILoggerService smsLogger = new SmsLoggerService(); 
            
            List<ILoggerService> loggers = new List<ILoggerService> {smsLogger,filebaseLogger };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKrediManager,loggers);


            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager,konutKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

            

            

            

        }
    }
}