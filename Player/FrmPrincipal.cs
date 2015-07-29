using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.IO;
using Newtonsoft.Json;


namespace Player
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();

            //recebe o valor inicial programado do volume
            trbVolume.Value = 100;
           
        }
        string[] files, paths;
        int volume = 100;
        // Começa em 0
        // Valores são:
        // 0 = pause;
        // 1 = play;
        // 2 = stop;

        //Contole das músicas e locução
        int statusMusic = 0;
        int RetMusic = 0;
        int statusLocucao = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            MidiaPlayer.Ctlcontrols.play();
            statusMusic = 1;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            MidiaPlayer.Ctlcontrols.pause();
            statusMusic = 0;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MidiaPlayer.Ctlcontrols.stop();
            statusMusic = 2;
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog1 = new OpenFileDialog();

            OpenFileDialog1.Multiselect = true;

            if (OpenFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                files = OpenFileDialog1.SafeFileNames;
                paths = OpenFileDialog1.FileNames;
                
                listBox.Items.Clear(); //Limpa a lista sempre antes de adicionar outras músicas
                MidiaPlayer.Ctlcontrols.stop(); // Faz o player parar quando selecionar uma nova pasta

                for (int i = 0; i < files.Length; i++)
                {
                    listBox.Items.Add(files[i]); //Adiciona as músicas na lista
                }

            }

            //Display frmAbout as a modal dialog
            //Form frmAbout = new Form();
            //frmAbout.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MidiaPlayer.URL = paths[listBox.SelectedIndex];

            //música em play
            statusMusic = 1;
        }

        private void MidiaPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (MidiaPlayer.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                timer1.Interval = 100;
                timer1.Enabled = true;
            }  
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < files.Length - 1)
            {
                listBox.SelectedIndex++; //Pula de música assim que acabar a anterior
                timer1.Enabled = false;
            }
            else
            {
                listBox.SelectedIndex = 0; //Se não houver mais música na lista volta para o começo
                timer1.Enabled = false;
            } 
        }

        private void MidiaPlayer_Enter(object sender, EventArgs e)
        {
            MidiaPlayer.uiMode = "invisible";
            MidiaPlayer.settings.volume = volume;
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBox.SelectedIndex < files.Length - 1)
                    listBox.SelectedIndex++; //Pula de música assim que acabar a anterior
                else
                    listBox.SelectedIndex = 0; //Se não houver mais música na lista volta para o começo
            }
            catch
            {
                Console.WriteLine("Sem música");
            }
        }

        private void btn_ant_Click(object sender, EventArgs e)
        {
            try
            {

                if (listBox.SelectedIndex < files.Length - 1)
                    listBox.SelectedIndex--; //Pula de música assim que acabar a anterior
                else
                    listBox.SelectedIndex = 0; //Se não houver mais música na lista volta para o começo
            }
            catch
            {
                Console.WriteLine("Sem música");
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void testeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ChamadaFunc chamafunc = new ChamadaFunc();
            chamafunc.ShowDialog();
        }

        private void MidiaPlayerChamada_Enter(object sender, EventArgs e)
        {
            MidiaPlayerChamada.uiMode = "invisible";
        }

        private void trbVolume_Scroll(object sender, EventArgs e)
        {
            MidiaPlayer.settings.volume = trbVolume.Value;            
        }

        private void btnChamada_Click(object sender, EventArgs e)
        {
            // inicia o timer
            timerLocucao.Start();
            //mostra o label
            lblLocucao.Visible = true;
            // realiza o controle das musicas
            ControlaMusica(statusMusic);

            WindowsMicrophoneMuteLibrary.WindowsMicMute micMute = new WindowsMicrophoneMuteLibrary.WindowsMicMute();
            micMute.UnMuteMic();
        }

        private void timerLocucao_Tick(object sender, EventArgs e)
        {
            string vlFinal = "01:00";
            
            WindowsMicrophoneMuteLibrary.WindowsMicMute micMute = new WindowsMicrophoneMuteLibrary.WindowsMicMute();

            if (statusLocucao < 60)
            {
                statusLocucao = statusLocucao + 1;                
                lblLocucao.Text = "Parar Locução \n" + TimeSpan.FromSeconds(statusLocucao).ToString("mm\\:ss") + " até " + vlFinal;
            }
            else
            {
                lblLocucao.Visible = false;
                lblLocucao.Text = "";
                //para a locução
                timerLocucao.Stop();
                statusLocucao = 0;
                micMute.UnMuteMic();
                //retorna a música caso esteja tocando
                RetornaMusica(RetMusic);                
            }

        }

        private void lblLocucao_Click(object sender, EventArgs e)
        {
            WindowsMicrophoneMuteLibrary.WindowsMicMute micMute = new WindowsMicrophoneMuteLibrary.WindowsMicMute();

            lblLocucao.Visible = false;
            lblLocucao.Text = "";
            //para a locução
            timerLocucao.Stop();
            statusLocucao = 0;
            micMute.UnMuteMic();
            //retorna a música caso esteja tocando
            RetornaMusica(RetMusic);
        }

        private void ControlaMusica(int controle)
        {
            if (controle == 1)
            {
                MidiaPlayer.Ctlcontrols.pause();
                string caminho = Path.GetFullPath(@"Sounds\sensui.wav");

                MidiaPlayerChamada.URL = caminho;

                MidiaPlayerChamada.Ctlcontrols.play();
                RetMusic = 1;
            }

            //música parada, stop ou pause
            if (statusMusic == 0 || statusMusic == 2)
            {
                RetMusic = 0;
            }
        }

        private void RetornaMusica(int controle)
        {
            if (controle == 1)
            {
                MidiaPlayer.Ctlcontrols.play();
            }

        }
    }
}
