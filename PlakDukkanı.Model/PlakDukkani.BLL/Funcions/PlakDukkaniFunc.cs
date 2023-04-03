using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using PlakDukkanı.DAL.Context;
using PlakDukkanı.Model.Models;

namespace PlakDukkani.BLL.Funcions
{
    public static class PlakDukkaniFunc
    {

        public static PlakDukkaniContext _db = new PlakDukkaniContext();

        public static bool UserControl(string username,string password)
        {

            var username1 = _db.Administrators.Where(x => x.UserName.Equals(username)).FirstOrDefault();
            bool pas = username1.VerifyPassword(password);
            if (username1.FirstName ==username && pas)
            {
               return true;
            }
            return false;
        }
        public static List<Album> GetAlbums()
        {
            return _db.Albums.ToList();
        }
        /// <summary>
        /// Album eklemek için albüm bilgilerini yollayınız.
        /// </summary>
        /// <param name="ad"></param>
        /// <param name="fiyat"></param>
        /// <param name="cikisTarihi"></param>
        /// <param name="sanatci"></param>
        public static void AddAlbums(string ad, decimal fiyat, DateTime cikisTarihi,Artist_Group sanatci )
        {
            try
            {
                Album album = new Album()
                {
                    Name = ad,
                    Price = fiyat,
                    ReleaseDate = cikisTarihi,
                    Discontinued = true,
                    Artist_Group = sanatci
                };

                _db.Albums.Add(album);
                _db.SaveChanges();
            }
            catch (Exception ex) { }
        }
        public static void DeletedAlbum(Album album)
        {
            _db.Albums.Remove(album);
            _db.SaveChanges();
        }
        /// <summary>
        /// Artist veya grup eklemek için isim ve açıklama gönderiniz.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="des"></param>
        public static void AddArtist_Group(string name, string des)
        {
            try
            {
                Artist_Group artist_Group = new Artist_Group()
                {
                    Name = name,
                    Description = des
                };
                _db.Artist_Groups.Add(artist_Group);
                _db.SaveChanges();
            }
            catch (Exception) { }
        }
        public static void DeleteArtist_Group(Artist_Group artist_Group)
        {
            _db.Artist_Groups.Remove(artist_Group);
            _db.SaveChanges ();
        }
        public static void UpdateArtist_Group(Artist_Group artist_Group,string name,string des) 
        { 
            artist_Group.Name = name;
            artist_Group.Description = des;
            _db.SaveChanges();
        }
    }
}
