<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmUberCar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblHeading = New Label()
        lblNumberOfMiles = New Label()
        lblCostPerMile = New Label()
        txtNumberOfMiles = New TextBox()
        lblFlatRate = New Label()
        picCar = New PictureBox()
        btnDisplayFare = New Button()
        btnClear = New Button()
        btnExit = New Button()
        lblTotalCost = New Label()
        lblFare = New Label()
        CType(picCar, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.BackColor = Color.DimGray
        lblHeading.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.ForeColor = Color.White
        lblHeading.Location = New Point(565, 21)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(186, 23)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Driveless Uber Car"
        ' 
        ' lblNumberOfMiles
        ' 
        lblNumberOfMiles.AutoSize = True
        lblNumberOfMiles.BackColor = Color.DimGray
        lblNumberOfMiles.Font = New Font("Tahoma", 11.25F)
        lblNumberOfMiles.ForeColor = Color.White
        lblNumberOfMiles.Location = New Point(565, 194)
        lblNumberOfMiles.Name = "lblNumberOfMiles"
        lblNumberOfMiles.Size = New Size(122, 18)
        lblNumberOfMiles.TabIndex = 1
        lblNumberOfMiles.Text = "Number Of Miles:"
        ' 
        ' lblCostPerMile
        ' 
        lblCostPerMile.AutoSize = True
        lblCostPerMile.BackColor = Color.DimGray
        lblCostPerMile.Font = New Font("Tahoma", 9.75F)
        lblCostPerMile.ForeColor = Color.White
        lblCostPerMile.Location = New Point(565, 60)
        lblCostPerMile.Name = "lblCostPerMile"
        lblCostPerMile.Size = New Size(42, 16)
        lblCostPerMile.TabIndex = 2
        lblCostPerMile.Text = "$X.XX"
        ' 
        ' txtNumberOfMiles
        ' 
        txtNumberOfMiles.Font = New Font("Tahoma", 11.25F)
        txtNumberOfMiles.Location = New Point(693, 191)
        txtNumberOfMiles.Name = "txtNumberOfMiles"
        txtNumberOfMiles.Size = New Size(44, 26)
        txtNumberOfMiles.TabIndex = 3
        txtNumberOfMiles.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblFlatRate
        ' 
        lblFlatRate.AutoSize = True
        lblFlatRate.BackColor = Color.DimGray
        lblFlatRate.Font = New Font("Tahoma", 9.75F)
        lblFlatRate.ForeColor = Color.White
        lblFlatRate.Location = New Point(565, 100)
        lblFlatRate.Name = "lblFlatRate"
        lblFlatRate.Size = New Size(42, 16)
        lblFlatRate.TabIndex = 4
        lblFlatRate.Text = "$X.XX"
        ' 
        ' picCar
        ' 
        picCar.Dock = DockStyle.Left
        picCar.Image = My.Resources.Resources.Uber
        picCar.Location = New Point(0, 0)
        picCar.Name = "picCar"
        picCar.Size = New Size(479, 420)
        picCar.SizeMode = PictureBoxSizeMode.StretchImage
        picCar.TabIndex = 5
        picCar.TabStop = False
        ' 
        ' btnDisplayFare
        ' 
        btnDisplayFare.BackColor = Color.WhiteSmoke
        btnDisplayFare.Font = New Font("Tahoma", 9.75F)
        btnDisplayFare.ForeColor = Color.Black
        btnDisplayFare.Location = New Point(502, 330)
        btnDisplayFare.Name = "btnDisplayFare"
        btnDisplayFare.Size = New Size(75, 40)
        btnDisplayFare.TabIndex = 6
        btnDisplayFare.Text = "Display Fare"
        btnDisplayFare.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.WhiteSmoke
        btnClear.Font = New Font("Tahoma", 9.75F)
        btnClear.ForeColor = Color.Black
        btnClear.Location = New Point(605, 330)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(75, 40)
        btnClear.TabIndex = 7
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.WhiteSmoke
        btnExit.Font = New Font("Tahoma", 9.75F)
        btnExit.ForeColor = Color.Black
        btnExit.Location = New Point(699, 330)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(75, 40)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblTotalCost
        ' 
        lblTotalCost.AutoSize = True
        lblTotalCost.BackColor = Color.DimGray
        lblTotalCost.Font = New Font("Tahoma", 11.25F)
        lblTotalCost.ForeColor = Color.White
        lblTotalCost.Location = New Point(565, 277)
        lblTotalCost.Name = "lblTotalCost"
        lblTotalCost.Size = New Size(117, 18)
        lblTotalCost.TabIndex = 9
        lblTotalCost.Text = "Fare to be paid: "
        ' 
        ' lblFare
        ' 
        lblFare.AutoSize = True
        lblFare.BackColor = Color.DimGray
        lblFare.Font = New Font("Tahoma", 11.25F)
        lblFare.ForeColor = Color.White
        lblFare.Location = New Point(688, 277)
        lblFare.Name = "lblFare"
        lblFare.Size = New Size(49, 18)
        lblFare.TabIndex = 10
        lblFare.Text = "Label2"
        ' 
        ' frmUberCar
        ' 
        AcceptButton = btnDisplayFare
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DimGray
        CancelButton = btnClear
        ClientSize = New Size(800, 420)
        Controls.Add(lblFare)
        Controls.Add(lblTotalCost)
        Controls.Add(btnExit)
        Controls.Add(btnClear)
        Controls.Add(btnDisplayFare)
        Controls.Add(picCar)
        Controls.Add(lblFlatRate)
        Controls.Add(txtNumberOfMiles)
        Controls.Add(lblCostPerMile)
        Controls.Add(lblNumberOfMiles)
        Controls.Add(lblHeading)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmUberCar"
        Text = "Driveless Uber Car"
        CType(picCar, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblNumberOfMiles As Label
    Friend WithEvents lblCostPerMile As Label
    Friend WithEvents txtNumberOfMiles As TextBox
    Friend WithEvents lblFlatRate As Label
    Friend WithEvents picCar As PictureBox
    Friend WithEvents btnDisplayFare As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblFare As Label

End Class
