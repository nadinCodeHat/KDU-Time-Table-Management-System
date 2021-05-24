using System.Windows.Forms;

namespace KDU_TTMS
{
    public partial class Add_Lecturer : Form
    {
        public Add_Lecturer()
        {
            InitializeComponent();
        }

        //On addBtn click
        //Insert lecturer login info
        //string insertLoginQuery = "INSERT INTO Login_Info(email, password) VALUES (@email,@password)";
        //using (SqlCommand cmd = new SqlCommand(insertLoginQuery, con))
        //{
        //    //Generate a random 8 characters password and encrypt
        //    //@Todo send email with login_info
        //    byte[] password = Cryptography.callEncrypt(Cryptography.generateRandom());
        //    cmd.Parameters.AddWithValue("@email", emailTxt.Text.ToString());
        //    cmd.Parameters.AddWithValue("@password", password);
        //    cmd.ExecuteNonQuery();
        //}
    }
}
