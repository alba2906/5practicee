

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
            txtPow.Visible = type == "��������������";
            lblPow.Visible = type == "��������������";
            txtModelyear.Visible = type == "����������";
            lblModelyear.Visible = type == "����������";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // ��������, ��� ������� ������ � ComboBox
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("�������� ��� �� ������.");
                return;
            }

            string type = cmbType.SelectedItem.ToString();
            string firma = txtFirma.Text.Trim();
            string model = txtModel.Text.Trim();

            if (!int.TryParse(txtPrice.Text.Trim(), out int price))
            {
                MessageBox.Show("�������� ����(���.). ���������� �����.");
                return;
            }

            if (!int.TryParse(txtSpeed.Text.Trim(), out int speed))
            {
                MessageBox.Show("�������� ������������ �������� (��/�). ���������� �����.");
                return;
            }

            if (type == "������������ ��������")
            {
                transportList.Add(new Transport(firma, model, price, speed));
            }
            else if (type == "��������������")
            {
                if (!int.TryParse(txtPow.Text.Trim(), out int pow))
                {
                    MessageBox.Show("�������� ��������(��). ���������� �����.");
                    return;
                }
                transportList.Add(new Escooter(firma, model, price, speed, pow));
            }
            else if (type == "����������")
            {
                if (!int.TryParse(txtModelyear.Text.Trim(), out int modelyear))
                {
                    MessageBox.Show("�������� ��� �������. ���������� �����.");
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
                    cmbType.SelectedItem = "��������������";
                    txtPow.Text = escooter.Pow.ToString();
                }
                else if (selectedTransport is Auto auto)
                {
                    cmbType.SelectedItem = "����������";
                    txtModelyear.Text = auto.Modelyear.ToString();
                }
                else
                {
                    cmbType.SelectedItem = "������������ ��������";
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
                    MessageBox.Show("�������� ����(���.). ���������� �����.");
                    return;
                }

                if (!int.TryParse(txtSpeed.Text.Trim(), out int speed))
                {
                    MessageBox.Show("�������� ������������ �������� (��/�). ���������� �����.");
                    return;
                }

                Transport selectedTransport = transportList[selectedIndex];

                if (type == "������������ ��������")
                {
                    selectedTransport = new Transport(firma, model, price, speed);
                }
                else if (type == "��������������")
                {
                    if (!int.TryParse(txtPow.Text.Trim(), out int pow))
                    {
                        MessageBox.Show("�������� ��������(��). ���������� �����.");
                        return;
                    }
                    selectedTransport = new Escooter(firma, model, price, speed, pow);
                }
                else if (type == "����������")
                {
                    if (!int.TryParse(txtModelyear.Text.Trim(), out int modelyear))
                    {
                        MessageBox.Show("�������� ��� �������. ���������� �����.");
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
                string details = $"{transport.Firma} {transport.Model} (����: {transport.Price}, ������������ ��������: {transport.Speed}";
                if (transport is Escooter escooter)
                {
                    details += $", ��������: {escooter.Pow})";
                }
                else if (transport is Auto auto)
                {
                    details += $", ��� �������: {auto.Modelyear})";
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
