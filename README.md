🎯 TraversalCoreProje - Genel Bakış
TraversalCoreProje, kullanıcıların destinasyonları (seyahat yerlerini) inceleyebildiği, yorum yapabildiği ve rezervasyon oluşturabildiği, yöneticilerin ve üyelerin ise bu içerikleri kontrol edebildiği çok katmanlı bir ASP.NET Core uygulamasıdır.

🧱 Katmanlar ve Yapılar
📌 1. EntityLayer
Veri varlıklarını (entity) tanımlar. EF Core ile veritabanı işlemlerinde kullanılır.

📄 Öne çıkan sınıflar:

Destination.cs: Seyahat edilecek yer.

Comment.cs: Kullanıcı yorumları.

Rezervation.cs: Rezervasyon bilgileri.

AppUser.cs, AppRole.cs: Kimlik yönetimi için kullanıcı ve rol varlıkları.

Testimonial.cs, Guide.cs, Feature.cs: Tanıtım amaçlı içerikler.

About2.cs, SubAbout.cs: "Hakkımızda" bölümleri için kullanılır.

📌 2. DataAccessLayer (DAL)
Veritabanına erişimi sağlayan katmandır.

➕ Abstract (Interface):
Her tablo için IxxxDal adında arayüzler yer alır. Örn: ICommentDal, IDestinationDal.

🧩 Concrete:
EntityFramework/: EF Core ile DAL implementasyonları. (Örn: EfCommentDal, EfDestinationDal)

Context.cs: EF DbContext sınıfı.

Repository/GenericRepository.cs: Generic repository yapısı.

📌 3. BusinessLayer
İş mantığının bulunduğu katmandır.

➕ Abstract:
Servis arayüzleri: ICommentService, IDestinationService, IGuideService vb.

IGenericService<T>: Generic servis arayüzü.

🧩 Concrete:
CommentManager, DestinationManager, FeatureManager vb. servis implementasyonları.

ValidationRules/AboutValidator.cs: FluentValidation kullanılarak yapılan model doğrulama.

📌 4. TraversalCoreProje (Ana Web Projesi)
Uygulamanın sunum katmanıdır. Kullanıcı arayüzünü ve HTTP isteklerini yönetir.

🧩 Areas/Member:
Üyelere özel alan (profil, yorum, rezervasyon gibi işlemleri yönetir).

RezervationController.cs, ProfileController.cs, CommentController.cs

Views içinde ilgili Razor sayfaları (örneğin Profile/, Rezervation/)

🧩 Controllers (Ana proje içi):
Global sayfalar ve işlemler (örneğin ana sayfa, hakkında sayfası gibi).

🧩 ViewComponents:
_SliderPartial, _PopularDestinations, _Statistics, _SubAbout: Ana sayfadaki bölümleri temsil eder.

_CommentList: Yorumların listelendiği component.

🧩 Views:
Uygulamanın HTML tarafı, Razor sayfaları içerir.

Layout yapısı muhtemelen Shared/_Layout.cshtml içinde bulunur.

🛠️ Diğer:
Program.cs / Startup.cs: Uygulama başlatma ve konfigürasyon.

appsettings.json: Veritabanı ve diğer ayarlar.

💡 Öne Çıkan Özellikler
✅ Katmanlı Mimari (N-Tier Architecture)
✅ Entity Framework Core ile Veritabanı İşlemleri
✅ Generic Repository & Service Kullanımı
✅ FluentValidation ile Model Doğrulama
✅ ViewComponent ile Parçalı Sayfa Yapısı
✅ Area Kullanımı (Üye Paneli)
✅ Razor View (MVC UI)
✅ Rezervasyon Sistemi
✅ Yorum Yönetimi
✅ Hakkımızda / Tanıtım İçerikleri
✅ Slider, Popüler Destinasyonlar gibi dinamik görsel içerikler
