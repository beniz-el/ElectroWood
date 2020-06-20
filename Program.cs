using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //MongoCRUD db = new MongoCRUD("ElectroWood");
            //db.InsertRecord("Admin", new PersonModel { pseudo = "admin", password = "admin" });
            //Console.ReadLine();

            //MongoCRUD db = new MongoCRUD("ElectroWood");
            //db.InsertRecord("Materiels", new Materiels { Id = "1254b", Nom = "piece", Description = "Bois" });
            //Console.ReadLine();

            //MongoCRUD db = new MongoCRUD("ElectroWood");
            //db.InsertRecord("Profs", new profs { CIN = "D14587", Nom = "Alami", Prenom = "Hassan", Filiere = "Ginf", Email = "Alami@gmail.com" });
            //Console.ReadLine();

            //MongoCRUD db = new MongoCRUD("ElectroWood");
            //db.InsertRecord("Reservation", new Reservation { Date_debut = "2020-05-18 09:00", Date_fin = "2020-05-18 13:00", CIN_prof = "D14587", Groupe ="ZY", Projet = "Electrowood"   });
            //Console.ReadLine();

            ////MongoCRUD db = new MongoCRUD("ElectroWood");
            ////db.InsertRecord("ProjetPro", new Projet { Nom = "Electrowood", CIN_prof= "D14587", Filiere = "Ginf", Groupe = "AZY" });
            ////Console.ReadLine();

            ////MongoCRUD db = new MongoCRUD("ElectroWood");
            //db.InsertRecord("ProjetPers", new ProjetPers { Nom = "CPCODE", CIN_prof = "A14587",  Groupe = "AZY" });
            //Console.ReadLine();
        }

    }
}
