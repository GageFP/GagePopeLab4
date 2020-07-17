<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.chbNew = New System.Windows.Forms.CheckBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ltvOutput = New System.Windows.Forms.ListView()
        Me.chdNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chdPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ttpMain = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Location = New System.Drawing.Point(54, 4)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(39, 23)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Acura", "Alfa-Romeo", "Aston-Martin", "Audi", "Bently", "BMW", "Bugatti", "Buick", "Cadillac", "Chevrolet", "Chrysler", "Citroen", "Dodge", "Ferrari", "Fiat", "Ford", "Geely", "Genesis", "GMC", "Honda", "Hyundai", "Infiniti", "Jaguar", "Jeep", "Kia", "Lamborghini", "Lancia", "Land Rover", "Lexus", "Lincoln", "Lotus", "Maserati", "Maybach", "Mazda", "Mclaren", "Mercedes", "Mini", "Mitsubishi", "Nissan", "Opel", "Pagani", "Peugeot", "Pontiac", "Porsche", "Ram", "Renault", "Rolls-Royce", "Skoda", "Smart", "Subaru", "Suzuki", "Tesla", "Toyota", "Volkswagen", "Volvo"})
        Me.cmbMake.Location = New System.Drawing.Point(99, 6)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(106, 21)
        Me.cmbMake.TabIndex = 1
        Me.ttpMain.SetToolTip(Me.cmbMake, "Select make of the car from the dropdown list.")
        '
        'chbNew
        '
        Me.chbNew.AutoSize = True
        Me.chbNew.Location = New System.Drawing.Point(99, 116)
        Me.chbNew.Name = "chbNew"
        Me.chbNew.Size = New System.Drawing.Size(15, 14)
        Me.chbNew.TabIndex = 9
        Me.ttpMain.SetToolTip(Me.chbNew, "Select if the car is new or not.")
        Me.chbNew.UseVisualStyleBackColor = True
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(99, 34)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(106, 20)
        Me.txtModel.TabIndex = 3
        Me.ttpMain.SetToolTip(Me.txtModel, "Enter the model of the car.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(21, 409)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(93, 31)
        Me.btnEnter.TabIndex = 12
        Me.btnEnter.Text = "&Enter"
        Me.ttpMain.SetToolTip(Me.btnEnter, "Confirms the inputs.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'lblResults
        '
        Me.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResults.Location = New System.Drawing.Point(7, 337)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(392, 69)
        Me.lblResults.TabIndex = 11
        Me.ttpMain.SetToolTip(Me.lblResults, "Displays if the input was successful and which, if any, errors have occured.")
        '
        'lblModel
        '
        Me.lblModel.Location = New System.Drawing.Point(54, 37)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(39, 13)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.Location = New System.Drawing.Point(54, 65)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(39, 13)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Location = New System.Drawing.Point(54, 93)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(39, 13)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNew
        '
        Me.lblNew.Location = New System.Drawing.Point(54, 116)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(39, 13)
        Me.lblNew.TabIndex = 8
        Me.lblNew.Text = "&New:"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.cmbYear.Location = New System.Drawing.Point(99, 62)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(106, 21)
        Me.cmbYear.TabIndex = 5
        Me.ttpMain.SetToolTip(Me.cmbYear, "Select year the car was made.")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(99, 90)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(106, 20)
        Me.txtPrice.TabIndex = 7
        Me.ttpMain.SetToolTip(Me.txtPrice, "Enter price of the car.")
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(157, 409)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(93, 31)
        Me.btnReset.TabIndex = 13
        Me.btnReset.Text = "&Reset"
        Me.ttpMain.SetToolTip(Me.btnReset, "Reset form back to default state.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(293, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(93, 31)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.ttpMain.SetToolTip(Me.btnExit, "Exit the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ltvOutput
        '
        Me.ltvOutput.CheckBoxes = True
        Me.ltvOutput.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chdNew, Me.chdID, Me.chdMake, Me.chdModel, Me.chdYear, Me.chdPrice})
        Me.ltvOutput.FullRowSelect = True
        Me.ltvOutput.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ltvOutput.HideSelection = False
        Me.ltvOutput.Location = New System.Drawing.Point(7, 136)
        Me.ltvOutput.MultiSelect = False
        Me.ltvOutput.Name = "ltvOutput"
        Me.ltvOutput.Size = New System.Drawing.Size(392, 198)
        Me.ltvOutput.TabIndex = 10
        Me.ttpMain.SetToolTip(Me.ltvOutput, "Displays all previously entered cars.")
        Me.ltvOutput.UseCompatibleStateImageBehavior = False
        Me.ltvOutput.View = System.Windows.Forms.View.Details
        '
        'chdNew
        '
        Me.chdNew.Text = "New"
        Me.chdNew.Width = 40
        '
        'chdID
        '
        Me.chdID.Text = "ID"
        Me.chdID.Width = 30
        '
        'chdMake
        '
        Me.chdMake.Text = "Make"
        Me.chdMake.Width = 90
        '
        'chdModel
        '
        Me.chdModel.Text = "Model"
        Me.chdModel.Width = 90
        '
        'chdYear
        '
        Me.chdYear.Text = "Year"
        Me.chdYear.Width = 48
        '
        'chdPrice
        '
        Me.chdPrice.Text = "Price"
        Me.chdPrice.Width = 90
        '
        'frmCar
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(407, 450)
        Me.Controls.Add(Me.ltvOutput)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.chbNew)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents cmbMake As ComboBox
    Friend WithEvents chbNew As CheckBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents lblResults As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ltvOutput As ListView
    Friend WithEvents chdNew As ColumnHeader
    Friend WithEvents chdID As ColumnHeader
    Friend WithEvents chdMake As ColumnHeader
    Friend WithEvents chdModel As ColumnHeader
    Friend WithEvents chdYear As ColumnHeader
    Friend WithEvents chdPrice As ColumnHeader
    Friend WithEvents ttpMain As ToolTip
End Class
