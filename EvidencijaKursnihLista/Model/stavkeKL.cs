namespace EvidencijaKursnihLista.Model
{
    public class StavkeKL
    {
        public int Id { get; set; }
        public string OznakaValuce { get; set; }
        public string SifraValute { get; set; }
        public string NazivZemlje { get; set; }
        public int VaziZa { get; set; }
        public decimal SrednjiKurs { get; set; }
        public decimal KupovniKurs { get; set; }
        public decimal ProdajniKurs { get; set; }
    }
}
