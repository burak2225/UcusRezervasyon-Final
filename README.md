UÇUŞ REZERVASYON-FİNAL

Bu uygulamada belirtilen Uçak Entity Class, Lokasyon Entity Class, Uçuş Enity Class, Rezervasyon Entity Class lar oluşturulup kullanıcıdan inputları aldıktan sonra rezervasyon yapılır.
Her Class ın altı olduğu Id bilgisini içeren BaseEntity Class bulunmaktadır.
Uçak bilgileri hazır programda hazır bulunmaktadır(1adet)
Lokasyon bilgileri kullanıcı inputu ile girilmiştir
Uçuş bilgileri Lokasyon bilgileriyle birlikte DateTime metodu ile güncel saat ve tarih kaydedilmiştir.
Rezervasyon classında Uçuş bilgileri alınıp kullanıcıdan kişisel bilgileri input ile alınır ve RezervasyonYap metodu ile ilgili uçağın kapasitesi kontrol edilip bu duruma göre kaydı yapar
(eğer kayıt yapılabilirse uçak kapasitesini 1 azaltır)
Son olarak Rezervasyon bilgilerini cvs formatında kaydeder

Görsel Programlama 1
Burak Özbey
