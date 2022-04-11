using System;
using System.Windows.Forms;
using TelecomLogic.BindingModels;
using TelecomLogic.Interfaces;

namespace TelecomView
{
    public partial class FormService : Form
    {
        public int Id { set { id = value; } }
        private readonly IServiceLogic _logic;
        private int? id;

        public FormService(IServiceLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = _logic.Read(new ServiceBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        TextBoxServiceName.Text = view.name_service;
                        textBoxAvailability.Text = view.availability_overtariff;
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
            if (string.IsNullOrEmpty(TextBoxServiceName.Text))
            {
                MessageBox.Show("Заполните название услуги", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if ((string.IsNullOrEmpty(textBoxAvailability.Text)) || ((textBoxAvailability.Text != "Да") && (textBoxAvailability.Text != "Нет")))
            {
                MessageBox.Show("У этой услуги есть сверхтариф? Да/Нет", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logic.CreateOrUpdate(new ServiceBindingModel
                {
                    Id = id,
                    name_service = TextBoxServiceName.Text,
                    availability_overtariff = textBoxAvailability.Text,
                });
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