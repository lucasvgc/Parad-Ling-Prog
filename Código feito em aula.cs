using System;
class Test
{	
	static string mensagem;
	public static void Main()
	{
		//padrão cameCase
		int total = 0;
		
		total = somar(100,200);
		
		
		
		//A sina de 100 MAIS 200 é igual a 300
		//mensagem = "A soma de " + numero1 + " MAIS " 
		//						+ numero2 + " é igual a "
		//						+ total;
		
		Console.WriteLine(mensagem);
		Console.ReadLine();
	}
	
	static int somar(int numero1, int numero2)
	{
		return numero1 + numero2;
	}
	
	//help promp dos
	/*
		dir - lista o conteúdo da pasta
		cd .. - volta um nivel acima da pasta	
			ex. c:\windows\test\ cd .. 
				volta para c:\windows
		cd\ vai para a raiz do root c:\
		mkdir -  cria uma nova pasta dentro do diretório
			ex. mkdir nomeDaPasta
		cd nomeDaPasta - acessa a pasta.
		cls - limpa o prompt comando	
		
		*****************************
		Compilar um programa C#
		ex. 
		c:\plp\aula03\csc.exe nomeDoArquivo.cs
		
		
	*/
}