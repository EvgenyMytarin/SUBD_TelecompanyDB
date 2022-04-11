using System;
using System.Windows.Forms;
using Unity;
using TelecomLogic.Interfaces;

namespace TelecomView
{
    public partial class FormMain : Form
    {
        private readonly IOrderLogic _orderLogic;

        public FormMain(IOrderLogic orderLogic)
        {
            _orderLogic = orderLogic;
            InitializeComponent();
        }

        private void button_client_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormClients>();
            form.ShowDialog();
        }

        private void button_service_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormServices>();
            form.ShowDialog();
        }

        private void button_tariff_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormTariffs>();
            form.ShowDialog();
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            var form = Program.Container.Resolve<FormOrders>();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var list = _orderLogic.Read(null);
        }
    }
}
