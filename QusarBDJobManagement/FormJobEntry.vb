Imports System.Data
Imports System.Data.OleDb

Public Class FormJobEntry
    Dim connectionString As OleDbConnection

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        connectionString = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\PersonelDB.mdb;User Id=admin;Password=;")

        Dim cmd As OleDbCommand
        cmd = New OleDbCommand

        With cmd
            .Connection = connectionString
            .CommandType = CommandType.Text
            .CommandText = "insert into tblPersonel (Name ,Batch, CadetNo,  DOB , BG , occupation , officeAddress , PositionOrDesignation , HomePhone , OfficePhone , Email , Cell , MailingAddress , PermanentAddress , SpouseName , OccupationOfSpouse , SpouseDOB ,SpouseBG , MarriageDate ,EmergencyContact ,ChildrenInfo ) values ('" & Me.txtName.Text & "', '" & Me.txtBatchNo.Text & "', '" & Me.txtCadetNo.Text & "', '" & Me.txtDOB.Text & "', '" & Me.cmbBG.Text & "', '" & Me.txtOccupation.Text & "', '" & Me.txtOfficeAddress.Text & "', '" & Me.txtPosition.Text & "', '" & Me.txtHomePhone.Text & "', '" & Me.txtOfficePhone.Text & "', '" & Me.txtEmail.Text & "', '" & Me.txtCellNumber.Text & "', '" & Me.txtMailingAddress.Text & "', '" & Me.txtPermanentAddress.Text & "', '" & Me.txtSpouseName.Text & "', '" & Me.txtSpouseOccupation.Text & "', '" & Me.txtSpouseDOB.Text & "', '" & Me.cmbSpouseBG.Text & "', '" & Me.txtMarriageDate.Text & "', '" & Me.txtEmergencyContact.Text & "', '" & Me.txtChildreninfo.Text & "')"

        End With
        connectionString.Open()
        cmd.ExecuteNonQuery()
        connectionString.Close()



        'clear all
        Me.txtName.Text = ""
        Me.txtBatchNo.Text = ""
        Me.txtCadetNo.Text = ""
        Me.txtDOB.Text = ""
        Me.cmbBG.SelectedItem = Nothing
        Me.txtOccupation.Text = ""
        Me.txtOfficeAddress.Text = ""
        Me.txtPosition.Text = ""
        Me.txtHomePhone.Text = ""
        Me.txtOfficePhone.Text = ""
        Me.txtEmail.Text = ""
        Me.txtCellNumber.Text = ""
        Me.txtMailingAddress.Text = ""
        Me.txtPermanentAddress.Text = ""
        Me.txtSpouseName.Text = ""
        Me.txtSpouseOccupation.Text = ""
        Me.txtSpouseDOB.Text = ""
        Me.cmbSpouseBG.SelectedItem = Nothing
        Me.txtMarriageDate.Text = ""
        Me.txtEmergencyContact.Text = ""
        Me.txtChildreninfo.Text = ""


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
End Class