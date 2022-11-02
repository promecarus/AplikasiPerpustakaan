Public Class ClassKoleksi
    Private namaKoleksi As String
    Private jenisKoleksi As String
    Private deskripsi As String
    Private penerbit As String
    Private tahunTerbit As Integer
    Private lokasiRak As String
    Private tanggalMasukKoleksi As Date
    Private stock As Integer
    Private bahasa As String
    Private kategoriList As New List(Of String)
    Private gambarKoleksi

    Public Property GSNamaKoleksi() As String
        Get
            Return namaKoleksi
        End Get
        Set(ByVal value As String)
            namaKoleksi = value
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

    Public Property GSDeskripsi() As String
        Get
            Return deskripsi
        End Get
        Set(ByVal value As String)
            deskripsi = value
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

    Public Property GSTahunTerbit() As Integer
        Get
            Return tahunTerbit
        End Get
        Set(ByVal value As Integer)
            tahunTerbit = value
        End Set
    End Property

    Public Property GSLokasiRak() As String
        Get
            Return lokasiRak
        End Get
        Set(ByVal value As String)
            lokasiRak = value
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

    Public Property GSKategoriList()
        Get
            Return kategoriList
        End Get
        Set(ByVal value)
            kategoriList = value
        End Set
    End Property

    Public Property GSGambarKoleksi()
        Get
            Return gambarKoleksi
        End Get
        Set(ByVal value)
            gambarKoleksi = value
        End Set
    End Property
End Class
