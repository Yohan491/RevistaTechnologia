using System;


namespace tristezaTotal.Models
{
    public class Revistas
    {
        //Constructor
        public Revistas() => register = DateTime.Now;

        public int Id { get; set; }
        public string nome { get; set; }

        public DateTime register { get; set; }

        //ToString
        public override string ToString() =>
        $"id: {Id} | Nome: {nome} | Criado em: {register}";

    }
}