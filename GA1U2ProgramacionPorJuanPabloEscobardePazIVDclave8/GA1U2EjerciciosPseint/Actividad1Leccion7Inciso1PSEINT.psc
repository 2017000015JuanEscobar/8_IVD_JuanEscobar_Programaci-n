Algoritmo ACTIVIDAD1LECCION7INCISO1PSEINT	
	Definir cali1, cali2, cali3, cali4, cali5, promedio Como Real
	Escribir "Ingresa sus calificaciones del 0 al 100:"
	Escribir "Ingresa la calificación 1"
	Leer cali1
	Si cali1 < 0 O cali1 > 100 Entonces
		Escribir "Número incorrecto. Tiene que ser del 1 al 100"
	SiNo
		Escribir "Ingresa la calificación 2"
		Leer cali2
		Si cali2 < 0 O cali2 > 100 Entonces
			Escribir "Número incorrecto. Tiene que ser del 1 al 100"
		SiNo
			Escribir "Ingresa la calificación 3"
			Leer cali3
			Si cali3 < 0 O cali3 > 100 Entonces
				Escribir "Número incorrecto. Tiene que ser del 1 al 100"
			SiNo
				Escribir "Ingresa la calificación 4"
				Leer cali4
				Si cali4 < 0 O cali4 > 100 Entonces
					Escribir "Número incorrecto. Tiene que ser del 1 al 100"
				SiNo
					Escribir "Ingresa la calificación 5"
					Leer cali5
					Si cali5 < 0 O cali5 > 100 Entonces
						Escribir "Número incorrecto. Tiene que ser del 1 al 100"
					SiNo
						promedio <- (cali1 + cali2 + cali3 + cali4 + cali5) / 5
						Escribir "Promedio: ", promedio
						Si promedio >= 60 Entonces
							Escribir "Resultado: APROBADO"
						SiNo
							Escribir "Resultado: REPROBADO"
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
FinAlgoritmo
