using System;
using System.Windows.Forms;
using NeelyFood.Models;
using System.Data.Entity;

namespace NeelyFood
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // إذا تغيّر الموديل، يحذف القاعدة ويعيد إنشائها
            Database.SetInitializer(new AppDbInitializer());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmLogin());
        }
    }

    // هنا نعرّف Initializer خاص بنا
    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            // إنشاء المستخدمين الأساسيين
            context.Users.Add(new User
            {
                Username = "neelyfood",
                Password = "12345neely",
                Role = "Admin"
            });

            context.Users.Add(new User
            {
                Username = "rawan",
                Password = "12345rawan",
                Role = "Customer"
            });

            context.SaveChanges();
        }
    }
}
