using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> Users = new();

            int[] PatrykMarks = { 5, 2, 3 };
            DateTime PatrykDataStart = new DateTime(2021, 02, 13);
            DateTime PatrykDataEnd = new DateTime(2022, 01, 04);
            User PatrykUser = new("Patryk", "STUDENT", 21, PatrykMarks, PatrykDataStart, PatrykDataEnd);
            Users.Add(PatrykUser);


            int[] MaciekMarks = { 5, 5, 5, 5, 5 };
            DateTime MaciekDataStart = new DateTime(2020, 04, 21);
            DateTime MaciekDataEnd = new DateTime(2022, 02, 28);
            User MaciekUser = new("Maciek", "STUDENT", 21, MaciekMarks, MaciekDataStart, MaciekDataEnd);
            Users.Add(MaciekUser);


            int[] AndrzejMarks = { 4, 3, 5, 3, 4 };
            DateTime AndrzejDataStart = new DateTime(2020, 03, 21);
            DateTime AndrzejDataEnd = new DateTime(2022, 01, 03);
            User AndrzejUser = new("Andrzej", "STUDENT", 24, AndrzejMarks, AndrzejDataStart, AndrzejDataEnd);
            Users.Add(AndrzejUser);

            int[] DawidMarks = { 3, 4, 4 };
            DateTime DawidDataStart = new DateTime(2018, 02, 14);
            DateTime DawidDataEnd = new DateTime(2021, 05, 22);
            User DawidUser = new("Dawid", "STUDENT", 25, DawidMarks, DawidDataStart, DawidDataEnd);
            Users.Add(DawidUser);

            int[] MarekMarks = { 4, 5, 5, 2, 4 };
            DateTime MarekDataStart = new DateTime(2020, 02, 07);
            User MarekUser = new("Marek", "STUDENT", 36, MarekMarks, MarekDataStart);
            Users.Add(MarekUser);

            int[] MariuszMarks = { 3, 4 };
            DateTime MariuszDataStart = new DateTime(2020, 02, 04);
            DateTime MariuszDataEnd = new DateTime(2021, 12, 13);
            User MariuszUser = new("Mariusz", "STUDENT", 25, MariuszMarks, MariuszDataStart, MariuszDataEnd);
            Users.Add(MariuszUser);

            int[] RobertMarks = { 4, 5, 5, 4 };
            DateTime RobertDataStart = new DateTime(2021, 10, 13);
            DateTime RobertDataEnd = new DateTime(2021, 12, 13);
            User RobertUser = new("Robert", "STUDENT", 22, RobertMarks, RobertDataStart, RobertDataEnd);
            Users.Add(RobertUser);

            int[] JerzyMarks = { 5, 5, 5, 5, 4, 3 };
            DateTime JerzyDataStart = new DateTime(2021, 09, 02);
            User JerzyUser = new("Jerzy", "STUDENT", 29, JerzyMarks, JerzyDataStart);
            Users.Add(JerzyUser);

            int[] CezarMarks = { 3, 3, 3, 3, 4 };
            DateTime CezarDataStart = new DateTime(2021, 09, 02);
            User CezarUser = new("Jerzy", "STUDENT", 29, CezarMarks, CezarDataStart);
            Users.Add(CezarUser);

            int[] BartoszMarks = { 3, 5, 4, 5 };
            DateTime BartoszDataStart = new DateTime(2021, 09, 01);
            User BartoszUser = new("Bartosz", "STUDENT", 27, BartoszMarks, BartoszDataStart);
            Users.Add(BartoszUser);

            int[] FilipMarks = { 2, 5, 2, 5};
            DateTime FilipDataStart = new DateTime(2020, 04, 20);
            DateTime FilipDataEnd = new DateTime(2021, 11, 18);
            User FilipUser = new("Filip", "STUDENT", 21, FilipMarks, FilipDataStart, FilipDataEnd);
            Users.Add(FilipUser);

            //teachers
            DateTime AdrianDataStart = new DateTime(2021, 10, 13);
            DateTime AdrianDataEnd = new DateTime(2021, 12, 13);
            User AdrianUser = new("Adrian", "TEACHER", 34, null, AdrianDataStart, AdrianDataEnd);
            Users.Add(AdrianUser);

            DateTime MarianDataStart = new DateTime(2017, 10, 26);
            DateTime MarianDataEnd = new DateTime(2022, 02, 13);
            User MarianUser = new("Marian", "TEACHER", 51, null, MarianDataStart, MarianDataEnd);
            Users.Add(MarianUser);

            DateTime KacperDataStart = new DateTime(2018, 10, 01);
            User KacperUser = new("Kacper", "TEACHER", 78, null, KacperDataStart);
            Users.Add(AdrianUser);

            DateTime ErykDataStart = new DateTime(2019, 10, 13);
            User ErykUser = new("Eryk", "TEACHER", 52, null, ErykDataStart);
            Users.Add(ErykUser);

            //moderators
            DateTime WaldemarDataStart = new DateTime(2018, 10, 13);
            User WaldemarUser = new("Waldemar", "MODERATOR", 22, null, WaldemarDataStart);
            Users.Add(WaldemarUser);

            DateTime PiotrDataStart = new DateTime(2020, 02, 13);
            DateTime PiotrDataEnd = new DateTime(2021, 12, 13);
            User PiotrUser = new("Piotr", "MODERATOR", 28, null, PiotrDataStart, PiotrDataEnd);
            Users.Add(PiotrUser);

            DateTime JanDataStart = new DateTime(2019, 05, 13);
            DateTime JanDataEnd = new DateTime(2021, 04, 03);
            User JanUser = new("Jan", "MODERATOR", 22, null, JanDataStart, JanDataEnd);
            Users.Add(JanUser);

            DateTime RemigiuszDataStart = new DateTime(2021, 12, 04);
            User RemigiuszUser = new("Remigiusz", "MODERATOR", 32, null, RemigiuszDataStart);
            Users.Add(RemigiuszUser);


            //admins
            DateTime GrzegorzDataStart = new DateTime(2020, 10, 13);
            User GrzegorzUser = new("Grzegorz", "ADMIN", 46, null, GrzegorzDataStart);
            Users.Add(GrzegorzUser);



            //Polecenia zwracające:

            //1. Ilość rekordów w tablicy
            var q1 = (from user in Users select user).Count();

            Console.WriteLine($"1. {q1}\n");


            //2. Listę nazw użytkowników
            var q2 = from user in Users select user.Name;
            Console.Write("2.");
            foreach (var user in q2)
            {
                Console.Write($"{user}\n");
            }
            Console.WriteLine();

            //3. Posortowanych użytkowników po nazwach
            var q3 = from user in Users orderby user.Name select user.Name;
            Console.Write("3.");
            foreach (var user in q3)
            {
                Console.WriteLine($"{user}");
            }
            Console.WriteLine();

            //4. Listę dostępnych ról użytkowników
            var q4 = (from user in Users select user.Role).Distinct();
            Console.Write("4.");
            foreach (var user in q4)
            {
                Console.WriteLine($"{user}");
            }
            Console.WriteLine();

            //5. Listy pogrupowanych użytkowników po rolach
            var q5 = from user in Users orderby user.Role select user;
            Console.Write("5.");
            foreach (var user in q5)
            {
                Console.WriteLine($"{user.Role} {user.Name}");
            }
            Console.WriteLine();

            //6. Ilość rekordów, dla których podano oceny (nie null i więcej niż 0)
            var q6 = (from user in Users where user.Marks != null && user.Marks.Count() > 0 select user).Count();
            Console.WriteLine($"6. {q6}\n");

            //7. Sumę, ilość i średnią wszystkich ocen studentów
            var q7 = from user in Users where user.Marks != null && user.Marks.Count() > 0 select user;
            Console.Write("7.");
            foreach (var user in q7)
            {
                var Sum = (from s in user.Marks select s).Sum();
                var Count = (from c in user.Marks select c).Count();
                var Average = (from a in user.Marks select a).Average();
                Console.WriteLine($"{user.Name}: Suma = {Sum}, Ilość = {Count}, Średnia = {Math.Round(Average, 2)}");
            }
            Console.WriteLine();

            //8. Najlepszą ocenę
            Console.Write("8.");
            var students = from user in Users where user.Marks != null && user.Marks.Count() > 0 select user;
            foreach (var user in students)
            {
                var max = (from b in user.Marks select b).Max();
                Console.WriteLine($"{user.Name} the best score= {max} ");
            }
            Console.WriteLine();

            //9. Najgorszą ocenę
            Console.Write("9.");
            foreach (var user in q7)
            {
                var min = (from b in user.Marks select b).Min();
                Console.WriteLine($"{user.Name} worst score= {min} ");
            }
            Console.WriteLine();

            //10. Najlepszego studenta
            Console.Write("10.");
            double beststudent = 0;
            foreach (var user in q7)
            {
                var average = (from d in user.Marks select d).Average();
                if (average > beststudent) beststudent = average;
            }

            var q10 = from user in Users where user.Marks != null && user.Marks.Count() > 0 && ((from d in user.Marks select d).Average()) == beststudent select user;
            foreach (var user in q10)
            {
                Console.Write(user.Name);
            }
            Console.WriteLine();
            Console.WriteLine();

            //11. Listę studentów, którzy posiadają najmniej ocen
            Console.Write("11.");
            var minCount = 5;
            foreach (var user in q7)
            {
                var count = (from c in user.Marks select c).Count();
                if (minCount > count) minCount = count;
            }
            var q11 = from user in Users where user.Marks != null && user.Marks.Count() > 0 && ((from c in user.Marks select c).Count()) == minCount select user;
            foreach (var user in q11)
            {
                Console.Write(user.Name);
            }
            Console.WriteLine();
            Console.WriteLine();

            //12. Listę studentów, którzy posiadają najwięcej ocen
            Console.Write("12.");
            var maxCount = 0;
            foreach (var user in q7)
            {
                var count = (from c in user.Marks select c).Count();
                if (maxCount < count) maxCount = count;
            }
            var q12 = from user in Users where user.Marks != null && user.Marks.Count() > 0 && ((from c in user.Marks select c).Count()) == maxCount select user;
            foreach (var user in q12)
            {
                Console.WriteLine(user.Name);
            }
            Console.WriteLine();

            //14. Studentów posortowanych od najlepszego
            Console.Write("14.");
            var q14 = from user in Users where user.Marks != null && user.Marks.Count() > 0 orderby ((from d in user.Marks select d).Average()) descending select user;
            foreach (var user in q14)
            {
                Console.WriteLine($"{user.Name} {Math.Round((from d in user.Marks select d).Average(), 2)}");
            }
            Console.WriteLine();

            //15. Średnią ocenę wszystkich studentów
            Console.Write("15.");
            double sumaSrednich = 0;
            foreach (var user in q7)
            {
                double Average = (from a in user.Marks select a).Average();
                sumaSrednich += Average;
            }
            Console.Write(Math.Round(sumaSrednich / q6, 2));
            Console.WriteLine();
            Console.WriteLine();


            //17. Listę użytkowników, którzy nie zostali usunięci (data usunięcia nie została ustawiona)
            Console.Write("17.");
            var q17 = from user in Users where user.RemovedAt == null select user;
            foreach (var user in q17)
            {
                Console.WriteLine(user.Name);
            }
            Console.WriteLine();

            //18. Najnowszego studenta (najnowsza data utworzenia)
            Console.Write("18. ");
            DateTime? newStudent = new(1, 10, 13);
            var q18 = from user in Users where user.Role == "STUDENT" && user.CreatedAt != null select user;
            foreach (var user in q18)
            {
                if (newStudent < user.CreatedAt) newStudent = user.CreatedAt;
            }
            Console.WriteLine(newStudent);
            Console.WriteLine();

        }
    }
}


