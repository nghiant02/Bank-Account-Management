using Repository.Services;

namespace PRN211PE_SU22_DEMO
{
    public partial class Form1 : Form
    {
        //gọi hàm
        public UserServices _UserServices;

        public Form1()
        {
            _UserServices = new UserServices();
            InitializeComponent();
            txtUsername.Text = "Administrator";
            txtPassword.Text = "123";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //khai báo
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            //kiểm tra username && password có trong DB ko | role == 1 : đề bài yêu cầu 
            var user = _UserServices.GetAll().Where(p => p.UserName.Equals(username) && p.Password.Equals(password) && p.UserRole == 1).FirstOrDefault();

            if (user != null)
            {
                this.Hide();
                var ManagementForm = new Management(user);
                ManagementForm.ShowDialog();
            }
            else
            //nếu role != 1 : sorry,you ... 
            {
                MessageBox.Show("Sorry, you are not allowed to access this function","Login Fail",MessageBoxButtons.OK);
            }
        }
    }
}