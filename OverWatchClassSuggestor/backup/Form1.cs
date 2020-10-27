using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverWatchClassSuggestor
{
    public partial class FormOverWatchClassSuggestor : Form
    {
        public FormOverWatchClassSuggestor()
        {   
            InitializeComponent();
            comboBoxMap.Items.Add(" ");
            comboBoxMap.Items.Add("Control");
            comboBoxMap.Items.Add("Hybrid Attacking");
            comboBoxMap.Items.Add("Hybrid Defending");
            comboBoxMap.Items.Add("PayLoad/Escort Attacking");
            comboBoxMap.Items.Add("PayLoad/Escort Defending");
            comboBoxMap.Items.Add("Point Capture/Assault Attacking");
            comboBoxMap.Items.Add("Point Capture/Assault Defending");
        }

        public void clearButtonEnemy(int i)
        {
            switch(i)
            {
                case 1:
                    buttonEnemy1.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
                    break;
                case 2:
                    buttonEnemy2.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
                    break;
                case 3:
                    buttonEnemy3.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
                    break;
                case 4:
                    buttonEnemy4.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
                    break;
                case 5:
                    buttonEnemy5.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
                    break;
                case 6:
                    buttonEnemy6.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
                    break;
            }
        }

        public void clearAllButtonEnemy()
        {
            buttonEnemy1.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
            buttonEnemy2.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
            buttonEnemy3.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
            buttonEnemy4.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
            buttonEnemy5.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
            buttonEnemy6.Image = global::OverWatchClassSuggestor.Properties.Resources.blank;
            RefreshRecommendations();
        }

        public void clearAllLabelEnemy()
        {
            labelDoomfist.Text = "0";
            labelMcCree.Text = "0";
            labelSoldier76.Text = "0";
            labelBastion.Text = "0";
            labelZenyatta.Text = "0";
            labelGenji.Text = "0";
            labelJunkrat.Text = "0";
            labelPharah.Text = "0";
            labelSombra.Text = "0";
            labelTracer.Text = "0";
            labelHanzo.Text = "0";
            labelMei.Text = "0";
            labelTorbjorn.Text = "0";
            labelWidowmaker.Text = "0";
            labelDva.Text = "0";
            labelOrisa.Text = "0";
            labelReinhardt.Text = "0";
            labelRoadhog.Text = "0";
            labelWinston.Text = "0";
            labelZarya.Text = "0";
            labelAna.Text = "0";
            labelLucio.Text = "0";
            labelMercy.Text = "0";
            labelSymmetra.Text = "0";
            labelReaper.Text = "0";            
        }


        public Button getButtonEnemy(int i)
        {
            switch (i)
            {
                case 0:
                    return buttonEnemy1;
                    //break;
                case 1:
                    return buttonEnemy2;
                    //break;
                case 2:
                    return buttonEnemy3;
                    //break;
                case 3:
                    return buttonEnemy4;
                    //break;
                case 4:
                    return buttonEnemy5;
                    //break;
                case 5:
                    return buttonEnemy6;
                    //break;
            }
            return null;
        }

        public void setButtonEnemy(int i, string enemy)
        {
            switch (i)
            {
                case 0:
                    buttonEnemy1.Image = ((System.Drawing.Image)(resources.GetObject("button"+enemy+".Image")));
                    break;
                case 1:
                    buttonEnemy2.Image = ((System.Drawing.Image)(resources.GetObject("button" + enemy + ".Image")));
                    break;
                case 2:
                    buttonEnemy3.Image = ((System.Drawing.Image)(resources.GetObject("button" + enemy + ".Image")));
                    break;
                case 3:
                    buttonEnemy4.Image = ((System.Drawing.Image)(resources.GetObject("button" + enemy + ".Image")));
                    break;
                case 4:
                    buttonEnemy5.Image = ((System.Drawing.Image)(resources.GetObject("button" + enemy + ".Image")));
                    break;
                case 5:
                    buttonEnemy6.Image = ((System.Drawing.Image)(resources.GetObject("button" + enemy + ".Image")));
                    break;
                   
            }
            
        }

        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOverWatchClassSuggestor));

        //public void doSomethingYouFucker()
        //{ 
            
            //public System.Windows.Forms.Button[] buttonEnemy = { buttonEnemy1 };
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private System.Drawing.Color getBackColor(int s) // s for score
        {
            if (s > 0)
                return System.Drawing.Color.LightGreen;
            else if (s < 0)
                return System.Drawing.Color.Red;
            else
                return System.Drawing.Color.Silver; 
        }


        public void RefreshRecommendations()
        {
            labelDoomfist.Text = OverWatchClasses.classDoomfist.getRecommendation().ToString();
            labelMcCree.Text = OverWatchClasses.classMcCree.getRecommendation().ToString();            
            labelSoldier76.Text = OverWatchClasses.classSoldier76.getRecommendation().ToString();
            labelBastion.Text = OverWatchClasses.classBastion.getRecommendation().ToString();
            labelZenyatta.Text = OverWatchClasses.classZenyatta.getRecommendation().ToString();
            labelGenji.Text = OverWatchClasses.classGenji.getRecommendation().ToString();
            labelJunkrat.Text = OverWatchClasses.classJunkrat.getRecommendation().ToString();
            labelPharah.Text = OverWatchClasses.classPharah.getRecommendation().ToString();
            labelSombra.Text = OverWatchClasses.classSombra.getRecommendation().ToString();
            labelTracer.Text = OverWatchClasses.classTracer.getRecommendation().ToString();
            labelHanzo.Text = OverWatchClasses.classHanzo.getRecommendation().ToString();
            labelMei.Text = OverWatchClasses.classMei.getRecommendation().ToString();
            labelTorbjorn.Text = OverWatchClasses.classTorbjorn.getRecommendation().ToString();
            labelWidowmaker.Text = OverWatchClasses.classWidowMaker.getRecommendation().ToString();
            labelDva.Text = OverWatchClasses.classDva.getRecommendation().ToString();
            labelOrisa.Text = OverWatchClasses.classOrisa.getRecommendation().ToString();
            labelReinhardt.Text = OverWatchClasses.classReinhardt.getRecommendation().ToString();
            labelRoadhog.Text = OverWatchClasses.classRoadhog.getRecommendation().ToString();
            labelWinston.Text = OverWatchClasses.classWinston.getRecommendation().ToString();
            labelZarya.Text = OverWatchClasses.classZarya.getRecommendation().ToString();
            labelAna.Text = OverWatchClasses.classAna.getRecommendation().ToString();
            labelLucio.Text = OverWatchClasses.classLucio.getRecommendation().ToString();
            labelMercy.Text = OverWatchClasses.classMercy.getRecommendation().ToString();
            labelSymmetra.Text = OverWatchClasses.classSymmetra.getRecommendation().ToString();
            labelReaper.Text = OverWatchClasses.classReaper.getRecommendation().ToString();

            labelDoomfist.BackColor = getBackColor(Convert.ToInt32(labelDoomfist.Text));
            labelMcCree.BackColor = getBackColor(Convert.ToInt32(labelMcCree.Text));
            labelSoldier76.BackColor = getBackColor(Convert.ToInt32(labelSoldier76.Text));
            labelBastion.BackColor = getBackColor(Convert.ToInt32(labelBastion.Text));
            labelZenyatta.BackColor = getBackColor(Convert.ToInt32(labelZenyatta.Text));
            labelGenji.BackColor = getBackColor(Convert.ToInt32(labelGenji.Text));
            labelJunkrat.BackColor = getBackColor(Convert.ToInt32(labelJunkrat.Text));
            labelPharah.BackColor = getBackColor(Convert.ToInt32(labelPharah.Text));
            labelSombra.BackColor = getBackColor(Convert.ToInt32(labelSombra.Text));
            labelTracer.BackColor = getBackColor(Convert.ToInt32(labelTracer.Text));
            labelHanzo.BackColor = getBackColor(Convert.ToInt32(labelHanzo.Text));
            labelMei.BackColor = getBackColor(Convert.ToInt32(labelMei.Text));
            labelTorbjorn.BackColor = getBackColor(Convert.ToInt32(labelTorbjorn.Text));
            labelWidowmaker.BackColor = getBackColor(Convert.ToInt32(labelWidowmaker.Text));
            labelMcCree.BackColor = getBackColor(Convert.ToInt32(labelMcCree.Text));
            labelDva.BackColor = getBackColor(Convert.ToInt32(labelDva.Text));
            labelOrisa.BackColor = getBackColor(Convert.ToInt32(labelOrisa.Text));
            labelReinhardt.BackColor = getBackColor(Convert.ToInt32(labelReinhardt.Text));
            labelRoadhog.BackColor = getBackColor(Convert.ToInt32(labelRoadhog.Text));
            labelWinston.BackColor = getBackColor(Convert.ToInt32(labelWinston.Text));
            labelZarya.BackColor = getBackColor(Convert.ToInt32(labelZarya.Text));
            labelAna.BackColor = getBackColor(Convert.ToInt32(labelAna.Text));
            labelLucio.BackColor = getBackColor(Convert.ToInt32(labelLucio.Text));
            labelMercy.BackColor = getBackColor(Convert.ToInt32(labelMercy.Text));
            labelSymmetra.BackColor = getBackColor(Convert.ToInt32(labelSymmetra.Text));
            labelReaper.BackColor = getBackColor(Convert.ToInt32(labelReaper.Text));

/*
            if (Convert.ToInt32(labelMcCree.Text) > 1)
            { 
                labelGenji.ForeColor = System.Drawing.Color.White;
                labelGenji.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelSoldier76.Text) > 1)
            {
                labelSoldier76.ForeColor = System.Drawing.Color.White;
                labelSoldier76.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelBastion.Text) > 1)
            {
                labelBastion.ForeColor = System.Drawing.Color.White;
                labelBastion.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelZenyatta.Text) > 1)
            {
                labelZenyatta.ForeColor = System.Drawing.Color.White;
                labelZenyatta.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelGenji.Text) > 1)
            {
                labelGenji.ForeColor = System.Drawing.Color.White;
                labelGenji.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelJunkrat.Text) > 1)
            {
                labelJunkrat.ForeColor = System.Drawing.Color.White;
                labelJunkrat.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelPharah.Text) > 1)
            {
                labelPharah.ForeColor = System.Drawing.Color.White;
                labelPharah.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelTracer.Text) > 1)
            {
                labelTracer.ForeColor = System.Drawing.Color.White;
                labelTracer.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelMei.Text) > 1)
            {
                labelMei.ForeColor = System.Drawing.Color.White;
                labelMei.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelTorbjorn.Text) > 1)
            {
                labelTorbjorn.ForeColor = System.Drawing.Color.White;
                labelTorbjorn.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelWidowmaker.Text) > 1)
            {
                labelWidowmaker.ForeColor = System.Drawing.Color.White;
                labelWidowmaker.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelDva.Text) > 1)
            {
                labelDva.ForeColor = System.Drawing.Color.White;
                labelDva.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelReinhardt.Text) > 1)
            {
                labelReinhardt.ForeColor = System.Drawing.Color.White;
                labelReinhardt.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelRoadhog.Text) > 1)
            {
                labelRoadhog.ForeColor = System.Drawing.Color.White;
                labelRoadhog.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelWinston.Text) > 1)
            {
                labelWinston.ForeColor = System.Drawing.Color.White;
                labelWinston.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelZarya.Text) > 1)
            {
                labelZarya.ForeColor = System.Drawing.Color.White;
                labelZarya.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelAna.Text) > 1)
            {
                labelAna.ForeColor = System.Drawing.Color.White;
                labelAna.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelLucio.Text) > 1)
            {
                labelLucio.ForeColor = System.Drawing.Color.White;
                labelLucio.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelMercy.Text) > 1)
            {
                labelMercy.ForeColor = System.Drawing.Color.White;
                labelMercy.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelSymmetra.Text) > 1)
            {
                labelSymmetra.ForeColor = System.Drawing.Color.White;
                labelSymmetra.BackColor = System.Drawing.Color.Green;
            }

            if (Convert.ToInt32(labelReaper.Text) > 1)
            {
                labelReaper.ForeColor = System.Drawing.Color.White;
                labelReaper.BackColor = System.Drawing.Color.Green;
            }
 * */
        
        }

        private void buttonMcCree_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.mcCree);
            RefreshRecommendations();
        }

        private void buttonSoldier76_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.soldier76);
            RefreshRecommendations();
        }

        private void buttonBastion_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.bastion);
            RefreshRecommendations();
        }

        private void buttonZenyatta_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.zenyatta);
            RefreshRecommendations();
        }

        private void buttonGenji_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.genji);
            //buttonEnemy1.Tag = OverWatchClasses.genji;
            RefreshRecommendations();
        }

        private void buttonJunkrat_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.junkrat);
            RefreshRecommendations();
        }

        private void buttonPharah_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.pharah);
            RefreshRecommendations();
        }

        private void buttonTracer_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.tracer);
            RefreshRecommendations();
        }

        private void buttonHanzo_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.hanzo);
            RefreshRecommendations();
        }

        private void buttonMei_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.mei);
            RefreshRecommendations();
        }

        private void buttonTorbjorn_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.torbjorn);
            RefreshRecommendations();
        }

        private void buttonWidowmaker_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.widowMaker);
            RefreshRecommendations();
        }

        private void buttonDva_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.dva);
            RefreshRecommendations();
        }

        private void buttonReinhardt_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.reinhardt);
            RefreshRecommendations();
        }

        private void buttonRoadhog_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.roadhog);
            RefreshRecommendations();
        }

        private void buttonWinston_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.winston);
            RefreshRecommendations();
        }

        private void buttonZarya_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.zarya);
            RefreshRecommendations();
        }

        private void buttonAna_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.ana);
            RefreshRecommendations();
        }

        private void buttonLucio_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.lucio);
            RefreshRecommendations();
        }

        private void buttonMercy_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.mercy);
            RefreshRecommendations();
        }

        private void buttonSymmetra_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.symmetra);
            RefreshRecommendations();
        }

        private void buttonResetEnemyTeam_Click(object sender, EventArgs e)
        {
            OverWatchClasses.clearEnemyTeam();
        }



        private void labelGenji_Click(object sender, EventArgs e)
        {

        }

        private void labelReaper_Click(object sender, EventArgs e)
        {

        }

        private void buttonReaper_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.reaper);
            RefreshRecommendations();

        }

        private void labelDva_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.dva);
            RefreshRecommendations();
        }

        private void labelZenyatta_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.zenyatta);
            RefreshRecommendations();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OverWatchClasses.removeEnemy(1); // buttonEnemy1.Tag.ToString()
            RefreshRecommendations();
        }

        private void buttonEnemy2_Click(object sender, EventArgs e)
        {
            OverWatchClasses.removeEnemy(2); // buttonEnemy1.Tag.ToString()
            RefreshRecommendations();
        }

        private void buttonEnemy3_Click(object sender, EventArgs e)
        {
            OverWatchClasses.removeEnemy(3); // buttonEnemy1.Tag.ToString()
            RefreshRecommendations();
        }

        private void buttonEnemy4_Click(object sender, EventArgs e)
        {
            OverWatchClasses.removeEnemy(4); // buttonEnemy1.Tag.ToString()
            RefreshRecommendations();
        }

        private void buttonEnemy5_Click(object sender, EventArgs e)
        {
            OverWatchClasses.removeEnemy(5); // buttonEnemy1.Tag.ToString()
            RefreshRecommendations();
        }

        private void buttonEnemy6_Click(object sender, EventArgs e)
        {
            OverWatchClasses.removeEnemy(6); // buttonEnemy1.Tag.ToString()
            RefreshRecommendations();
        }

        private void labelPharah_Click(object sender, EventArgs e)
        {

        }

        private void labelWidowmaker_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelBastion_Click(object sender, EventArgs e)
        {

        }

        private void labelDoomfist_Click(object sender, EventArgs e)
        {

        }

        private void buttonSombra_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.sombra);
            RefreshRecommendations();
        }

        private void labelSombra_Click(object sender, EventArgs e)
        {

        }

        private void buttonDoomfist_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.doomfist);
            RefreshRecommendations();
        }

        private void labelOrisa_Click(object sender, EventArgs e)
        {

        }

        private void buttonOrisa_Click(object sender, EventArgs e)
        {
            OverWatchClasses.addEnemy(OverWatchClasses.orisa);
            RefreshRecommendations();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMap_SelectedIndexChanged(object sender, EventArgs e)
        {      
      
           OverWatchClasses.setMap(comboBoxMap.SelectedItem.ToString());
           RefreshRecommendations();
        }
    }
}
