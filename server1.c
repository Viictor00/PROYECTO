#include <stdio.h>
#include <mysql.h>
#include <string.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
//Función para obtener la contraseña del usuario 
	char* password (char user[], MYSQL *conn)
{
	// Creamos las variables correspondientes para analizar errores, crear la consulta y obtener los resultados 
	MYSQL_RES *resultado;
	char consulta [100]; 
	int err; 
	MYSQL_ROW row;
	//Creamos la consulta correspondiente con el nombre que se recive por parámetro
	strcpy(consulta, "select Password from Jugador where Username = '");
	strcat(consulta, user);
	strcat(consulta, "';");
	
	//Ejecutamos la consulta
	err = mysql_query(conn, consulta);
	if (err!=0)
	{
		printf("Error al consultar la base de datos\n",
			   mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	//Guardamos el resultado en la extructura row declarada al inicio
	resultado = mysql_store_result(conn);
	row = mysql_fetch_row(resultado);
	//i no devuelve nada entonces y salimos 
	if (row == NULL)
	{
		printf("No Existe el usuario\n");
		exit(1);
	}
	//En caso contrario pues devolvemos el únicovalor que ha de salir en el resultado 
	else
	{
		return (row[0]); 
	}
	
}
	//Creamos una función para crear un usuario para que los nuevos puedan darse de alta en la base de datos

	void add_user (char user[], char pass[],MYSQL *conn)
{
	//Creamos las extructuras para realizar la consulta y detectar en caso de que tengamos algún error
	char consulta [100];
	int err; 
	
	//Creamos la consulta para insertar el usuario y la contraseña dentro de la base de datos
	strcpy(consulta, "insert into Jugador values ( '");
	strcat(consulta,user);
	strcat(consulta,"','");
	strcat(consulta,pass);
	strcat(consulta,"');");
	
	//Analizamos el resultado de la consulta
	err = mysql_query(conn, consulta);
	if (err!=0)
	{
		printf("Error al introducir usuario en  la base de datos\n",
			   mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	
	
}

	//Creamos una función para buscar si el usuario existe antes de añadirlo o comprobar si el nombre de uuario es correcto al inicar sesion  
	int seek_user(char user[], MYSQL *conn)
{
	// Creamos las variables correspondientes para analizar errores, crear la consulta y obtener los resultados 
	MYSQL_RES *resultado;
	char consulta [100]; 
	int err; 
	MYSQL_ROW row;
	//Creamos la consulta correspondiente con el nombre que se recive por parámetro
	strcpy(consulta, "select * from Jugador where Username = '");
	strcat(consulta, user);
	strcat(consulta, "';");
	
	//Ejecutamos la consulta
	err = mysql_query(conn, consulta);
	if (err!=0)
	{
		printf("Error al consultar la base de datos\n",
			   mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	//Guardamos el resultado en la extructura row declarada al inicio
	resultado = mysql_store_result(conn);
	row = mysql_fetch_row(resultado);
	//i no devuelve nada entonces y salimos 
	if (row == NULL)
	{
		printf("No Existe el usuario\n");
		return 0;
	}
	//En caso contrario pues devolvemos -1 indicando que el usuario ya existe
	else
	{
		printf("El usuario Existe\n");
		return -1; 
	}
	
}
	// Creamos una función para consultar cuantas partidas ha jugado el jugador 
	int played_matches (char user[], MYSQL *conn)
{
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	int partidas = 0;
	char consulta [80];
	// Creamos laconsulta adecuada segn la cnsolade comandos en SQL
	strcpy (consulta,"SELECT * FROM Performance WHERE Jugador ='"); 
	strcat (consulta, user);
	strcat (consulta,"';");
	
	err= mysql_query (conn,consulta);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//Guardamos el resultado en la estructaura creada previamente 
	resultado = mysql_store_result (conn);
	//Vamos cogiendo las filas hasta que sea nulo 
	row = mysql_fetch_row (resultado);
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else
	// A medida que itermaos vamos aumentando el contador de partidas 
		while (row !=NULL) { 
			partidas = partidas + 1; 
			row = mysql_fetch_row (resultado);
	}
		
		printf ("El usuario %s ha jugado %d partidas \n",user,partidas);
	//Devolvemos las partidas calculadas
		return partidas; 
		
		
}
	//Creamos una función para poder calcular cuantas partidas ha ganado el jugador que tengamos como argumento

	int won_matches (char user[], MYSQL *conn)	
{
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	int partidas = 0;
	char consulta [80];
	//Creamos la consulta correspondiente 
	strcpy (consulta,"select * from Partida where Ganador = '"); 
	strcat (consulta, user);
	strcat (consulta,"';");
	
	err= mysql_query (conn,consulta);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	//Recogemos el resultado 
	resultado = mysql_store_result (conn);
	row = mysql_fetch_row (resultado);
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else
		while (row !=NULL) { 
			partidas = partidas + 1; //A medida que avancemos incrememtamso el contador de partidas 
			row = mysql_fetch_row (resultado);
	}
	
		printf ("El usuario %s ha ganado %d partidas \n",user,partidas);
		return partidas; 
		
		
}
	//Creamos función para buscae el tiempo juagdo por un jugador en específico
	float gaming_time (char user[], MYSQL *conn)
{
	int err;
	// Estructura especial para almacenar resultados de consultas 
	MYSQL_RES *resultado;
	MYSQL_ROW row;
	float time = 0;
	char consulta [400];
	//Creamos la consulta pertinente para extarer los datos 
	strcpy (consulta,"SELECT Partida.Duracion from Jugador,Partida,Performance where Jugador.Username = '"); 
	strcat (consulta, user);
	strcat (consulta,"' and Jugador.Username = Performance.Jugador and Partida.Identificador = Performance.Partida;");
	
	err= mysql_query (conn,consulta);
	if (err!=0) {
		printf ("Error al consultar datos de la base %u %s\n",
				mysql_errno(conn), mysql_error(conn));
		exit (1);
	}
	resultado = mysql_store_result (conn);//cogemos los resultados 
	row = mysql_fetch_row (resultado);
	if (row == NULL)
		printf ("No se han obtenido datos en la consulta\n");
	else
		while (row !=NULL) { // a medida quevamos cogiendo resulatdos nuevos resultados conertimos row y se o sumaos a al avariable creada al inicio 
			time = time + atof(row[0]);
			row = mysql_fetch_row (resultado);
	}

		return time; 
		
		
}



int main(int argc, char *argv[])
{
	//Primero establecemos la conexión la base de datos
	MYSQL *conn;
	int err;	
	
	conn = mysql_init(NULL);
	if (conn == NULL)
	{
		printf("Error al crear la conexion: %u %s\n",
			   mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	else {
		printf("Se ha creado la conexión correctamente :)\n");
	}
	
	conn = mysql_real_connect (conn, "localhost", "root", "mysql", "Juego", 0, NULL, 0);
	if (conn == NULL)
	{
		printf("Error al inicializar la conexion: %u %s\n",
			   mysql_errno(conn), mysql_error(conn));
		exit(1);
	}
	else 
	{
		printf("Se ha iniciado la conexión correctamente :) \n");
	}
	// Una vez establecida la conexión con la base de datos entonces pasamos a inicializar los sockets
	
	int sock_conn, sock_listen, ret;
	struct sockaddr_in serv_adr;
	char peticion[512];
	char respuesta[512];
	// INICIALIZACIONES
	 //Abrimos el socket 
	if ((sock_listen = socket(AF_INET, SOCK_STREAM, 0)) < 0)
		printf("Error creant socket");
	// Hacemos bind al puerto que deseemos conectar 
	
	
	memset(&serv_adr, 0, sizeof(serv_adr));// inicializa a cero serv_addr
	serv_adr.sin_family = AF_INET;
	
	// asocia el socket a cualquiera de las IP de la maquina. 
	//htonl formatea el numero que recibe al formato necesario
	//serv_adr.sin_addr.s_addr = htonl(INADDR_ANY);
	// establecemos el puerto de escucha
	serv_adr.sin_port = htons(9040);
	if (bind(sock_listen, (struct sockaddr *) &serv_adr, sizeof(serv_adr)) < 0)
		printf ("Error al bind");
	
	if (listen(sock_listen, 3) < 0)
		printf("Error en el Listen");

	int i;
	// Bucle infinito
	for (;;){
		printf ("Escuchando\n");
		
		sock_conn = accept(sock_listen, NULL, NULL);
		printf ("He recibido conexion\n");
		////sock_conn es el socket que usaremos para este cliente
		
		int terminar =0;
		// Entramos en un bucle para atender todas las peticiones de este cliente
		//hasta que se desconecte
		while (terminar ==0)
		{
			// Ahora recibimos la petici?n
			ret=read(sock_conn,peticion, sizeof(peticion));
			printf ("Recibido\n");
			
			// Tenemos que añadirle la marca de fin de string 
			// para que no escriba lo que hay despues en el buffer
			peticion[ret]='\0';
			printf ("Peticion: %s\n",peticion);
			// vamos a ver que quieren
			char *p = strtok( peticion, "/");
			int codigo =  atoi (p);
			// Ya tenemos el c?digo de la petici?n
			char nombre[20];
			
			if (codigo !=0)
			{
				p = strtok( NULL, "/");
				
				strcpy (nombre, p);
				 //Ya tenemos el nombre
				printf ("Codigo: %d, Nombre: %s\n", codigo, nombre);
			}
			
			if (codigo ==0) //petici0n de desconexi?n
				terminar=1;
			else if (codigo == 1) //El usuario desea iniciar sesion
			{ 
				p = strtok( NULL, "/"); // obtenemos la contraseña 
				//Para iniciar sesion debemos de comprobar si el usuario existe
				int j = seek_user(nombre,conn);
				if (j == -1)//si resulta que el usuario existe procedemos a comparar las contraseñas
				{
					char pass [30];
					strcpy(pass,password("Axel",conn)); //Obtenemos la cotraseña del usuario 
					int m = strcmp(p,pass); 
					if (m == 0) // tenemos las dos contraseñas identicas 
					{
						sprintf (respuesta, "%s: has iniciado sesion con exito",nombre);
						
					}
					else 
					{
						sprintf (respuesta, "%s: la contraseña no coincide",nombre);
						
					}
			
					
				}
				else
				{
					sprintf (respuesta, "El usuario %s no existe",nombre);					
				}
				
			}
			else if (codigo == 2) // peticion para crear un nuevo usuario
			{
				p = strtok( NULL, "/"); // obtenemos la contraseña 
				//Para iniciar sesion debemos de comprobar si el usuario existe
				int j = seek_user(nombre,conn);
				if (j == 0)//si resulta que el usuario no existe creamos el usuario nuevo
				{
					add_user(nombre,p,conn); 
					sprintf (respuesta, "El usuario %s ha sido creado.",nombre);
					
				}
				else
				{
					sprintf (respuesta, "El usuario %s ya existe.",nombre);					
				}
				
				
			}
			else if (codigo == 3) // El usuario quiere saber cuantas partidas ha ganado
			{
				int a = won_matches(nombre,conn); //LLamamos a la función para buscar el número de partidas ganadas
				sprintf (respuesta, "%s: has ganado %d partidas.",nombre,a);
				
			}
			else if (codigo == 4) // El usuario quiere saber cuantas partidas ha ganado
			{
				int a = played_matches(nombre,conn); //LLamamos a la función para buscar el número de partidas ganadas
				sprintf (respuesta, "%s: has jugado %d partidas.",nombre,a);
				
			}
			else if (codigo == 5) // El usuario quiere saber cuanto tiempo a estado jugando 
			{
				float a = gaming_time(nombre,conn);//LLamamos a la función para calcular el tiempo jugado
				sprintf (respuesta, "%s tienes %.2f minutos jugados.\n",nombre,a); // devolvemos el tiempo jugado 
				
			}
			// Si el codigo es 0 entonces cerramos a conexion 
			if (codigo !=0)
			{
				
				printf ("Respuesta: %s\n", respuesta);
				// Enviamos respuesta
				write (sock_conn,respuesta, strlen(respuesta));
			}
			
		}
		 //Se acabo el servicio para este cliente
		 //Cerramos ambas conexiones
		close(sock_conn); 
		
	}
	
	
	
}
