using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGennemgang
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //List<T> er en generisk liste. T betyder at her kan der stå en vilkårlig type fx int string eller en type i selv 
            //har kodet fx et Person objekt eller Dice objekt.

            //Nr 1 : en ny liste med heltal (int)
            List<int> listeHeltal = new List<int>();
            //tilføj tal //Add()
            listeHeltal.Add(10);
            listeHeltal.Add(20);
            listeHeltal.Add(30);

            
            //looper igennem listen
            foreach (int l in listeHeltal)
            {
                Console.WriteLine($"værdien er :{l}");
            }


            //Skriv antallet af elementer ud //liste.Count
            Console.WriteLine($"Antal elementer : {listeHeltal.Count}");

            //fjern element på bestemt position //RemoveAt()
            listeHeltal.RemoveAt(1);

            //Skriv antallet af elementer ud //liste.Count
            Console.WriteLine($"Antal elementer : {listeHeltal.Count}");

            foreach (int l in listeHeltal)
            {
                Console.WriteLine($"værdien er :{l}");
            }

            //Slet alt data i listen //Clear()
            listeHeltal.Clear();

            Console.WriteLine($"Antal elementer : {listeHeltal.Count}");

            listeHeltal.Add(10);
            listeHeltal.Add(20);
            listeHeltal.Add(30);
            listeHeltal.Add(20);
            listeHeltal.Add(30);

            foreach (int l in listeHeltal)
            {
                Console.WriteLine($"værdien er :{l}");
            }

            listeHeltal.Remove(30);
            Console.WriteLine("Efter remove(30)");
            foreach (int l in listeHeltal)
            {
                Console.WriteLine($"værdien er :{l}");
            }

            //Nr 2: en ny liste med strings
            List<string> navneListe = new List<string>();
            navneListe.Add("Anne Sofie");
            navneListe.Add("Magnus");
            navneListe.Add("Kasper");
            navneListe.Add("Lisa");

            foreach (string navn in navneListe)
            {
                Console.WriteLine($"navnet er : {navn}");
            }

            Console.WriteLine($"Antal i navnelisten {navneListe.Count}" );


            //Nr 3: en ny liste med objekter af fx studerende i 1R
            //vi opretter en ny klasse Person
            Person 
            //tilføj ny variabel med Person

            //tilføj objekt med Add()

            //tilføj direkte med Add(new Person)

            //foreach og tilføj objekt

            //Spørgsmål ?


            //FILO FirstInLastOut
            //kort gennemgang af Stack() først på tavlen
            //Stack<int> mySTack = new Stack<int>();
            //mySTack.Push(3);
            //mySTack.Push(5);
            //Console.WriteLine($"Antal i mySTack : {mySTack.Count}");
            //Console.WriteLine($"POP : {mySTack.Pop()}");
            //Console.WriteLine($"Antal i myStack : {mySTack.Count}");

            //FIFO FirstInFirstOut
            //Kort gennemgang af Queue først på tavlen
            //Queue<int> myQueue = new Queue<int>();
            //myQueue.Enqueue(10);
            //myQueue.Enqueue(100);
            //myQueue.Enqueue(1000);
            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine(myQueue.Dequeue());
            //Console.WriteLine(myQueue.Dequeue());
        }
    }
        }
   
