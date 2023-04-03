using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlakDukkani.BLL.Funcions;
using PlakDukkanı.Model.Models;

namespace PlakDukkani.UI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            View();
            cbArtist.SelectedIndex = -1;
            cbArtistRefresh();
        }
        /// <summary>
        /// Filtrelenmemiş albüm listesini görüntüler.
        /// </summary>
        private void View()
        {
            dgwAlbum.DataSource = null;
            dgwAlbum.DataSource = PlakDukkaniFunc.GetAlbums();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            PlakDukkaniFunc.AddAlbums(txtAlbumAdi.Text, nupPrice.Value, dtpReleaseDate.Value, (Artist_Group)cbArtist.SelectedItem);
        }


        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            PlakDukkaniFunc._db.SaveChanges();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var secili = dgwAlbum.CurrentRow.DataBoundItem;
            PlakDukkaniFunc.DeletedAlbum((Album)secili);
            dgwAlbum.DataSource = PlakDukkaniFunc.GetAlbums();
        }

        private void btnArtistEkle_Click(object sender, EventArgs e)
        {
            PlakDukkaniFunc.AddArtist_Group(txtArtistName.Text, txtArtistDes.Text);
            cbArtistRefresh();
        }


        private void btnArtistSil_Click(object sender, EventArgs e)
        {
            PlakDukkaniFunc.DeleteArtist_Group((Artist_Group)(cbArtist.SelectedItem));
        }


        private void btnArtistGuncelle_Click(object sender, EventArgs e)
        {
            PlakDukkaniFunc.UpdateArtist_Group(((Artist_Group)(cbArtist.SelectedItem)), txtArtistName.Text, txtArtistDes.Text);
            cbArtistRefresh();
        }
        private void cbArtistRefresh()
        {
            cbArtist.DataSource = null;
            cbArtist.DataSource = PlakDukkaniFunc._db.Artist_Groups.ToList();

        }

        private void btnview_Click(object sender, EventArgs e)
        {
            if (cbList.SelectedIndex == 0)
            {
                var list = PlakDukkaniFunc._db.Albums.Where(x => !x.Discontinued).Select(x => new { AlbumAdi = x.Name, Sanatçi = x.Artist_Group.Name }).ToList();
                dgwAlbum.DataSource = null;
                dgwAlbum.DataSource = list;
            }
            else if (cbList.SelectedIndex == 1)
            {
                var list = PlakDukkaniFunc._db.Albums.Where(x => x.Discontinued).Select(x => new { AlbumAdi = x.Name, Sanatçi = x.Artist_Group.Name }).ToList();
                dgwAlbum.DataSource = null;
                dgwAlbum.DataSource = list;
            }
            else if (cbList.SelectedIndex == 2)
            {
                var list = PlakDukkaniFunc._db.Albums.OrderByDescending(x => x.AlbumId).Take(10).Select(x => new { AlbumAdi = x.Name, Sanatçi = x.Artist_Group.Name }).ToList();
                dgwAlbum.DataSource = null;
                dgwAlbum.DataSource = list;
            }
            else if (cbList.SelectedIndex == 3)
            {
                var list = PlakDukkaniFunc._db.Albums.Where(x => x.DiscountRate > 0).OrderByDescending(x => x.DiscountRate).Select(x => new { AlbumAdi = x.Name, Sanatçi = x.Artist_Group.Name }).ToList();
                dgwAlbum.DataSource = null;
                dgwAlbum.DataSource = list;
            }

        }

        private void btnTumList_Click(object sender, EventArgs e)
        {
            View();
        }
    }
}
