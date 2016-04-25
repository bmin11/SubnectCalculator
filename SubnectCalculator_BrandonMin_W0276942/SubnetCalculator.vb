Option Strict On

'Imports all functions from Functions.vb
Imports SubnetCalculatorClassLibrary_BrandonMin_W0276942
Imports System.IO
Imports System.Data

''' <summary>
''' Calculator for subnetting the network
''' Calculates and displays all subnetting informations
''' 
''' Name: Brandon Min
''' Date: 2014/12/11
''' </summary>
''' <remarks>PROG 1101 Final Assignment</remarks>
Public Class SubnetCalculator
    Dim decimalInput As String
    Dim numberOfHostsPerSubnet As Integer
    Dim subnetSize As Integer
    Dim decimalOctets As String = String.Empty
    Dim decimalAddress As Long
    Dim binaryOctets As String = String.Empty
    Dim hexOctets As String = String.Empty
    Dim networkClass As Char = String.Empty
    Dim numberOfAddresses As Integer
    Dim subnetMask As String = String.Empty
    Dim subnetMaskBinary As String = String.Empty
    Dim numberOfSubnets As Integer

    'All address ranges are stored here
    Dim addresses() As String
    'All variables are stored here after the calculation
    Dim dataArray() As String
    'All textboxes in the form are stored here
    Dim textboxArray() As TextBox

    ''' <summary>
    ''' Loads all textboxes into an array upon opening the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SubnetCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTextboxArray()
    End Sub

    ''' <summary>
    ''' Calculates all subnetting information and calls a sub to update all information for display
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub calculateAndUpdate()
        If validateInput(TextBoxNetworkAddress.Text, TextBoxHostPerSubnet.Text) Then
            decimalInput = TextBoxNetworkAddress.Text
            numberOfHostsPerSubnet = Convert.ToInt32(TextBoxHostPerSubnet.Text)
            subnetSize = CalculateSubnetSize(numberOfHostsPerSubnet)
            decimalOctets = CalculateDecimalOctets(TextBoxNetworkAddress.Text)
            decimalAddress = CalculateDecimalAddress(decimalOctets)
            binaryOctets = CalculateBinaryAddress(decimalOctets)
            hexOctets = CalculateHexAddress(decimalOctets)
            networkClass = CalculateNetworkClass(decimalOctets)
            numberOfAddresses = CalculateNumberOfIPAddresses(decimalOctets)
            subnetMask = CalculateSubnetMask(numberOfHostsPerSubnet)
            subnetMaskBinary = CalculateBinaryMask(numberOfHostsPerSubnet)
            numberOfSubnets = CalculateNumberOfSubnets(decimalOctets, numberOfHostsPerSubnet)
            addresses = CalculateSubnetList(decimalOctets, numberOfHostsPerSubnet)

            updateDataArray()
            updateTextboxArray()

            updateDisplay()
        Else
            clearAll()
        End If
    End Sub

    ''' <summary>
    ''' Updates the array with subnetting datas
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updateDataArray()
        dataArray = {decimalInput,
                    numberOfHostsPerSubnet.ToString,
                    subnetSize.ToString,
                    decimalOctets,
                    decimalAddress.ToString,
                    binaryOctets,
                    hexOctets,
                    networkClass,
                    numberOfAddresses.ToString,
                    subnetMask,
                    subnetMaskBinary,
                    numberOfSubnets.ToString}
    End Sub

    ''' <summary>
    ''' Updates the array with textbox objects
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updateTextboxArray()
        textboxArray = {TextBoxSubnetSize,
                        TextBoxDecimalOctets,
                        TextBoxDecimalAddress,
                        TextBoxBinaryOctets,
                        TextBoxHexOctets,
                        TextBoxClass,
                        TextBoxNumberOfAddresses,
                        TextBoxSubnetMask,
                        TextBoxBinaryMask,
                        TextBoxNumberOfSubnets}
    End Sub

    ''' <summary>
    ''' Updates all textbox texts
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub updateDisplay()
        ListBoxAddresses.Items.Clear()
        For i As Integer = 0 To textboxArray.GetUpperBound(0)
            textboxArray(i).Text = dataArray(i + 2)
        Next
        ProgressBarListbox.Visible = True
        ProgressBarListbox.Maximum = addresses.Length
        ProgressBarListbox.Value = ProgressBarListbox.Minimum
        For i As Integer = 0 To addresses.GetUpperBound(0)
            ListBoxAddresses.Items.Add(addresses(i))
            ProgressBarListbox.Value += 1
        Next
    End Sub

    ''' <summary>
    ''' Loads all subnetting datas from the file into each dataArray and addresses
    ''' </summary>
    ''' <param name="filePath">path directory to the file</param>
    ''' <remarks>It has no error checking for the file format. Thus, the file data must be formatted correctly or else, it may potentially break the program.</remarks>
    Private Sub loadToVariables(filePath As String)
        Dim reader As StreamReader = File.OpenText(filePath)
        Dim line As String = reader.ReadLine()
        ReDim dataArray(11)
        For i As Integer = 0 To dataArray.GetUpperBound(0)
            dataArray(i) = line
            line = reader.ReadLine()
        Next
        Dim index As Integer
        ReDim addresses(index)
        Do Until IsNothing(line)
            ReDim Preserve addresses(index)
            addresses(index) = line
            line = reader.ReadLine()
            index += 1
        Loop
        reader.Close()
    End Sub

    ''' <summary>
    ''' Saves all datas into a text file
    ''' </summary>
    ''' <param name="filePath">path directory to the file save location</param>
    ''' <remarks></remarks>
    Private Sub saveToFile(filePath As String)
        Dim writer As StreamWriter = File.CreateText(filePath)
        For i As Integer = 0 To dataArray.GetUpperBound(0)
            writer.WriteLine(dataArray(i))
        Next
        For i As Integer = 0 To addresses.GetUpperBound(0)
            writer.WriteLine(addresses(i))
        Next
        writer.Close()
    End Sub

    ''' <summary>
    ''' Calculates subnetting upon being clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ButtonCalculate_Click(sender As Object, e As EventArgs) Handles ButtonCalculate.Click
        calculateAndUpdate()
    End Sub

    ''' <summary>
    ''' Opens a text file to be loaded and updates the loaded datas to display
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>Error may occur due to incorrectly formatted text file</remarks>
    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim result As DialogResult = OpenFileDialogLoad.ShowDialog()
        Dim filePath As String = String.Empty
        If result = Windows.Forms.DialogResult.OK Then
            filePath = OpenFileDialogLoad.FileName
            loadToVariables(filePath)
            updateTextboxArray()
            updateDisplay()
            TextBoxNetworkAddress.Text = dataArray(0)
            TextBoxHostPerSubnet.Text = dataArray(1)
            MsgBox("File loaded")
        End If
    End Sub

    ''' <summary>
    ''' Clears texts from all textboxes and listbox, except user inputs
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearAll()
        For i As Integer = 0 To textboxArray.GetUpperBound(0)
            textboxArray(i).Text = String.Empty
        Next
        ListBoxAddresses.Items.Clear()
        ProgressBarListbox.Visible = False
    End Sub

    ''' <summary>
    ''' Saves the file to the directed location by the user
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        If validateInput(TextBoxNetworkAddress.Text, TextBoxHostPerSubnet.Text) Then
            Dim result As DialogResult = SaveFileDialog.ShowDialog()
            Dim filePath As String = String.Empty
            If result = Windows.Forms.DialogResult.OK Then
                filePath = SaveFileDialog.FileName
                saveToFile(filePath)
                MsgBox("File saved to " & filePath)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Calculates subnetting upon being selected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub CalculateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalculateToolStripMenuItem.Click
        calculateAndUpdate()
    End Sub

    ''' <summary>
    ''' Clears the form upon being selected
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        updateTextboxArray()
        clearAll()
        TextBoxNetworkAddress.Text = String.Empty
        TextBoxHostPerSubnet.Text = String.Empty
    End Sub

    ''' <summary>
    ''' Closes the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
