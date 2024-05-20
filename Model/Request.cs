namespace PeakInvestAPI.Model
{
    public class Request
    {
        public class CadastroRequest
        {
            public short Parcelas { get; set; }
            public decimal Valor { get; set; }
        }

        public class CadastroResponse
        {
            public decimal Resultado { get; set; }
        }

    }
}
