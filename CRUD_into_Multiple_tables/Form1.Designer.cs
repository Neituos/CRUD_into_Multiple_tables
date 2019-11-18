namespace CRUD_into_Multiple_tables
{
    partial class IHM_Crud_With_Two_Tables
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelCustomerIDNotUsed = new System.Windows.Forms.Label();
            this.dataGridViewAdress = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAddAddress = new System.Windows.Forms.Button();
            this.labelAdressNotUsed = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmailNotUsed = new System.Windows.Forms.Label();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.labelFullNameNotUsed = new System.Windows.Forms.Label();
            this.textBoxIdUser = new System.Windows.Forms.TextBox();
            this.dataGridViewCustomer = new System.Windows.Forms.DataGridView();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.streetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdress)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(426, 408);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 26);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelCustomerIDNotUsed
            // 
            this.labelCustomerIDNotUsed.AutoSize = true;
            this.labelCustomerIDNotUsed.Location = new System.Drawing.Point(22, 18);
            this.labelCustomerIDNotUsed.Name = "labelCustomerIDNotUsed";
            this.labelCustomerIDNotUsed.Size = new System.Drawing.Size(69, 13);
            this.labelCustomerIDNotUsed.TabIndex = 1;
            this.labelCustomerIDNotUsed.Text = "Id utilisateur :";
            // 
            // dataGridViewAdress
            // 
            this.dataGridViewAdress.AllowUserToAddRows = false;
            this.dataGridViewAdress.AllowUserToDeleteRows = false;
            this.dataGridViewAdress.AutoGenerateColumns = false;
            this.dataGridViewAdress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAdress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.streetDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn});
            this.dataGridViewAdress.DataSource = this.addressBindingSource;
            this.dataGridViewAdress.Location = new System.Drawing.Point(114, 94);
            this.dataGridViewAdress.Name = "dataGridViewAdress";
            this.dataGridViewAdress.Size = new System.Drawing.Size(523, 94);
            this.dataGridViewAdress.TabIndex = 3;
            this.dataGridViewAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewAdress_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAddAddress);
            this.panel1.Controls.Add(this.labelAdressNotUsed);
            this.panel1.Controls.Add(this.dataGridViewAdress);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.labelEmailNotUsed);
            this.panel1.Controls.Add(this.textBoxFullName);
            this.panel1.Controls.Add(this.labelFullNameNotUsed);
            this.panel1.Controls.Add(this.textBoxIdUser);
            this.panel1.Controls.Add(this.labelCustomerIDNotUsed);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 203);
            this.panel1.TabIndex = 0;
            // 
            // buttonAddAddress
            // 
            this.buttonAddAddress.Location = new System.Drawing.Point(643, 94);
            this.buttonAddAddress.Name = "buttonAddAddress";
            this.buttonAddAddress.Size = new System.Drawing.Size(24, 23);
            this.buttonAddAddress.TabIndex = 4;
            this.buttonAddAddress.Text = "+";
            this.buttonAddAddress.UseVisualStyleBackColor = true;
            this.buttonAddAddress.Click += new System.EventHandler(this.buttonAddAddress_Click);
            // 
            // labelAdressNotUsed
            // 
            this.labelAdressNotUsed.AutoSize = true;
            this.labelAdressNotUsed.Location = new System.Drawing.Point(22, 94);
            this.labelAdressNotUsed.Name = "labelAdressNotUsed";
            this.labelAdressNotUsed.Size = new System.Drawing.Size(51, 13);
            this.labelAdressNotUsed.TabIndex = 9;
            this.labelAdressNotUsed.Text = "Adresse :";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "email", true));
            this.textBoxEmail.Location = new System.Drawing.Point(114, 68);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(306, 20);
            this.textBoxEmail.TabIndex = 2;
            // 
            // labelEmailNotUsed
            // 
            this.labelEmailNotUsed.AutoSize = true;
            this.labelEmailNotUsed.Location = new System.Drawing.Point(22, 70);
            this.labelEmailNotUsed.Name = "labelEmailNotUsed";
            this.labelEmailNotUsed.Size = new System.Drawing.Size(41, 13);
            this.labelEmailNotUsed.TabIndex = 7;
            this.labelEmailNotUsed.Text = "Email  :";
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "name", true));
            this.textBoxFullName.Location = new System.Drawing.Point(114, 42);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(306, 20);
            this.textBoxFullName.TabIndex = 1;
            // 
            // labelFullNameNotUsed
            // 
            this.labelFullNameNotUsed.AutoSize = true;
            this.labelFullNameNotUsed.Location = new System.Drawing.Point(22, 44);
            this.labelFullNameNotUsed.Name = "labelFullNameNotUsed";
            this.labelFullNameNotUsed.Size = new System.Drawing.Size(85, 13);
            this.labelFullNameNotUsed.TabIndex = 5;
            this.labelFullNameNotUsed.Text = "Nom et prénom :";
            // 
            // textBoxIdUser
            // 
            this.textBoxIdUser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "CustomerID", true));
            this.textBoxIdUser.Location = new System.Drawing.Point(114, 16);
            this.textBoxIdUser.Name = "textBoxIdUser";
            this.textBoxIdUser.ReadOnly = true;
            this.textBoxIdUser.Size = new System.Drawing.Size(132, 20);
            this.textBoxIdUser.TabIndex = 0;
            // 
            // dataGridViewCustomer
            // 
            this.dataGridViewCustomer.AllowUserToAddRows = false;
            this.dataGridViewCustomer.AllowUserToDeleteRows = false;
            this.dataGridViewCustomer.AutoGenerateColumns = false;
            this.dataGridViewCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.Delete});
            this.dataGridViewCustomer.DataSource = this.customersBindingSource;
            this.dataGridViewCustomer.Location = new System.Drawing.Point(12, 253);
            this.dataGridViewCustomer.Name = "dataGridViewCustomer";
            this.dataGridViewCustomer.Size = new System.Drawing.Size(732, 149);
            this.dataGridViewCustomer.TabIndex = 3;
            this.dataGridViewCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellClick);
            this.dataGridViewCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCustomer_CellContentClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(507, 408);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(79, 26);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Modifier";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(669, 408);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(79, 26);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "&Enregister";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(588, 408);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(79, 26);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Annuler";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(84, 227);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(660, 20);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Recherche :";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Supprimer";
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataSource = typeof(CRUD_into_Multiple_tables.Customers);
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // streetDataGridViewTextBoxColumn
            // 
            this.streetDataGridViewTextBoxColumn.DataPropertyName = "Street";
            this.streetDataGridViewTextBoxColumn.HeaderText = "Street";
            this.streetDataGridViewTextBoxColumn.Name = "streetDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // addressBindingSource
            // 
            this.addressBindingSource.DataSource = typeof(CRUD_into_Multiple_tables.Address);
            // 
            // IHM_Crud_With_Two_Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.dataGridViewCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonAdd);
            this.Name = "IHM_Crud_With_Two_Tables";
            this.Text = "Crud avec deux tables";
            this.Load += new System.EventHandler(this.IHM_Crud_With_Two_Tables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdress)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelCustomerIDNotUsed;
        private System.Windows.Forms.DataGridView dataGridViewAdress;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIdUser;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmailNotUsed;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Label labelFullNameNotUsed;
        private System.Windows.Forms.Label labelAdressNotUsed;
        private System.Windows.Forms.Button buttonAddAddress;
        private System.Windows.Forms.DataGridView dataGridViewCustomer;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn streetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addressBindingSource;
    }
}

