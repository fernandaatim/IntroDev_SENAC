using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public class ViewUserEmprestimos : Form
    {
        private readonly DataGridView DgvEmprestimos;
        private readonly Label LblUser;
        private readonly Button BtnDetalhesMulta;
        private readonly Button BtnVoltar;
        private readonly TextBox TxtIdMulta;
        private readonly string Usuario;

        public ViewUserEmprestimos(int id)
        {
            ControllerEmprestimo.Sincronizar();
            Usuario = ControllerEmprestimo.ObterNomeUsuario(id);

            Text = $"Emprestimos {Usuario}";
            ControlBox = false;
            Size = new Size(900, 550);
            StartPosition = FormStartPosition.CenterScreen;

            LblUser = new Label
            {
                Text = $"Bem Vindo {Usuario} Aos seus Empréstimos",
                Location = new Point(25, 25),
                AutoSize = true,
                Font = new Font("Arial", 24, FontStyle.Bold)
            };

            DgvEmprestimos = new DataGridView
            {
                Location = new Point(0, 150),
                Size = new Size(850, 300),
                AutoGenerateColumns = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false
            };

            // BtnDetalhesMulta = new Button
            // {
            //     Text = "Ver Detalhes da Multa",
            //     Location = new Point(520, 475),
            //     Size = new Size(150, 30)
            // };
            // BtnDetalhesMulta.Click += BtnDetalhesMulta_Click;

            // TxtIdMulta = new TextBox
            // {
            //     Location = new Point(350, 475),
            //     Size = new Size(150, 30)
            // };

            BtnVoltar = new Button
            {
                Text = "Voltar",
                Location = new Point(700, 475),
                Size = new Size(150, 30)
            };
            BtnVoltar.Click += BtnVoltar_Click;

            Controls.Add(DgvEmprestimos);
            Controls.Add(LblUser);
            Controls.Add(BtnDetalhesMulta);
            Controls.Add(TxtIdMulta);
            Controls.Add(BtnVoltar);

            Listar(id);
        }

        private void Listar(int id)
        {
            List<Emprestimo> emprestimos = ControllerEmprestimo.ListarEmprestimos()
                .Where(p => p.Id_usuario == id).ToList();

            DgvEmprestimos.Columns.Clear();
            DgvEmprestimos.DataSource = null;

            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                HeaderText = "Id"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Livro",
                HeaderText = "Livro"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data_emprestimo",
                HeaderText = "Data Empréstimo"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data_prazo",
                HeaderText = "Data Prazo"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Data_devolucao",
                HeaderText = "Data Devolução"
            });
            DgvEmprestimos.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Horario",
                HeaderText = "Horário"
            });

            DgvEmprestimos.DataSource = emprestimos;
        }

        private void BtnDetalhesMulta_Click(object sender, EventArgs e)
        {
            string idMultaInput = TxtIdMulta.Text.Trim();
            int idMulta;

            if (int.TryParse(idMultaInput, out idMulta))
            {
                string message = idMulta != 0
                    ? $"O ID da multa é: {idMulta}"
                    : "Não há multa associada a este empréstimo.";

                MessageBox.Show(message, "Detalhes da Multa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID válido para a multa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            if (ViewHome.CurrentInstance != null)
            {
                ViewHome.CurrentInstance.Show();
            }
        }
    }
}