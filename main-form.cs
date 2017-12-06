using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SmallBasic.Library;
using System.Diagnostics;
using System.Threading;

namespace BELL_PRES
{

    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
            once_min_box.SelectedIndex = 0;
            twice_min_box.SelectedIndex = 0;
            min_box_5.SelectedIndex = 0;
            txt_audio_1.Text = Properties.Settings.Default.PlaySoundFile_1;
            txt_audio_2.Text = Properties.Settings.Default.PlaySoundFile_2;
            txt_audio_5.Text = Properties.Settings.Default.PlaySoundFile_3;
        }

        private string[] audio_files = new string[3];

        WMPLib.WindowsMediaPlayer mediaPlayer = new WMPLib.WindowsMediaPlayer();


        public void GetAudioFiles()
        {
            //Get from Setting File.
            //audio_files[0] = ;
            //audio_files[1] = ;
            //audio_files[2] = ;
        } 

        private void PlaySound(int i)
        {
            //sound.playandwait(@"c:\users\toyudocuments\visual studio 2015\projects\bell-pres\bell-pres\presen-"+i+".mp3");
            if (i == 1)
            {
                //try
                //{
                //    sound.play(txt_audio_1.text.tostring());
                //}
                //catch ()
                //{
                //    messagebox.show("音声ファイルを登録してください。<br/>setting タブより登録してください。", "error", messageboxbuttons.ok, messageboxicon.error);
                //}                
                try
                {
                    //オーディオファイルを指定する（自動的に再生される）
                    mediaPlayer.URL = txt_audio_1.Text.ToString();
                    //再生する
                    mediaPlayer.controls.play();
                }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show("押すのが早すぎます！", "Error!", MessageBoxButtons.OK);
                }
            }
            else if (i == 2)
            {
                try
                {
                    //オーディオファイルを指定する（自動的に再生される）
                    mediaPlayer.URL = txt_audio_2.Text.ToString();
                    //再生する
                    mediaPlayer.controls.play();
                }
                catch (System.InvalidOperationException e)
                {
                    MessageBox.Show("押すのが早すぎます！", "Error!", MessageBoxButtons.OK);
                }
            }
            else if (i == 3)
            {
                try
                {
                    //オーディオファイルを指定する（自動的に再生される）
                    mediaPlayer.URL = txt_audio_5.Text.ToString();
                    //再生する
                    mediaPlayer.controls.play();
                }
                catch (InvalidOperationException e)
                {
                    MessageBox.Show("押すのが早すぎます！", "Error!", MessageBoxButtons.OK);  
                }
            }
        }
        private void once_Click(object sender, EventArgs e)
        {
            Task task_playsound = Task.Run(() =>
            {
                PlaySound(1);
            });
        }

        private void twice_Click(object sender, EventArgs e)
        {
            Task task_playsound = Task.Run(() =>
            {
                PlaySound(2);
            });
        }

        private void time_5_Click(object sender, EventArgs e)
        {
            Task task_playsound = Task.Run(() =>
            {
                PlaySound(3);
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("T１：" + once_min_box.SelectedItem.ToString() + "<br/> T2:" + twice_min_box.SelectedItem.ToString() + "<br/> T3:" + min_box_5.SelectedItem.ToString(),
                "確認!", MessageBoxButtons.OK);
            int time_1 = ((int.Parse(once_min_box.SelectedItem.ToString()) * 60) + int.Parse(once_sec_box.Text)) * 1000;
            int time_2 = ((int.Parse(twice_min_box.SelectedItem.ToString()) * 60) + int.Parse(twice_sec_box.Text)) * 1000;
            int time_3 = ((int.Parse(min_box_5.SelectedItem.ToString()) * 60) + int.Parse(sec_box_5.Text)) * 1000;

            MessageBox.Show(time_1.ToString() + time_2.ToString() + time_3.ToString(), "確認", MessageBoxButtons.OK);

            Task task_play_sound_auto = Task.Run(() =>
            {
                Thread.Sleep(time_1);
                PlaySound(1);

                Thread.Sleep(time_2 - time_1);
                PlaySound(2);

                Thread.Sleep(time_3 - time_2);
                PlaySound(3);
            });
        }

        private void btn_set_audio_1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "音声ファイル(*.mp3;*.wav)|*.mp3;*.wav";
            ofd.Title = "音声ファイルを選択";
            //Show Dialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_audio_1.Text = ofd.FileName;
                Properties.Settings.Default.PlaySoundFile_1 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void btn_set_audio_2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "音声ファイル(*.mp3;*.wav)|*.mp3;*.wav";
            ofd.Title = "音声ファイルを選択";
            //Show Dialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_audio_2.Text = ofd.FileName;
                Properties.Settings.Default.PlaySoundFile_2 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void btn_set_audio_5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "音声ファイル(*.mp3;*.wav)|*.mp3;*.wav";
            ofd.Title = "音声ファイルを選択";
            //Show Dialog
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txt_audio_5.Text = ofd.FileName;
                Properties.Settings.Default.PlaySoundFile_3 = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }
    }
}