using Controller;
using Model;

namespace View;

public class ViewTarefa : Form {
    private readonly Label LblNome;
    private readonly Label LblData;
    private readonly Label LblHora;
    private readonly Label LblDescricao;
    private readonly TextBox InputNome;
    private readonly TextBox InputData;
    private readonly TextBox InputHora;
    private readonly TextBox InputDescricao;
    private readonly Button BtnCadastrar;
    private readonly Button BtnExcluir;
    private readonly Button BtnEditar;
    private readonly DataGridView ListaTarefas;

    public ViewTarefa(){
        ControllerTarefa.Sincronizar();
        
        Size = new Size(400, 400);
        StartPosition = FormStartPosition.CenterScreen;

        LblNome = new Label{
            Text = "Nome: ",
            Location = new Point(20, 50),
            Size = new Size (50,20)
        };

        InputNome = new TextBox{
            Location = new Point(70, 50),
        };

        LblData = new Label{
            Text = "Data: ",
            Location = new Point(190, 50),
            Size = new Size (50,20)
        };

        InputData = new TextBox{
            Location = new Point(250, 50),
        };

        LblHora = new Label{
            Text = "Hora: ",
            Location = new Point(20, 100),
            Size = new Size (50,20)
        };
        
        InputHora = new TextBox{
            Location = new Point(70, 100),
        };

        LblDescricao = new Label{
            Text = "Descricao: ",
            Location = new Point(190, 100),
            Size = new Size (60,20)
        };
        
        InputDescricao = new TextBox{
            Location = new Point(250, 100),
        };

        BtnCadastrar = new Button {
            Text = "Cadastrar",
            Location = new Point(50, 150),
        };
        BtnCadastrar.Click += ClickCadastrar;
        BtnEditar = new Button {
            Text = "Alterar",
            Location = new Point(150, 150),
        };
        BtnEditar.Click += ClickAlterar;
        BtnExcluir = new Button {
            Text = "Deletar",
            Location = new Point(250, 150),
        };
        BtnExcluir.Click += ClickDeletar;

        ListaTarefas = new DataGridView {
            Location = new Point(0, 200),
            Size = new Size(400, 150)
        };



        Controls.Add(LblNome);
        Controls.Add(LblData);
        Controls.Add(LblHora);
        Controls.Add(LblDescricao);
        Controls.Add(InputNome);
        Controls.Add(InputData);
        Controls.Add(InputHora);
        Controls.Add(InputDescricao);
        Controls.Add(BtnCadastrar);
        Controls.Add(BtnEditar);
        Controls.Add(BtnExcluir);
        Controls.Add(ListaTarefas);

        Listar();
    }

    private void ClickCadastrar(object? sender, EventArgs e) {
        if(InputNome.Text == "") {
            return;
        }
        ControllerTarefa.CriarTarefa(InputNome.Text, InputData.Text,InputHora.Text,InputDescricao.Text);
        Listar();
    }

    private void ClickAlterar(object? sender, EventArgs e) {
        int indice = ListaTarefas.SelectedRows[0].Index;
        if(InputNome.Text == "") {
            return;
        }
        ControllerTarefa.AlterarTarefa(indice, InputNome.Text, InputData.Text,InputHora.Text,InputDescricao.Text);
        Listar();
    }

    private void ClickDeletar(object? sender, EventArgs e) {
        int indice = ListaTarefas.SelectedRows[0].Index;
        ControllerTarefa.ExcluirTarefa(indice);
        Listar();
    }


    private void Listar() {
        List<Tarefa> tarefas = ControllerTarefa.ListarTarefas();
        ListaTarefas.Columns.Clear();
        ListaTarefas.AutoGenerateColumns = false;
        ListaTarefas.DataSource = tarefas;
        
        ListaTarefas.Columns.Add(new DataGridViewTextBoxColumn {
            DataPropertyName = "Id",
            HeaderText = "Id"
        });
        ListaTarefas.Columns.Add(new DataGridViewTextBoxColumn {
            DataPropertyName = "Nome",
            HeaderText = "Nome"
        });
        ListaTarefas.Columns.Add(new DataGridViewTextBoxColumn {
            DataPropertyName = "Data",
            HeaderText = "Data"
        });
        ListaTarefas.Columns.Add(new DataGridViewTextBoxColumn {
            DataPropertyName = "Hora",
            HeaderText = "Hora"
        });
        ListaTarefas.Columns.Add(new DataGridViewTextBoxColumn {
            DataPropertyName = "Descricao",
            HeaderText = "Descrição"
        });
    }
}


// Nome = nome;
// Data = data;
// Hora = hora;
// Descricao = descricao;