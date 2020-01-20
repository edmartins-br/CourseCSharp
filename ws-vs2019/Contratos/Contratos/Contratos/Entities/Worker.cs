using Contratos.Entities.Enums;
using System.Collections.Generic; // namespace da classe lsit

namespace Contratos.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        // Composição de objetos
        public Department Department { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker()
        {

        }

        // Não incluir as associações "para muitos", não é usual passar uma
        // lista instanciada num construtor de um ojeto
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // Adiciona um contrato, fornecido no metodo.
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        // Remove um contrato, fornecido no metodo.
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        // Operação Income - quanto ganhou num dado e ano e mes
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}
