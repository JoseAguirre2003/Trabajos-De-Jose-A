var diasSemana = ["Lunes","Martes","Miercoles","Jueves","Viernes"]
        var asistencia = [0,0,0,0,0]

        for (i=0;i<5;i++)
            asistencia[i] = Math.round(Math.random()*150);

        var acumAsistencias = 0;
        var contMay100=0;
        var diaMayorAsistencia=diasSemana[0];
        var mayorAsistencia=asistencia[0];

        for (i=0;i<5;i++){
            acumAsistencias+=asistencia[i];
            if (asistencia[i]>mayorAsistencia){
                mayorAsistencia=asistencia[i]
                diaMayorAsistencia=diasSemana[i]
            }
            if (asistencia[i]>100)
                contMay100++;
        }
        
        var promedio = acumAsistencias/5;

        for (i=0;i<5;i++)
            console.log(`El dia de la semana ${i+1} es ${diasSemana[i]} `+
                        `y la asistencia fue de ${asistencia[i]} personas`)
        
        console.warn(`El total de asistencias fue ${acumAsistencias}, el `+
                    `promedio de asistencia diaria fue de ${promedio.toFixed(2)},`+
                    ` y en ${contMay100} dias hubo mas de 100 personas asistentes`)
        console.warn(`El dia de mayor asistencia fue ${diaMayorAsistencia}`)

        for (i=0;i<5;i++)
            if (asistencia[i]<promedio) {
                console.log(`El dia ${diasSemana[i]} hubo menor asistencia que el promedio, con una asistencia de ${asistencia[i]}`)
            }