using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TorsdagsWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Adition(2, 4));
            // mem - stack forandre sig ikke  non volitile
            // mem - heap volatile => svare til random placering / access
            User niels = new User();
            niels.A();
            User objectnavn = new User();
            objectnavn.A();
            // istedet for lave object kan du ogsa fa fat i attribute i classen
            // denne kan du kalde men kan ikke arbejde med indholdet
            User.Hans();
            Product item = new Product();
            item.Vare();


            List<User> liste = new List<User>()
            {
                new User
                {
                    alder= 6,
                }
            };
            List<Product> producktliste = new List<Product>()
            {
                new Product
                {
                    productID = 1,
                    navn= "ost",
                    describtion = "Chees",
                    weigth= 0.5
                },
                new Product
                {
                    productID= 2,
                    navn= "Tun",
                    describtion = "fisk",
                    weigth= 1.5
                }
            };

        }

        public static int Adition(int tal1, int tal2)
        {
            return tal1 + tal2;
        }
    }
    // 2 Ting i klasser (attributer og metoder)
    // Name convention - classes skal starte med stort!
    class User
    {
        //Encapsulation - public - protected - default og private 
        //Fields
        public int alder; // Betyder andre classer kan se den variable
        protected string navn;
        private string mail;
        string adress;
        //properties 
        //methods
        public void A()
        {
            alder = 5;
            navn = "Bo er en dummme mand!!";
        }
        public void B()
        {
            alder = 12;
            navn = "Taralel";
        }
        public static void Hans()
        {
            Console.WriteLine("Dette er en static metode sa du kan kalde den med User.hans(); derikte");
        }
        //constructor 
        public User() // initialiserer et object
        {
            // Plejer satte sine attributer herinde 
        }
        ~User()// deconstructor
        {

        }
    }

}
