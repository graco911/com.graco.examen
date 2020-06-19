using System.Net.Mail;

namespace com.graco.examen.Helpers
{
    public static class Utils
    {
        public static bool ValidateEmail(string email)
        {
			try
			{
				MailAddress m = new MailAddress(email);
				return true;

			}
			catch (System.Exception)
			{
				return false;
			}
        }
    }
}
