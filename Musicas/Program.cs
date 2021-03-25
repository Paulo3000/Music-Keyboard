using System;
using System.ComponentModel.Design;

namespace Musicas
{
    class Program
    {
        static void Main(string[] args)
        {

            int C = 264;// agudos e graves notas musicais
            int D = 297;
            int E = 330;
            int F = 352;
            int G = 396;
            int A = 440;
            int B = 495;
            int c = 528;
            int si_bmol = 467;
            int tempo_nota = 300, tempo2 = 200, tempo3 = 1000, cont = 0;
            int rapido = 200, extensso = 1000, escolha1 = 0;
        Menu:
            Console.WriteLine("PARA OUVIR A MUSICA digite 1\nPARA TOCAR O TECLADO digite2");
            escolha1 = int.Parse(Console.ReadLine());
            if (escolha1 == 1) { goto Musicas; }
            if (escolha1 == 2) { goto Teclado; }
            else
            {
                Console.Clear();
                Console.Beep(2000,rapido);
                Console.Beep(3000, rapido);
                Console.Beep(5000, rapido);
                Console.Beep(6000, rapido);
                goto Menu;
            }





        Musicas:
            while (true)
            {
                cont++;
                //329 duração da nota

                //ASA BRANCA
                Console.WriteLine("Asa branca");
                Console.Beep(F, tempo_nota);
                Console.Beep(D, tempo_nota);
                Console.Beep(E, tempo_nota);
                Console.Beep(C, tempo_nota);
                Console.Beep(D, tempo_nota);
                Console.Beep(B, tempo_nota);
                Console.Beep(C, tempo_nota);
                Console.Beep(A, tempo_nota);
                Console.Beep(B, tempo_nota);
                Console.Beep(G, tempo_nota);
                Console.Beep(A, tempo_nota);
                Console.Beep(G, tempo_nota);
                Console.Beep(E, tempo_nota);
                Console.Beep(G, tempo_nota);
                Console.Beep(G, tempo3);

                Console.Beep(F, tempo_nota);
                Console.Beep(D, tempo_nota);
                Console.Beep(E, tempo_nota);
                Console.Beep(C, tempo_nota);
                Console.Beep(D, tempo_nota);
                Console.Beep(B, tempo_nota);
                Console.Beep(C, tempo_nota);
                Console.Beep(A, tempo_nota);
                Console.Beep(B, tempo_nota);
                Console.Beep(G, tempo_nota);
                Console.Beep(A, tempo_nota);
                Console.Beep(G, tempo_nota);
                Console.Beep(E, tempo_nota);
                Console.Beep(G, tempo_nota);
                Console.Beep(G, tempo3);
                //-----------
                Console.Beep(G, tempo2);
                Console.Beep(A, tempo2);
                Console.Beep(B, tempo3);//nota estença
                Console.Beep(B, tempo3);
                Console.WriteLine("musica 2");

                //titanic
                Console.Beep(F, rapido);
                Console.Beep(G, rapido);
                Console.Beep(A, extensso);

                //-------
                Console.Beep(G, rapido);
                Console.Beep(A, rapido);
                Console.Beep(G, rapido);
                Console.Beep(F, rapido);
                Console.Beep(G, rapido);
                Console.Beep(C, extensso);

                //
                Console.Beep(si_bmol, rapido);
                Console.Beep(A, rapido);
                Console.Beep(F, rapido);
                Console.Beep(D, rapido);
                Console.Beep(D, extensso);

                if (cont == 2)
                {
                    goto Menu;
                }
            }
        Teclado:
            Console.WriteLine("\nPara tocar o telcado as notas são as letras\nC-D-E-F-G-A-B-Ç");
            char escolha;
            while (true)
            {
                escolha = Console.ReadKey().KeyChar;
                switch (escolha)
                {
                    case 'c':
                        Console.Beep(C, tempo_nota);
                        break;
                    case 'd':
                        Console.Beep(D, tempo_nota);
                        break;
                    case 'e':
                        Console.Beep(E, tempo_nota);
                        break;
                    case 'f':
                        Console.Beep(F, tempo_nota);
                        break;
                    case 'g':
                        Console.Beep(G, tempo_nota);
                        break;
                    case 'a':
                        Console.Beep(A, tempo_nota);
                        break;
                    case 'b':
                        Console.Beep(B, tempo_nota);
                        break;
                    case 'ç':
                        Console.Beep(c, tempo_nota);
                        break;



                }
            }





        }
    }
}
