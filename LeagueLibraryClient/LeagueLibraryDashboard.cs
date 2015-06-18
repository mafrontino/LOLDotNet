using LOLDotNet.LeagueDataModel.LeagueEntityObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOLDotNet.LeagueLibraryClient
{
    public partial class LeagueLibraryDashboard : Form
    {
        private ChampionCollection champions;

        public LeagueLibraryDashboard(ChampionCollection champions)
        {
            InitializeComponent();

            this.champions = champions;
            List<string> list = this.champions.Champions.Keys.ToList<string>();
            list.Sort();
            lbxChampions.DataSource = list;
            //lbxChampions.DisplayMember = "Key";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxChampions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbxChampions.SelectedIndex >= 0)
            {
                Champion targetChampion = champions[lbxChampions.SelectedItem.ToString()];
                txtId.Text = targetChampion.Id.ToString();
                txtTitle.Text = targetChampion.Title.ToString();
                txtLore.Text = targetChampion.Lore;
                txtPartype.Text = targetChampion.Partype;
                //txtFreeToPlay.Text = targetChampion.FreeToPlay;
                //targetChampion

                //targetChampion.Stats
            }
        }
    }
}
