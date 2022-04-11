using System;
using System.Windows.Forms;
using TelecomLogic.BindingModels;
using TelecomLogic.Interfaces;

namespace TelecomView
{
    public partial class FormTariff : Form
    {
        public int Id { set { id = value; } }
        private readonly ITariffLogic _logic;
        private int? id;

        public FormTariff(ITariffLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void FormTariff_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = _logic.Read(new TariffBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        TextBoxTariffName.Text = view.name_tariff;
                        textBoxUnitTariff.Text = view.unit_tariff;
                        textBoxService.Text = view.name_service;
                        textBoxAmountTariff.Text = Convert.ToString(view.amount_tariff);
                        textBoxAmountOvertariff.Text = Convert.ToString(view.amount_tariff);
                        textBoxPriceTariff.Text = Convert.ToString(view.price_tariff);
                        textBoxPriceOvertariff.Text = Convert.ToString(view.price_overtariff);
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
            if (string.IsNullOrEmpty(TextBoxTariffName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxUnitTariff.Text))
            {
                MessageBox.Show("Заполните единицы измерения", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPriceTariff.Text))
            {
                MessageBox.Show("Заполните цену тарифа", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPriceOvertariff.Text))
            {
                MessageBox.Show("Заполните цену сверхтарифа или оставьте 0", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxAmountOvertariff.Text))
            {
                MessageBox.Show("Заполните единицы тарифа", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxAmountTariff.Text))
            {
                MessageBox.Show("Заполните единицы сверхтарифа", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxService.Text))
            {
                MessageBox.Show("Выберите услугу", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logic.CreateOrUpdate(new TariffBindingModel
                {
                    Id = id,
                    name_tariff = TextBoxTariffName.Text,
                    unit_tariff = textBoxUnitTariff.Text,
                    name_service = textBoxService.Text,
                    amount_tariff = Convert.ToInt32(textBoxAmountTariff.Text),
                    price_tariff = Convert.ToDecimal(textBoxPriceTariff.Text),
                    amount_overtariff = Convert.ToInt32(textBoxAmountOvertariff.Text),
                    price_overtariff = Convert.ToDecimal(textBoxPriceOvertariff.Text),
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