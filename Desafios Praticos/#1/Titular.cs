﻿class Titular
{
    public string Nome { get; set; }

    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;
    }

    public string Cpf { get; set; }
    public string Endereco { get; set; }
}