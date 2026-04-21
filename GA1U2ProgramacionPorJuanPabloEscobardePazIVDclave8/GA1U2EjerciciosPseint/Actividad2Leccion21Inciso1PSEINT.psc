Algoritmo Actividad2Leccion21Inciso1PSEINT
	Definir bdv Como Entero
	Escribir 'Buzon de voz de: Bodegas Martines'
	Escribir 'Ingrese uno los siguientes'
	Escribir 'numeros si quiere comunicarse con:'
	Escribir '1: Ventas'
	Escribir '2: Compras'
	Escribir '3: Direccion'
	Escribir '4: Inventario'
	Leer bdv
	Según bdv Hacer
		1:
			Escribir 'Bienvenido al departamento de: Ventas'
			Escribir 'Correo del responsable: cl_Martines@gmail.com'
		2:
			Escribir 'Bienvenido al departamento de: Compras'
			Escribir 'Correo del responsable: v_fatima@gmail.com'
		3:
			Escribir 'Bienvenido al departamento de: Direccion'
			Escribir 'Correo del responsable: pjose2006@gmail.com'
		4:
			Escribir 'Bienvenido al departamento de: Inventario'
			Escribir 'Correo del responsable: d_ramirez16@gmail.com'
		De Otro Modo:
			Escribir 'Ingrese un numero valido'
	FinSegún
FinAlgoritmo
