namespace bpAPI
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string CPF { get; set; } = string.Empty;
        public string RG { get; set; } = string.Empty;
        public string NomePai { get; set; } = string.Empty;
        public string NomeMae { get; set; } = string.Empty;
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; } = string.Empty;
        public string CEP { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public int Numero { get; set; } = 0;
        public string Estado { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;

    }
}
