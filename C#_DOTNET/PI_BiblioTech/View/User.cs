using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public class ViewUser : Form
    {
        private Button BtnVoltar;

        private Label LblNome;
        private Label LblCpf;
        private Label LblDataNascimento;
        private TextBox InpNome;
        private TextBox InpCpf;
        private TextBox InpDataNascimento;
        private Button BtnCadastrar;
        private Button BtnAlterar;
        private Button BtnDeletar;
        private DataGridView DgvUsuarios;

        private BindingSource _bindingSource;

        public ViewUser()
        {
            InitializeComponent();
            Listar();
        }
        private void InitializeComponent()
        {
            ControllerUser.Sincronizar();
            _bindingSource = new BindingSource();

            Text = "Usuários";
            Size = new Size(500, 400);
            StartPosition = FormStartPosition.CenterScreen;

            LblNome = new Label
            {
                Text = "Nome: ",
                Location = new Point(50, 25),
            };
            LblCpf = new Label
            {
                Text = "Cpf: ",
                Location = new Point(50, 75),
            };
            LblDataNascimento = new Label
            {
                Text = "Data De Nascimento: ",
                Location = new Point(50, 125),
                Size = new Size(100, 40)
            };

            InpNome = new TextBox
            {
                Name = "Nome",
                Location = new Point(150, 25),
                Size = new Size(200, 20)
            };
            InpCpf = new TextBox
            {
                Name = "Cpf",
                Location = new Point(150, 75),
                Size = new Size(200, 20)
            };
            InpDataNascimento = new TextBox
            {
                Name = "DataNascimento",
                Location = new Point(150, 125),
                Size = new Size(200, 20)
            };

            BtnCadastrar = new Button
            {
                Text = "Cadastrar",
                Location = new Point(375, 25),
            };
            BtnCadastrar.Click += ClickCadastrar;
            BtnAlterar = new Button
            {
                Text = "Alterar",
                Location = new Point(375, 75),
            };
            BtnAlterar.Click += ClickAlterar;
            BtnDeletar = new Button
            {
                Text = "Deletar",
                Location = new Point(375, 125),
            };
            BtnDeletar.Click += ClickDeletar;

            DgvUsuarios = new DataGridView
            {
                Location = new Point(0, 200),
                Size = new Size(500, 150),
                AutoGenerateColumns = false
            };
            BtnVoltar = new Button
            {
                Text = "Voltar",
                Location = new Point(0, 0),
                Size = new Size(70, 20)
            };
            BtnVoltar.Click += BtnVoltar_Click;

            Controls.Add(LblNome);
            Controls.Add(LblCpf);
            Controls.Add(LblDataNascimento);
            Controls.Add(InpNome);
            Controls.Add(InpCpf);
            Controls.Add(InpDataNascimento);
            Controls.Add(BtnCadastrar);
            Controls.Add(BtnAlterar);
            Controls.Add(BtnDeletar);
            Controls.Add(DgvUsuarios);
            Controls.Add(BtnVoltar);


        }
        private void ClickCadastrar(object? sender, EventArgs e)
        {
            if (InpNome.Text == "")
            {
                return;
            }
            ControllerUser.Criar(InpNome.Text, InpDataNascimento.Text, InpCpf.Text);
            Listar();
        }

        private void ClickAlterar(object? sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count > 0)
            {
                int index = DgvUsuarios.SelectedRows[0].Index;
                if (InpNome.Text == "")
                {
                    return;
                }
                ControllerUser.Alterar(index, InpNome.Text, InpDataNascimento.Text, InpCpf.Text);
                Listar();
            }
        }

        private void ClickDeletar(object? sender, EventArgs e)
        {
            if (DgvUsuarios.SelectedRows.Count > 0)
            {
                int index = DgvUsuarios.SelectedRows[0].Index;
                ControllerUser.Deletar(index);
                Listar();
            }
        }

        private void Listar()
        {
            List<User> users = ControllerUser.Listar();
            _bindingSource.DataSource = users;
            DgvUsuarios.DataSource = _bindingSource;

            DgvUsuarios.Columns.Clear();
            DgvUsuarios.AutoGenerateColumns = false;
            AdicionarColunasAoDataGridView();
        }
        private void AdicionarColunasAoDataGridView()
        {
            if (DgvUsuarios.Columns.Count == 0)
            {
                DgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Id",
                    HeaderText = "Id"
                });
                DgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Usuario",
                    HeaderText = "Nome"
                });
                DgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Cpf",
                    HeaderText = "Cpf"
                });
                DgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
                {
                    DataPropertyName = "Data_nascimento",
                    HeaderText = "Data de Nascimento"
                });
            }
        }
        private void LimparDataGridView()
        {
            _bindingSource.Clear();
            DgvUsuarios.Columns.Clear();
        }
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            LimparDataGridView();
            this.Close();
            if (ViewHome.CurrentInstance != null)
            {
                ViewHome.CurrentInstance.Show();
            }
        }
    }
}
