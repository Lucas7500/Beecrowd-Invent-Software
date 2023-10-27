using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;

class Corvo
{

    static void Main(string[] args)
    {
        Dictionary<string, int> binario_de_piscadas = new Dictionary<string, int>(){
                    {"--*",1},
                    {"-*-",2},
                    {"-**",3},
                    {"*--",4},
                    {"*-*",5},
                    {"**-",6},
                    {"***",7} };
        //List<int> minhaLista = new List<int>();

        List<int> entradas_recebidas = new List<int>();
        List<int> resultados_encontrados = new List<int>();
        int gritos_contados = 0;
        while (true)
        {
            if (gritos_contados < 3)
            {
                string entrada_do_usuario = Console.ReadLine();
                if (entrada_do_usuario != "caw caw")
                {
                    entradas_recebidas.Add(binario_de_piscadas[entrada_do_usuario]);
                    //Console.WriteLine($"Entrada adicionanada: { binario_de_piscadas[entrada_do_usuario]}");
                }
                else
                {
                    gritos_contados++;
                    int soma_entradas = 0;
                    foreach (var item in entradas_recebidas)
                    {
                        soma_entradas += item;
                    }
                    entradas_recebidas.Clear();
                    //Console.WriteLine($"Soma das entradas: {soma_entradas}");
                    resultados_encontrados.Add(soma_entradas);
                }
            }
            else
            {
                foreach (var item in resultados_encontrados)
                {
                    Console.WriteLine(item);
                }
                break;


            }



        }

    }

}