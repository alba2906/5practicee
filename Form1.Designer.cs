

namespace _5practicee
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstTransport;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtPow;
        private System.Windows.Forms.TextBox txtModelyear;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblPow;
        private System.Windows.Forms.Label lblModelyear;
        private System.Windows.Forms.Label lblType;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lstTransport = new ListBox();
            txtFirma = new TextBox();
            txtModel = new TextBox();
            txtPrice = new TextBox();
            txtSpeed = new TextBox();
            txtPow = new TextBox();
            txtModelyear = new TextBox();
            cmbType = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnShow = new Button();
            btnSave = new Button();
            lblFirma = new Label();
            lblModel = new Label();
            lblPrice = new Label();
            lblSpeed = new Label();
            lblPow = new Label();
            lblModelyear = new Label();
            lblType = new Label();
            SuspendLayout();
            // 
            // lstTransport
            // 
            lstTransport.FormattingEnabled = true;
            lstTransport.ItemHeight = 15;
            lstTransport.Location = new Point(12, 12);
            lstTransport.Name = "lstTransport";
            lstTransport.Size = new Size(605, 229);
            lstTransport.TabIndex = 0;
            // 
            // txtFirma
            // 
            txtFirma.Location = new Point(12, 303);
            txtFirma.Name = "txtFirma";
            txtFirma.Size = new Size(260, 23);
            txtFirma.TabIndex = 3;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(12, 347);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(260, 23);
            txtModel.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(12, 391);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(260, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtSpeed
            // 
            txtSpeed.Location = new Point(12, 435);
            txtSpeed.Name = "txtSpeed";
            txtSpeed.Size = new Size(260, 23);
            txtSpeed.TabIndex = 9;
            // 
            // txtPow
            // 
            txtPow.Location = new Point(12, 479);
            txtPow.Name = "txtPow";
            txtPow.Size = new Size(260, 23);
            txtPow.TabIndex = 11;
            // 
            // txtModelyear
            // 
            txtModelyear.Location = new Point(12, 523);
            txtModelyear.Name = "txtModelyear";
            txtModelyear.Size = new Size(260, 23);
            txtModelyear.TabIndex = 13;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "Транспортное средство", "Электросамокат", "Автомобиль" });
            cmbType.Location = new Point(12, 259);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(260, 23);
            cmbType.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(171, 552);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(420, 552);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(510, 537);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(119, 23);
            btnEdit.TabIndex = 17;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(277, 552);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(122, 23);
            btnShow.TabIndex = 18;
            btnShow.Text = "Показать список";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(510, 566);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 23);
            btnSave.TabIndex = 19;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblFirma
            // 
            lblFirma.AutoSize = true;
            lblFirma.Location = new Point(12, 285);
            lblFirma.Name = "lblFirma";
            lblFirma.Size = new Size(45, 15);
            lblFirma.TabIndex = 4;
            lblFirma.Text = "Фирма";
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(12, 329);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(50, 15);
            lblModel.TabIndex = 6;
            lblModel.Text = "Модель";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(12, 373);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(35, 15);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Цена";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(12, 417);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(143, 15);
            lblSpeed.TabIndex = 10;
            lblSpeed.Text = "Максимальная скорость";
            // 
            // lblPow
            // 
            lblPow.AutoSize = true;
            lblPow.Location = new Point(12, 461);
            lblPow.Name = "lblPow";
            lblPow.Size = new Size(67, 15);
            lblPow.TabIndex = 12;
            lblPow.Text = "Мощность";
            // 
            // lblModelyear
            // 
            lblModelyear.AutoSize = true;
            lblModelyear.Location = new Point(12, 505);
            lblModelyear.Name = "lblModelyear";
            lblModelyear.Size = new Size(75, 15);
            lblModelyear.TabIndex = 14;
            lblModelyear.Text = "Год выпуска";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(12, 241);
            lblType.Name = "lblType";
            lblType.Size = new Size(93, 15);
            lblType.TabIndex = 2;
            lblType.Text = "Тип транспорта";
            // 
            // Form1
            // 
            ClientSize = new Size(635, 601);
            Controls.Add(btnSave);
            Controls.Add(btnShow);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblModelyear);
            Controls.Add(txtModelyear);
            Controls.Add(lblPow);
            Controls.Add(txtPow);
            Controls.Add(lblSpeed);
            Controls.Add(txtSpeed);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(lblModel);
            Controls.Add(txtModel);
            Controls.Add(lblFirma);
            Controls.Add(txtFirma);
            Controls.Add(lblType);
            Controls.Add(cmbType);
            Controls.Add(lstTransport);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
