using TelecomLogic.BindingModels;
using TelecomLogic.Interfaces;

namespace TelecomView
{
    public partial class FormOrder : Form
    {
        public int Id { set { id = value; } }
        private readonly IOrderLogic _logic;
        private int? id;

        public FormOrder(IOrderLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = _logic.Read(new OrderBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxNameClient.Text = view.name_client;                        
                        textBoxNameClient.Text = view.name_client;
                        textBoxNameService.Text = view.name_service;
                        textBoxNameTariff.Text = view.name_tariff;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNameClient.Text))
            {
                MessageBox.Show("Нужен клиент!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNameTariff.Text))
            {
                MessageBox.Show("Нужен тариф!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxNameService.Text))
            {
                MessageBox.Show("Нужна услуга!", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logic.CreateOrUpdate(new OrderBindingModel
                {
                    Id = id,                    
                    name_client = textBoxNameClient.Text,
                    name_service = textBoxNameService.Text,
                    name_tariff = textBoxNameTariff.Text,
                    date_conclusion = DateTime.Now,
                }) ;
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}