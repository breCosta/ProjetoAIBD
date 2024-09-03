namespace ProjetoBD.Entidades
{
    public class Candidato
    {
        public string NomeCandidato {  get; set; }
        public DateTime DtaNasc {  get; set; }
        public Contato Contato { get; set; }
        public Endereço Endereço { get; set; }
    }
}
