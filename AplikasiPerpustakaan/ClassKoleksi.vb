Imports System.Text
Imports MySql.Data.MySqlClient

Public Class ClassKoleksi
    Private namaKoleksi As String
    Private dirGambarBuku
    Private deskripsiKoleksi As String
    Private penerbit As String
    Private jenisKoleksi As String
    Private tahunTerbit As Integer
    Private lokasi As String
    Private tanggalMasukKoleksi As Date
    Private stock As Integer
    Private bahasa As String
    Private kategori As New List(Of String)
    Private listKoleksi As New List(Of String)

    Private koleksiDataTable As New ArrayList()

    Public Shared dbConn As New MySqlConnection
    Public Shared sqlCommand As New MySqlCommand
    Public Shared sqlRead As MySqlDataReader
    Public Shared sqlQuery As String

    Private server As String = "localhost"
    Private username As String = "root"
    Private password As String = ""
    Private database As String = "db_perpustakaan"

    Public Function ConvertKoleksiToString(vals As List(Of String))
        Dim builder As StringBuilder = New StringBuilder()
        For Each val As String In vals
            builder.Append(val).Append("|")
        Next

        'Convert to string.
        Dim res = builder.ToString
        Return res
    End Function

    Public Function ConvertStringToKoleksi(value As String)
        Dim arr() As String = value.Split("|")

        'Convert to list.
        Dim vals As List(Of String) = arr.ToList()
        Return vals
    End Function

    Public Function AddKoleksiDataTable(dir_gambar As String,
                                        nama_koleksi As String,
                                        jenis_koleksi As String,
                                        penerbit_koleksi As String,
                                        deskripsi_koleksi As String,
                                        tahun_terbit As String,
                                        lokasi_rak As String,
                                        tanggal_masuk As String,
                                        stock_koleksi As Integer,
                                        bahasa_koleksi As String,
                                        kategori_koleksi As String)
        koleksiDataTable.Add({dir_gambar,
                             nama_koleksi,
                             jenis_koleksi,
                             penerbit_koleksi,
                             deskripsi_koleksi,
                             tahun_terbit,
                             lokasi_rak,
                             tanggal_masuk,
                             stock_koleksi,
                             bahasa_koleksi,
                             kategori_koleksi})
    End Function

    Public Function RemoveKoleksiDataTable(index As Integer)
        koleksiDataTable.RemoveAt(index)
    End Function

    Public ReadOnly Property getKoleksiDataTable() As ArrayList
        Get
            Return koleksiDataTable
        End Get
    End Property

    'setter getter
    Public Property GSNamaKoleksi() As String
        Get
            Return namaKoleksi
        End Get
        Set(ByVal value As String)
            namaKoleksi = value
        End Set
    End Property

    Public Property GSDirGambarBuku()
    Public Property GSDirGambarBuku() As String
        Get
            Return dirGambarBuku
        End Get
        Set(ByVal value)
        Set(ByVal value As String)
            dirGambarBuku = value
        End Set
    End Property

    Public Property GSDeskripsiKoleksi() As String
        Get
            Return deskripsiKoleksi
        End Get
        Set(ByVal value As String)
            deskripsiKoleksi = value
        End Set
    End Property

    Public Property GSPenerbit() As String
        Get
            Return penerbit
        End Get
        Set(ByVal value As String)
            penerbit = value
        End Set
    End Property

    Public Property GSJenisKoleksi() As String
        Get
            Return jenisKoleksi
        End Get
        Set(ByVal value As String)
            jenisKoleksi = value
        End Set
    End Property

    Public Property GSTahunTerbit() As Integer
        Get
            Return tahunTerbit
        End Get
        Set(ByVal value As Integer)
            tahunTerbit = value
        End Set
    End Property

    Public Property GSLokasi() As String
        Get
            Return lokasi
        End Get
        Set(ByVal value As String)
            lokasi = value
        End Set
    End Property

    Public Property GSTanggalMasukKoleksi() As Date
        Get
            Return tanggalMasukKoleksi
        End Get
        Set(ByVal value As Date)
            tanggalMasukKoleksi = value
        End Set
    End Property

    Public Property GSStock() As Integer
        Get
            Return stock
        End Get
        Set(ByVal value As Integer)
            stock = value
        End Set
    End Property

    Public Property GSBahasa() As String
        Get
            Return bahasa
        End Get
        Set(ByVal value As String)
            bahasa = value
        End Set
    End Property

    Public Property GSKategori()
        Get
            Return kategori
        End Get
        Set(ByVal value)
            kategori = value
        End Set
    End Property

    'kategori
    Public Function AddKategori(value As String)
        kategori.Add(value)
    End Function

    Public ReadOnly Property getKategoriItem() As List(Of String)
        Get
            Return kategori
        End Get
    End Property

    Public Function ResetKategori()
        kategori.Clear()
    End Function

    Public Property GSListKoleksi()
        Get
            Return listKoleksi
        End Get
        Set(ByVal value)
            listKoleksi = value
        End Set
    End Property

    'koleksi
    Public Function AddKoleksi(value As String)
        listKoleksi.Add(value)
    End Function

    Public Function RemoveKoleksi(value As String)
        listKoleksi.Remove(value)
    End Function

    Public ReadOnly Property getKoleksiItem() As List(Of String)
        Get
            Return listKoleksi
        End Get
    End Property
End Class
