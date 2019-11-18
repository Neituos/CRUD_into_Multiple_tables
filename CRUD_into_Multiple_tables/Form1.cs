using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_into_Multiple_tables
{
    public partial class IHM_Crud_With_Two_Tables : Form
    {
        EcfDbEntities db;

        public IHM_Crud_With_Two_Tables()
        {
            InitializeComponent();
        }

        private void IHM_Crud_With_Two_Tables_Load(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            db = new EcfDbEntities();
            db.Configuration.ProxyCreationEnabled = false;
            db.Configuration.LazyLoadingEnabled = false;
            customersBindingSource.DataSource = db.Customers.Include("Address").ToList();
            ShowAddress();
        }

        private void ShowAddress()
        {
            Customers obj = customersBindingSource.Current as Customers;
            if(obj!=null)
            {
                if(obj.Address != null)
                {
                    addressBindingSource.DataSource = obj.Address.ToList();
                }
            }
        }

        private void dataGridViewCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ShowAddress();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            buttonAdd.Enabled = false;
            panel1.Enabled = true;
            textBoxFullName.Focus();
            Customers c = new Customers();
            db.Customers.Add(c);
            customersBindingSource.Add(c);
            customersBindingSource.MoveLast();
            addressBindingSource.DataSource = null;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            buttonEdit.Enabled = false;
            panel1.Enabled = true;
            textBoxFullName.Focus();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            buttonAdd.Enabled = true;
            buttonEdit.Enabled = true;
            customersBindingSource.ResetBindings(false);
            foreach(DbEntityEntry entry in db.ChangeTracker.Entries())
            {
                switch(entry.State)
                {
                    case System.Data.Entity.EntityState.Added:
                        entry.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        entry.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                await db.SaveChangesAsync();
                panel1.Enabled = false;
                buttonAdd.Enabled = true;
                buttonEdit.Enabled = true;
                MessageBox.Show("Les données ont bien été enregistrer", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddAddress_Click(object sender, EventArgs e)
        {
            Customers c = customersBindingSource.Current as Customers;
            if(c != null)
            {
                if(addressBindingSource.DataSource==null)
                {
                    addressBindingSource.DataSource = c.Address.ToList();
                    Address a = new Address() { Customers = c };
                    addressBindingSource.Add(a);
                    db.Address.Add(a);
                }
            }
        }

        private void dataGridViewCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridViewCustomer.Columns[e.ColumnIndex].Name == "Delete")
            {
                if(MessageBox.Show("Voulez vraiment Supprimer cette utilisateur ?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Customers.Remove(customersBindingSource.Current as Customers);
                    customersBindingSource.RemoveCurrent();
                }
            }
        }

        private void dataGridViewAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Voulez vraiment Supprimer cette adresse ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    db.Address.Remove(addressBindingSource.Current as Address);
                    customersBindingSource.RemoveCurrent();
                }
            }
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if(string.IsNullOrEmpty(textBoxSearch.Text))
                {
                    customersBindingSource.DataSource = db.Customers.Include("Address").ToList();
                    ShowAddress();
                }
                else
                {
                    var query = from o in db.Customers.Include("Address")
                                where o.name.Contains(textBoxSearch.Text)
                                select o;
                    customersBindingSource.DataSource = query.ToList();
                    ShowAddress();
                }
            }
        }
    }
}
