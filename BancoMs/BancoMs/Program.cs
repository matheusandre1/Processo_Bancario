using BancoMs;
using BancoMs.Titular;

Console.WriteLine("Banco Ms");

/*ContaCorrente conta1 = new ContaCorrente();
conta1.titular = "Matheus André";
conta1.conta = "000001-X";
conta1.numero_agencia = 001;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 100;

ContaCorrente conta2 = new ContaCorrente();
conta1.titular = "Sara Galvão";
conta1.conta = "0000002-X";
conta1.numero_agencia = 002;
conta1.nome_agencia = "Agência Central";
conta1.saldo = 300; */

//Cliente cliente = new Cliente();
//cliente.nome = "Matheus";
//cliente.cpf = "12345678911";
//cliente.profissao = "Programador";

//ContaCorrente conta3 = new ContaCorrente();
//conta3.titular = new cliente;

//conta3.conta = "255555-X";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agência Brasil";

//Console.WriteLine(cliente.nome);
//Console.WriteLine(conta3.titular.nome);
//Console.WriteLine();

//Console.WriteLine();

Cliente Matheus = new Cliente();


ContaCorrente Conta4 = new ContaCorrente();
Conta4.Saldo = 500;
Conta4.Titular = Matheus;

Console.WriteLine("Saldo: " + Conta4.Saldo);
