# Minikod-OBS

Projeyi nasıl çalıştırırız ?

Yüklenmesi gerekenler:

Visual Studio 2022 Community:
https://visualstudio.microsoft.com/tr/vs/community/
Visual Studio Paketleri:
Masaüstü ve Mobil: .NET Masaüstü Geliştirme Paketi (Projenin çalışması içindir.)
Web ve Bulut: ASP.NET Web Geliştirme Paketi (IIS Express'in çalışması içindir.)

Postgre SQL Version 15.x :
https://www.enterprisedb.com/downloads/postgres-postgresql-downloads
Postgre Konfigürasyonu:
User Id=postgres; Password=admin

Bu adımlardan sonra projeyi Github Desktop ile açın ve bilgisayarınıza klonlayın. 

Ardından projenin klasörüne erişin ve deneme3.sln solution dosyasını çalıştırın. Proje açılacaktır.

Proje açıldıktan sonra gerekli .Net Core paketleri kurmasına izin verin. 

Sonrasında Package Manager Konsol'a gelin ve "EntityFramework6\Update-Database" komutunu girin. Varolan migrationları veritabanınıza uyarlayacak
ve veritabanınızı hazır hale getirecektir.

Sonrasında Postgre SQL veritabanınızı kontrol edin ve Admins tablosunda ilk satırınızı oluşturup şu değerleri girin:
AdminID: 1
Kullanici: yigit
Sifre: 1234
Rol: B
Personel_Sube_Adı:
Eskişehir

Ardından bu değerleri girdikten sonra veritabanını Save edin. (F5 veya F6)

Sonrasında deneme3'ü IIS Express ile çalıştırmayı deneyin ilk sefer çalıştırdığınız için obj ve bin klasörleri ile .dll dosyaları oluşturulacak ve sizden
SSL Sertifika izini isteyecektir. Onay veriniz.

Ardından proje çalıştıktan sonra yigit - 1234 ile sisteme login olun.

Sizi öğrenci ekleme ekranına yönlendirecektir. İlk öğrencinizi eklemezseniz sistem hata verecektir. Formu eksiksiz doldurun ve fotoğrafı da yükleyin. 
Ardından öğrenci listesinde öğrenciniz gözükecektir. Öğrenci detaylarına girdiğinizde sistem exception verecektir. Exceptiondaki onay kutusunu kaldırın ve devam edin.

Bitiş.
