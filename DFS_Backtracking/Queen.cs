using System;
using System.Collections.Generic;
using System.Text;

namespace DFS_Backtracking
{
		public class Queen
		{
			/// <permbledhje>
			///**************************************************************************
			/// Kthehet true nese vendosja e mbretereshes nuk shkakton ndonje konflikt
			/// me mbretereshat e tjera q[n] permes q[n-1]
			/// **************************************************************************
			/// </permbledhje>
			public static bool IsConsistent(int[] q, int n)
			{
				for (int i = 0; i < n; i++)
				{
	
					if (q[i] == q[n])
					{
						return false; // kolona e njejte
					}
					if ((q[i] - q[n]) == (n - i))
					{
						return false; // Diagonalja e pare
					}
					if ((q[n] - q[i]) == (n - i))
					{
						return false; // Diagonalja e dyte
					}
					if (q[n] == 2)
					{
						return false; // Nese ka pozite blocked
					}
				}
				return true;
			}

			///*************************************************************************
			/// Printimi n-by-n i mbretereshave nga permutacioni q
			/// **************************************************************************
			
			public static void PrintQueens(int[] q)
			{
				int n = q.Length;

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if ((q[j] == 2 || q[i]==2) && (q[j] == i))
					{
						Console.Write(" 2 ");

					} else
					{
						if (q[i] == j)
						{
							Console.Write(" 1 ");
						}
						else
						{
							Console.Write(" 0 ");
						}
					}
					  
					
					}
					Console.Write("\n");
				}
				Console.Write("\n");
			}


			///*************************************************************************
			///  Provimi i te githa permutacioneve duke perdorur backtracking
			/// **************************************************************************
			
			public static void Enumerate(int n)
			{
				int[] a = new int[n];

				Random BlockedPos = new Random(); //Inicializimi i vlerave random per blocked positions

				int bp = BlockedPos.Next(2, 6); //Caktimi i range sa vlera me i marre blocked

				for (int k = 0; k < bp; k++)
				{
					int c = BlockedPos.Next(0, n); //Ne keto kolona vendosen vlerat 2 per blocked
					a[c] = 2; //Override i tabeles ku do te vendoset vlera 2, pra mbishkruhet 2 ne vend te 0.
				}

				Enumerate(a, 0);
			}

			public static void Enumerate(int[] q, int k)
			{
				int n = q.Length;
				if (k == n)
				{
					PrintQueens(q);
				}
				else
				{
					for (int i = 0; i < n; i++)
					{ 
						q[k] = i;
						if (IsConsistent(q, k))
						{
							Enumerate(q, k + 1);
						}
					}
				}
			}

		}

	}
