Imports System.Net
Imports System.Net.Sockets
Imports System.Threading



Public Class LanderServer
    'Public Server Vars
    Dim TCPServer As Socket
    Dim TCPListenerz As TcpListener
    Dim Connection As Boolean = False



    ' Reminder Try to cap the acceleration

    Dim Timer As Stopwatch ' used to make sure that the game runs at same speed on all computers
    Dim backBuffer As Image ' this is the buffer for the drawing surface for the lander image
    Dim graphics As Graphics ' this is the drawing surface for the lander image
    Dim clientWidth As Integer ' Width of the form
    Dim clientHeight As Integer ' Height of the form
    Dim frameInterval As Long   ' time that the frame is on the screen in milliseconds
    Dim dt As Double ' frameInterval in seconds
    Dim startTick As Long  ' time on the Timer stop watch when the frame is put on the screen
    ' Dim landerImage As Rectangle ' Image of the lander
    Dim velocity As Point  ' Velocity of the lander (acceleration vector)
    Const GRAVITY As Integer = 50 ' Gravity acting on the lander (acceleration vector)
    Dim angle As Double  ' Angle that the lander is positioned at
    Const MIN_ANGLE As Integer = 45 ' Rightmost angle
    Const MAX_ANGLE As Integer = 135 'Leftmost angle
    Const THRUST_SPEED As Integer = 2 'This is an acceleration magnitude
    Dim thrustX As Double  ' Thrust in X direction
    Dim thrustY As Double  ' Thrust in Y direction
    Const PI As Double = 3.14159265 ' Used to convert angle to radians
    Dim fuel As Long ' Fuel value for the lander
    Dim fuelTimer As New System.Timers.Timer  ' Timer used for decrementing the fuel
    Dim lowFuelTimer As New System.Timers.Timer  ' Timer used for flashing the low fuel warning
    Dim lowFuelSeen As Boolean = False ' Needed because timer events cannot change controls on a form since they are run on a seperate thread
    Dim thrusting As Boolean ' tells if lander is thrusting
    Dim crashed As Boolean = False ' Tells is lander has crashed
    Dim landed As Boolean = False  ' Tells if lander has lander
    Dim accelerationY As Double ' Net Acceleration in the Y direction
    Dim keyLeftPressed As Boolean = False ' Tells if left key is pressed
    Dim keyRightPressed As Boolean = False ' Tells if right key is pressed
    Dim keyUpPressed As Boolean = False   ' Tells if up key is pressed

    Dim landerLocation As Point ' needed because a picturebox location cannot be changed with an expression
    Dim landerLocation2 As Point
    'While the Form exists run GameLoop
    Private Sub LanderTest_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        GameLoop()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MainMenu.Hide()
        'Obtain server IpAdress
        Dim IPHost As IPHostEntry
        IPHost = Dns.GetHostByName(Dns.GetHostName())
        Dim hostIp As String = IPHost.AddressList(0).ToString()



        Me.DoubleBuffered = True  ' Prevents flickering
        'Me.WindowState = FormWindowState.Maximized ' Maximize the window on form load
        'Msg Box
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle

        MessageBox.Show("Your IP is: " & hostIp, "Host") ' Display Directions, also allows wait til network connection is made


        'Start Tcp
        TCPListenerz = New TcpListener(IPAddress.Any, 1000) 'change port here
        TCPListenerz.Start()
        TCPServer = TCPListenerz.AcceptSocket()
        TCPServer.Blocking = False
        TimerRec.Enabled = True
        Connection = True


        Timer = New Stopwatch()
        clientWidth = Me.Size.Width()
        clientHeight = Me.Size.Height()
        frameInterval = 17 ' about 60 FPS
        dt = frameInterval / 1000  ' frameInterval now in seconds

        Me.ClientSize = New Size(clientWidth, clientHeight)
        backBuffer = New Bitmap(clientWidth, clientHeight)
        graphics = graphics.FromImage(backBuffer)
        velocity = New Point(0, 0)
        angle = 90
        'landerImage = New Rectangle(150, 50, 10, 20) ' To be replaced with picture of lander?

        fuel = 1000 ' Initialize fuel to 1000
        'Set fuel timer properties
        fuelTimer.Interval = frameInterval
        AddHandler fuelTimer.Elapsed, AddressOf fuelTimer_Tick

        'Set fuel warning timer properties
        lowFuelTimer.Interval = frameInterval * 10
        AddHandler lowFuelTimer.Elapsed, AddressOf fuelWarningTimer_Tick

    End Sub

    'TCP Timer refreshes constantly to send and recieve inputs.
    Private Sub TimerRec_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerRec.Tick
        Dim sendBytes() As Byte
        sendBytes = System.Text.Encoding.ASCII.GetBytes(landerLocation.X.ToString & " " & landerLocation.Y.ToString)
        TCPServer.Send(sendBytes)

        Dim recieved As String = ""
        Try
            Dim rcvbytes(TCPServer.ReceiveBufferSize) As Byte
            TCPServer.Receive(rcvbytes)
            recieved = System.Text.Encoding.ASCII.GetString(rcvbytes)
        Catch ex As Exception
        End Try

        Debug.Print(recieved)

        If recieved IsNot "" Then

            Dim recArray() As String = Split(recieved, " ")
            Dim X, Y As String
            X = recArray(0)
            Y = recArray(1)
            landerLocation2.X = CInt(X)
            landerLocation2.Y = CInt(Y)

            landerPic2.Location = (landerLocation2)

        End If
        'Move Second lander here
        'If recieved IsNot "" Then
        '    Dim recArray() As String = Split(recieved)
        '    For i As Integer = 0 To recArray.Length - 1
        '        If recArray(i) = "up" Then

        '        ElseIf recArray(i) = "left" Then

        '        ElseIf recArray(i) = "right" Then

        '        ElseIf recArray(i) = "UP" Then

        '        ElseIf recArray(i) = "LEFT" Then

        '        ElseIf recArray(i) = "RIGHT" Then

        '        End If
        '    Next
        'End If

    End Sub




    'Controls Gameplay and Renders New Frame
    Private Sub GameLoop()
        Timer.Start()
        Do While (Me.Created)
            startTick = Timer.ElapsedMilliseconds
            GameLogic()
            RenderScene()
            Application.DoEvents()
            ' Required to make sure all computers run game at the same speed
            Do While Timer.ElapsedMilliseconds - startTick < frameInterval

            Loop
        Loop
    End Sub

    Private Sub GameLogic()
        'Move Lander with velocity result of last frame

        MoveLander()
        accelerationY = GRAVITY + thrustY

        velocity.X += thrustX * dt
        velocity.Y += accelerationY * dt
        LimitVelocity()
        landerLocation.X += velocity.X * dt
        landerLocation.Y += velocity.Y * dt
        'landerImage.X += (velocity.X * dt) ' x position
        'landerImage.Y += (velocity.Y * dt) ' y position
        ' detectCollision(crashed)
        ApplyBoundaries()

    End Sub

    Private Sub ApplyBoundaries()

        'Set invisible wall on left boundary
        If landerLocation.X < 0 Then
            landerLocation.X = 0
            velocity.X = 0
        End If

        'Set invisible wall on right boundary
        If landerLocation.X + picLander.Width > clientWidth Then
            landerLocation.X = clientWidth - picLander.Width
            velocity.X = 0
        End If

        'Set invisible ceiling
        If landerLocation.Y < 0 Then
            landerLocation.Y = 0
            velocity.Y = 0
        End If

        'Set invisible floor
        If landerLocation.Y + picLander.Height > clientHeight Then
            landerLocation.Y = clientHeight - picLander.Height
            velocity.Y = 0

        End If
    End Sub



    Private Sub RenderScene()
        lblAngle.Text = angle
        lblVelX.Text = velocity.X
        lblVelY.Text = velocity.Y
        lblLocX.Text = landerLocation.X
        lblLocY.Text = landerLocation.Y

        lblFuel.Text = fuel
        lblLowFuel.Visible = lowFuelSeen
        If fuel = 0 Then
            lblLowFuel.Visible = False
            lblOutOfFuel.Visible = True
        End If
        ' If thrusting then
        '   play thrust sound

        ' If crashed then
        '   play crash animation and sound
        '   spawn

        ' If landed then
        '   show label saying good landing
        '   spawn

        backBuffer = New Bitmap(clientWidth, clientHeight)
        graphics = graphics.FromImage(backBuffer)
        pbSurface.Image = Nothing
        'graphics.FillRectangle(Brushes.Blue(), landerImage) ' To be replaced with image of drawLander(angle) Function
        picLander.Location = (landerLocation)


        pbSurface.Image = backBuffer
    End Sub

    ' Handles keydown events that will change a boolean to allow for "simultaneous" key input
    Private Sub KeysPressed(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Dim sendbytes() As Byte
        If e.KeyValue = Keys.Left Then
            keyLeftPressed = True
            'sendbytes = System.Text.Encoding.ASCII.GetBytes("left ")
            'TCPServer.Send(sendbytes)
        ElseIf e.KeyValue = Keys.Right Then
            keyRightPressed = True
            'sendbytes = System.Text.Encoding.ASCII.GetBytes("right ")
            'TCPServer.Send(sendbytes)
        ElseIf e.KeyValue = Keys.Up Then
            keyUpPressed = True
            'sendbytes = System.Text.Encoding.ASCII.GetBytes("up ")
            'TCPServer.Send(sendbytes)
        End If
    End Sub

    ' Sets the key that was released to false
    Private Sub KeyReleased(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Dim sendbytes() As Byte
        If e.KeyValue = Keys.Left Then
            keyLeftPressed = False
            'sendbytes = System.Text.Encoding.ASCII.GetBytes("LEFT ")
            'TCPServer.Send(sendbytes)
        ElseIf e.KeyValue = Keys.Right Then
            'sendbytes = System.Text.Encoding.ASCII.GetBytes("RIGHT ")
            'TCPServer.Send(sendbytes)
            keyRightPressed = False
        ElseIf e.KeyValue = Keys.Up Then
            keyUpPressed = False
            'sendbytes = System.Text.Encoding.ASCII.GetBytes("UP ")
            'TCPServer.Send(sendbytes)
        End If

    End Sub
    ' Handles movement 
    Private Sub MoveLander()
        'Rotate Left
        If keyLeftPressed Then
            angle += 1

            If angle > MAX_ANGLE Then
                angle = MAX_ANGLE
            End If

        End If

        'Rotate Right
        If keyRightPressed Then
            angle -= 1

            If angle < MIN_ANGLE Then
                angle = MIN_ANGLE
            End If

        End If

        'Apply Thrust if there is fuel
        If fuel > 0 Then

            If keyUpPressed Then
                Thrust()
            End If
        Else
        End If
    End Sub

    Private Sub Thrust()
        fuelTimer.Enabled = True
        thrusting = True
        ' Because THRUST_SPEED is a magnitude it must be converted to it's component vectors and added to the velocity
        thrustX += THRUST_SPEED * Cosine(angle)
        thrustY += -1 * THRUST_SPEED * Sine(angle) ' Negative Value because top left corner of window is (0,0)
    End Sub

    Private Sub fuelTimer_Tick(sender As Object, e As Timers.ElapsedEventArgs)
        If fuel <> 0 Then
            fuel -= 1
            ' Low fuel show warning start lowFuelTimer
            If fuel < 200 And fuel > 0 Then
                lowFuelTimer.Enabled = True
            ElseIf fuel = 0 Then
                lowFuelTimer.Enabled = False
                thrustY = 0 ' make ship drops even if up arrow is pressed
            End If
        End If
    End Sub

    Private Sub StopThrust(Sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyValue = Keys.Up Then
            fuelTimer.Enabled = False
            thrustX = 0
            thrustY = 0
            thrusting = False
        End If
    End Sub

    ' GetAngle function that will return the value of the angle
    ' GetLocation function that will return the location
    ' GetVelocity function that will return the velocity

    Private Function Cosine(angle As Double) As Double
        Cosine = Math.Cos(angle * PI / 180)
    End Function

    Private Function Sine(angle As Double) As Double
        Sine = Math.Sin(angle * PI / 180)
    End Function

    ' Set booleans that will make RenderScene flicker the Low Fuel warning
    Private Sub fuelWarningTimer_Tick(ByVal sender As Object, ByVal e As System.Timers.ElapsedEventArgs)
        If lowFuelSeen Then
            lowFuelSeen = False
        Else
            lowFuelSeen = True
        End If
    End Sub

    ' Function drawLander(angle, thrusting)
    '   Series of if statements for if lander is between certain angle and is thrusting
    '   Then draw appropriate lander picture

    ' Function land(locationX, locationY, angle, velocity, terrain)
    '   if lander collides with terrain at > 25 velocity
    '   then set crashed to true,
    '   elseif lander collides with terrain at < 25 velocity and angle = about 90
    '   add 50 * multiplier value and set landed to True

    ' Limits velocity to allow easier maneuvering
    Private Sub LimitVelocity()
        If velocity.Y > 50 Then ' Limit down velocity
            velocity.Y = 50
        ElseIf velocity.Y < -50 Then ' Limit up velocity
            velocity.Y = -50
        End If

        If velocity.X > 50 Then
            velocity.X = 50 ' Limit Right velocity
        ElseIf velocity.X < -50 Then
            velocity.X = -50
        End If
    End Sub


End Class