/*
 * SENERYO: 
 * BİR AÇIK DÜNYA VASITA SÜRME SİMÜLASYON OYUNU TASARLANACAK
 * BU OYUNDA OYUNCULAR OLACAK
 * OYUNCULARIN OYUNDA SÜREBİLMEK İÇİN BAZI VASITALARI OLACAK
 * BU VASITALARIN ARABA, TIR, MOTORSİKLET, UÇAK, HELİKOPTER, GEMİ GİBİ TÜREVLERİ OLACAK
 * EĞER VASITA TIR GİBİ YÜK TAŞIYABİLİYORSA YÜK TAŞIMA YETENEĞİ OLACAK
 * OYUNCU VASITAYI HARAKET ETTİRİP DURDURACAK
 */

using Task3OOP;

Player player = new Player("Alperen");

Scania scania = new Scania("Siyah");
player.PlayerVehicle = scania;
player.CarryLoad();
player.Move();
player.Move();
player.Stop();

Volkswagen volkswagen = new Volkswagen();
player.PlayerVehicle = volkswagen;
player.CarryLoad();
player.Move();
player.Stop();
player.Stop();