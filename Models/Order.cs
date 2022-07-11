namespace TestApply.Models
{
    public partial class Order
    {
        public int IdOrder { get; set; }
        public string Description { get; set; }
        public int IdStatus { get; set; }
        public string NoStatus { get {
            return IdStatus == 1 ? "Pending" : IdStatus == 2 ? "Progress" : IdStatus == 3 ? "Completed" : "" ;
        } }
        // Status
        // 1 - Pending
        // 2 - Progress
        // 3 - Completed
    }
}
