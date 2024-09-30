using System;
using System.Threading;

namespace Wekker
{
    class Program
    {
        // Delegates voor de alarmmethodes
        public delegate void AlarmAction();
        static Timer timer;

        // Velden voor alarminstellingen
        static DateTime alarmTime;
        static int snoozeTime = 5; // Sluimertijd in minuten
        static AlarmAction alarmMethods;

        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Stel alarmtijd in");
                Console.WriteLine("2. Stel sluimertijd in");
                Console.WriteLine("3. Schakel wekmethoden in of uit");
                Console.WriteLine("4. Start alarm");
                Console.WriteLine("5. Stoppen");
                Console.WriteLine("Kies een optie:");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        SetAlarmTime();
                        break;
                    case 2:
                        SetSnoozeTime();
                        break;
                    case 3:
                        ConfigureAlarmMethods();
                        break;
                    case 4:
                        StartAlarm();
                        break;
                }
            } while (choice != 5);
        }

        // Methode om de alarmtijd in te stellen
        static void SetAlarmTime()
        {
            Console.WriteLine("Geef de alarmtijd in (HH:mm):");
            alarmTime = DateTime.Parse(Console.ReadLine());
            Console.WriteLine($"Alarm is ingesteld voor: {alarmTime.ToString("HH:mm")}");
            Thread.Sleep(2000);
        }

        // Methode om de sluimertijd in te stellen
        static void SetSnoozeTime()
        {
            Console.WriteLine("Geef de sluimertijd in minuten:");
            snoozeTime = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sluimertijd ingesteld op {snoozeTime} minuten.");
            Thread.Sleep(2000);
        }

        // Methode om wekmethoden in of uit te schakelen
        static void ConfigureAlarmMethods()
        {
            alarmMethods = null; // reset

            Console.WriteLine("Kies de wekmethoden:");
            Console.WriteLine("1. Geluid");
            Console.WriteLine("2. Boodschap");
            Console.WriteLine("3. Knipperlicht");
            Console.WriteLine("Voer de nummers in van de methoden die je wilt gebruiken, gescheiden door komma's:");

            string[] methods = Console.ReadLine().Split(',');

            foreach (string method in methods)
            {
                switch (method.Trim())
                {
                    case "1":
                        alarmMethods += SoundAlarm;
                        break;
                    case "2":
                        alarmMethods += MessageAlarm;
                        break;
                    case "3":
                        alarmMethods += LightAlarm;
                        break;
                }
            }
            Console.WriteLine("Wekmethoden zijn geconfigureerd.");
            Thread.Sleep(2000);
        }

        // Start het alarm op basis van de ingestelde tijd
        static void StartAlarm()
        {
            if (alarmMethods == null)
            {
                Console.WriteLine("Geen wekmethode geselecteerd. Configureer eerst de wekmethode.");
                Thread.Sleep(2000);
                return;
            }

            TimeSpan timeUntilAlarm = alarmTime - DateTime.Now;

            if (timeUntilAlarm.TotalMilliseconds > 0)
            {
                Console.WriteLine($"Alarm gaat af om {alarmTime.ToString("HH:mm")}. Wachten...");
                timer = new Timer(AlarmCallback, null, (int)timeUntilAlarm.TotalMilliseconds, Timeout.Infinite);
            }
            else
            {
                Console.WriteLine("De alarmtijd is in het verleden, stel een nieuwe tijd in.");
                Thread.Sleep(2000);
            }
        }

        // Callback wanneer het alarm afloopt
        static void AlarmCallback(object state)
        {
            Console.Clear();
            Console.WriteLine("Alarm af!");
            alarmMethods?.Invoke(); // Roep de geselecteerde alarmacties aan

            Console.WriteLine("\n1. Stop alarm");
            Console.WriteLine("2. Sluimer");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                Console.WriteLine($"Sluimering voor {snoozeTime} minuten.");
                timer.Change(snoozeTime * 60000, Timeout.Infinite); // Sluimer opnieuw instellen
            }
            else
            {
                timer.Dispose();
                Console.WriteLine("Alarm gestopt.");
            }
            Thread.Sleep(2000);
        }

        // Alarmmethodes
        static void SoundAlarm()
        {
            Console.WriteLine("GELUID: Beep Beep Beep!");
        }

        static void MessageAlarm()
        {
            Console.WriteLine("BOODSCHAP: Tijd om op te staan!");
        }

        static void LightAlarm()
        {
            Console.WriteLine("KNIPPERLICHT: *** *** ***");
        }
    }
}