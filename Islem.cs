using System;

public class Islem
{
    public int Id { get; set; }
    public string Tanim { get; set; } = string.Empty;
    public decimal Miktar { get; set; }
    public string Tur { get; set; } = "Gider"; 
    public string Kategori { get; set; } = "Genel";
    public DateTime Tarih { get; set; } = DateTime.Now;
}