using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados
{
    class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine($"Valor do objeto: {meuObjeto}");

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "João Pedro";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"\nNome do aluno: {aluno.nome} \nNota do aluno: {aluno.nota} \nIdade do aluno: {aluno.idade}");
        }
    }
}
