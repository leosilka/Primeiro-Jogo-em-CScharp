string mensagemBoasVindas = "Seja bem vindo(a)";
Random numeroAleatorio = new Random();
int numeroAdivinhacao = numeroAleatorio.Next(1, 11);
int acertos = 0;
int erros = 0;
int contador = 0;

void LogoDoJogo()
{
    Console.WriteLine(@"
                               dMMMMMP .aMMMb  .aMMMMP .aMMMb                      
                                  dMP dMP""dMP dMP""    dMP""dMP                      
                                 dMP dMP dMP dMP MMP""dMP dMP                       
                            dK .dMP dMP.aMP dMP.dMP dMP.aMP                        
                            VMMMP""  VMMMP""  VMMMP""  VMMMP""                         
                                                                                   
                                    dMMMMb  dMMMMMP                                
                                   dMP VMP dMP                                     
                                  dMP dMP dMMMP                                    
                                 dMP.aMP dMP                                       
                                dMMMMP"" dMMMMMP                                    
                                                                                   
    .aMMMb  dMMMMb  dMP dMP dMP dMP dMMMMb  dMP dMP .aMMMb  .aMMMb  .aMMMb  .aMMMb 
   dMP""dMP dMP VMP amr dMP dMP amr dMP dMP dMP dMP dMP""dMP dMP""VMP dMP""dMP dMP""dMP 
  dMMMMMP dMP dMP dMP dMP dMP dMP dMP dMP dMMMMMP dMMMMMP dMP     dMMMMMP dMP dMP  
 dMP dMP dMP.aMP dMP  YMvAP"" dMP dMP dMP dMP dMP dMP dMP dMP.aMP dMP dMP dMP.aMP   
dMP dMP dMMMMP"" dMP    VP""  dMP dMP dMP dMP dMP dMP dMP  VMMMP"" dMP dMP  VMMMP""    
                                                                                   
");
}

void MenuJogo()
{
    Console.WriteLine(@"
        [1] - Registrar Usuário (Em desenvolvimento)
        [2] - Iniciar Jogo 
        [3] - Ver Pontuação (Em desenvolvimento)
        [9] - Sair
");
    Console.Write("Escolha uma Opção: ");
    string menuEscolha = Console.ReadLine()!;
    int menuEscolhaNumero = int.Parse(menuEscolha);

    switch (menuEscolhaNumero)
    {
        case 1:
            Console.WriteLine("Sistema em Desenvolvimento!");
            break;
        case 2:
            Console.WriteLine(mensagemBoasVindas);
            while (acertos != 1)
            {
                Console.Write("Adivinhe o número que estou pensando: ");
                string escolhaUsuario = Console.ReadLine()!;
                int numeroUsuario = int.Parse(escolhaUsuario);
                if (numeroUsuario == numeroAdivinhacao)
                {
                    contador++;
                    acertos++;
                    Console.WriteLine($"Parabéns, você acertou o número!");
                    Console.WriteLine($"Você teve {acertos} acerto em {contador} tentativas!");
                } else
                {
                    contador++;
                    erros++;
                    Console.WriteLine($"Infelizmente você errou! Tente Novamente!");
                }

            }
            break;
        case 3:
            Console.WriteLine("Sistema em Desenvolvimento!");
            break;
        case 9:
            Console.WriteLine("Sistema em Desenvolvimento!");
            break;
        default:
            Console.WriteLine("Opção Invalida!");
            break;
    }
}

LogoDoJogo();
MenuJogo();