Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Class Book
        Public Property Title As String
        Public Property Author As String
        Public Property PublicationYear As Integer

        Public Overrides Function ToString() As String
            Return $"{Title} by {Author}, {PublicationYear}"
        End Function
    End Class

    Private books As New List(Of Book)

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(txtTitle.Text) OrElse String.IsNullOrWhiteSpace(txtAuthor.Text) OrElse String.IsNullOrWhiteSpace(txtYear.Text) Then
            MessageBox.Show("Please fill in all fields.")
            Return
        End If

        Dim newBook As New Book With {
        .Title = txtTitle.Text,
        .Author = txtAuthor.Text,
        .PublicationYear = Convert.ToInt32(txtYear.Text)
    }

        books.Add(newBook)
        UpdateBookList()
        ClearInputFields()
    End Sub

    Private Sub UpdateBookList()
        ListBoxBooks.DataSource = Nothing
        ListBoxBooks.DataSource = books
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If ListBoxBooks.SelectedIndex <> -1 Then
            Dim selectedBook As Book = CType(ListBoxBooks.SelectedItem, Book)
            selectedBook.Title = txtTitle.Text
            selectedBook.Author = txtAuthor.Text
            selectedBook.PublicationYear = Convert.ToInt32(txtYear.Text)
            UpdateBookList()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListBoxBooks.SelectedIndex <> -1 Then
            books.RemoveAt(ListBoxBooks.SelectedIndex)
            UpdateBookList()
        End If
    End Sub

    Private Sub ListBoxBooks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxBooks.SelectedIndexChanged

        If ListBoxBooks.SelectedIndex <> -1 Then
            Dim selectedBook As Book = CType(ListBoxBooks.SelectedItem, Book)
            txtTitle.Text = selectedBook.Title
            txtAuthor.Text = selectedBook.Author
            txtYear.Text = selectedBook.PublicationYear.ToString()
        End If
    End Sub

    Private Sub ClearInputFields()
        txtTitle.Clear()
        txtAuthor.Clear()
        txtYear.Clear()
    End Sub


End Class
