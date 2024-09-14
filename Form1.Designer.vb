<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lblTitle = New Label()
        lblAuthor = New Label()
        lblYear = New Label()
        ListBoxBooks = New ListBox()
        btnAdd = New Button()
        btnView = New Button()
        btnUpdate = New Button()
        btnDelete = New Button()
        txtTitle = New TextBox()
        txtAuthor = New TextBox()
        txtYear = New TextBox()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(118, 55)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(29, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Title"
        ' 
        ' lblAuthor
        ' 
        lblAuthor.AutoSize = True
        lblAuthor.Location = New Point(118, 115)
        lblAuthor.Name = "lblAuthor"
        lblAuthor.Size = New Size(44, 15)
        lblAuthor.TabIndex = 1
        lblAuthor.Text = "Author"
        ' 
        ' lblYear
        ' 
        lblYear.AutoSize = True
        lblYear.Location = New Point(118, 180)
        lblYear.Name = "lblYear"
        lblYear.Size = New Size(89, 15)
        lblYear.TabIndex = 2
        lblYear.Text = "PublicationYear"
        ' 
        ' ListBoxBooks
        ' 
        ListBoxBooks.FormattingEnabled = True
        ListBoxBooks.ItemHeight = 15
        ListBoxBooks.Location = New Point(198, 269)
        ListBoxBooks.Name = "ListBoxBooks"
        ListBoxBooks.Size = New Size(354, 169)
        ListBoxBooks.TabIndex = 3
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(168, 218)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(75, 23)
        btnAdd.TabIndex = 4
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnView
        ' 
        btnView.Location = New Point(288, 217)
        btnView.Name = "btnView"
        btnView.Size = New Size(75, 23)
        btnView.TabIndex = 5
        btnView.Text = "View"
        btnView.UseVisualStyleBackColor = True
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(411, 216)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(75, 23)
        btnUpdate.TabIndex = 6
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(536, 215)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(75, 23)
        btnDelete.TabIndex = 7
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' txtTitle
        ' 
        txtTitle.Location = New Point(245, 48)
        txtTitle.Name = "txtTitle"
        txtTitle.Size = New Size(276, 23)
        txtTitle.TabIndex = 8
        ' 
        ' txtAuthor
        ' 
        txtAuthor.Location = New Point(245, 112)
        txtAuthor.Name = "txtAuthor"
        txtAuthor.Size = New Size(276, 23)
        txtAuthor.TabIndex = 9
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(245, 177)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(276, 23)
        txtYear.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(txtYear)
        Controls.Add(txtAuthor)
        Controls.Add(txtTitle)
        Controls.Add(btnDelete)
        Controls.Add(btnUpdate)
        Controls.Add(btnView)
        Controls.Add(btnAdd)
        Controls.Add(ListBoxBooks)
        Controls.Add(lblYear)
        Controls.Add(lblAuthor)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents ListBoxBooks As ListBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtYear As TextBox
End Class
