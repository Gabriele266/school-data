using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SchoolData.Models
{
    /**
     * Rappresenta uno studente
     * */
	public class Student
	{
        public int Id { get; set; }
        [DisplayName("Nome")]
        public String? nome { get; set; }
        [DisplayName("Cognome")]
        public String? cognome { get; set; }
        [DisplayName("Assenze")]
        public int assenze { get; set; }
        [DisplayName("Classe")]
        public String? classe { get; set; }
        [DisplayName("Spec")]
        public String? specializzazione { get; set; }
        [DisplayName("Media voti")]
        public float? averageVote { get; set; }

        public Student(String nome, String cognome, int assenze, String? classe, String? specializzazione, int? average) 
        {
            this.nome = nome;
            this.cognome = cognome;
            this.assenze = assenze;
            this.classe = classe;
            this.specializzazione = specializzazione;
            this.averageVote = average;
        }

        public override string ToString()
        {
            return "Studente " + Id;
        }

        public bool Equals(Student obj)
        {
            return this.Id == obj.Id;
        }

        /**
         *  Restituisce valori mock per gli studenti
         * */
        public static Student[] GetMockValues()
        {
            Student[] mock =
            {
                new Student(nome: "Giovanni", cognome: "Secondo", assenze: 20, classe: "5A", specializzazione: "Informatica", average: null),
                new Student(nome: "Gabriele", cognome: "Terzo", assenze: 5, classe: "5B", specializzazione: "Meccanica", average: null),
                new Student(nome: "Albert", cognome: "Einstein", assenze: 0, classe: "4B", specializzazione: "Physics", average: null),
                new Student(nome: "John", cognome: "Lennon", assenze: 0, classe: "3B", specializzazione: "Music", average: null),
            };

            return mock;
        }
    }
}