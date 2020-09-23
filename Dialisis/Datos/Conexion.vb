Imports System.Configuration

Public Class Conexion

    'Conexion HAMERSERVER

    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=Dialisis;Data Source=25.13.170.93")


    'Conexion HAMERSERVER-LOCAL_LAN
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=HAMER-HOME-PC")


    'Conexion CHOCO-RYZEN
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=Dialisis;Data Source=DESKTOP-IPJ62B9\SQLEXPRESS")

    Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=DESKTOP-IPJ62B9\SQLEXPRESS_CHOK")

    'Conexion local NoteMariano

    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Dialisis;Data Source=(local)")

    'Conexion Dialisis
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=Dialisis;Data Source=SERVER")





    
End Class
