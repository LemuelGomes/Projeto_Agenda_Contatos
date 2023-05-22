using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_Agenda_Contatos
{
    public partial class FormAGENDA : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        public FormAGENDA()
        {
            InitializeComponent();

            textBoxID.Enabled = false;
            servidor = "Server=localhost;Database=agenda_de_contatos;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            atualizar_dataGRID();
            bool radioButtonBLOQUEADO = true;
            bool radioButtonDESBLOQUEADO = false;
        }
        private void atualizar_dataGRID()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT * FROM contatos;";
                MySqlDataAdapter adaptadorContatos = new MySqlDataAdapter(comando);
                DataTable tabelacontatos = new DataTable();
                adaptadorContatos.Fill(tabelacontatos);
                dataGridViewCONTATOS.DataSource = tabelacontatos;
                dataGridViewCONTATOS.Columns["id"].HeaderText = "Código";
                dataGridViewCONTATOS.Columns["nome"].HeaderText = "Nome";
                dataGridViewCONTATOS.Columns["sobrenome"].HeaderText = "Sobrenome";
                dataGridViewCONTATOS.Columns["telefone"].HeaderText = "Telefone Fixo";
                dataGridViewCONTATOS.Columns["celular"].HeaderText = "Celular";
                dataGridViewCONTATOS.Columns["email"].HeaderText = "Email";
                dataGridViewCONTATOS.Columns["linkedin"].HeaderText = "LinkedIn";
                dataGridViewCONTATOS.Columns["status"].HeaderText = "Status";
            }
            catch
            {
                MessageBox.Show("Não conseguimos atualizar sua lista de contatos, fale com o administrador do sistema!");
            }
            finally
            {
                conexao.Close();
            }
        }
        private void buttonCADASTRAR_Click(object sender, EventArgs e)
        {
            bool novoContato = true;

            string bloqueado = "sim";

            if (radioButtonBLOQUEADO.Checked)
            {
                bloqueado = "sim";
            }
            else
            {
                bloqueado = "não";
            }

            if (textBoxEMAIL.Text != "" && textBoxCELULAR.Text != "")
            {
                if (novoContato)
                {
                    try
                    {
                        conexao.Open();
                        comando.CommandText = "SELECT email FROM contatos WHERE email = '" + textBoxEMAIL.Text + "';";

                        MySqlDataReader resultado = comando.ExecuteReader();

                        if (resultado.Read())
                        {
                            novoContato = false;
                            MessageBox.Show("Contato já Cadastrado!!!");
                        }
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("Erro ao cadastrar o contato. Fale com o administrador do sistema.");
                    }
                    finally
                    {
                        conexao.Close();
                    }

                    if (novoContato == true && textBoxNOME.Text != "" && (textBoxTELEFONE.Text != "" || textBoxCELULAR.Text != "") && (radioButtonBLOQUEADO.Checked || radioButtonDESBLOQUEADO.Checked))
                    {
                        try
                        {
                            conexao.Open();
                            comando.CommandText = "INSERT INTO contatos (nome, sobrenome, telefone, celular, email, linkedin, status) VALUES ('" + textBoxNOME.Text + "', '" + textBoxSOBRENOME.Text + "', '" + textBoxTELEFONE.Text + "', '" + textBoxCELULAR.Text + "', '" + textBoxEMAIL.Text + "', '" + textBoxLINKEDIN.Text + "', '" + groupBoxSTATUS.Text + "');";
                            comando.ExecuteNonQuery();
                        }
                        catch (Exception erro)
                        {
                            MessageBox.Show("Seu Contato não foi cadastrado, verifique com o administrador do sistema");
                        }
                        finally
                        {
                            conexao.Close();
                            MessageBox.Show("Contato cadastrado com sucesso!");
                            textBoxNOME.Clear();
                            textBoxSOBRENOME.Clear();
                            textBoxTELEFONE.Clear();
                            textBoxCELULAR.Clear();
                            textBoxEMAIL.Clear();
                            textBoxLINKEDIN.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Algum campo não está preenchido!");
                    }
                }
            }
        }
        private void buttonEXCLUIR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "DELETE FROM contatos WHERE id = " + textBoxID.Text + ";";
                comando.ExecuteNonQuery();
                MessageBox.Show("Contato exluído com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show("O contato não foi excluido, verifique o Código do contato!");
            }
            finally
            {
                conexao.Close();
                textBoxID.Clear();
                textBoxNOME.Clear();
                textBoxSOBRENOME.Clear();
                textBoxTELEFONE.Clear();
                textBoxCELULAR.Clear();
                textBoxEMAIL.Clear();
                textBoxLINKEDIN.Clear();
            }
            atualizar_dataGRID();
        }
        private void dataGridViewCONTATOS_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxID.Text = dataGridViewCONTATOS.CurrentRow.Cells[0].Value.ToString();
            textBoxNOME.Text = dataGridViewCONTATOS.CurrentRow.Cells[1].Value.ToString();
            textBoxSOBRENOME.Text = dataGridViewCONTATOS.CurrentRow.Cells[2].Value.ToString();
            textBoxTELEFONE.Text = dataGridViewCONTATOS.CurrentRow.Cells[3].Value.ToString();
            textBoxCELULAR.Text = dataGridViewCONTATOS.CurrentRow.Cells[4].Value.ToString();
            textBoxEMAIL.Text = dataGridViewCONTATOS.CurrentRow.Cells[5].Value.ToString();
            textBoxLINKEDIN.Text = dataGridViewCONTATOS.CurrentRow.Cells[6].Value.ToString();
            if (dataGridViewCONTATOS.CurrentRow.Cells[7].Value.ToString() == "sim")
            {
                radioButtonBLOQUEADO.Checked = true;
                radioButtonDESBLOQUEADO.Checked = false;
            }
            else
            {
                radioButtonBLOQUEADO.Checked = false;
                radioButtonDESBLOQUEADO.Checked = true;
            }           
        }

        private void buttonALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "UPDATE contatos SET nome = '" + textBoxNOME.Text + "', sobrenome = '" + textBoxSOBRENOME.Text + "', telefone = '" + textBoxTELEFONE.Text + "', celular = '" + textBoxCELULAR.Text + "', email = '" + textBoxEMAIL.Text + "', linkedin '" + textBoxLINKEDIN.Text + "', status = '" + groupBoxSTATUS.Text + "' WHERE id = '" + textBoxID.Text + "';";
                comando.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                //MessageBox.Show("Seu contato não foi atualizado na agenda! Verifique com o administrador!");
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Seu Contato foi atualizado na agenda!");
                textBoxID.Clear();
                textBoxNOME.Clear();
                textBoxSOBRENOME.Clear();
                textBoxTELEFONE.Clear();
                textBoxCELULAR.Clear();
                textBoxEMAIL.Clear();
                textBoxLINKEDIN.Clear();
            }
        }             
        private void buttonLIMPAR_Click(object sender, EventArgs e)
        {
            textBoxID.Clear();
            textBoxNOME.Clear();
            textBoxSOBRENOME.Clear();
            textBoxTELEFONE.Clear();
            textBoxCELULAR.Clear();
            textBoxEMAIL.Clear();
            textBoxLINKEDIN.Clear();
        }

        private void buttonFECHAR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}