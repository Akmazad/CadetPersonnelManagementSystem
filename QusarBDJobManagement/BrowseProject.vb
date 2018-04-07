Imports System.Data
Imports System.Data.OleDb



Public Class BrowseProject

    'global variables
    Dim constr As OleDbConnection
    Dim deleteID As Integer


    Public updateID As Integer

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub
    Private Sub DoSearch()
        Try
            constr = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\PersonelDB.mdb;User Id=admin;Password=;")
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand
            cmd.Connection = constr
            cmd.CommandType = CommandType.Text

            Dim whereClause As String = ""



            'check option
            If cmbSearchOption.SelectedItem.ToString() = "Name" Then
                cmd.CommandText = "Select * from tblPersonel where Name like '%" & Me.txtKeyword.Text & "%' order by Name;"

            ElseIf cmbSearchOption.SelectedItem.ToString() = "Batch" Then
                cmd.CommandText = "Select * from tblPersonel where Batch like '%" & Me.txtKeyword.Text & "%' order by Name;"

            ElseIf cmbSearchOption.SelectedItem.ToString() = "CadetID" Then
                cmd.CommandText = "Select * from tblPersonel where CadetNo like '%" & Me.txtKeyword.Text & "%' order by Name;"

            ElseIf cmbSearchOption.SelectedItem.ToString() = "Blood Group" Then
                cmd.CommandText = "Select * from tblPersonel where BG like '%" & Me.txtKeyword.Text & "%' order by Name;"

            ElseIf cmbSearchOption.SelectedItem.ToString() = "Occupation" Then
                cmd.CommandText = "Select * from tblPersonel where occupation like '%" & Me.txtKeyword.Text & "%' order by Name;"

            ElseIf cmbSearchOption.SelectedItem.ToString() = "Email" Then
                cmd.CommandText = "Select * from tblPersonel where Email like '%" & Me.txtKeyword.Text & "%' order by Name;"

            ElseIf cmbSearchOption.SelectedItem.ToString() = "CellNumber" Then
                cmd.CommandText = "Select * from tblPersonel where Cell like '%" & Me.txtKeyword.Text & "%' order by Name;"

            ElseIf cmbSearchOption.SelectedItem.ToString() = "Spouse Name" Then
                cmd.CommandText = "Select * from tblPersonel where SpouseName like '%" & Me.txtKeyword.Text & "%' order by Name;"
            End If



            constr.Open()
            Dim adapter As New OleDbDataAdapter
            adapter.SelectCommand = cmd
            Dim _DataTable As New DataTable
            adapter.Fill(_DataTable)

            If _DataTable.Rows.Count <> 0 Then
                Me.ListBox1.DataSource = _DataTable

                Me.ListBox1.DisplayMember = "Name"
                Me.ListBox1.ValueMember = "id"

            Else
                Me.ListBox1.DataSource = Nothing
                Me.ListBox1.Items.Clear()
                Me.ListBox1.Items.Add("             There's no Result to display")
                Me.ListBox1.ForeColor = Color.DarkRed

                'clear all
                ClearAll()

                Me.btnEdit.Enabled = False
                Me.btnUpdate.Enabled = False
            End If



            constr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKeyword.KeyPress
        If e.KeyChar = CType(ChrW(13), Char) Then
            DoSearch()
        End If
    End Sub

    Private Sub ListBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.Click

        Try
            ClearAll()
            If Me.ListBox1.Items(0).ToString() = "             There's no Result to display" Then

                'clear all
                ClearAll()

                'readonly all
                ReadOnlyAll()

                Me.btnEdit.Enabled = False
                Return
            End If
            'readonly all
            ReadOnlyAll()

            'enabling delete options
            Me.btnDelete.Enabled = True
            deleteID = Me.ListBox1.SelectedValue.ToString()


            Me.btnEdit.Enabled = True
            Me.btnUpdate.Enabled = False
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand
            cmd.Connection = constr
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Select * from tblpersonel where id = " & Me.ListBox1.SelectedValue.ToString()

            constr.Open()

            Dim reader As OleDbDataReader = cmd.ExecuteReader()

            While reader.Read
                Me.txtName.Text = reader.Item("Name").ToString()
                Me.txtBatchNo.Text = reader.Item("Batch").ToString()
                Me.txtCadetNo.Text = reader.Item("CadetNo").ToString()
                Me.txtDOB.Text = reader.Item("DOB").ToString()
                Me.cmbBG.SelectedItem = reader.Item("BG").ToString()
                Me.txtOccupation.Text = reader.Item("occupation").ToString()
                Me.txtOfficeAddress.Text = reader.Item("officeAddress").ToString()
                Me.txtPosition.Text = reader.Item("PositionOrDesignation").ToString()
                Me.txtHomePhone.Text = reader.Item("HomePhone").ToString()
                Me.txtOfficePhone.Text = reader.Item("OfficePhone").ToString()
                Me.txtEmail.Text = reader.Item("Email").ToString()
                Me.txtCellNumber.Text = reader.Item("Cell").ToString()
                Me.txtMailingAddress.Text = reader.Item("MailingAddress").ToString()
                Me.txtPermanentAddress.Text = reader.Item("PermanentAddress").ToString()
                Me.txtSpouseName.Text = reader.Item("SpouseName").ToString()
                Me.txtSpouseOccupation.Text = reader.Item("OccupationOfSpouse").ToString()
                Me.txtSpouseDOB.Text = reader.Item("SpouseDOB").ToString()
                Me.cmbSpouseBG.SelectedItem = reader.Item("SpouseBG").ToString()
                Me.txtMarriageDate.Text = reader.Item("MarriageDate").ToString()
                Me.txtEmergencyContact.Text = reader.Item("EmergencyContact").ToString()
                Me.txtChildreninfo.Text = reader.Item("ChildrenInfo").ToString()

                updateID = CType(Me.ListBox1.SelectedValue.ToString(), Integer)

            End While
            constr.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Me.txtName.ReadOnly = False
        Me.txtBatchNo.ReadOnly = False
        Me.txtCadetNo.ReadOnly = False
        Me.txtDOB.ReadOnly = False
        Me.cmbBG.Enabled = True
        Me.txtOccupation.ReadOnly = False
        Me.txtOfficeAddress.ReadOnly = False
        Me.txtPosition.ReadOnly = False
        Me.txtHomePhone.ReadOnly = False
        Me.txtOfficePhone.ReadOnly = False
        Me.txtEmail.ReadOnly = False
        Me.txtCellNumber.ReadOnly = False
        Me.txtMailingAddress.ReadOnly = False
        Me.txtPermanentAddress.ReadOnly = False
        Me.txtSpouseName.ReadOnly = False
        Me.txtSpouseOccupation.ReadOnly = False
        Me.txtSpouseDOB.ReadOnly = False
        Me.cmbSpouseBG.Enabled = True
        Me.txtMarriageDate.ReadOnly = False
        Me.txtEmergencyContact.ReadOnly = False
        Me.txtChildreninfo.ReadOnly = False


        Me.btnUpdate.Enabled = True
        Me.btnEdit.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnUpdate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Dim ans As String = CStr(MsgBox("Do You really wanna Update this record?", MsgBoxStyle.YesNo, "Ready to Update Files?"))

        If CDbl(ans) = vbYes Then
            Try
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand
                cmd.Connection = constr
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Update tblpersonel set Name = '" & Me.txtName.Text & "', Batch = '" & Me.txtBatchNo.Text & "', CadetNo = '" & Me.txtCadetNo.Text & "', DOB = '" & Me.txtDOB.Text & "', BG = '" & Me.cmbBG.Text & "', occupation ='" & Me.txtOccupation.Text & "', officeAddress ='" & Me.txtOfficeAddress.Text & "', PositionOrDesignation ='" & Me.txtPosition.Text & "', HomePhone ='" & Me.txtHomePhone.Text & "', OfficePhone ='" & Me.txtOfficePhone.Text & "', Email ='" & Me.txtEmail.Text & "', Cell ='" & Me.txtCellNumber.Text & "', MailingAddress ='" & Me.txtMailingAddress.Text & "', PermanentAddress ='" & Me.txtPermanentAddress.Text & "', SpouseName ='" & Me.txtSpouseName.Text & "', OccupationOfSpouse ='" & Me.txtSpouseOccupation.Text & "', SpouseDOB ='" & Me.txtSpouseDOB.Text & "', SpouseBG ='" & Me.cmbSpouseBG.Text & "', MarriageDate ='" & Me.txtMarriageDate.Text & "', EmergencyContact ='" & Me.txtEmergencyContact.Text & "', ChildrenInfo ='" & Me.txtChildreninfo.Text & "' where id = " & updateID & ";"

                constr.Open()
                cmd.ExecuteNonQuery()
                constr.Close()


                'readonly all
                ReadOnlyAll()

                Me.btnEdit.Enabled = True
                Me.btnUpdate.Enabled = False

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim ans As String = CStr(MsgBox("Do You really wanna Delete this record?", MsgBoxStyle.YesNo, "Ready to Delete Files?"))

        If CDbl(ans) = vbYes Then
            Try
                ListBox1.DataSource = Nothing
                ListBox1.Items.Clear()
                'delete from table
                Dim cmd As OleDbCommand
                cmd = New OleDbCommand
                cmd.Connection = constr
                cmd.CommandType = CommandType.Text
                cmd.CommandText = "Delete from tblPersonel where id = " & deleteID

                constr.Open()
                cmd.ExecuteNonQuery()
                constr.Close()

                'get again

                cmd = New OleDbCommand
                cmd.Connection = constr
                cmd.CommandType = CommandType.Text

                Dim whereClause As String = ""

                If cmbSearchOption.SelectedItem.ToString() = "Name" Then
                    cmd.CommandText = "Select * from tblPersonel where Name like '%" & Me.txtKeyword.Text & "%';"

                ElseIf cmbSearchOption.SelectedItem.ToString() = "Batch" Then
                    cmd.CommandText = "Select * from tblPersonel where Batch like '%" & Me.txtKeyword.Text & "%' order by Name;"

                ElseIf cmbSearchOption.SelectedItem.ToString() = "CadetID" Then
                    cmd.CommandText = "Select * from tblPersonel where CadetNo like '%" & Me.txtKeyword.Text & "%' order by Name;"

                ElseIf cmbSearchOption.SelectedItem.ToString() = "Blood Group" Then
                    cmd.CommandText = "Select * from tblPersonel where BG like '%" & Me.txtKeyword.Text & "%';"

                ElseIf cmbSearchOption.SelectedItem.ToString() = "Occupation" Then
                    cmd.CommandText = "Select * from tblPersonel where occupation like '%" & Me.txtKeyword.Text & "%';"

                ElseIf cmbSearchOption.SelectedItem.ToString() = "Email" Then
                    cmd.CommandText = "Select * from tblPersonel where Email like '%" & Me.txtKeyword.Text & "%';"

                ElseIf cmbSearchOption.SelectedItem.ToString() = "CellNumber" Then
                    cmd.CommandText = "Select * from tblPersonel where Cell like '%" & Me.txtKeyword.Text & "%';"

                ElseIf cmbSearchOption.SelectedItem.ToString() = "Spouse Name" Then
                    cmd.CommandText = "Select * from tblPersonel where SpouseName like '%" & Me.txtKeyword.Text & "%';"
                End If


                constr.Open()

                Dim adapter As New OleDbDataAdapter
                adapter.SelectCommand = cmd
                Dim _DataTable As New DataTable
                adapter.Fill(_DataTable)

                If _DataTable.Rows.Count <> 0 Then

                    Me.ListBox1.DataSource = _DataTable

                    Me.ListBox1.DisplayMember = "Name"
                    Me.ListBox1.ValueMember = "id"

                    'reset
                    ClearAll()
                    Me.btnEdit.Enabled = False
                    Me.btnDelete.Enabled = False
                    Me.btnUpdate.Enabled = False
                Else
                    Me.ListBox1.DataSource = Nothing
                    Me.ListBox1.Items.Clear()
                    Me.ListBox1.Items.Add("             There's no Result to display")
                    Me.ListBox1.ForeColor = Color.DarkRed

                    ClearAll()

                    Me.btnDelete.Enabled = False
                    Me.btnEdit.Enabled = False
                    Me.btnUpdate.Enabled = False
                End If


                constr.Close()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        
    End Sub

    Public Sub ClearAll()
        'clear all
        Me.txtName.Text = ""
        Me.txtBatchNo.Text = ""
        Me.txtCadetNo.Text = ""
        Me.txtDOB.Text = ""
        Me.cmbBG.SelectedIndex = -1

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
        Me.cmbSpouseBG.SelectedIndex = -1

        Me.txtMarriageDate.Text = ""
        Me.txtEmergencyContact.Text = ""
        Me.txtChildreninfo.Text = ""
    End Sub

    Public Sub ReadOnlyAll()
        Me.txtName.ReadOnly = True
        Me.txtBatchNo.ReadOnly = True
        Me.txtCadetNo.ReadOnly = True
        Me.txtDOB.ReadOnly = True
        Me.cmbBG.Enabled = False
        Me.txtOccupation.ReadOnly = True
        Me.txtOfficeAddress.ReadOnly = True
        Me.txtPosition.ReadOnly = True
        Me.txtHomePhone.ReadOnly = True
        Me.txtOfficePhone.ReadOnly = True
        Me.txtEmail.ReadOnly = True
        Me.txtCellNumber.ReadOnly = True
        Me.txtMailingAddress.ReadOnly = True
        Me.txtPermanentAddress.ReadOnly = True
        Me.txtSpouseName.ReadOnly = True
        Me.txtSpouseOccupation.ReadOnly = True
        Me.txtSpouseDOB.ReadOnly = True
        Me.cmbSpouseBG.Enabled = False
        Me.txtMarriageDate.ReadOnly = True
        Me.txtEmergencyContact.ReadOnly = True
        Me.txtChildreninfo.ReadOnly = True
    End Sub

    Private Sub BrowseProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbSearchOption.Text = cmbSearchOption.Items(0).ToString()

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        DoSearch()
    End Sub
End Class