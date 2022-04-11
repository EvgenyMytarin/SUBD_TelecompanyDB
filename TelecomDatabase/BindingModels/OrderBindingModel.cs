namespace TelecomLogic.BindingModels
{
    public class OrderBindingModel
    {
        public int? Id { get; set; }

        public DateTime date_conclusion { get; set; }

        public string name_service { get; set; }

        public string name_tariff { get; set; }

        public string name_client { get; set; }
    }
}