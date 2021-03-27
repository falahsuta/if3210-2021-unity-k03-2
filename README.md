# Tugas Besar 2 IF3210 Pengembangan Aplikasi pada Platform Khusus

## Anggota Kelompok

* 13518015 Arief Darmawan Tantriady
* 13518087 Radhinansyah Hemsa Ghaida
* 13518102 Muhammad Falah Sutanwindaya

## Deskripsi Game

Secara ringkas, game yang kami buat merupakan suatu game 3D top-down dengan gameplay tank battle royal. Permainan ini merupakan ekstensi dari game Tanks - Unity Learn.

## Cara Kerja

Setelah game ini dibuka, akan muncul main menu. Pada main menu, pengguna dapat mengatur pengaturan suara pada setting, serta pada main menu ada juga pilihan untuk memilih map
dan mode bermain. Pada game ini, pemain akan bermain melawan pemain yang lain pada satu komputer yang sama. Player 1 dapat bergerak dengan menggunakan WASD dan Spasi untuk menembak. Player 2 dapat bergerak menggunakan Arrow Keys serta Enter untuk menembak. Terdapat 2 mode yang dapat dipilih pada game ini yaitu battle Royal dan Coin Collection. Kedua mode tersebut dijelaskan pada spesifikasi dibawah.


## Spesifikasi

### Multiplayer dapat dijalankan secara local area network dengan lebih dari dua pemain. 

Fitur ini TIDAK kami implementasikan.

### Main Menu

![](xxx)

Pada main menu, terdapat pilihan untuk bermain game dimana pilihan tersebut terdiri dari mode yang ingin dimainkan serta map yang ingin dimainkan. Selain itu, pada main menu, terdapat pula settings untuk mengatur intensitas suara.

### Map

![](xxx)

Terdapat dua map yang dapat dipilih dalam game ini, yaitu:
* Forest
* Snow

Setiap map memiliki desain dan luasan yang berbeda. 

### Cash

![](xxx)


Terdapat objek cash yang muncul secara periodik pada mode battle royal. Tank dapat mengambil cash untuk menambahkan uang yang dimilikinya. Pada mode CoinCollecting tidak ada pengambilan cash.


### Senjata

![](xxx)

Terdapat senjata-senjata yang bisa dipilih pada mode battle royal. Pemain dapat membeli senjata dengan menggunakan cash yang diambil pada permainan.


### Collision

![](xxx)

Terdapat interaksi antara objek-objek pada game ini seperti karakter dengan objek cash dan coin. Objek-objek tersebut memiliki behavior yang berebeda dari collision dengan benda
yang ada di map seperti rumah, pohon, batu, dll. 

### Mode

![](xxx)

Ada dua mode yang diimplementasikan pada game ini, yaitu:
* Battle Royale: Player saling bertarung hingga HP dari musuh mencapai 0. Permainan bersifat best of 5.
* Coin Collection: Player saling mengumpulkan coin selama 60 detik yang akan spawn secara random dalam map. Peraih koin terbanyak menjadi pemenangnya. Pada mode ini, pemain bisa saling menembak namun tidak bisa saling membunuh sehingga tembakan hanya digunakan sebagai distraksi.


## Library yang digunakan dan justifikasinya

* asset gold coin: tidak perlu membuat 3d asset dari awal


## Pembagian Kerja Anggota Kelompok
* 13518015 Arief Darmawan Tantriady
1. Main menu dan setting suara
2. Objek Cash
3. Pilihan-pilihan pada main menu
4. Object Pooler (script only), Test Multiplayer (branch multiplayer (not done)), Shop 

* 13518087 Radhinansyah Hemsa Ghaida
1. Desain map forest dan snow
2. Game mode Coin Collection

* 13518102 Muhammad Falah Sutanwindaya
1. Animasi saat bergerak
2. Dua jenis senjata
3. Collision

## About

Arief | Radhin | Falah
