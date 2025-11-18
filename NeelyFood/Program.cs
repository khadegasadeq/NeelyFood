using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using NeelyFood.Models;
using System.Data.Entity;


namespace NeelyFood
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // إنشاء قاعدة البيانات والجداول إذا لم تكن موجودة
            System.Data.Entity.Database.SetInitializer(new System.Data.Entity.CreateDatabaseIfNotExists<AppDbContext>());

            using (var context = new AppDbContext())
            {
                // إضافة الادمن إذا لم يكن موجود
                if (!context.Users.Any(u => u.Username == "neelyfood"))
                {
                    context.Users.Add(new User
                    {
                        Username = "neelyfood",
                        Password = "12345neely",
                        Role = "Admin"
                    });
                }

                // إضافة مستخدمين افتراضيين
                if (!context.Users.Any(u => u.Username == "rawan"))
                {
                    context.Users.Add(new User
                    {
                        Username = "rawan",
                        Password = "12345rawan",
                        Role = "Customer"
                    });
                }

                if (!context.Users.Any(u => u.Username == "khadega"))
                {
                    context.Users.Add(new User
                    {
                        Username = "khadega",
                        Password = "12345khadega",
                        Role = "Customer"
                    });
                }

                context.SaveChanges();
            }

            // تشغيل الفورم الرئيسي
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new FrmLogin());
        }
    }
}
