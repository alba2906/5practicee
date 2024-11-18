

namespace _5practicee
{
    public partial class Form1 : Form
    {
        private List<Transport> transportList = new List<Transport>();
        private int selectedIndex = -1;

        public Form1()
        {
            InitializeComponent();
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string type = cmbType.SelectedItem?.ToString();
            txtPow.Visible = type == "Электросамокат";
            lblPow.Visible = type == "Электросамокат";
            txtModelyear.Visible = type == "Автомобиль";
            lblModelyear.Visible = type == "Автомобиль";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Проверка, что элемент выбран в ComboBox
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип из списка.");
                return;
            }

            string type = cmbType.SelectedItem.ToString();
            string firma = txtFirma.Text.Trim();
            string model = txtModel.Text.Trim();

            if (!int.TryParse(txtPrice.Text.Trim(), out int price))
            {
                MessageBox.Show("Неверная цена(руб.). Попробуйте снова.");
                return;
            }

            if (!int.TryParse(txtSpeed.Text.Trim(), out int speed))
            {
                MessageBox.Show("Неверная максимальная скорость (км/ч). Попробуйте снова.");
                return;
            }

            if (type == "Транспортное средство")
            {
                transportList.Add(new Transport(firma, model, price, speed));
            }
            else if (type == "Электросамокат")
            {
                if (!int.TryParse(txtPow.Text.Trim(), out int pow))
                {
                    MessageBox.Show("Неверная мощность(Вт). Попробуйте снова.");
                    return;
                }
                transportList.Add(new Escooter(firma, model, price, speed, pow));
            }
            else if (type == "Автомобиль")
            {
                if (!int.TryParse(txtModelyear.Text.Trim(), out int modelyear))
                {
                    MessageBox.Show("Неверный год выпуска. Попробуйте снова.");
                    return;
                }
                transportList.Add(new Auto(firma, model, price, speed, modelyear));
            }

            UpdateListBox();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstTransport.SelectedIndex >= 0)
            {
                transportList.RemoveAt(lstTransport.SelectedIndex);
                UpdateListBox();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lstTransport.SelectedIndex >= 0)
            {
                selectedIndex = lstTransport.SelectedIndex;
                Transport selectedTransport = transportList[selectedIndex];

                txtFirma.Text = selectedTransport.Firma;
                txtModel.Text = selectedTransport.Model;
                txtPrice.Text = selectedTransport.Price.ToString();
                txtSpeed.Text = selectedTransport.Speed.ToString();

                if (selectedTransport is Escooter escooter)
                {
                    cmbType.SelectedItem = "Электросамокат";
                    txtPow.Text = escooter.Pow.ToString();
                }
                else if (selectedTransport is Auto auto)
                {
                    cmbType.SelectedItem = "Автомобиль";
                    txtModelyear.Text = auto.Modelyear.ToString();
                }
                else
                {
                    cmbType.SelectedItem = "Транспортное средство";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedIndex >= 0)
            {
                string type = cmbType.SelectedItem.ToString();
                string firma = txtFirma.Text.Trim();
                string model = txtModel.Text.Trim();

                if (!int.TryParse(txtPrice.Text.Trim(), out int price))
                {
                    MessageBox.Show("Неверная цена(руб.). Попробуйте снова.");
                    return;
                }

                if (!int.TryParse(txtSpeed.Text.Trim(), out int speed))
                {
                    MessageBox.Show("Неверная максимальная скорость (км/ч). Попробуйте снова.");
                    return;
                }

                Transport selectedTransport = transportList[selectedIndex];

                if (type == "Транспортное средство")
                {
                    selectedTransport = new Transport(firma, model, price, speed);
                }
                else if (type == "Электросамокат")
                {
                    if (!int.TryParse(txtPow.Text.Trim(), out int pow))
                    {
                        MessageBox.Show("Неверная мощность(Вт). Попробуйте снова.");
                        return;
                    }
                    selectedTransport = new Escooter(firma, model, price, speed, pow);
                }
                else if (type == "Автомобиль")
                {
                    if (!int.TryParse(txtModelyear.Text.Trim(), out int modelyear))
                    {
                        MessageBox.Show("Неверный год выпуска. Попробуйте снова.");
                        return;
                    }
                    selectedTransport = new Auto(firma, model, price, speed, modelyear);
                }

                transportList[selectedIndex] = selectedTransport;
                UpdateListBox();
                ClearFields();
                selectedIndex = -1;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void UpdateListBox()
        {
            lstTransport.Items.Clear();
            foreach (var transport in transportList)
            {
                string details = $"{transport.Firma} {transport.Model} (Цена: {transport.Price}, Максимальная скорость: {transport.Speed}";
                if (transport is Escooter escooter)
                {
                    details += $", Мощность: {escooter.Pow})";
                }
                else if (transport is Auto auto)
                {
                    details += $", Год выпуска: {auto.Modelyear})";
                }
                else
                {
                    details += ")";
                }
                lstTransport.Items.Add(details);
            }
        }

        private void ClearFields()
        {
            txtFirma.Clear();
            txtModel.Clear();
            txtPrice.Clear();
            txtSpeed.Clear();
            txtPow.Clear();
            txtModelyear.Clear();
            cmbType.SelectedIndex = -1;
        }
    }
}
