Imports System.Reflection
Imports System.Drawing.Imaging

Module Grayscaling
    Dim colorMatrix As New ColorMatrix(New Single()() {New Single() {0.3F, 0.3F, 0.3F, 0, 0}, New Single() {0.59F, 0.59F, 0.59F, 0, 0}, New Single() {0.11F, 0.11F, 0.11F, 0, 0}, New Single() {0, 0, 0, 1, 0}, New Single() {0, 0, 0, 0, 1}})
    Dim attributes As New ImageAttributes()
    Dim g As Graphics

    Public Function MakeGrayscale3(original As Bitmap) As Bitmap
        'get a graphics object from the new image
        g = Graphics.FromImage(original)

        'set the color matrix attribute
        attributes.SetColorMatrix(ColorMatrix)

        'draw the original image on the new image
        'using the grayscale color matrix
        g.DrawImage(original, New Rectangle(0, 0, original.Width, original.Height), 0, 0, original.Width, original.Height, _
            GraphicsUnit.Pixel, attributes)

        'dispose the Graphics object
        g.Dispose()
        Return original
    End Function

End Module
