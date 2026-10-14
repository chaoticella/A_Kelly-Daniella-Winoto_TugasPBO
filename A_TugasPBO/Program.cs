class Orang
{
    public string nama;
    public int umur;

    public Orang(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }

    public virtual void Aktivitas()
    {
        Console.WriteLine($"Orang-orang sedang melakukan aktivitas");
    }

    public virtual void InfoOrang()
    {
        Console.WriteLine($"Nama: {nama}, Umur: {umur}");
    }
}

class Pasien : Orang
{
    string keluhan;
    public Pasien(string nama, int umur, string keluhan) : base(nama, umur)
    {
        this.keluhan = keluhan;
    }

    public void CekKeluhan()
    {
        Console.WriteLine($"- Pasien {nama} sedang mengalami {keluhan}");
    }

    public override void Aktivitas()
    {
        Console.WriteLine($"- Pasien dengan nama {nama} sedang melakukan pemeriksaan di Rumah Sakit");
    }
}

class TenagaMedis : Orang
{
    public string spesialisasi;
    public TenagaMedis(string nama, int umur, string spesialisasi) : base(nama, umur)
    {
        this.spesialisasi = spesialisasi;
    }

    public void CekSpesialis()
    {
        Console.WriteLine($"- Tenaga medis {nama} memiliki spesialisasi {spesialisasi}");
    }

    public override void Aktivitas()
    {
        Console.WriteLine($"- Tenaga-tenaga medis {nama} sedang beraktivitas");
    }
}

class Dokter : TenagaMedis
{
    public Dokter(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi)
    {
    }

    public void Diagnosa()
    {
        Console.WriteLine($"- Dokter {nama} sedang mendiagnosa pasien");
    }

    public override void Aktivitas()
    {
        Console.WriteLine($"- Dokter {nama} sedang memeriksa pasien.");
    }
}

class Perawat :TenagaMedis 
{
    public Perawat(string nama, int umur, string spesialisasi) : base(nama, umur, spesialisasi)
    {
    }
    public void CekPasien()
    {
        Console.WriteLine($"- Perawat {nama} sedang memeriksa pasien");
    }

    public override void Aktivitas()
    {
        Console.WriteLine($"- Perawat {nama} sedang membantu dokter memeriksa pasien.");
    }
}

class Pasienanak : Pasien
{
    public Pasienanak(string nama, int umur, string keluhan) : base(nama, umur, keluhan)
    {
    }
    public void Menangis()
    {
        Console.WriteLine($"- Pasien anak dengan nama {nama} sedang menangis, bunyinya 'oek oek'");
    }

    public override void Aktivitas()
    {
        Console.WriteLine($"- Pasien anak dengan nama {nama} sedang diperiksa oleh dokter.");
    }
}

class PasienDewasa : Pasien
{
    public PasienDewasa(string nama, int umur, string keluhan) : base(nama, umur, keluhan)
    {
    }
    public void Konsultasi()
    {
        Console.WriteLine($"- Pasien dewasa dengan nama {nama} sedang berkonsultasi dengan dokter spesialis.");
    }
    public override void Aktivitas()
    {
        Console.WriteLine($"- Pasien dewasa dengan nama {nama} sedang berbincang dengan dokter.");
    }
}

class RumahSakit
{
    public List<Orang> daftarOrang = new List<Orang>();

    public void TambahOrang(Orang orang)
    {
        daftarOrang.Add(orang);
    }

    public void DaftarOrang()
    {
        foreach (var orang in daftarOrang)
        {
            orang.InfoOrang();
        }
    }
}
class Program
{
    private static void Main(string[] args)
    {
        Pasienanak pasien1 = new Pasienanak("Ucup", 11, "Demam");
        PasienDewasa pasien2 = new PasienDewasa("Fira", 35, "Sakit kepala");
        Dokter dokter = new Dokter("Dr. Emma", 49, "Dokter Umum");
        Perawat nurse = new Perawat("Audrey", 30, "Umum");

        RumahSakit rumahsakit = new RumahSakit();

        rumahsakit.TambahOrang(pasien1);
        rumahsakit.TambahOrang(pasien2);
        rumahsakit.TambahOrang(dokter);
        rumahsakit.TambahOrang(nurse);

        rumahsakit.DaftarOrang();

        pasien1.Aktivitas();
        dokter.Aktivitas();
        dokter.Diagnosa();
        dokter.InfoDokter();
        pasien1.Menangis();
        nurse.Aktivitas();
    }
}
