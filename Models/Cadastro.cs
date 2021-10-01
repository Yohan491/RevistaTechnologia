using System;


namespace tristezaTotal.Models
{
    public class Cadastro
    {
        //Constructor
        public Cadastro() => register = DateTime.Now;

        public int Id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public DateTime register { get; set; }

        //ToString
        public override string ToString() =>
        $"id: {Id} | Nome: {nome} | Senha: {senha} | Criado em: {register}";

    }
}