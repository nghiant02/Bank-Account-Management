using Microsoft.Identity.Client;
using Repository.Models;
using Repository.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRN211PE_SU22_DEMO
{
    public partial class Management : Form
    {
        public User _user;
        public BankAccountServices _bankAccountServices;
        public AccountTypeServices _accountTypeServices;

        public Management(User user)
        {
            _user = user;
            _bankAccountServices = new BankAccountServices();
            _accountTypeServices = new AccountTypeServices();
            InitializeComponent();
            LoadTable();
            var listBankAccount = _bankAccountServices.GetAll().ToList();
            dgvListAccount.DataSource = listBankAccount;

            //xử lí để gọi AccountType
            var listaccount = _accountTypeServices.GetAll().ToList();
            cbAccountType.DataSource = listaccount;
            cbAccountType.DisplayMember = "TypeName";
            cbAccountType.ValueMember = "TypeId";
            cbAccountType.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //tạo hàm load lại dgv
        public void LoadTable()
        {
            var listBankAccount = _bankAccountServices.GetAll().ToList();
            dgvListAccount.DataSource = listBankAccount;
        }

        public void ClearTextBox()
        {
            txtAccountID.Text = "";
            txtAccountName.Text = "";
            txtBranchName.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var accountID = txtAccountID.Text;
            var accountname = txtAccountName.Text;
            var branchname = txtBranchName.Text;

            var accountype = cbAccountType.SelectedValue.ToString();
            var account = _bankAccountServices.GetAll().Where(p => p.AccountId == accountname).FirstOrDefault();
            if (account != null)
            {
                //kiểm tra xem có tồn tại không
                MessageBox.Show("ID account is existed", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                account = new BankAccount();
                account.AccountId = accountID;
                account.AccountName = accountname;
                account.BranchName = branchname;
                account.OpenDate = DateTime.Now;
                account.TypeId = accountype;


                _bankAccountServices.Create(account);
                //create xong phải tải lại dgv
                LoadTable();
                //khi load xong phải trả các field về rỗng
                ClearTextBox();
            }
        }

        private void dgvListAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var accountid = dgvListAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            var Account = _bankAccountServices.GetAll().Where(p => p.AccountId == accountid).FirstOrDefault();

            if (Account != null)
            {
                txtAccountID.Text = Account.AccountId;
                txtAccountID.Enabled = false;
                txtAccountName.Text = Account.AccountName;
                txtBranchName.Text = Account.BranchName;

                var listaccount = _accountTypeServices.GetAll().ToList();
                cbAccountType.DataSource = listaccount;
                cbAccountType.DisplayMember = "TypeName";
                cbAccountType.ValueMember = "TypeId";
                cbAccountType.SelectedIndex = listaccount.IndexOf(listaccount.Where(p => p.TypeId == Account.TypeId).ToList().FirstOrDefault());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var id = txtAccountID.Text;
                var account = _bankAccountServices.GetAll().Where(p => p.AccountId == id).FirstOrDefault();
                _bankAccountServices.Delete(account);
                MessageBox.Show("Delete successfully","Delete task",MessageBoxButtons.OK);
                LoadTable();
                ClearTextBox();
            }catch (Exception)
            {
                MessageBox.Show("Please try again", "Delete task", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var accountID = txtAccountID.Text;
            var accountName = txtAccountName.Text;
            var branchName = txtBranchName.Text;

            var accounttype = cbAccountType.SelectedValue.ToString();
            var account = _bankAccountServices.GetAll().Where(p => p.AccountId == accountID).FirstOrDefault();

            if (account != null)
            {
                account.BranchName = branchName;
                account.AccountName = accountName;
                account.TypeId = accounttype;
                _bankAccountServices.Update(account);
                LoadTable();
                ClearTextBox();
            }
        }
    }
}
