namespace PwaTVMC.Shared.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Municipio { get; set; }
        public string Bairro { get; set; }
        public string Uf { get; set; }
        public string Gps { get; set; }
    }
}