using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyContact
{
    public partial class FrmAddOrEdit : Form
    {
        private IContactRepository repository;
        public FrmAddOrEdit()
        {
            InitializeComponent();
            repository = new ContactRepository();
        }

        private void FrmAddOrEdit_Load(object sender, EventArgs e)
        {

        }

        bool validateInput()
        {
            
            if (txtName.Text == "")
            {
                
                MessageBox.Show("لطفا نام را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtFamily.Text == "")
            {

                MessageBox.Show("لطفا نام خانوادگی را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtMobile.Text == "")
            {

                MessageBox.Show("لطفا شماره موبایل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAge.Value == 0)
            {

                MessageBox.Show("لطفا سن را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtEmail.Text == "")
            {

                MessageBox.Show("لطفا ایمیل را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
               bool isSuccess = repository.Insert(txtName.Text, txtFamily.Text, txtMobile.Text, txtEmail.Text, (int)txtAge.Value,
                    txtAddress.Text);
               if (isSuccess)
               {
                   MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
                   DialogResult = DialogResult.OK;
               }
               else
               {
                   MessageBox.Show("عملیات با شکست مواجه شد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
            }
        }
    }
}
