//fungsi dari class ini adalah untuk masukan data(set) dan mengambil data(get)

class karyawan {
  //deklarasi variabel
  var _name; 
  var _harga;
  var _jumlah; //variabel global untukclass
  var _totalharga;
  String getName() {
    return this._name;
  }

  void setName(String nama) {
    this._nama = nama;
  }

  int getharga() {
    return this._address;
  }

  void setHarga(String address) {
    this._harga = harga;
  }

  int getjumlah() {
    return this._jumlah;
  }

  void setjumlah(int _jumlah) {
    this._jumlah = _jumlah;
  }

  void settotal(int _totalharga) {
    _totalharga = _harga * _jumlah;
    this._totalharga = _totalharga;
  }

  int gettotal() {
    return this. _totalharga;
  }
}

// fungsi main
main() {
 var _jumlah;
 var barang = new Person();
 _jumlah = 20;
 barang.setName("Buku");
 barang.setHarga(5000);
 barang.setjumlah(_jumlah);
 barang.settotal(20000);

 print("Nama: ${barang.getNama()}");
 print("harga: ${barang.getHarga()}");
 print("jumlah: ${barang.getjumlah()}");
 print("TotalBarang: ${barang.gettotal()}");

//Nama : Dian
//Alamat: Lombok
//Alamat Email :..
//Berapa Kali Pembayaran :...
//umur:30
//Pembayaran: 120000