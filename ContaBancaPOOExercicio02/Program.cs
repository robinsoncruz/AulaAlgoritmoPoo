using ContaBancaPOOExercicio02;

ContaBancaria _contabancaria=new ContaBancaria();

_contabancaria.Depositar(50);
_contabancaria.Saldo = 1500;
Console.Write(_contabancaria.getSaldo());


Console.ReadLine();


