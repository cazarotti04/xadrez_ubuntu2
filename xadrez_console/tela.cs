using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
	class tela
	{
		public static void imprimirTabuleiro(Tabuleiro tab)
		{
			for(int i=0; i<tab.linhas; i++)
			{
				for(int j = 0; j < tab.colunas; j++)
				{
					if(tab.pp(i, j) == null)
					{
						Console.Write("- ");
					}
					Console.Write(tab.pp(i, j) +" ");
				}
				Console.WriteLine();
			}
		}
	}
}
