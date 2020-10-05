using System;

namespace RegiaoIbge.App
{
    public class Cidade
    {
        public int Id { get; set; }
        public string CodigoMunicipio { get; set; }
        public string NomeMunicipio { get; set; }
        public string Mesorregiao { get; set; }
        public Uf? Uf { get; set; }
    }

    public enum Uf
    {
        Rondonia = 11,
        Acre = 12,
        Amazonas = 13,
        Roraima = 14,
        Para = 15,
        Amapa = 16,
        Tocantis = 17,
        Maranhao = 21,
        Piaui = 22,
        Ceara = 23,
        RioGrandeDoNorte = 24,
        Paraiba = 25,
        Pernambuco = 26,
        Alagoas = 27,
        Sergipe = 28,
        Bahia = 29,
        MinasGerais = 31,
        EspiritoSanto = 32,
        RioDeJaneiro = 33,
        SaoPaulo = 34,
        Parana = 41,
        SantaCatarina = 42,
        RioGrandeDoSul = 43,
        MatoGrossoDoSul = 50,
        MatoGrosso = 51,
        Goias = 52,
        DistritoFederal = 53,
        Exterior = 99

    }
}