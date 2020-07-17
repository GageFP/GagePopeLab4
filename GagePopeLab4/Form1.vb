' NETD2202 - Lab 4
' Gage Pope - 100774956
' July 17, 2020
' Description: Windows form application that takes 5 user inputs between textboxes, comboboxes, and a checkbox. Validates all inputs, outputs proper error messages if any occur.
'              Displays all valid inputs in a listview with proper columns for the information.
Option Strict On

Public Class frmCar
#Region "Variables, Constants, and Arrays"
    Dim selectedIndex As Integer = -1
    Dim editInput As Boolean = False
    Dim dataUpdate As Boolean = False
    Dim errorMessage As String = ""
    Dim cars As New List(Of CarClass)
    Private Const MIN_PRICE As Integer = 0
#End Region

#Region "Functions and Subprocedures"

    ''' <summary>
    ''' subroutine to reset the form to default state
    ''' </summary>
    Sub ResetForm()
        cmbMake.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        txtModel.Text = ""
        txtPrice.Text = ""
        lblResults.Text = ""
        chbNew.Checked = False
        ltvOutput.SelectedIndices.Clear()
    End Sub

    ''' <summary>
    ''' function to validate all inputs at once and create error message if any occur
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <returns></returns>
    Function ValidateInputs(make As String, model As String, year As String, price As String) As Boolean
        ' create variable to check price tryparse
        Dim priceNum As Decimal
        ' clear errorMessage variable before checking for errors
        errorMessage = ""

        ' if make is empty create error message
        If String.IsNullOrWhiteSpace(make) Then
            errorMessage += "A make must be selected from the dropdown list." & Environment.NewLine
        End If

        ' if model is empty or white space create error message
        If String.IsNullOrWhiteSpace(model) Then
            errorMessage += "Please enter a valid model." & Environment.NewLine
        End If

        ' if year is empty create error message
        If String.IsNullOrWhiteSpace(year) Then
            errorMessage += "A year must be selected from the dropdown list." & Environment.NewLine
        End If

        ' if price is empty create error message
        ' if price is not numeric create error message
        ' if price is less than 0 create error message
        If String.IsNullOrWhiteSpace(price) Then
            errorMessage += "Please enter a price" & Environment.NewLine
        ElseIf Decimal.TryParse(price, priceNum) = False Then
            errorMessage += "The price must be numeric."
        ElseIf priceNum < MIN_PRICE Then
            errorMessage += "The price must be equal to or greater than " & MIN_PRICE & Environment.NewLine
        End If

        ' if errorMessage is empty return true otherwise return false
        If String.IsNullOrWhiteSpace(errorMessage) Then
            Return True
        Else
            Return False
        End If
    End Function

    ''' <summary>
    ''' subroutine to update the listview when new inputs are entered or existing inputs are editted
    ''' </summary>
    Private Sub UpdateListview()
        Dim carList As ListViewItem

        ' make dataUpdate true so checkboxes can be altered if needed and clear listview
        dataUpdate = True
        ltvOutput.Items.Clear()

        ' recreate listview with existing inputs to update any editted inputs
        For Each car As CarClass In cars
            carList = New ListViewItem()

            carList.Checked = car.CarNew
            carList.SubItems.Add(car.CarId.ToString)
            carList.SubItems.Add(car.CarMake)
            carList.SubItems.Add(car.CarModel)
            carList.SubItems.Add(car.CarYear)
            carList.SubItems.Add(car.CarPrice)

            ltvOutput.Items.Add(carList)
        Next
        ' make dataUpdate false again so checkboxes cant be altered by user
        dataUpdate = False
    End Sub

#End Region

#Region "Event Handlers"

    ''' <summary>
    ''' exits the application when exit button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ''' <summary>
    ''' calls the reset function when reset button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetForm()
    End Sub

    ''' <summary>
    ''' handles the validation, errors if any, and outputs when the enter button is clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim make As String = cmbMake.Text
        Dim model As String = txtModel.Text
        Dim year As String = cmbYear.Text
        Dim price As String = txtPrice.Text
        Dim isNew As Boolean = chbNew.Checked
        Dim car As CarClass

        If ValidateInputs(make, model, year, price) = False Then
            ' if ValidateInputs returns false then display errorMessaage in lblResults
            lblResults.Text = errorMessage
        Else
            ' if ValidateInputs returns true continue with entering input into listview
            If editInput Then
                ' if editInput is true then update the selected listview index with new information
                cars(selectedIndex).CarMake = make
                cars(selectedIndex).CarModel = model
                cars(selectedIndex).CarYear = year
                cars(selectedIndex).CarPrice = price
                cars(selectedIndex).CarNew = isNew

                ' update the listview and call reset sub
                UpdateListview()
                ResetForm()

                ' inform user input edit was successful
                lblResults.Text = "It worked!"
            Else
                ' if editInput is false then add a new entry into the listview
                car = New CarClass(make, model, year, price, isNew)
                cars.Add(car)
                ' call reset sub
                ResetForm()

                ' inform user input was successful
                lblResults.Text = "It worked!"

                ' update the listview
                UpdateListview()
            End If
        End If
    End Sub

    ''' <summary>
    ''' handles the user selecting one of the inputs in the listview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ltvOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ltvOutput.SelectedIndexChanged
        ' if an item in the listview is selected populate the data into the input fields and turn editInput to true so the user can edit
        If Not ltvOutput.FocusedItem Is Nothing Then
            selectedIndex = ltvOutput.FocusedItem.Index
            Dim car As CarClass = cars(selectedIndex)

            editInput = True

            cmbMake.Text = car.CarMake
            txtModel.Text = car.CarModel
            cmbYear.Text = car.CarYear
            txtPrice.Text = car.CarPrice
            chbNew.Checked = car.CarNew

            lblResults.Text = "editting selected data."
        End If
    End Sub

    ''' <summary>
    ''' prevennts the user from changing the checkbox in listview
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ltvOutput_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ltvOutput.ItemCheck
        If dataUpdate = False Then
            e.NewValue = e.CurrentValue
        End If
    End Sub

#End Region

End Class
