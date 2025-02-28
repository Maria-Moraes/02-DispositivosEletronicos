﻿using System.Reflection;
using System.Text.RegularExpressions;

namespace _02_DispositivosEletronicos.Models
{
    public class Smartphone : DispositivoEletronico
    {
        public bool Tem5G {  get; set; }
        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoDeFabricacao}, 5G: {(Tem5G ? "Sim" : "Não")}";
        }
    }
}
