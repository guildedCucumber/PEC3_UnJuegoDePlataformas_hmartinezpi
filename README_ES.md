# PEC3 - Juego Plataformas 3D

# Programación en Unity 3D

### Fechas importantes de la PEC3

Fecha de publicación del enunciado: 13/05/2024

Fecha de entrega: 16/06/2024

Fecha de calificación: 08/07/2024

### Librerías necesarias para hacer las prácticas
Esta práctica la vamos a realizar usando el motor de videojuegos Unity 3D en su versión **2022.3.20f1 LTS.**

### Sistemas operativos aceptados
Os recomendamos que realicéis las prácticas en un entorno Windows o Mac OS. Si necesitáis licencias de Windows, Microsoft Visual Studio o cualquier otro software, comentadlo en el foro de la asignatura y os indicaremos si desde la UOC os las podemos proporcionar.

### Normas de uso de modelos de Inteligencia Artificial

En esta actividad sólo se permite un uso limitado de herramientas de inteligencia artificial. Concretamente en el contexto de las artes y el diseño, las herramientas de IA, tanto textuales como visuales, pueden servir para generar y esbozar ideas, contextualizar conceptos, plantear prototipos o combinar elementos de manera innovadora o alternativa. En caso de utilizar estas herramientas, es necesario explicitar y citar correctamente su uso en la elaboración del trabajo. Esto implica indicar en cada apartado de la actividad entregada qué herramientas se han utilizado, los objetivos, los prompts que se han empleado, la respuesta obtenida y el proceso que se ha seguido para revisar y editar la salida. Para hacerlo correctamente, consulta la guía [¿Cómo citar la IA en los trabajos?](https://openaccess.uoc.edu/bitstream/10609/148823/2/U2_17_GuiaCitarIA_ESP.pdf). En el plan docente y en la [Web sobre integridad académica y plagio de la UOC](https://campus.uoc.edu/estudiant/microsites/plagi/es/index.html) encontrarás información sobre qué se considera conducta irregular y las consecuencias que puede tener.

Recuerda también que en caso de usar herramientas de IA generativa, no se debe proporcionar información personal, confidencial o protegida por propiedad intelectual. Ten en cuenta que un uso inadecuado de la IA generativa, como la falta de revisión de la respuesta obtenida o la falta de citación de las herramientas utilizadas, será considerada una conducta irregular en la evaluación. En caso de duda, consulta con el profesorado colaborador.

### ¿Qué se tiene que entregar?

Se deberá subir el proyecto funcionando sin errores al GitLab, y que este contenga TODOS los siguientes elementos:

• Un TAG identificativo (PEC3) en la versión final que queréis que sea evaluada.

• Un fichero README.md que explique cómo ejecutar el proyecto si es que hay algún requisito extra, así como unas instrucciones que expliquen los controles del juego o si hay que hacer alguna acción específica en concreto para poder jugarlo.

• En ese mismo Readme, se deberá incluir una descripción explicando qué partes habéis implementado y cómo lo habéis hecho.

• Así como también un **link a un vídeo** que enseñe y liste los puntos que se han implementado y su funcionamiento.


### Descripción del juego propuesto

Siguiendo el hilo del documento &quot;Un juego de plataformas 3D&quot;, os proponemos que implementéis un juego en tercera persona en el que el jugador tenga que escapar de una invasión zombie. Un estilo de juego similar al Dead Rising (ver [vídeo](https://www.youtube.com/watch?v=If0rFpcowwY)).

Los puntos básicos que debéis implementar son:

1.	Crear un pequeño entorno urbano abierto (un pueblecito o una ciudad pequeña) donde transcurrirá la acción.
2.	El personaje deberá tener una pistola para disparar en línea recta hacia adeltante siempre (no hace falta apuntar).
3.	El personaje deberá estar completamente animado. Idle, caminar, correr, saltar, girar, disparar, recibir impacto y morir. 
4.	Tanto la cantidad de vida como la munición deberán siempre verse por pantalla (HUD).
5.	Los enemigos serán zombies que tendrán una IA similar a los drones: irán paseando por la ciudad y cuando el player esté cerca irán corriendo hacia el personaje y lo atacarán cuerpo a cuerpo cuando lo alcancen.
6.	Los enemigos deberán tener animación de caminar, atacar, morir y recibir impacto.
7.	Habrá peatones caminando de manera autónoma por la ciudad. Los peatones deberán huir de los zombies si se encuentran cerca. 
8.	Habrá coches circulando de manera autónoma por la ciudad. Además, podremos robar un coche y circular con él. 
9.	Poner sistemas de partículas cuando te hieren o cuando un zombie es golpeado o muere. 
10.	Repartidos por el escenario deberán haber ítems de ‘vida’ y ‘munición’. 
11.	El juego deberá tener un completo menú que contenga por lo menos las siguientes opciones:

• Iniciar partida

• Opciones (aquí tienen cavida opciones tales como gráficos, audio, idioma...) 

• pantalla de game over y que al morir podamos reiniciar el nivel.


Los puntos que valoraremos son:

1.	Definir una buena estructura de datos para guardar la información del juego.
2.	Claridad y sencillez en el código.
3.	Buena documentación y explicación del trabajo realizado.

Los puntos optativos que podéis implementar una vez implementados los puntos anteriores son:

1.	Crear situaciones donde sea necesario saltar para llegar a ciertas zonas.
2.	Añadir nuevas armas como granadas o una escopeta.
3.	El juego deberá estar sonorizado completamente. 
4.	Hacer diferentes tipos de zombies. Más fuertes, resistentes o rápidos.
5.	Crear la posibilidad de poder apuntar manualmente al disparar.
6.	Crear algún tipo de puzzle donde sea necesario encontrar una llave para abrir una nueva zona. Esa llave la puede dejar algún zombie ‘boss’ al morir.
7.	Que el player tenga otro arma, un cuchillo o espada para enfrentarse a los zombies cuerpo a cuerpo.
8.	Los enemigos al morir podrían dejar items en el suelo. 
9.	Si los peatones son atrapados por un zombie, que se transformen en zombie también.
10. Si atropellamos a los zombies o a los petaones, estos deberían explotar.
11.	Los zombies irán ‘spawneando’ por la ciudad de manera random o en puntos concretos a medida que el player los va matando o cada cierto tiempo prefijado. A más rato llevemos jugando más rápido han de aparecer. La idea es hacer un survival que cada vez sea más difícil sobrevivir.

Como punto opcional extra también teneis la opción de hacer que la cabeza y un poco el torso del personaje miren automáticamente hacia los items que tenga a una cierta distancia utilizando el **Animation Rigging** de Unity.

Para implementar este último punto, os recomendamos las siguientes fuentes de información oficiales donde encontraréis todo lo necesiario para empezar a trabajar con el Animation Rigging:

- [Unity Documentation - Manual](https://docs.unity3d.com/Manual/com.unity.animation.rigging.html)

- [Unity Learn - Working with Animation Rigging](https://learn.unity.com/tutorial/working-with-animation-rigging)

- [Unity Blog - What is Rigging in Animation?](https://unity.com/solutions/rigging-animation)

Otro punto extra lo podéis conseguir utilizando el sistema de **iluminación global** de Unity, bakeando las luces y el ambient occlusion.   
Para entender como funciona y configurar la iluminación os recomendamos las siguientes fuentes de información oficiales donde encontraréis todo lo necesiario para empezar a trabajar con la iluminación global:

- [Unity Documentation - Lighting - Manual](https://docs.unity3d.com/Manual/LightingOverview.html)

- [Unity Documentation - Lightmappers - Manual](https://docs.unity3d.com/Manual/Lightmappers.html)

- [Unity Documentation - Baked Lights - Manual](https://docs.unity3d.com/Manual/LightMode-Baked.html)

- [Unity Documentation - Ambient Occlusion - Manual](https://docs.unity3d.com/2022.3/Documentation/Manual/LightingBakedAmbientOcclusion.html)

- [Unity Learn - Introduction to Lighting and Rendering](https://learn.unity.com/tutorial/introduction-to-lighting-and-rendering-2019-3#)

- [Unity Learn - Working with Lighting in Unity](https://learn.unity.com/project/working-with-lighting-in-unity)

- [Unity Learn - Lighting Optimization with Precomputed Realtime GI](https://learn.unity.com/project/lighting-optimization-with-precomputed-realtime-gi)

- [Unity Youtube - How to build Lightmaps](https://www.youtube.com/watch?v=KJ4fl-KBDR8&ab_channel=Unity)