namespace TitleTrack.Domain.Entities
{
    public class TitleAbstract
    {
        public int TitleAbstractID { get; set; }
        public string OrderNo { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? SearchDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public string? ClientRefNo { get; set; }
        public int PropertyID { get; set; }
        public Property Property { get; set; }
        public int ProductTypeID { get; set; }
        public ProductType ProductType { get; set; }
        public string? OrderStatus { get; set; }
        public DateTime? DueDate { get; set; }
    }
}
