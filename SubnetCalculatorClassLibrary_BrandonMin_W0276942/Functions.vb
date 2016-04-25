Option Strict On

''' <summary>
''' Functions for calculating sub network ranges and setting
''' 
''' Name: Brandon Min
''' Date: 2014/12/11
''' </summary>
''' <remarks></remarks>
Public Module Functions
    Dim ipClassRanges() As Integer = {126, 191, 223}
    Dim ipClasses() As Char = {"A"c, "B"c, "C"c}

    ''' <summary>
    ''' Checks if both network address and the number of host per subnet is legal
    ''' 
    ''' </summary>
    ''' <param name="networkAddress">User input for Network Address</param>
    ''' <param name="numberOfHostPerSubnet">User input for Number of host per subnet</param>
    ''' <returns>If both inputs are legal, the function returns true. Else, returns false</returns>
    ''' <remarks>Usually, validation should be done for seperate functions. 
    ''' However, I wanted the validation to be done in a single function, so each function will only worry of the calculation and not clutter up
    ''' I recognize that this is not practical for longer and more complicated calculator</remarks>
    Public Function validateInput(networkAddress As String, numberOfHostPerSubnet As String) As Boolean
        Dim junks() As Char = {","c, ";"c, "/"c, ";"c, ":"c, "["c, "]"c, "{"c, "}"c, "("c, ")"c, "_"c, "+"c, "+"c, "!"c, "@"c, "#"c, "$"c, "%"c,
                               "^"c, "&"c, "*"c, "<"c, ">"c, "?"c, """"c, "'"c, "\"c, "|"c}
        'Removes all unnecessary notation on the networkAddress and numberOfHostPerSubnet
        For i As Integer = 0 To junks.GetUpperBound(0)
            networkAddress = networkAddress.Replace(junks(i), "")
            numberOfHostPerSubnet = numberOfHostPerSubnet.Replace(junks(i), "")
        Next
        Dim address() As String = networkAddress.Split("."c)
        Dim ip4Boolean As Boolean = True
        Dim ipClass As Char = "X"c
        'Checks if address is numeric
        For i As Integer = 0 To address.GetUpperBound(0)
            If Not IsNumeric(address(i)) Then
                ip4Boolean = False
            End If
        Next
        'Address must be 4 octets
        If address.Length <> 4 Or ip4Boolean = False Then
            ip4Boolean = False
        Else
            'Checks address's network class and sets it accordingly
            For i As Integer = 0 To ipClassRanges.GetUpperBound(0)
                If Convert.ToInt32(address(0)) <= ipClassRanges(i) Then
                    ipClass = ipClasses(i)
                    Exit For
                End If
            Next
            If ipClass = "X"c Then
                ip4Boolean = False
            Else
                'address octets must be lower then 255
                For i As Integer = 0 To address.GetUpperBound(0)
                    If Convert.ToInt32(address(i)) > 255 Or Convert.ToInt32(address(i)) < 0 Then
                        ip4Boolean = False
                    End If
                Next
                'No loop-back addresses are allowed for subnetting
                If Convert.ToInt32(address(0)) = 127 Then
                    ip4Boolean = False
                    'Default subnetmask should make sense
                ElseIf ipClass = "A"c And Convert.ToInt32(address(1)) + Convert.ToInt32(address(2)) + Convert.ToInt32(address(3)) > 0 Then
                    ip4Boolean = False
                ElseIf ipClass = "B"c And Convert.ToInt32(address(2)) + Convert.ToInt32(address(3)) > 0 Then
                    ip4Boolean = False
                ElseIf Convert.ToInt32(address(3)) > 0 Then
                    ip4Boolean = False
                End If
            End If
        End If
        If ip4Boolean = False Then
            MsgBox("ERROR: Network Address must be a valid IPv4 address")
            Return False
        ElseIf IsNumeric(numberOfHostPerSubnet) = False Then
            MsgBox("ERROR: Number of host must be a valid number")
            Return False
        ElseIf Convert.ToDouble(numberOfHostPerSubnet) Mod 1 <> 0 Or Convert.ToDouble(numberOfHostPerSubnet) < 0 Then
            MsgBox("ERROR: Number of host must be a valid number")
            Return False
        Else
            'Checks if the number of host can exist within the network
            Dim numberOfHostPerSubnetInteger = Convert.ToInt32(numberOfHostPerSubnet)
            If ipClass = "A"c And numberOfHostPerSubnetInteger > ((256 ^ 3) - 2) Then
                MsgBox("ERROR: Number of host must be a valid number")
                Return False
            ElseIf ipClass = "B"c And numberOfHostPerSubnetInteger > ((256 ^ 2) - 2) Then
                MsgBox("ERROR: Number of host must be a valid number")
                Return False
            ElseIf ipClass = "C"c And numberOfHostPerSubnetInteger > (256 - 2) Then
                MsgBox("ERROR: Number of host must be a valid number")
                Return False
            Else
                Return True
            End If
        End If
    End Function

    ''' <summary>
    ''' Calculates and returns the subnet size for given number of hosts per subnet
    ''' </summary>
    ''' <param name="numberOfHostsPerSubnet">User input for Number of host per subnet</param>
    ''' <returns>Returns subnet size in integer</returns>
    ''' <remarks></remarks>
    Public Function CalculateSubnetSize(numberOfHostsPerSubnet As Integer) As Integer
        Dim index As Integer
        Do Until (numberOfHostsPerSubnet + 2) <= 2 ^ (2 + index)
            index += 1
        Loop
        Return Convert.ToInt32(2 ^ (2 + index))
    End Function

    ''' <summary>
    ''' Processes the network address in decimal octet notation
    ''' </summary>
    ''' <param name="ipAddress">User input for Network Address</param>
    ''' <returns>Returns the network address in decimal notation as string (eg. "192.168.0.0")</returns>
    ''' <remarks>Validations are already taken care of with above function validationInput()
    ''' .......I'm sorry</remarks>
    Public Function CalculateDecimalOctets(ipAddress As String) As String
        Return ipAddress
    End Function

    ''' <summary>
    ''' Calculates the network address in decimal (whole number)
    ''' </summary>
    ''' <param name="ipAddress">User input for Network Address</param>
    ''' <returns>Returns the decimal of the network address As Long (eg. 3232235520)</returns>
    ''' <remarks>It may return a large number that requires int64</remarks>
    Public Function CalculateDecimalAddress(ipAddress As String) As Long
        Dim ipAddressString() As String = ipAddress.Split("."c)
        Dim ipAddressInteger(ipAddressString.GetUpperBound(0)) As Integer
        Dim decimalAddress As Long
        For i As Integer = 0 To ipAddressString.GetUpperBound(0)
            ipAddressInteger(i) = Convert.ToInt32(ipAddressString(i))
            decimalAddress += Convert.ToInt64(ipAddressInteger(i) * (256 ^ (3 - i)))
        Next
        Return decimalAddress
    End Function

    ''' <summary>
    ''' Processes the ip address in binary notation
    ''' </summary>
    ''' <param name="ipAddress">User input for Network Address</param>
    ''' <returns>Returns the network address in binary notation as string (eg. "11000000.11111111.11111111.00000000")</returns>
    ''' <remarks></remarks>
    Public Function CalculateBinaryAddress(ipAddress As String) As String
        Dim ipAddressString() As String = ipAddress.Split("."c)
        Dim ipAddressInteger(ipAddressString.GetUpperBound(0)) As Integer
        Dim line As String = String.Empty
        Dim ipAddressBinary(ipAddressString.GetUpperBound(0)) As String
        For i As Integer = 0 To ipAddressString.GetUpperBound(0)
            ipAddressInteger(i) = Convert.ToInt32(ipAddressString(i))
            For index As Integer = 7 To 0 Step -1
                If ipAddressInteger(i) >= (2 ^ index) Then
                    ipAddressInteger(i) -= Convert.ToInt32(2 ^ index)
                    line += "1"
                Else
                    line += "0"
                End If
            Next
            ipAddressBinary(i) = line
            line = String.Empty
        Next
        Return String.Format("{0}.{1}.{2}.{3}", ipAddressBinary(0), ipAddressBinary(1), ipAddressBinary(2), ipAddressBinary(3))
    End Function

    ''' <summary>
    ''' Processes the ip address in hexadecimal notation
    ''' </summary>
    ''' <param name="ipAddress">User input for Network Address</param>
    ''' <returns>Returns the network address in binary notation as string (eg. "C0.A8.0.0")</returns>
    ''' <remarks>Hex() converts the integer to hexadecimal as String</remarks>
    Public Function CalculateHexAddress(ipAddress As String) As String
        Const hexRange As Integer = 16
        Dim ipAddressString() As String = ipAddress.Split("."c)
        Dim line As String = String.Empty
        Dim ipAddressInteger(ipAddressString.GetUpperBound(0)) As Integer
        Dim ipAddressHex(ipAddressString.GetUpperBound(0)) As String
        For i As Integer = 0 To ipAddressString.GetUpperBound(0)
            ipAddressInteger(i) = Convert.ToInt32(ipAddressString(i))
            If ipAddressInteger(i) > hexRange Then
                line = Hex(ipAddressInteger(i))
                If line.Length < 2 Then
                    line &= "0"
                End If
            Else
                line = "0" & Hex(ipAddressInteger(i))
            End If
            ipAddressHex(i) = line
            line = String.Empty
            'ipAddressHex(i) = Hex(Convert.ToInt32(ipAddressString(i)))
        Next
        Return String.Format("{0}.{1}.{2}.{3}", ipAddressHex(0), ipAddressHex(1), ipAddressHex(2), ipAddressHex(3))
    End Function


    ''' <summary>
    ''' Processes the network class
    ''' </summary>
    ''' <param name="ipAddress">User input for Network Address</param>
    ''' <returns>Returns a Char that represents the network class</returns>
    ''' <remarks>ipClassRanges() As Integer = {126, 191, 223}
    '''          ipClasses() As Char = {"A", "B", "C"}</remarks>
    Public Function CalculateNetworkClass(ipAddress As String) As Char
        Dim ipAddressString() As String = ipAddress.Split("."c)
        Dim ipClass As Char
        For i As Integer = 0 To ipClassRanges.GetUpperBound(0)
            If Convert.ToInt32(ipAddressString(0)) <= ipClassRanges(i) Then
                ipClass = ipClasses(i)
                Exit For
            End If
        Next
        If ipClass <> "" Then
            Return ipClass
        Else
            Return "X"c
        End If
    End Function

    ''' <summary>
    ''' Calculates the number of ip addresses available with the network address
    ''' </summary>
    ''' <param name="ipAddress">User input for Network Address</param>
    ''' <returns>Returns the number of ip addresses as integer</returns>
    ''' <remarks></remarks>
    Public Function CalculateNumberOfIPAddresses(ipAddress As String) As Integer
        Dim networkClass As Char = CalculateNetworkClass(ipAddress)
        Return Convert.ToInt32(256 ^ (3 - Array.IndexOf(ipClasses, networkClass)))
    End Function

    ''' <summary>
    ''' Calculates the subnet mask of the network in decimal and CIDR notation for subnetting with the inputted number of hosts per subnet
    ''' </summary>
    ''' <param name="numberOfHostsPerSubnet">User input for Number of host per subnet</param>
    ''' <returns>Returns the subnet mask as string (eg. "255.255.255.0 or /28")</returns>
    ''' <remarks></remarks>
    Public Function CalculateSubnetMask(numberOfHostsPerSubnet As Integer) As String
        Dim ranges() As Integer = {24, 16, 8}
        Dim index As Integer
        Dim subnetString As String = String.Empty
        Do Until numberOfHostsPerSubnet < (2 ^ index)
            index += 1
        Loop
        If index > ranges(0) Then
            Return 256 - (2 ^ (index - ranges(0))) & ".0.0.0 or /" & 32 - index
        ElseIf index > ranges(1) Then
            Return "255." & 256 - (2 ^ (index - ranges(1))) & ".0.0 or /" & 32 - index
        ElseIf index > ranges(2) Then
            Return "255.255." & 256 - (2 ^ (index - ranges(2))) & ".0 or /" & 32 - index
        Else
            Return "255.255.255." & 256 - (2 ^ (index)) & " or /" & 32 - index
        End If
    End Function

    ''' <summary>
    ''' Processes the subnet mask in binary notation with the inputted number of hosts per subnet
    ''' </summary>
    ''' <param name="numberOfHostsPerSubnet">User input for Number of host per subnet</param>
    ''' <returns>Returns the subnet mask as string (eg. "11111111.11111111.11100000.00000000")</returns>
    ''' <remarks></remarks>
    Public Function CalculateBinaryMask(numberOfHostsPerSubnet As Integer) As String
        Dim index As Integer
        Dim subnetMask As String = String.Empty
        Do Until numberOfHostsPerSubnet < (2 ^ index)
            index += 1
        Loop
        For i As Integer = 0 To 31
            If index < 32 - i Then
                subnetMask &= "1"
            Else
                subnetMask &= "0"
            End If
            If (i + 1) Mod 8 = 0 And i <> 31 Then
                subnetMask &= "."
            End If
        Next
        Return subnetMask
    End Function

    ''' <summary>
    ''' Calculates the number of subnets needed for the inputted network and host per subnet
    ''' </summary>
    ''' <param name="ipAddress">User input for Network Address</param>
    ''' <param name="numberOfHostsPerSubnet">User input for Number of host per subnet</param>
    ''' <returns>Returns the number of subnets in the network</returns>
    ''' <remarks># of subnet = # of addresses / size of each subnets</remarks>
    Public Function CalculateNumberOfSubnets(ipAddress As String, numberOfHostsPerSubnet As Integer) As Integer
        Return Convert.ToInt32(CalculateNumberOfIPAddresses(ipAddress) / CalculateSubnetSize(numberOfHostsPerSubnet))
    End Function

    ''' <summary>
    ''' Processes all IP addresses ranges (subnets) in the network with the inputted network address and number of hosts per subnet
    ''' </summary>
    ''' <param name="ipAddress">User input for Network Address</param>
    ''' <param name="numberOfHostsPerSubnet">User input for Number of host per subnet</param>
    ''' <returns>Returns a string array of all IP ranges (eg. {"150.43.0.0 - 150.43.1.255", "150.43.2.0 - 150.43.3.255", ... })</returns>
    ''' <remarks>This function is very proccess intensive and it may make the program to freeze if inputs are extreme (eg. 117.0.0.0 with 2 hosts per subnet)
    '''          I'm suspecting that the proccess of storing all strings into an array is taking up all the proccess power
    '''          In the future, I may work on to return a single line of range instead of an array of all ranges</remarks>
    Public Function CalculateSubnetList(ipAddress As String, numberOfHostsPerSubnet As Integer) As String()
        Dim addresses(CalculateNumberOfSubnets(ipAddress, numberOfHostsPerSubnet) - 1) As String
        Dim decimalAddress As Long = CalculateDecimalAddress(ipAddress)
        Dim subnetSize As Integer = CalculateSubnetSize(numberOfHostsPerSubnet)
        Dim octetArray() As Long
        For i As Integer = 0 To addresses.GetUpperBound(0)
            octetArray = convertToOctet(decimalAddress)
            addresses(i) = String.Format("{0}.{1}.{2}.{3}", octetArray(0), octetArray(1), octetArray(2), octetArray(3))
            decimalAddress += subnetSize
            octetArray = convertToOctet(decimalAddress - 1)
            addresses(i) &= " - " & String.Format("{0}.{1}.{2}.{3}", octetArray(0), octetArray(1), octetArray(2), octetArray(3))
        Next
        Return addresses
    End Function

    ''' <summary>
    ''' Converts the decimal into four decimal octets
    ''' </summary>
    ''' <param name="decimalAddress">IP address in decimal (eg. 2519334912)</param>
    ''' <returns>Returns an array of Long which represents the IP address in decimal octet (eg. {150, 43, 0, 0})</returns>
    ''' <remarks>I'm not too sure how proccess intensive this function is</remarks>
    Private Function convertToOctet(decimalAddress As Long) As Long()
        Dim octetArray(3) As Long
        Dim octet As Long
        Dim rate As Long
        For i As Integer = 0 To octetArray.GetUpperBound(0)
            rate = Convert.ToInt64(256 ^ (3 - i))
            octet = decimalAddress \ rate
            decimalAddress -= octet * rate
            octetArray(i) = octet
        Next
        Return octetArray
    End Function
End Module
