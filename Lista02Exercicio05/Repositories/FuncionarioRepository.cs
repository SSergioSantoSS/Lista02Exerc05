using Lista02Exercicio05.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace Lista02Exercicio05.Repositories
{
    class FuncionarioRepository
    {
        public void ExportarDados(Funcionario funcionario)
        {
            var arquivo = $"c:\\Temp\\funcionario_{funcionario.IdFuncionario}.json";

            var formato = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            using (var streamWriter = new StreamWriter(arquivo))
            {
                streamWriter.WriteLine(formato);
            }

        }
    }
}
