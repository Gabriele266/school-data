using System;
using SchoolData.Models;

namespace SchoolData.Mock
{
	public class StudentMock
	{
		protected StudentMock()
		{
        }

        /**
         *  Restituisce valori mock per gli studenti
         * */
        public static Student[] GetMockValues()
        {
            Student[] mock =
            {
                new Student(nome: "Giovanni", cognome: "Secondo", assenze: 20, classe: "5A", specializzazione: "Informatica", averageVote: 5),
                new Student(nome: "Gabriele", cognome: "Terzo", assenze: 5, classe: "5B", specializzazione: "Meccanica", averageVote: null),
                new Student(nome: "Albert", cognome: "Einstein", assenze: 0, classe: "4B", specializzazione: "Physics", averageVote: null),
                new Student(nome: "John", cognome: "Lennon", assenze: 0, classe: "3B", specializzazione: "Music", averageVote: null),
            };

            return mock;
        }
    }
}

