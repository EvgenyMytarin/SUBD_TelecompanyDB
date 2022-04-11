using System;
using System.Windows.Forms;
using TelecomLogic.BindingModels;
using TelecomLogic.Interfaces;

namespace TelecomView
{
    public partial class FormClient : Form
    {
        public int Id { set { id = value; } }
        private readonly IClientLogic _logic;
        private int? id;

        public FormClient(IClientLogic logic)
        {
            InitializeComponent();
            _logic = logic;
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = _logic.Read(new ClientBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        TextBoxLastname.Text = view.last_name;
                        textBoxName.Text = view.name;
                        textBoxMiddlename.Text = view.middle_name;
                        textBoxPhone.Text = view.phone_number;
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
            if (string.IsNullOrEmpty(TextBoxLastname.Text))
            {
                MessageBox.Show("Заполните фамилию", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните имя", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logic.CreateOrUpdate(new ClientBindingModel
                {
                    Id = id,
                    last_name = TextBoxLastname.Text,
                    name = textBoxName.Text,
                    middle_name = textBoxMiddlename.Text,
                    phone_number = textBoxPhone.Text,
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