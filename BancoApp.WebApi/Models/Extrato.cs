public class Extrato
{
    public int Id { get; set; }
    public int CorrentistaId { get; set; }
    public DateTime Data { get; set; }
    public string TipoTransacao { get; set; }
    public decimal Valor { get; set; }
}