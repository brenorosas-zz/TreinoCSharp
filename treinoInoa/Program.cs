// public async Task SendEmail(string toEmailAddress, string emailSubject, string emailMessage){
//     var message = new MailMessage();
//     message.To.Add(toEmailAddress);
//     message.From = new MailAddress("brenodjango@gmail.com");
//     message.Subject = emailSubject;
//     message.Body = emailMessage;

//     using (var smtpClient = new SmtpClient()){
//         smtpClient.Host = "smtp.gmail.com";
//         smtpClient.Port = 587;
//         smtpClient.EnableSsl = true;
//         smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
//         smtpClient.UseDefaultCredentials = false;
//         smtpClient.Credentials = new NetworkCredential("brenodjangoemail@gmail.com", "Breno1999");
//         await smtpClient.SendMailAsync(message);
//         Console.WriteLine("Here");
//     }
// }
using System;
using System.Net;
using System.Threading.Tasks;
using System.Net.Mail;
namespace treinoInoa
{
    class Program
    {
        private static void SendEmail(int x, string toEmailAddress, string emailSubject, string emailMessage){
            Console.WriteLine(x);
            var smtpClient = new SmtpClient()
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("brenodjangoemail@gmail.com", "Breno1999"),
            };
            Console.WriteLine("Here");
            try{
                smtpClient.Send("brenodjangoemail@gmail.com", toEmailAddress, emailSubject, emailMessage);
            }
            catch(Exception ex){
                Console.WriteLine("Exception caught in CreateTestMessage2(): {0}", ex.ToString());
            }
        }
        private static void doJob(){
            for(int i = 0; i < 100; i++){
                Console.WriteLine(i);
            }
        }
        static async Task Main(string[] args)
        {
            SendEmail(10, "brenorosas@hotmail.com", "test3", "test3");
            for(int i = 0; i < 10; i++){
                // 
                await Task.Run(() => SendEmail(i, "brenorosas@hotmail.com", "breno", "breno"));
                Console.WriteLine();
            }
            SendEmail(10, "brenorosas@hotmail.com", "test4", "test4");
        }
    }
}