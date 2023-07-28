using Microsoft.AspNetCore.Mvc;
using System.Linq;
using deneme3.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting.Server;
using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Web;
using Microsoft.AspNetCore.Http;
using System.Drawing;
using System.Xml.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Security.Cryptography;
using System.Text;

using deneme3.ViewModel;
using Microsoft.AspNetCore.Authorization;
using EntityLayer.Tables;
using static EntityLayer.Tables.Veli;
using static EntityLayer.Tables.Ogrenci;

namespace deneme3.Controllers
{
    public class OgrenciController : Controller
    {
        Context1 c = new Context1();
        OgrenciKayıtViewModel multi = new OgrenciKayıtViewModel();

        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            multi.ogrenci = c.ogrencis.Find(id);
            multi.Anne = c.velis.FirstOrDefault(x => x.VelininTipi == VeliTipi.Anne && x.Ogrenci_Id == id);
            multi.Baba = c.velis.FirstOrDefault(x => x.VelininTipi == VeliTipi.Baba && x.Ogrenci_Id == id);

            var degerler = multi;

            degerler.ogrenci.OgrenciAdi = Decrypt(degerler.ogrenci.OgrenciAdi);
            degerler.ogrenci.OgrenciSoyad = Decrypt(degerler.ogrenci.OgrenciSoyad);

            return View(degerler);
        }

        [HttpPost]
        public async Task<IActionResult> Guncelle(IFormFile formFile, deneme3.ViewModel.OgrenciKayıtViewModel o)
        {
            var Ogrenci = c.ogrencis.Find(o.ogrenci.OgrenciNo);

            Ogrenci.OgrenciAdi = Encrypt(o.ogrenci.OgrenciAdi);
            Ogrenci.OgrenciSoyad = Encrypt(o.ogrenci.OgrenciSoyad);
            Ogrenci.TckimlikNo = o.ogrenci.TckimlikNo;
            Ogrenci.CepNo = o.ogrenci.CepNo;
            Ogrenci.Email = o.ogrenci.Email;
            Ogrenci.StudentGender = o.ogrenci.StudentGender;
            Ogrenci.DogumTarihi = o.ogrenci.DogumTarihi;
            Ogrenci.KayitTarihi = o.ogrenci.KayitTarihi;

            if (formFile != null)
            { 
            var extent = Path.GetExtension(formFile.FileName);
            var randomName = ($"{Guid.NewGuid()}{extent}");
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName);
            byte[] x;
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await formFile.CopyToAsync(stream);
            }
            using (var stream = new FileStream(path, FileMode.Open))
            {
                Image a = new Bitmap(stream);
                x = ImageToByte(a);


            }
                o.ogrenci.fotograf = x;
                Ogrenci.fotograf = o.ogrenci.fotograf;
            }


            var Anne = c.velis.FirstOrDefault(x => x.VelininTipi == VeliTipi.Anne && x.Ogrenci_Id == o.ogrenci.OgrenciNo);
            var Baba = c.velis.FirstOrDefault(x => x.VelininTipi == VeliTipi.Baba && x.Ogrenci_Id == o.ogrenci.OgrenciNo);

            Baba.TckimlikNo = o.Baba.TckimlikNo;
            Baba.Veli_Ad = o.Baba.Veli_Ad;
            Baba.Veli_Soyad = o.Baba.Veli_Soyad;
            Baba.VelininTipi = o.Baba.VelininTipi;
            Baba.Meslek = o.Baba.Meslek;
            Baba.Eposta = o.Baba.Eposta;
            Baba.Cepno = o.Baba.Cepno;

            Anne.TckimlikNo = o.Anne.TckimlikNo;
            Anne.Veli_Ad = o.Anne.Veli_Ad;
            Anne.Veli_Soyad = o.Anne.Veli_Soyad;
            Anne.VelininTipi = o.Anne.VelininTipi;
            Anne.Meslek = o.Anne.Meslek;
            Anne.Eposta = o.Anne.Eposta;
            Anne.Cepno = o.Anne.Cepno;

            c.SaveChanges();
            return RedirectToAction("Index");
        }

        // [Authorize] gerek kalmadı
        public IActionResult Index()
        {
            var degerler = c.ogrencis.ToList();

            
            foreach (var x in degerler)
            { 

            var cozum = x.OgrenciAdi;
            var cozum2 =x.OgrenciSoyad;

            x.CozulmusOgrenciAdi = Decrypt(cozum);
            x.CozulmusOgrenciSoyad = Decrypt(cozum2);

            }
            

            return View(degerler);
        }

        [HttpGet]
        public IActionResult YeniDepartman()
        {

            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> YeniDepartman(IFormFile formFile, deneme3.ViewModel.OgrenciKayıtViewModel o) 
        {

                    if (formFile != null) 
                    { 
                        var extent = Path.GetExtension(formFile.FileName);
                        var randomName = ($"{Guid.NewGuid()}{extent}");
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", randomName);
                        byte[] x;
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await formFile.CopyToAsync(stream);
                        }
                        using (var stream = new FileStream(path, FileMode.Open))
                        {
                            Image a = new Bitmap(stream);
                            x = ImageToByte(a);
                        }
                            o.ogrenci.fotograf = x;
                    }


                    else if (formFile == null && o.ogrenci.StudentGender == Gender.Kadin)
                    {
                        byte[] x;

                        Image a = new Bitmap("wwwroot/Graphics/woman.png");
                        x = ImageToByte(a);
                      
                        o.ogrenci.fotograf = x;
                    }


                    else if (formFile == null && o.ogrenci.StudentGender == Gender.Erkek)
                    {
                        byte[] x;

                        Image a = new Bitmap("wwwroot/Graphics/man.png");
                        x = ImageToByte(a);
                      
                        o.ogrenci.fotograf = x;
                    }


                    o.ogrenci.OgrenciAdi = Encrypt(o.ogrenci.OgrenciAdi);
                    o.ogrenci.OgrenciSoyad = Encrypt(o.ogrenci.OgrenciSoyad);                 

                    o.Baba.Ogrenci = o.ogrenci;
                    o.Anne.Ogrenci = o.ogrenci;

                    c.velis.Add(o.Baba);
                    c.velis.Add(o.Anne);
                    c.ogrencis.Add(o.ogrenci);

                    c.SaveChanges();
                    return RedirectToAction("Index");
        }

        public static byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }
        public static Image ByteToImage(byte[] img)
        {
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(img));
            return x;
        }

        public ContentResult OgrenciDurumGetir(int id)
        {
            var Ogrenci = c.ogrencis.Find(id);
            if (Ogrenci.Durum == true)
            {
                return Content("<script> alert('Ogrenciyi Pasife Alıyorsunuz') </script>");
            }

            else
            {
                return Content("<script> alert('Ogrenciyi Aktife Alıyorsunuz') </script>");
            }
        }

        public IActionResult OgrenciDurumDegistir(int id)
        {
            var Ogrenci = c.ogrencis.Find(id);


            if (Ogrenci.Durum == true)
            {
                Ogrenci.Durum = false;
            }

            else
            {
                Ogrenci.Durum = true;
            }


            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult PasifeAl(int id)
        {
            var Ogrenci=c.ogrencis.Find(id);
            Ogrenci.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult AktifeAl(int id)
        {
            var Ogrenci = c.ogrencis.Find(id);
            Ogrenci.Durum = true;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult OgrenciGetir()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult OgrenciGetir(EntityLayer.Tables.Ogrenci o)
        {
            var degerler = c.ogrencis.Find(o.OgrenciNo);
            
            return View("OgrenciGoster",degerler);

        }
        
        public IActionResult TanımlıOgrenciGetir12()
        {
            var query = c.ogrencis.Where(s => s.Cinsiyet == "e"&& s.Durum==true).ToList();

            return View(query);

        }

        [Authorize(Roles ="B")]
        public IActionResult OgrenciDetay(int id)
        {
            var degerler = c.ogrencis.Find(id);
            //var degerler = c.ogrencis.FirstOrDefault(x => x.OgrenciNo == id);

            degerler.CozulmusOgrenciAdi = Decrypt(degerler.OgrenciAdi);
            degerler.CozulmusOgrenciSoyad = Decrypt(degerler.OgrenciSoyad);

            return View(degerler);

        }

        private string Encrypt(string clearText)
        {
            string encryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }

            return clearText;
        }

        private string Decrypt(string cipherText)
        {
            string encryptionKey = "MAKV2SPBNI99212";
            byte[] cipherBytes = Convert.FromBase64String(cipherText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(encryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(cipherBytes, 0, cipherBytes.Length);
                        cs.Close();
                    }
                    cipherText = Encoding.Unicode.GetString(ms.ToArray());
                }
            }

            return cipherText;
        }

    }
}
