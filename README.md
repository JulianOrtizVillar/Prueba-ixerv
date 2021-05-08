# Prueba-ixerv
Prueba Prueba ixerv login 

hay que usar visual studio 
el rograma se realizo con c# y con sql server

para correr el programa:

1.se debe cargar la copia (Back up)de la base de datos LogginJulian.bak en SQL server 
2.luego dentro del codigo de c # en el controlador se debe cambiar la ruta de conexion en cada uno de los metodos (en el metodo login y en el metodo Newuser ) del controlador de la siguiente manera:

String conectionString = "Data Source=localhost;" +
                                        "Initial catalog=LogginJulian;" +
                                        "User id=sa;" +
                                        "Password=M@ria0313";
                                        
 y cambiar los datos por la conexion del servidor en el cual se cargue el backup de la db 
 
 en "Initial catalog va el nombre de la base de datos
 user : el usuario del servidor y  Password es la clave para el acceso.
