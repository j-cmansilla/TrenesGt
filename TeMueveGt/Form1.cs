using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeMueveGt
{
    public partial class Form1 : Form
    {
        int trenes;
        int vagonesPorTren;
        int filasPorVagon;
        int asientosPorFila;
        Tren[] listaTrenes;
        int trenesCreados;
        public Form1()
        {
            InitializeComponent();
            trenes = 0;
            vagonesPorTren = 0;
            filasPorVagon = 0;
            asientosPorFila = 0;
            trenesCreados = 0;
            Control.TrenesCreados = 0;
            Control.Correlativo = 1;
            Control.listaDeClientes = new List<Cliente>();
            Control.ListAsientos = new List<string>();
        }

        private void txtCantidadTrenes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAsientos_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCantidadTrenes.Text.Equals("") || txtVagones.Text.Equals("") || txtFilas.Text.Equals("") || txtAsientos.Text.Equals("") || txtPrecioAhorro.Text.Equals("") || txtPrecioLujo.Text.Equals(""))
            {
                MessageBox.Show("Ingrese toda la informacion requerida!");
                return;
            }
            if (int.Parse(txtCantidadTrenes.Text) < 1 || int.Parse(txtVagones.Text) < 1 || int.Parse(txtFilas.Text) < 1 || int.Parse(txtAsientos.Text) < 1 || int.Parse(txtPrecioAhorro.Text) < 1 || int.Parse(txtPrecioLujo.Text) < 1)
            {
                MessageBox.Show("Asegurese que todas las cantidades sean mayores a 0");
                return;
            }
            grupoCreacionDeTrenes.Enabled = true;
            grupoConfiguracion.Enabled = false;
            trenes = int.Parse(txtCantidadTrenes.Text);
            vagonesPorTren = int.Parse(txtVagones.Text);
            filasPorVagon = int.Parse(txtFilas.Text);
            asientosPorFila = int.Parse(txtAsientos.Text);
            Control.ListaTrenes = new Tren[trenes];
            Control.Filas = filasPorVagon;
            Control.Asientos = asientosPorFila;
            MessageBox.Show("Configuración finalizada!");
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int asientosLujo = 0;
            int asientosAhorro = 0;
            int vagonesDeLujo = 0;
            string esDeLujo = "A";
            bool asientosDeLujo = false;
            if (radioSi.Checked)
            {
                if (txtCantidadVagonesDeLujo.Text.Equals(""))
                {
                    MessageBox.Show("Ingrese la cantidad de vagones de lujo!");
                    return;
                }
                if (int.Parse(txtCantidadVagonesDeLujo.Text)>int.Parse(txtVagones.Text))
                {
                    MessageBox.Show("La cantidad de vagones de lujo no puede ser mayor que la cantidad de vagones totales!");
                    return;
                }
                vagonesDeLujo = int.Parse(txtCantidadVagonesDeLujo.Text);
                esDeLujo = "L";
            }
            else
            {
                vagonesDeLujo = 0;
            }
            Tren nuevoTren = new Tren(vagonesPorTren, "T"+(Control.Correlativo).ToString(),vagonesDeLujo,int.Parse(txtVagones.Text)-vagonesDeLujo);
            Control.Correlativo++;
            if (vagonesDeLujo>0)
            {
                for (int i = 0; i < vagonesDeLujo; i++)
                {
                    nuevoTren.ListaVagones[i] = new Vagon(true, Control.Filas, Control.Asientos);
                }
                for (int i = vagonesDeLujo; i < int.Parse(txtVagones.Text); i++)
                {
                    nuevoTren.ListaVagones[i] = new Vagon(false, Control.Filas, Control.Asientos);
                }
            }
            else
            {
                for (int i = 0; i < int.Parse(txtVagones.Text); i++)
                {
                    nuevoTren.ListaVagones[i] = new Vagon(false, Control.Filas, Control.Asientos);
                }
            }
            for (int k = 0; k < nuevoTren.ListaVagones.Length; k++)
            {
                for (int i = 0; i < Control.Filas; i++)
                {
                    for (int j = 0; j < Control.Asientos; j++)
                    {
                        string nombre = "F" + (i + 1).ToString() + "-" + "A" + (j + 1).ToString();
                        nuevoTren.ListaVagones[k].FilasYAsientos[i, j] = (new Asiento((nombre),new Cliente(),false));
                        if (nuevoTren.ListaVagones[k].esDeLujo)
                        {
                            Control.ListAsientos.Add((Control.Correlativo - 2).ToString() + k.ToString() + i.ToString() + j.ToString() + "D" + "L");
                        }
                        else
                        {
                            Control.ListAsientos.Add((Control.Correlativo - 2).ToString() + k.ToString() + i.ToString() + j.ToString() + "D" + "A");
                        }
                    }
                }
            }
            Control.ListaTrenes[Control.TrenesCreados] = nuevoTren;
            Control.TrenesCreados = Control.TrenesCreados + 1;
            if (trenes == Control.TrenesCreados)
            {
                grupoCreacionDeTrenes.Enabled = false;
            }
            txtCantidadVagonesDeLujo.Text = "";
            radioNo.Checked = false;
            radioSi.Checked = false;
            MessageBox.Show("Tren creado exitosamente!");
            grupoReservarComprar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnImprimirOCancelar.Enabled = false;
            btnContinuar.Enabled = true;
            btnCancelarReserva.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            /*if (Control.ListaTrenes[comboBox1.SelectedIndex].AsientosDeLujo)
            {
                tipoDeAsiento.Enabled = true;
                tipoDeAsiento.Items.Add("De Lujo");
                tipoDeAsiento.Items.Add("De Ahorro");
            }
            else
            {
                tipoDeAsiento.Enabled = false;
            }*/
        }

        private void btnDisponiblidad_Click(object sender, EventArgs e)
        {
            txtAsientosDisponiblesReporte.Text = Control.obtenerAsientosDisponibles().ToString();
            txtAsientosComprados.Text = Control.obtenerAsientosComprados().ToString();
            txtAsientosReservados.Text = Control.obtenerAsientosReservados().ToString();
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress_2(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        
        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (Control.obtenerAsientosDisponibles()<1)
            {
                MessageBox.Show("Ya no quedan asientos disponibles :(");
                return;
            }
            Cliente cliente = Control.obtenerCliente(txtDPI.Text);
            if (cliente != null)
            {
                if (cliente.TipoDeOperacion != "")
                {
                    if (cliente.TipoDeOperacion == "Reservar")
                    {
                        btnImprimirOCancelar.Enabled = true;
                        btnCancelarReserva.Enabled = true;
                    }
                    else
                    {
                        btnImprimirOCancelar.Enabled = true;
                    }
                    btnContinuar.Enabled = false;
                    return;
                }
            }
            grupoReservarComprar.Enabled = false;
            btnCancelarCompra.Enabled = true;
            grupoCantidadDeAsientos.Enabled = true;
            return;
        }

        private void Asientos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            string tipoDeOperacion = "Reservar";
            Cliente clienteDelSistema = null;
            Cliente cliente = null;
            if (txtAsientosDeAhorroSeleccionados.Text.Equals("") || txtAsientosDeLujoSeleccionados.Text.Equals(""))
            {
                MessageBox.Show("Llene todos los campos!");
                return;
            }
            if (int.Parse(txtAsientosDeAhorroSeleccionados.Text.ToString())>Control.obtenerAsientosDeAhorroDisponibles())
            {
                MessageBox.Show("La cantidad de asientos de ahorro que selecciono excede el limite. Limite: "+ Control.obtenerAsientosDeAhorroDisponibles().ToString());
                return;
            }
            if (int.Parse(txtAsientosDeLujoSeleccionados.Text.ToString()) > Control.obtenerAsientosDeLujoDisponibles())
            {
                MessageBox.Show("La cantidad de asientos de lujo que selecciono excede el limite. Limite: " + Control.obtenerAsientosDeLujoDisponibles().ToString());
                return;
            }
            if (Control.clienteExiste(txtDPI.Text))
            {
                clienteDelSistema = Control.obtenerCliente(txtDPI.Text);
            }
            if (radioComprar.Checked)
            {
                tipoDeOperacion = "Compra";
            }
            if (clienteDelSistema == null)
            {
                cliente = new Cliente(txtNombreCliente.Text, int.Parse(txtDPI.Text), tipoDeOperacion);
            }
            else
            {
                cliente = clienteDelSistema;
                cliente.TipoDeOperacion = tipoDeOperacion;
            }
            int asientosDeLujo = int.Parse(txtAsientosDeLujoSeleccionados.Text.ToString());
            int asientosDeAhorro = int.Parse(txtAsientosDeAhorroSeleccionados.Text.ToString());
            int asientosDeLujoReservados = asientosDeLujo;
            int asientosDeAhorroReservados = asientosDeAhorro;
            List<string> asientosCompradosOReservados = new List<string>();
            int total = 0;
            for (int i = 0; i < Control.ListaTrenes.Length; i++)
            {
                if (Control.ListaTrenes[i] == null)
                {

                }
                else
                {
                    for (int j = 0; j < Control.ListaTrenes[i].ListaVagones.Length; j++)
                    {
                        if (Control.ListaTrenes[i].ListaVagones[j].esDeLujo)
                        {
                            for (int k = 0; k < Control.ListaTrenes[i].ListaVagones[j].Filas; k++)
                            {
                                for (int h = 0; h < Control.ListaTrenes[i].ListaVagones[j].AsientosPorFila; h++)
                                {
                                    if (asientosDeLujoReservados > 0)
                                    {
                                        if (Control.ListaTrenes[i].ListaVagones[j].comprar(k, h))
                                        {
                                            total = total + int.Parse(txtPrecioLujo.Text.ToString());
                                            asientosDeLujoReservados--;
                                            asientosCompradosOReservados.Add(i.ToString() + j.ToString() + k.ToString() + h.ToString() + tipoDeOperacion[0] + "L");
                                            Control.comprar(i.ToString() + j.ToString() + k.ToString() + h.ToString() + "D" + "L", i.ToString() + j.ToString() + k.ToString() + h.ToString() + tipoDeOperacion[0] + "L");
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            for (int k = 0; k < Control.ListaTrenes[i].ListaVagones[j].Filas; k++)
                            {
                                for (int h = 0; h < Control.ListaTrenes[i].ListaVagones[j].AsientosPorFila; h++)
                                {
                                    if (asientosDeAhorroReservados > 0)
                                    {
                                        if (Control.ListaTrenes[i].ListaVagones[j].comprar(k, h))
                                        {
                                            total = total + int.Parse(txtPrecioAhorro.Text.ToString());
                                            asientosDeAhorroReservados--;
                                            asientosCompradosOReservados.Add(i.ToString() + j.ToString() + k.ToString() + h.ToString() + tipoDeOperacion[0] + "A");
                                            Control.comprar(i.ToString() + j.ToString() + k.ToString() + h.ToString() + "D" + "A", i.ToString() + j.ToString() + k.ToString() + h.ToString() + tipoDeOperacion[0] + "A");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            //Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].comprar(fila,columna);
            //Control.ListaTrenes[comboBox1.SelectedIndex].ListaVagones[comboVagon.SelectedIndex].FilasYAsientos[fila, columna].Cliente = cliente;
            //string asiento = comboBox1.SelectedIndex.ToString() + "," + comboVagon.SelectedIndex.ToString() + "," + fila.ToString() + "," + columna.ToString();
            //cliente.listaAsientos.Add(asiento);
            string boletos = string.Empty;
            for (int i = 0; i < asientosCompradosOReservados.Count; i++)
            {
                cliente.listaAsientos.Add(asientosCompradosOReservados[i]);
                boletos = boletos + "T" + asientosCompradosOReservados[i][0].ToString() + "_" + "V" + asientosCompradosOReservados[i][1].ToString() + "_" + "F" + asientosCompradosOReservados[i][2].ToString() + "_" + "A" + asientosCompradosOReservados[i][3].ToString()+ Environment.NewLine;
                cliente.FormatoImpresion = "BOLETOS: "+Environment.NewLine+boletos;
            }
            if (clienteDelSistema == null)
            {
                Control.listaDeClientes.Add(cliente);
            }
            //MessageBox.Show("");
            bigTextBox.Text = "BOLETOS:" + Environment.NewLine + boletos + "TOTAL: " + total.ToString() + ".00 Quetzales" + Environment.NewLine + "Tipo de operación: " + tipoDeOperacion;
            grupoReservarComprar.Enabled = true;
            grupoCantidadDeAsientos.Enabled = false;
            txtAsientosDeAhorroSeleccionados.Text = "";
            txtAsientosDeLujoSeleccionados.Text = "";
        }

        private void btnCancelarCompra_Click(object sender, EventArgs e)
        {
            grupoReservarComprar.Enabled = true;
            btnCancelarCompra.Enabled = false;
            txtAsientosDeAhorroSeleccionados.Text = "";
            txtAsientosDeLujoSeleccionados.Text = "";
        }

        private void txtPrecioLujo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtPrecioAhorro_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCantidadVagonesDeLujo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void radioSi_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSi.Checked)
            {
                txtCantidadVagonesDeLujo.Enabled = true;
                return;
            }
            txtCantidadVagonesDeLujo.Enabled = false;
        }

        private void btnImprimirOCancelar_Click(object sender, EventArgs e)
        {
            Cliente cliente = Control.obtenerCliente(txtDPI.Text);
            if (cliente != null)
            {
                bigTextBox.Text = cliente.FormatoImpresion;
                return;
            }
            btnImprimirOCancelar.Enabled = false;
            btnCancelarReserva.Enabled = false;
            btnContinuar.Enabled = true;
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            Cliente cliente = Control.obtenerCliente(txtDPI.Text);
            if (cliente != null)
            {
                for (int i = 0; i < cliente.listaAsientos.Count; i++)
                {
                    string tren = cliente.listaAsientos[i][0].ToString();
                    string vagon = cliente.listaAsientos[i][1].ToString();
                    string fila = cliente.listaAsientos[i][2].ToString();
                    string columna = cliente.listaAsientos[i][3].ToString();
                    string tipoDeOperacion = cliente.listaAsientos[i][4].ToString();
                    string tipoDeAsiento = cliente.listaAsientos[i][5].ToString();
                    Control.ListaTrenes[int.Parse(tren)].ListaVagones[int.Parse(vagon)].cancelarReserva(int.Parse(fila),int.Parse(columna));
                    Control.cancelarReservacion((tren + vagon + fila + columna + tipoDeOperacion + tipoDeAsiento), (tren + vagon + fila + columna + "D" + tipoDeAsiento));
                }
                for (int i = 0; i < cliente.listaAsientos.Count; i++)
                {
                    cliente.listaAsientos.RemoveAt(i);
                }
                cliente.TipoDeOperacion = "";
                MessageBox.Show("Reserva cancelada exitosamente!");
            }
            btnImprimirOCancelar.Enabled = false;
            btnCancelarReserva.Enabled = false;
            btnContinuar.Enabled = true;
            bigTextBox.Text = "";
        }

        private void txtAsientosDeAhorroSeleccionados_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAsientosDeLujoSeleccionados_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}