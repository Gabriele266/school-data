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

        public Student(String nome, String cognome, int assenze, String? classe, String? specializzazione, float? averageVote)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.assenze = assenze;
            this.classe = classe;
            this.specializzazione = specializzazione;
            this.averageVote = averageVote;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return "Studente " + Id;
        }

        public bool Equals(Student obj)
        {
            return this.Id == obj.Id;
        }
    }
}