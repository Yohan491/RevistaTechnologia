using System;


namespace tristezaTotal.Models
{
    public class Pacotes
    {
        //Constructor
        public Pacotes() => register = DateTime.Now;

        public int Id { get; set; }
        public string nome { get; set; }
        public DateTime register { get; set; }

        //ToString
        public override string ToString() =>
        $"id: {Id} | Nome: {Id} | Criado em: {register}";

    }
}