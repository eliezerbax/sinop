namespace SINOP.Domain.Entitys
{
    public class SinopEntity
    {

        public DateTime DataCriacao { get; set; }
        public DateTime DataUltimaModificacao { get; set; }
        public bool IsDelete { get; set; }
        public int IdUsuarioDelete { get; set; }
        public DateTime DataDelete { get; set; }
    }
}