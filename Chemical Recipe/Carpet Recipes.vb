Public Class Carpet_Recipes
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case True
            '---None---
            Case cboBox1.SelectedIndex = 0
                grpQM.Visible = True
                grpQM2.Visible = True

                grpPS1.Visible = False
                grpHS0.Visible = False
                grpJug.Visible = False

                grpChemPetOdor.Visible = False
                grpSS.Visible = False
                grpECC.Visible = False
                grpECA.Visible = False
                grpPSS.Visible = False
                grpPSSA.Visible = False
                grpRO.Visible = False
                '---Pet Oder (Hand Spray)---
            Case cboBox1.SelectedIndex = 1
                grpQM.Visible = False
                grpQM2.Visible = False

                grpPS1.Visible = False
                grpHS0.Visible = True
                grpJug.Visible = False

                grpChemPetOdor.Visible = True
                grpSS.Visible = False
                grpECC.Visible = False
                grpECA.Visible = False
                grpPSS.Visible = False
                grpPSSA.Visible = False
                grpRO.Visible = False
                '---Spot Stains (Hand Spray)---
            Case cboBox1.SelectedIndex = 2
                grpQM.Visible = False
                grpQM2.Visible = False

                grpPS1.Visible = False
                grpHS0.Visible = True
                grpJug.Visible = False

                grpChemPetOdor.Visible = False
                grpSS.Visible = True
                grpECC.Visible = False
                grpECA.Visible = False
                grpPSS.Visible = False
                grpPSSA.Visible = False
                grpRO.Visible = False
                '---Engine Chem Container---
            Case cboBox1.SelectedIndex = 3
                grpQM.Visible = False
                grpQM2.Visible = False

                grpPS1.Visible = False
                grpHS0.Visible = False
                grpJug.Visible = True

                grpChemPetOdor.Visible = False
                grpSS.Visible = False
                grpECC.Visible = True
                grpECA.Visible = False
                grpPSS.Visible = False
                grpPSSA.Visible = False
                grpRO.Visible = False
                '---Engine Chem Container (Alt)
            Case cboBox1.SelectedIndex = 4
                grpQM.Visible = False
                grpQM2.Visible = False

                grpPS1.Visible = False
                grpHS0.Visible = False
                grpJug.Visible = True

                grpChemPetOdor.Visible = False
                grpSS.Visible = False
                grpECC.Visible = False
                grpECA.Visible = True
                grpPSS.Visible = False
                grpPSSA.Visible = False
                grpRO.Visible = False
                '---Pre-Spray Solution---
            Case cboBox1.SelectedIndex = 5
                grpQM.Visible = False
                grpQM2.Visible = False

                grpPS1.Visible = True
                grpHS0.Visible = False
                grpJug.Visible = False

                grpChemPetOdor.Visible = False
                grpSS.Visible = False
                grpECC.Visible = False
                grpECA.Visible = False
                grpPSS.Visible = True
                grpPSSA.Visible = False
                grpRO.Visible = False
                '---Pre-Spray Solution (Alt)---
            Case cboBox1.SelectedIndex = 6
                grpQM.Visible = False
                grpQM2.Visible = False

                grpPS1.Visible = True
                grpHS0.Visible = False
                grpJug.Visible = False

                grpChemPetOdor.Visible = False
                grpSS.Visible = False
                grpECC.Visible = False
                grpECA.Visible = False
                grpPSS.Visible = False
                grpPSSA.Visible = True
                grpRO.Visible = False
                '--Regular Odor---
            Case cboBox1.SelectedIndex = 7
                grpQM.Visible = False
                grpQM2.Visible = False

                grpPS1.Visible = False
                grpHS0.Visible = False
                grpJug.Visible = False

                grpChemPetOdor.Visible = False
                grpSS.Visible = False
                grpECC.Visible = False
                grpECA.Visible = False
                grpPSS.Visible = False
                grpPSSA.Visible = False
                grpRO.Visible = True
        End Select


    End Sub

    Private Sub Carpet_Recipes_Load(sender As Object, e As EventArgs) Handles Me.Load
        '---Add new group, set to false.---
        grpPS1.Visible = False
        grpHS0.Visible = False
        grpJug.Visible = False

        grpChemPetOdor.Visible = False
        grpSS.Visible = False
        grpECC.Visible = False
        grpECA.Visible = False
        grpPSS.Visible = False
        grpPSSA.Visible = False
        grpRO.Visible = False

        '--Please Ignore---
        'grpQM.Visible = True
        'grpQM2.Visible = True
        'grpHS0.Visible = True

        '---Adds items to combobox.---
        cboBox1.Items.Add("None")                               'Index 0
        cboBox1.Items.Add("Pet Oder (Hand Spray)")              'Index 1
        cboBox1.Items.Add("Spot Stains (Hand Spray)")           'Index 2
        cboBox1.Items.Add("Engine Chem Container")              'Index 3
        cboBox1.Items.Add("Engine Chem Container (Alt)")        'Index 4
        cboBox1.Items.Add("Pre-Spray Solution")                 'Index 5
        cboBox1.Items.Add("Pre-Spray Solution (Alt)")           'Index 6
        cboBox1.Items.Add("Regular Oder")                       'Index 7

    End Sub

    Private Sub cboBox1_Click(sender As Object, e As EventArgs) Handles cboBox1.Click
        '---On combobox change, reset grp---
        grpQM.Visible = True
        grpQM2.Visible = True

        grpChemPetOdor.Visible = False
        grpSS.Visible = False
        grpECC.Visible = False
        grpECA.Visible = False
        grpPSS.Visible = False
        grpPSSA.Visible = False
        grpRO.Visible = False

        grpPS1.Visible = False
        grpJug.Visible = False
        grpHS0.Visible = False
    End Sub
End Class