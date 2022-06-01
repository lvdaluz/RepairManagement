using System;
using System.Text.RegularExpressions;

namespace Domain.Entities
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset BirthDate { get; set; }
        public string Cpf { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }

        public bool IsValid() =>
            Name?.Length >= 3
            && BirthDate != null
            && Cpf?.Length == 11 && Regex.IsMatch(Cpf, "\\d{11}")
            && Logradouro != null
            && Cep?.Length == 8 && Regex.IsMatch(Cep, "\\d{8}");
    }
}