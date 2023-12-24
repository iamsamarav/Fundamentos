using Fundamentos.Models;

Pessoa pessoaOne = new Pessoa();

pessoaOne.Nome = "Samara Vitória";
pessoaOne.Idade = 20;
pessoaOne.Apresentar();
pessoaOne.Produto = 20;
pessoaOne.Comprar();

Calculadora calculadoraOne = new Calculadora();

calculadoraOne.Somar(15, 30);
calculadoraOne.Potencia(3, 3);