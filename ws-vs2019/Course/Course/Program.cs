using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            double preco = double.Parse(Console.ReadLine());
            double desconto;

            if (preco < 20)
            {
                desconto = preco * 0.1;
                Console.WriteLine(desconto);
            }
            else
            {
                desconto = preco * 0.05;
                Console.WriteLine(desconto);
            }

        }
    }
}





    /*
    // ===================== EXERCICIO DE CONJUNTOS =======================

HashSet<int> A = new HashSet<int>();
HashSet<int> B = new HashSet<int>();
HashSet<int> C = new HashSet<int>();

Console.Write("O curso A possui quantos alunos? ");
            int a = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o código dos alunos do curso A: ");

            for (int i = 0; i<a; i++)
            {
                int aa = int.Parse(Console.ReadLine());
A.Add(aa);
            }

            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=--=-=-=-");
            Console.WriteLine();

            Console.WriteLine("O curso B possui quantos alunos? ");
            int b = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o código dos alunos do curso B: ");

            for (int i = 0; i<b; i++)
            {
                
                int bb = int.Parse(Console.ReadLine());
A.Add(bb);
            }

            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=--=-=-=-");
            Console.WriteLine();

            Console.WriteLine("O curso C possui quantos alunos? ");
            int c = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o código dos alunos do curso A: ");

            for (int i = 0; i<c; i++)
            {
                
                int cc = int.Parse(Console.ReadLine());
A.Add(cc);
            }

            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=--=-=-=-");
            Console.WriteLine();

            List<int> listA = new List<int>();
            
            foreach (int x in A)
            {
                listA.Add(x);
            }

            List<int> listB = new List<int>();

            foreach (int y in B)
            {
                listB.Add(y);
            }

            List<int> listC = new List<int>();

            foreach (int z in C)
            {
                listC.Add(z);
            }

            int total = listA.Count + listB.Count + listC.Count;
Console.WriteLine("Total de Alunos: " + total);



 
    // ================ CONJUNTOS ==========================
            
            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(1);
            A.Add(2);
            A.Add(3);
            A.Add(4);
            A.Add(5);

            B.Add(6);
            B.Add(7);
            B.Add(1);
            B.Add(2);

           // A.Remove(5); // Remove um valor
           


            foreach(int x in A)
                Console.WriteLine(x);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=");

            foreach (int y in B)
                Console.WriteLine(y);

            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=");

            Console.WriteLine("Digite um valor Inteiro: ");
            int N = int.Parse(Console.ReadLine());

            if (B.Contains(N))
            {
                Console.WriteLine(N + " Pertence ao conjunto B!");
            }
            else
            {
                Console.WriteLine(N + " Não pertence ao conjunto B!");
            }

            Console.WriteLine("-=-=-=-=-=-=-= REMOVER 'B' DE 'A' -=-=-=-=-=-=-=--=");

            A.ExceptWith(B); // Remove valores presentes no conjunto B, do conjunto A.
            foreach (int y in A)
                Console.WriteLine(y);

            Console.WriteLine("-=-=-=-=-=-=- UNIAO =-=-=-=-=-=-=-=--=");

            A.UnionWith(B);
            foreach (int y in A)
                Console.WriteLine(y);

            Console.WriteLine("-=-=-=-=-=-=- INTERSECÇÃO =-=-=-=-=-=-=-=--=");

            A.IntersectWith(B);
            foreach (int y in A)
                Console.WriteLine(y);
    
    
    
    
    
    // ========== MATRIZES - EXERCICIO DE FIXAÇÃO - ENCONTRAR NUMEROS EM VOLTA DO ALVO =====

    Console.WriteLine("Enter the Row´s number: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Collumn´s number: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[m, n];

            for (int i = 0; i < m; i++)
            {
                string[] values = Console.ReadLine().Split(' '); // ler strings e salvar num vetor

                for (int j = 0; j < m; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Enter a number to see around it: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] == x)
                    {
                        Console.WriteLine("Number position: " + "("+ i + "," + j + ")");
                        if (j > 0)
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        if (i > 0)
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        if (j < n - 1)
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        if (i < m - 1)
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                    }
                }
            }





// ================== MATRIZES - EXERCÍCIO RESOLVIDO======================

Console.WriteLine("Enter the Matrix order: ");
int n = int.Parse(Console.ReadLine());

// Declara uma matriz chamada mat
int[,] mat = new int[n, n];

// percorre as linhas - 00, 10, 20, ...
for (int i = 0; i < n; i++) 
{
    // Este comando le os valores e salva num vetor
    string[] values = Console.ReadLine().Split(' '); // Quebra as strings separando pelos espaços em branco e salva num vetor

    // Este segundo valor pega o vetor salvo e salva na primeira linha da matriz
    // Percorre as colunas e adiciona os valores nas posiçoes 00, 01, 02, ...
    for (int j = 0; j < n; j++) 
    {
        // converte os numeros para inteiro e guarda na matriz percorrendo as colunas
        mat[i, j] = int.Parse(values[j]);
    }
}

Console.WriteLine("Main Diagonal: ");
for(int i = 0; i < n; i++)
{
    // Para obter a diagonal, o numero da linah e da coluna são iguais, por isso usa-se [i,i]
    Console.Write(mat[i,i] + " "); // Posiç
    ão 11, 22, 33, 44, 55, ...
}
// Pula linha
Console.WriteLine();

// Quantos números negativos tem na matriz?
int count = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i,j] < 0)
        {
            count++;
        }
    }
}

Console.WriteLine("Negative Numbers: " + count);



//double[,] mat = new double[5, 5];
//Console.WriteLine(mat.Length);
//Console.WriteLine(mat.Rank);
//Console.WriteLine(mat.GetLength(0));
//Console.WriteLine(mat.GetLength(1));








// ================ LISTAS =======================
List<string> list = new List<string>();
list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Anna");
list.Insert(2, "Marco");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}
Console.WriteLine("List count: " + list.Count);
string s1 = list.Find(x => x[0] == 'A');

Console.WriteLine("First 'A': " + s1);
string s2 = list.FindLast(x => x[0] == 'A');

Console.WriteLine("Last 'A': " + s2);
int pos1 = list.FindIndex(x => x[0] == 'A');

Console.WriteLine("First position 'A': " + pos1);
int pos2 = list.FindLastIndex(x => x[0] == 'A');

Console.WriteLine("Last position 'A': " + pos2);
List<string> list2 = list.FindAll(x => x.Length == 5);

Console.WriteLine("---------------------");
foreach (string obj in list2)
{
    Console.WriteLine(obj);
}
list.Remove("Alex");
Console.WriteLine("---------------------");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}
list.RemoveAll(x => x[0] == 'M');
Console.WriteLine("---------------------");
foreach (string obj in list)
{
    Console.WriteLine(obj);
}







// =================== PENSIONATO ============================

Pensionato[] vect = new Pensionato[9];

for (int i = 0; i < 3; i++)
{
    Console.Write("Insira o nome do hóspede: ");
    string hospede = Console.ReadLine();

    Console.Write("Insira o e-mail do hóspede: ");
    string mail = Console.ReadLine();

    Console.Write("Insira o número do quarto escolhido: ");
    int quarto = int.Parse(Console.ReadLine());

    // pula linha
    Console.WriteLine();

    vect[i] = new Pensionato { Nome = hospede, Mail = mail, QuartoEscolhido = quarto };
}

for (int i = 0; i < 9; i++)
{
    if (vect[i] != null)
        {
        Console.WriteLine("Reserva: " + i);
        Console.Write("Nome do Hóspede: ");
        Console.WriteLine(vect[i].Nome);

        Console.Write("E-mail: ");
        Console.WriteLine(vect[i].Mail);

        Console.Write("Quarto reservado: ");
        Console.WriteLine(vect[i].QuartoEscolhido);

        Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
        Console.WriteLine();
    }
}





// ============ VETOR COM PONTEIROS PARA DUAS VARIÁVEIS - NÃO USA DUAS COLUNAS =============

Console.WriteLine("Insira a quantidade de produtos: ");
int n = int.Parse(Console.ReadLine());

Products[] vect = new Products[n];

for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Products { Name = name, Price = price };
}

double sum = 0;
for (int i = 0; i < n; i++)
{
    sum += vect[i].Price;
}

double avg = sum / n;
Console.WriteLine("The Average is: " + avg.ToString("F2", CultureInfo.InvariantCulture));






// ====================== VETORES / ARRAYS =============================

int n = int.Parse(Console.ReadLine());

double[] vect = new double[n];

for(int i = 0; i < n; i++)
{
    vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0;
for(int i = 0; i < n; i++)
{
    sum += vect[i];
}

double avg = sum / n;
Console.WriteLine("The Average Height is: " + avg.ToString("F2", CultureInfo.InvariantCulture));






// ============================ CONTA BANCARIA ==========================

Banco b = new Banco("", 0, 0);

Console.Write("Digite o Número da Conta: ");
int conta = int.Parse(Console.ReadLine());
b.SalvaConta(conta);

Console.WriteLine();

Console.Write("Digite o nome do titular da Conta: ");
b.Nome = Console.ReadLine();

Console.WriteLine();

// DEPOSITO INICIAL

Console.Write("Deseja fazer um depósito inicial? (S/N): ");
string sn = Console.ReadLine();

Console.WriteLine();

if (sn == "S" || sn == "s")
{
    Console.Write("Digite o VALOR DO DEPÓSITO: ");
    double inicial = double.Parse(Console.ReadLine());
    b.DepositoInicial(inicial);
    Console.WriteLine(b);
    Console.WriteLine();
}
else
{
    Console.WriteLine(b);
}

// ADICIONAR DEPÓSITO
Console.WriteLine();

Console.Write("Deseja fazer um depósito? (S/N): ");
string snd = Console.ReadLine();

Console.WriteLine();

if (snd == "S" || snd == "s")
{
    Console.Write("Digite o VALOR DO DEPÓSITO: ");
    double deposito = double.Parse(Console.ReadLine());
    b.AdicionaDeposito(deposito);
    Console.WriteLine(b);
    Console.WriteLine();
}
else
{
    Console.WriteLine(b);
}

// REALIZAR UM SAQUE

Console.WriteLine();

Console.Write("Deseja fazer um SAQUE? (S/N): ");
string sns = Console.ReadLine();

Console.WriteLine();

if (sns == "S" || sns == "s")
{
    Console.Write("Digite o VALOR DO SAQUE: ");
    double saque = double.Parse(Console.ReadLine());
    b.Saque(saque);
    Console.WriteLine(b);
    Console.WriteLine();
}
else
{
    Console.WriteLine(b);
}







// ================= TESTES DE ENCAPSULAMENTO - PROGRAMA PRODUTOS ==================

Produtos p = new Produtos("TV", 500.00, 10);

p.Nome = "T";

Console.WriteLine(p.Nome);
Console.WriteLine(p.Preco);



// ======================= RETANGULO ===========================

Retangulo Ret;
Ret = new Retangulo();

Console.Write("ENTRE COM A LARGURA DO RETÂNGULO: ");
Ret.Largura = double.Parse(Console.ReadLine());

Console.Write("ENTRE COM A ALTURA DO RETÂNGULO: ");
Ret.Altura = double.Parse(Console.ReadLine());

Console.WriteLine();

Console.Write(Ret);






// =========================== PRODUTOS ====================================


Console.Write("Entre com o NOME do Produto: ");
string nome = Console.ReadLine();

Console.Write("Entre com o PREÇO do Produto: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Entre com a QUANTIDADE de Itens: ");
int quantidade = int.Parse(Console.ReadLine());

// Estes parametros estão sendo passados pois um construtor na classe Produtos obriga a preencher
// os campos nome, preco e quantidade.
Produtos P = new Produtos(nome, preco, quantidade);

Console.WriteLine("DADOS DO PRODUTO: " + P );

Console.Write("Digite o número de produtos a ser ADICIONADO ao estoque: ");

int qtd = int.Parse(Console.ReadLine());
P.AdicionaProdutos(qtd);

// double ValorFinalAtualizado = P.ValorTotalAtualizado();

Console.WriteLine("DADOS ATUALIZADOS: " + P);

Console.Write("Digite o número de produtos a ser REMOVIDO ao estoque: ");

int qtdr = int.Parse(Console.ReadLine());
P.RemoveProdutos(qtdr);
Console.WriteLine("DADOS ATUALIZADOS: " + P);






/*
// ======================== TRIANGULO ===============================


Triangulo x, y;
x = new Triangulo();
y = new Triangulo();

Console.WriteLine("ENTRE COM AS MEDIDAS DO TRIÂNGULO X");

x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("ENTRE COM AS MEDIDAS DO TRIÂNGULO Y");

y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double AreaX = x.Area();
double AreaY = y.Area();

Console.WriteLine("Área do Triângulo X: " + AreaX.ToString("F4", CultureInfo.InvariantCulture));
Console.WriteLine("Área do Triângulo Y: " + AreaY.ToString("F4", CultureInfo.InvariantCulture));








// ============================ CADASTRO =================================

Pessoa primeiro, segundo;
primeiro = new Pessoa();
segundo = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");

Console.WriteLine("Nome: ");
primeiro.nome = Console.ReadLine();
Console.WriteLine("Idade: ");
primeiro.idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");

Console.WriteLine("Nome: ");
segundo.nome = Console.ReadLine();
Console.WriteLine("Idade: ");
segundo.idade = int.Parse(Console.ReadLine());

if (primeiro.idade > segundo.idade)
    Console.WriteLine("A pessoa mais velha é: " + primeiro.nome);
else
    Console.WriteLine("A pessoa mais velha é: " + segundo.nome);








// ============================== FUNCIONARIO =====================================

Console.WriteLine("=-=-=-=-=-=-=-=-=-=-=-=- FUNCIONARIO =-=-=-=-=-=-=-=-=-=-=-");

Funcionario primeiro2, segundo2, media;

    primeiro2 = new Funcionario();
    segundo2 = new Funcionario();
    media = new Funcionario();

    Console.WriteLine("Dados da primeira pessoa:");

    Console.WriteLine("Nome: ");
    primeiro2.nome = Console.ReadLine();
    Console.WriteLine("Salario: ");
    primeiro2.salario = double.Parse(Console.ReadLine());

    Console.WriteLine("Dados da segunda pessoa:");

    Console.WriteLine("Nome: ");
    segundo2.nome = Console.ReadLine();
    Console.WriteLine("Salario: ");
    segundo2.salario = double.Parse(Console.ReadLine());

    media.m = ((primeiro2.salario + segundo2.salario)/2);

    Console.WriteLine("A média do salário é: " + media.m);






// ------------------------------------------------------------------------------------

char genero = 'F';
int idade = 32;
double saldo = 10.35784;
String nome = "Maria";

Console.Write("Bom dia!");
Console.WriteLine("Boa tarde!");
Console.WriteLine("Boa noite!");
Console.WriteLine("---------------------------");
Console.WriteLine(genero);
Console.WriteLine(idade);
Console.WriteLine(saldo);
Console.WriteLine(nome);
Console.WriteLine(saldo.ToString("F2"));
Console.WriteLine(saldo.ToString("F4"));
Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));

// Técnica de Concatenação (ANTIGA)
Console.WriteLine(nome + " tem " + idade + " anos e possui um saldo de R$" + saldo.ToString("F2"));

// Técnica do Place Holder
Console.WriteLine("{0} tem {1} anos e tem um saldo de R${2:F2}", nome, idade, saldo);

// Técnica de interpolação
Console.WriteLine($"{nome} tem {idade} anos e possui um saldo de {saldo:F2}");







// -----------------------------------------------------------------------------

//Operadores Aritméticos

// Calculando Báskara

int n1 = 3 + 4 * 2;
int n2 = (3 + 4) * 2;
int n3 = 17 % 3;
double n4 = 10.0 / 8.0;
double a = 1.0, b = -3.0, c = -4.0;
double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.WriteLine(delta);
Console.WriteLine(x1);
Console.WriteLine(x2);

// ------------------------------------------------------------

*/


