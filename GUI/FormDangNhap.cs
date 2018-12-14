using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
namespace GUI
{
    public partial class formDangNhap : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public formDangNhap()
        {
            InitializeComponent();
            ControlEffect.SetPlaceHolder(txtUsername, "Tên đăng nhập", Color.Black, Color.Gray);
            ControlEffect.SetPlaceHolder(txtPassword, "Mật khẩu", Color.Black, Color.Gray);
        }
        public class ControlEffect
        {
            public static void SetPlaceHolder(TextBox textBox, string placeHolderText, Color defaultColor, Color placeHolderColor)
            {
                // Lưu lại thuộc tính UseSystemPasswordChar và PasswordChar để xử lý trường hợp TextBox là Password
                bool usePassword = textBox.UseSystemPasswordChar;
                char passChar = textBox.PasswordChar;

                // Nếu TextBox không Focus và không có dữ liệu > Thiết lập PlaceHolder
                if (!textBox.Focused && textBox.Text == "")
                {
                    textBox.ForeColor = placeHolderColor;
                    textBox.Text = placeHolderText;
                    textBox.UseSystemPasswordChar = false;
                    textBox.PasswordChar = '\0';
                }


                // Sự kiện Enter, nếu TextBox đang có PlaceHolder > đưa dữ liệu về "" và set default color
                textBox.Enter += (s, e) =>
                {
                    if (textBox.Text == placeHolderText && textBox.ForeColor == placeHolderColor)
                    {
                        textBox.Text = "";
                        textBox.ForeColor = defaultColor;
                        if(placeHolderText == "Mật khẩu")
                            textBox.UseSystemPasswordChar = !usePassword;
                        textBox.PasswordChar = passChar;
                    }
                };

                // Sự kiện Leave, nếu TextBox không có dữ liệu > tạo PlaceHoder
                textBox.Leave += (s, e) =>
                {
                    if (textBox.Text == "")
                    {
                        textBox.ForeColor = placeHolderColor;
                        textBox.Text = placeHolderText;
                        textBox.UseSystemPasswordChar = false;
                        textBox.PasswordChar = '\0';
                    }
                };
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           try
            {
                string username = txtUsername.Text;
                string pass = txtPassword.Text;

                if (TaiKhoanBLL.Instance.check(username, pass))
                {
                    DTO.TaiKhoan tk = new DTO.TaiKhoan();
                    tk = TaiKhoanBLL.Instance.getInfoByID(username);
                    FormChinh mainForm = new FormChinh(tk);
                    mainForm.Show();
                    this.Hide();
                }
                else MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
            
            catch
            {
                MessageBox.Show("Lỗi, đăng nhập k thành công ");
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult drl = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (drl == DialogResult.Yes) this.Close();
        }

        private void txtPassword_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }

}
