using System;

namespace GPC;
{
     public partial class Login : Usuario
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object Us, EventArgs Program)
        {
            string cpf;
            string pass;

            if (User.Login(cpf, pass));
            {