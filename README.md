# 💻 Asp.Net Core 8.0 CQRS - Mediator DesignPattern ile RentACarFilter Projesi
📢 M&Y Yazılım Akademi Danışmanlıktan aldığım eğitim kapsamında geliştirmiş olduğum 7. proje olan Rent A Car Filtre Uygulaması projesidir.

## 🪶 Projenin Amacı;
Proje bir araç kiralama sitesinin arayüzüne ve veritabanı sistemine sahiptir. Kullanıcılar listeli araçları görebilir, araçların detaylarını açılan pop-up' da inceleyebilir, istedikleri tarihlerdeki araçları filtreleyerek müsait araçları görüntüleyebilirler. Bununla birlikte bütün bu veriler yönetim panelinden yönetilmektedir.

## 🛠️ Kullanılan Bazı Teknolojiler
* 🏗️ CQRS - Mediator Repository Design Patterns üzerine kuruldu.
* 🗄️ DbCodeFirst ile MSSQL veritabanı oluşturulup yönetimi sağlandı.
* ⚡ Entity Framework 8.0 Veritabanı etkileşimi ve ORM için kullanıldı.
* 🔐 Üyelik sistemi Identity ile kontrol edilip rol bazlı yetkilendirme sağlanmıştır.
* 🏢 Proje Admin adlı bir Area vardır ve ana ekrandan ayrılmaktadır.
* 🧩 Bütün proje SOLID prensipleriyle ve folder structure yapısıyla oluşturuldu.
* 💻 HTML-CSS Bootstrap ile arayüzler tasarlandı.
* 🗂️ Area sistemiyle paneller birbirinden ayrılıp yönetimi kolaylaştırıldı.
* 🔄 Projede bol bol iç içe layout ve ViewComponent yapısı kullanıldı.

# Veritabanı
![Veritabanı](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/database.png?raw=true)
### Giriş
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/login.png?raw=true)
### Kayıt
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/register.png?raw=true)

### Yönetim Paneli
#### Anasayfa
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/admin_default.png?raw=true)
#### Markalar
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/admin_brandList.png?raw=true)
#### Lokasyonlar
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/admin_locationList.png?raw=true)
#### Araçlar
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/admin_carList.png?raw=true)
##### Yeni Araç
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/admin_createCar.png?raw=true)
##### Araç Güncelleme
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/admin_updateCar.png?raw=true)
#### Rezervasyonlar
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/admin_reservation.png?raw=true)

### Ana Ekran
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/ui_filter.png?raw=true)
####
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/ui_filterList.png?raw=true)
####
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/ui_filterListModal.png?raw=true)
####
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/ui_filterNoCar.png?raw=true)
####
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/ui_carList.png?raw=true)
####
![](https://github.com/batuhanyalin/RentACarFilterProject/blob/master/RentACarFilterProject/wwwroot/images/projectScreenshots/ui_footer.png?raw=true)



