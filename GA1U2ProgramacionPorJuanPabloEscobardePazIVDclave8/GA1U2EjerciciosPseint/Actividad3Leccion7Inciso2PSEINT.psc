Algoritmo Actividad3Leccion7inciso2PSEINT
	Definir ang1, ang2, ang3 Como Entero
	Escribir "Triangulos"
	Escribir "Ingrese los angulos del triangulo:"
	Leer ang1
	Leer ang2
	Leer ang3
	Si ang1 = 60 y ang2 = 60 y ang3 = 60 Entonces
		Escribir "Es un triangulo equilatero"
	FinSi
	Si ang1 = ang2 y ang3 <> ang1 o ang1 = ang3 y ang2 <> ang1 o ang2 = ang3 y ang1 <> ang2 Entonces
		Escribir "El triangulo es isoceles"
	FinSi
	Si ang1 <> ang2 y ang1 <> ang3 y ang2 <> ang3 Entonces
		Escribir "Es un triangulo escaleno "
	FinSi
FinAlgoritmo
