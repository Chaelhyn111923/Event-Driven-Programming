Public Class Form1

    Private Countdown As Integer = 10

    Private PedestrianRequestA As Boolean = False
    Private PedestrianRequestB As Boolean = False
    Private PedestrianRequestC As Boolean = False
    Private PedestrianRequestD As Boolean = False
    Private PedestrianTime As Integer = 0
    Private PedestrianTimeB As Integer = 0
    Private PedestrianTimeC As Integer = 0
    Private PedestrianTimeD As Integer = 0
    Private Phase As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = "Smart Traffic Light Simulation"

        Timer1.Interval = 1000
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Countdown -= 1

        lblCountdown.Text = Countdown.ToString()

        Me.Text = "Traffic Simulation - Countdown: " & Countdown

        ' RESET ALL LIGHTS

        PanelRedAN.BackColor = Color.DarkRed
        PanelYellowAN.BackColor = Color.DarkGoldenrod
        PanelGreenAN.BackColor = Color.DarkGreen

        PanelRedAS.BackColor = Color.DarkRed
        PanelYellowAS.BackColor = Color.DarkGoldenrod
        PanelGreenAS.BackColor = Color.DarkGreen

        PanelRedAW.BackColor = Color.DarkRed
        PanelYellowAW.BackColor = Color.DarkGoldenrod
        PanelGreenAW.BackColor = Color.DarkGreen

        PanelRedA.BackColor = Color.DarkRed
        PanelYellowA.BackColor = Color.DarkGoldenrod
        PanelGreenA.BackColor = Color.DarkGreen

        ' B
        PanelRedBN.BackColor = Color.DarkRed
        PanelYellowBN.BackColor = Color.DarkGoldenrod
        PanelGreenBN.BackColor = Color.DarkGreen

        PanelRedBS.BackColor = Color.DarkRed
        PanelYellowBS.BackColor = Color.DarkGoldenrod
        PanelGreenBS.BackColor = Color.DarkGreen

        PanelRedBW.BackColor = Color.DarkRed
        PanelYellowBW.BackColor = Color.DarkGoldenrod
        PanelGreenBW.BackColor = Color.DarkGreen

        PanelRedB.BackColor = Color.DarkRed
        PanelYellowB.BackColor = Color.DarkGoldenrod
        PanelGreenB.BackColor = Color.DarkGreen

        ' C
        PanelRedCN.BackColor = Color.DarkRed
        PanelYellowCN.BackColor = Color.DarkGoldenrod
        PanelGreenCN.BackColor = Color.DarkGreen

        PanelRedCS.BackColor = Color.DarkRed
        PanelYellowCS.BackColor = Color.DarkGoldenrod
        PanelGreenCS.BackColor = Color.DarkGreen

        PanelRedCW.BackColor = Color.DarkRed
        PanelYellowCW.BackColor = Color.DarkGoldenrod
        PanelGreenCW.BackColor = Color.DarkGreen

        PanelRedC.BackColor = Color.DarkRed
        PanelYellowC.BackColor = Color.DarkGoldenrod
        PanelGreenC.BackColor = Color.DarkGreen

        ' D
        PanelRedDN.BackColor = Color.DarkRed
        PanelYellowDN.BackColor = Color.DarkGoldenrod
        PanelGreenDN.BackColor = Color.DarkGreen

        PanelRedDS.BackColor = Color.DarkRed
        PanelYellowDS.BackColor = Color.DarkGoldenrod
        PanelGreenDS.BackColor = Color.DarkGreen

        PanelRedDW.BackColor = Color.DarkRed
        PanelYellowDW.BackColor = Color.DarkGoldenrod
        PanelGreenDW.BackColor = Color.DarkGreen

        PanelRedD.BackColor = Color.DarkRed
        PanelYellowD.BackColor = Color.DarkGoldenrod
        PanelGreenD.BackColor = Color.DarkGreen

        If Countdown <= 0 Then

            Phase += 1

            If Phase > 3 Then
                Phase = 0
            End If

            Countdown = 10

        End If

        Select Case Phase

            Case 0

                lblPhase.Text = "North/South Green"

                PanelGreenAN.BackColor = Color.Lime
                PanelGreenAS.BackColor = Color.Lime
                PanelRedAW.BackColor = Color.Red
                PanelRedA.BackColor = Color.Red

                PanelGreenBN.BackColor = Color.Lime
                PanelGreenBS.BackColor = Color.Lime
                PanelRedBW.BackColor = Color.Red
                PanelRedB.BackColor = Color.Red

                PanelGreenCN.BackColor = Color.Lime
                PanelGreenCS.BackColor = Color.Lime
                PanelRedCW.BackColor = Color.Red
                PanelRedC.BackColor = Color.Red

                PanelGreenDN.BackColor = Color.Lime
                PanelGreenDS.BackColor = Color.Lime
                PanelRedDW.BackColor = Color.Red
                PanelRedD.BackColor = Color.Red

            Case 1

                lblPhase.Text = "North/South Yellow"

                PanelYellowAN.BackColor = Color.Yellow
                PanelYellowAS.BackColor = Color.Yellow

                PanelYellowBN.BackColor = Color.Yellow
                PanelYellowBS.BackColor = Color.Yellow

                PanelYellowCN.BackColor = Color.Yellow
                PanelYellowCS.BackColor = Color.Yellow

                PanelYellowDN.BackColor = Color.Yellow
                PanelYellowDS.BackColor = Color.Yellow

            Case 2

                lblPhase.Text = "East/West Green"

                PanelGreenAW.BackColor = Color.Lime
                PanelGreenA.BackColor = Color.Lime

                PanelGreenBW.BackColor = Color.Lime
                PanelGreenB.BackColor = Color.Lime

                PanelGreenCW.BackColor = Color.Lime
                PanelGreenC.BackColor = Color.Lime

                PanelGreenDW.BackColor = Color.Lime
                PanelGreenD.BackColor = Color.Lime

                PanelRedAN.BackColor = Color.Red
                PanelRedAS.BackColor = Color.Red

                PanelRedBN.BackColor = Color.Red
                PanelRedBS.BackColor = Color.Red

                PanelRedCN.BackColor = Color.Red
                PanelRedCS.BackColor = Color.Red

                PanelRedDN.BackColor = Color.Red
                PanelRedDS.BackColor = Color.Red

            Case 3

                lblPhase.Text = "East/West Yellow"

                PanelYellowAW.BackColor = Color.Yellow
                PanelYellowA.BackColor = Color.Yellow

                PanelYellowBW.BackColor = Color.Yellow
                PanelYellowB.BackColor = Color.Yellow

                PanelYellowCW.BackColor = Color.Yellow
                PanelYellowC.BackColor = Color.Yellow

                PanelYellowDW.BackColor = Color.Yellow
                PanelYellowD.BackColor = Color.Yellow

        End Select



        If PedestrianRequestA Then

            PanelPedA.BackColor = Color.Lime

            PedestrianTime -= 1

            If PedestrianTime <= 0 Then

                PanelPedA.BackColor = Color.DarkRed
                PedestrianRequestA = False

            End If

            If PedestrianRequestB Then

                PanelPedB.BackColor = Color.Lime

            Else

                PanelPedB.BackColor = Color.DarkRed

            End If


            If PedestrianRequestC Then

                PanelPedC.BackColor = Color.Lime

            Else

                PanelPedC.BackColor = Color.DarkRed

            End If


            If PedestrianRequestD Then

                PanelPedD.BackColor = Color.Lime

            Else

                PanelPedD.BackColor = Color.DarkRed

            End If

        End If

        If Countdown <= 0 Then
            Countdown = 10
        End If

        If PedestrianRequestB Then

            PanelPedB.BackColor = Color.Lime

            PedestrianTimeB -= 1

            If PedestrianTimeB <= 0 Then

                PanelPedB.BackColor = Color.DarkRed
                PedestrianRequestB = False

            End If

        End If


        If PedestrianRequestC Then

            PanelPedC.BackColor = Color.Lime

            PedestrianTimeC -= 1

            If PedestrianTimeC <= 0 Then

                PanelPedC.BackColor = Color.DarkRed
                PedestrianRequestC = False

            End If

        End If


        If PedestrianRequestD Then

            PanelPedD.BackColor = Color.Lime

            PedestrianTimeD -= 1

            If PedestrianTimeD <= 0 Then

                PanelPedD.BackColor = Color.DarkRed
                PedestrianRequestD = False

            End If

        End If
    End Sub


    Private Sub btnPedA_Click(sender As Object, e As EventArgs) Handles btnPedA.Click

        PedestrianRequestA = True
        PedestrianTime = 5

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles PanelPedD.Paint

    End Sub

    Private Sub btnPedB_Click(sender As Object, e As EventArgs) Handles btnPedB.Click

        PedestrianRequestB = True
        PedestrianTimeB = 5

    End Sub

    Private Sub btnPedC_Click(sender As Object, e As EventArgs) Handles btnPedC.Click

        PedestrianRequestC = True
        PedestrianTimeC = 5


    End Sub

    Private Sub btnPedD_Click(sender As Object, e As EventArgs) Handles btnPedD.Click

        PedestrianRequestD = True
        PedestrianTimeD = 5


    End Sub



    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        Timer1.Start()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click

        Timer1.Stop()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Countdown = 10
        Phase = 0

    End Sub



    Private Sub lblCountdown_Click(sender As Object, e As EventArgs) Handles lblCountdown.Click

    End Sub

    Private Sub PanelRoadH_Paint(sender As Object, e As PaintEventArgs) Handles PanelRoadH.Paint

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles RoadVertical.Paint

    End Sub

    Private Sub Panel2_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class