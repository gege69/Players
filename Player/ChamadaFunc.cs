using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Speech.Synthesis;
using SpeechLib;

namespace Player
{
    public partial class ChamadaFunc : Form
    {
        public ChamadaFunc()
        {
            InitializeComponent();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            //int velocidade = trbVelocidade.Value;
            //int volume = trbVolume.Value;
            string mensagem = string.IsNullOrEmpty(txtFalar.Text) ? "The book is on the table." : txtFalar.Text;

            Falar01(-5, 100, mensagem);
//            if (radioButton1.Checked)
  //              Falar01(velocidade, volume, mensagem);
    //        else
      //          Falar02(velocidade, volume, mensagem);
        }

        private void Falar01(int velocidade, int volume, string mensagem)
        {
            // Cria o objeto
            SpVoice speak = new SpVoice();
            // Define a velocidade
            speak.Rate = velocidade;
            // Define o volume
            speak.Volume = volume;
            // Pede uma requisição para falar
            speak.Speak(mensagem, SpeechVoiceSpeakFlags.SVSFDefault);
            //Se você deixar essa linha, o texto falará apenas quando terminar o método (método Assíncrono)
            speak.WaitUntilDone(speak.SynchronousSpeakTimeout);
        }

        private void Falar02(int velocidade, int volume, string mensagem)
        {
            // Cria o objeto
            SpeechSynthesizer speak = new SpeechSynthesizer();
            // Define a velocidade
            speak.Rate = velocidade;
            // Define o volume
            speak.Volume = volume;
            // Fala o texto
            // Você pode substituir esse método pelo SpeakAsync
            speak.Speak(mensagem);
        }
    }
}
