using System;

class Program {
  public static void Main (string[] args) {
    // Exercício 1 -----------------------------------
    // Faça um programa que simule a aceleração de dois carros de fórmula 1 que estão acelerando, o veículo 1 está inicialmente a 200 km/h e o veículo 2 a 180 km/h, a cada repetição o veículo 1 aumenta sua velocidade em 1 km/h, e o veículo 2 aumenta sua velocidade em 3 km/h, enquanto a velocidade do veículo 1 não for superior a do veículo 2 o programa deverá continuar a execução, assim que a velocidade de 2 for maior o ciclo de repetição deverá ser interrompido, a duração máxima é de 15 voltas.
    int veic1 = 200;
    int veic2 = 180;

    while (true){
      veic1 += 1;
      veic2 += 3;
      
      if(veic2 > veic1){
        break;
      }
    }

    // Exercício 2 --------------------------------
    //  Faça um programa que recebe 5 notas, que podem variar de 0 a 100, caso uma das notas seja fora deste eixo de valores, o usuário deve digitar as notas até atingir um valor válido, caso em algum momento as notas digitadas superarem o valor 300 o programa deve encerrar a execução e imprimir na tela: “Aprovado”, caso as 5 notas sejam digitadas, verifique se soma é superior a 300 e imprima “Aprovado” caso seja maior e “Reprovado” caso seja menor.
    int soma = 0;
    for(int i = 0; i < 5; i++){
      int nota;
      while(true){
        Console.WriteLine("Escreva uma nota: " );
        nota = Convert.ToInt32(Console.ReadLine());
        if(nota >= 0 && nota <= 100){
          break;
        }
        Console.WriteLine("Digite uma nota válida!");
      }
      soma += nota;
      if(soma > 300){
        break;
      }
    }

    if(soma >= 300){
      Console.WriteLine("Aprovado");
    } else {
      Console.WriteLine("Reprovado");
    }
  }
}