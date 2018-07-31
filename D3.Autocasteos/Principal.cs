using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D3.Autocasteos
{
    public partial class Principal : Form
    {
        [DllImport("user32.dll")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        const int WM_SYSKEYDOWN = 0x0104;
        const int VK_K1 = 0x0031;
        const int VK_K2 = 0x0032;
        const int VK_K3 = 0x0033;
        const int VK_K4 = 0x0034;

        public bool Autocasteando { get; set; }
        public string WindowsName { get; set; }

        private IntPtr WindowToFind { get; set; }

        public Principal()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.WindowsName = "Diablo III";

            this.WindowToFind = FindWindow(null, this.WindowsName);
            this.DetenetAutoCasteo();

            if(this.WindowToFind == null)
            {
                MessageBox.Show("Atención","No se puede encontrar el juego, por favor inicia Diablo 3 para poder utilizar esta herramienta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void AutoCastear(int pKeyCode, IntPtr pWindowToFind)
        {
            PostMessage(pWindowToFind, Principal.WM_SYSKEYDOWN, pKeyCode, 0);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            this.IniciarAutoCasteo();
        }

        public void IniciarAutoCasteo()
        {
            if (!this.Autocasteando)
            {
                if (this.AlgunaHabilidadSeleccionada())
                {
                    this.Autocasteando = true;
                    this.pnlStatus.BackColor = Color.Green;
                    
                    this.HabilitarControles(true);
                    Task.Run(() => EjecutarAutoCasteos(this.cboHabilidad1.Checked, this.cboHabilidad2.Checked, this.cboHabilidad3.Checked, this.cboHabilidad4.Checked));
                }
                else
                {
                    MessageBox.Show("Debes seleccionar al menos una habilidad","No hay ninguna habilidad seleccionada para castear", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Atención","Autocasteo en ejecución", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarControles(bool pValor)
        {
            this.btnIniciar.Enabled = !pValor;
            this.btnDetener.Enabled = pValor;
            this.cboHabilidad1.Enabled = !pValor;
            this.cboHabilidad2.Enabled = !pValor;
            this.cboHabilidad3.Enabled = !pValor;
            this.cboHabilidad4.Enabled = !pValor;
            this.lblAutoCasteando.Visible = pValor;
            this.lblPausado.Visible = !pValor;
        }

        private void EjecutarAutoCasteos(bool h1, bool h2, bool h3, bool h4)
        {
            while (this.Autocasteando)
            {
                if (h1)
                {
                    Task.Run(() => this.AutoCastear(VK_K1, this.WindowToFind));
                }
                if (h2)
                {
                    Task.Run(() => this.AutoCastear(VK_K2, this.WindowToFind));
                }
                if (h3)
                {
                    Task.Run(() => this.AutoCastear(VK_K3, this.WindowToFind));
                }
                if (h4)
                {
                    Task.Run(() => this.AutoCastear(VK_K4, this.WindowToFind));
                }
                Thread.Sleep(500);
            }
        }

        private bool AlgunaHabilidadSeleccionada()
        {
            return this.cboHabilidad1.Checked || this.cboHabilidad2.Checked || this.cboHabilidad3.Checked || this.cboHabilidad4.Checked;
        }

        public void DetenetAutoCasteo()
        {
            this.Autocasteando = false;
            this.pnlStatus.BackColor = Color.Red;
            this.HabilitarControles(false);
        }

        private void btnDetener_Click(object sender, EventArgs e)
        {
            this.DetenetAutoCasteo();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F5)
            {
                this.IniciarAutoCasteo();
                return true;
            }
            else if (keyData == Keys.F4)
            {
                this.DetenetAutoCasteo();
                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }
    }
}
