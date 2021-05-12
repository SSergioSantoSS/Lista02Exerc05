using System;
using Lista02Exercicio05.Entities;
using Lista02Exercicio05.Repositories;


namespace Lista02Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nCADASTRO DE FUNCIONÁRIOS");

            var funcionario = new Funcionario();

            funcionario.Departamento = new Departamento();


            funcionario.IdFuncionario = Guid.NewGuid();

            Console.WriteLine("\nPor favor, informe o nome do funcionário...:");
            funcionario.Nome = Console.ReadLine();

            Console.WriteLine("\nPor favor, informe o salário do funcionário...:");
            funcionario.Salario =double.Parse(Console.ReadLine());

            Console.WriteLine("\nPor favor, informe a data de admissão do funcionário...:");
            funcionario.DataAdmissao =DateTime.Parse(Console.ReadLine());

            Console.WriteLine("\nCADASTRO DO DEPARTAMENTO");

            Console.WriteLine("\nPor favor, informe o id do departamento do funcionário...:");
            funcionario.Departamento.IdDepartamento = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPor favor, informe o nome do departamento do funcionário...:");
            funcionario.Departamento.Nome = Console.ReadLine();

            Console.WriteLine("\nPor favor, descreva o departamento do funcionário...:");
            funcionario.Departamento.Descricao = Console.ReadLine();


            Console.WriteLine("\nPOR FAVOR, VERIFIQUE SE OS DADOS DO FUNCIONÁRIO ESTÃO CORRETOS");

            Console.WriteLine("ID..................:" + funcionario.IdFuncionario);
            Console.WriteLine("Nome................:" + funcionario.IdFuncionario);
            Console.WriteLine("Salário.............:" + funcionario.IdFuncionario);
            Console.WriteLine("Data de Admissão....:" + funcionario.IdFuncionario);
            
            
            Console.WriteLine("\nPOR FAVOR, VERIFIQUE SE OS DADOS DO DEPARTAMENTO ESTÃO CORRETOS");

            Console.WriteLine("ID..................:" + funcionario.Departamento.IdDepartamento);
            Console.WriteLine("Nome................:" + funcionario.Departamento.Nome);
            Console.WriteLine("Descrição...........:" + funcionario.Departamento.Descricao);


            var funcinarioRepository = new FuncionarioRepository();


            try
            {
                funcinarioRepository.ExportarDados(funcionario);
                Console.WriteLine("\nDADOS GRAVADOS COM SUCESSO!");
            }
            catch (Exception e)
            {

                Console.WriteLine("\nERRO..:"+e.Message);
            }
            Console.ReadKey();
        }
    }
}
