Public Class CarClass
#Region "Properties"
    Private make As String = ""
    Private model As String = ""
    Private year As Integer = 0
    Private price As Decimal = 0
    Private newStatus As Boolean = False
    Private identificationNumber As Integer = 0
    Shared count As Integer = 0
#End Region

#Region "Property Methods"
    Public Property CarMake() As String
        Get
            Return make
        End Get
        Set(value As String)
            make = value
        End Set
    End Property

    Public Property CarModel() As String
        Get
            Return model
        End Get
        Set(value As String)
            model = value
        End Set
    End Property

    Public Property CarYear() As String
        Get
            Return year
        End Get
        Set(value As String)
            year = value
        End Set
    End Property

    Public Property CarPrice() As String
        Get
            Return price
        End Get
        Set(value As String)
            price = value
        End Set
    End Property

    Public Property CarNew() As Boolean
        Get
            Return newStatus
        End Get
        Set(value As Boolean)
            newStatus = value
        End Set
    End Property

    Public ReadOnly Property CarId() As Integer
        Get
            Return identificationNumber
        End Get
    End Property

    Public ReadOnly Property CarCount() As Integer
        Get
            Return count
        End Get
    End Property
#End Region

#Region "Constructors"

    Public Sub New()
        count += 1
        identificationNumber = count
    End Sub

    Public Sub New(make As String, model As String, year As String, price As String, newStatus As Boolean)
        count += 1
        identificationNumber = count
        Me.CarMake = make
        Me.CarModel = model
        Me.CarYear = year
        Me.CarPrice = price
        Me.CarNew = newStatus
    End Sub
#End Region

#Region "Methods"
    Function GetCarData() As String
        Return "-Car information-" & Environment.NewLine &
            "Make: " & Me.CarMake & Environment.NewLine &
            "Model: " & Me.CarModel & Environment.NewLine &
            "Year: " & Me.CarYear & Environment.NewLine &
            "Price: " & Me.CarPrice & Environment.NewLine &
            "New: " & Me.CarNew & Environment.NewLine
    End Function
#End Region
End Class